﻿using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Threading.Tasks;
using Grpc.Core;
using Grpc.Core.Interceptors;
using OpenTelemetry.Trace;
using Prometheus;

namespace MyJetWallet.Sdk.GrpcMetrics
{
    public class PrometheusMetricsInterceptor : Interceptor
    {
        public static string AppName { get; set; }
        public static string AppVersion { get; set; }
        public static string AppHost { get; set; }

        public const string GrpcSourceAppNameHeader = "source-app-name";
        public const string GrpcSourceAppVersionHeader = "source-app-name";
        public const string GrpcSourceAppHostHeader = "source-app-name";
        
        private static Counter ServerGrpcCallInCount = Prometheus.Metrics
            .CreateCounter("jet_grpc_server_call_in_count",
                "Counter of calls grpc methods. Counter applied before execute logic",
                new CounterConfiguration { LabelNames = new[] { "host", "controller", "method" } });

        private static Counter ServerGrpcCallOutCount = Prometheus.Metrics
            .CreateCounter("jet_grpc_server_call_out_count",
                "Counter of calls grpc methods. Counter applied after execute logic",
                new CounterConfiguration { LabelNames = new[] { "host", "controller", "method", "status" } });

        private static readonly Gauge ServerGrpcCallProcessCount = Prometheus.Metrics
            .CreateGauge("jet_grpc_server_call_process_count",
                "Counter of active calls of grpc methods.",
                new GaugeConfiguration { LabelNames = new[] { "host", "controller", "method" } });

        private static readonly Histogram ServerGrpcCallDelaySec = Prometheus.Metrics
            .CreateHistogram("jet_grpc_server_call_delay_sec",
                "Histogram of grpc call delay in second.",
                new HistogramConfiguration
                {
                    LabelNames = new[] { "host", "controller", "method" },
                    Buckets = new double[] { double.PositiveInfinity }
                });


        private static Counter ClientGrpcCallInCount = Prometheus.Metrics
            .CreateCounter("jet_grpc_client_call_in_count",
                "Counter of calls grpc methods. Counter applied before execute logic",
                new CounterConfiguration { LabelNames = new[] { "host", "controller", "method" } });

        private static Counter ClientGrpcCallOutCount = Prometheus.Metrics
            .CreateCounter("jet_grpc_client_call_out_count",
                "Counter of calls grpc methods. Counter applied after execute logic",
                new CounterConfiguration { LabelNames = new[] { "host", "controller", "method", "status" } });

        private static readonly Gauge ClientGrpcCallProcessCount = Prometheus.Metrics
            .CreateGauge("jet_grpc_client_call_process_count",
                "Counter of active calls of grpc methods.",
                new GaugeConfiguration { LabelNames = new[] { "host", "controller", "method" } });

        private static readonly Histogram ClientGrpcCallDelaySec = Prometheus.Metrics
            .CreateHistogram("jet_grpc_client_call_delay_sec",
                "Histogram of grpc call delay in second.",
                new HistogramConfiguration
                {
                    LabelNames = new[] { "host", "controller", "method" },
                    Buckets = new double[] { double.PositiveInfinity }
                });

        private static readonly string HostName;

        static PrometheusMetricsInterceptor()
        {
            var name = Assembly.GetEntryAssembly()?.GetName();

            AppName = name?.Name ?? "--none--";
            AppVersion = name?.Version?.ToString();
            
            HostName = Environment.GetEnvironmentVariable("HOST") 
                        ?? Environment.GetEnvironmentVariable("HOSTNAME") 
                        ?? AppName;

            AppHost = HostName;
        }

        public override async Task<TResponse> UnaryServerHandler<TRequest, TResponse>(TRequest request,
            ServerCallContext context,
            UnaryServerMethod<TRequest, TResponse> continuation)
        {
            var method = context.Method;
            var prm = context.Method.Split('/');
            var controller = prm.Length >= 2 ? prm[1] : "unknown";

            var sourceAppName = context.RequestHeaders?.Get(GrpcSourceAppHostHeader)?.Value ?? "-none-";
            var sourceAppVersion = context.RequestHeaders?.Get(GrpcSourceAppVersionHeader)?.Value ?? "-none-";
            var sourceAppHost = context.RequestHeaders?.Get(GrpcSourceAppHostHeader)?.Value ?? "-none-";

            Activity.Current?.AddTag("call-source-AppName", sourceAppName);
            Activity.Current?.AddTag("call-source-AppVersion", sourceAppVersion);
            Activity.Current?.AddTag("call-source-AppAppHost", sourceAppHost);

            using (ServerGrpcCallProcessCount.WithLabels(HostName, controller, method).TrackInProgress())
            {
                using (ServerGrpcCallDelaySec.Labels(HostName, controller, method).NewTimer())
                {
                    ServerGrpcCallInCount.WithLabels(HostName, controller, method).Inc();

                    try
                    {
                        var resp = await continuation(request, context);

                        ServerGrpcCallOutCount.WithLabels(HostName, controller, method, context.Status.StatusCode.ToString()).Inc();

                        return resp;
                    }
                    catch (Exception ex)
                    {
                        ServerGrpcCallOutCount.WithLabels(HostName, controller, method, "exception").Inc();
                        Activity.Current?.RecordException(ex);
                        if (request != null)
                            Activity.Current?.AddTag("grpc-request", JsonSerializer.Serialize(request));
                        throw;
                    }
                }
            }
        }

        public override TResponse BlockingUnaryCall<TRequest, TResponse>(TRequest request, ClientInterceptorContext<TRequest, TResponse> context,
            BlockingUnaryCallContinuation<TRequest, TResponse> continuation)
        {
            var method = context.Method.Name;
            var controller = context.Method.ServiceName;
            
            context.Options.Headers?.Add(GrpcSourceAppNameHeader, AppName);
            context.Options.Headers?.Add(GrpcSourceAppVersionHeader, AppVersion);
            context.Options.Headers?.Add(GrpcSourceAppHostHeader, AppHost);

            using (ClientGrpcCallProcessCount.WithLabels(HostName, controller, method).TrackInProgress())
            {
                using (ClientGrpcCallDelaySec.Labels(HostName, controller, method).NewTimer())
                {
                    ClientGrpcCallInCount.WithLabels(HostName, controller, method).Inc();

                    try
                    {
                        var resp = continuation(request, context);

                        ClientGrpcCallOutCount.WithLabels(HostName, controller, method, "success").Inc();

                        return resp;
                    }
                    catch (Exception ex)
                    {
                        ClientGrpcCallOutCount.WithLabels(HostName, controller, method, "exception").Inc();
                        Activity.Current?.RecordException(ex);
                        if (request != null)
                            Activity.Current?.AddTag("grpc-request", JsonSerializer.Serialize(request));
                        throw;
                    }
                }
            }
        }

        public override AsyncUnaryCall<TResponse> AsyncUnaryCall<TRequest, TResponse>(TRequest request, ClientInterceptorContext<TRequest, TResponse> context,
            AsyncUnaryCallContinuation<TRequest, TResponse> continuation)
        {
            var method = context.Method.Name;
            var controller = context.Method.ServiceName;
            
            context.Options.Headers?.Add(GrpcSourceAppNameHeader, AppName);
            context.Options.Headers?.Add(GrpcSourceAppVersionHeader, AppVersion);
            context.Options.Headers?.Add(GrpcSourceAppHostHeader, AppHost);

            var clientGrpcCallProcessCount = ClientGrpcCallProcessCount.WithLabels(HostName, controller, method).TrackInProgress();

            var clientGrpcCallDelaySec = ClientGrpcCallDelaySec.Labels(HostName, controller, method).NewTimer();

            ClientGrpcCallInCount.WithLabels(HostName, controller, method).Inc();

            try
            {
                var resp = continuation(request, context);

                resp.ResponseAsync.ContinueWith(task =>
                {
                    clientGrpcCallProcessCount.Dispose();
                    clientGrpcCallDelaySec.Dispose();

                    string status;
                    try
                    {
                        status = resp.GetStatus().StatusCode.ToString();
                    }
                    catch (Exception)
                    {
                        status = "unknown";
                    }
                    ClientGrpcCallOutCount.WithLabels(HostName, controller, method, status).Inc();
                });

                resp.ResponseAsync.ContinueWith(task =>
                {
                    ClientGrpcCallOutCount.WithLabels(HostName, controller, method, "exception").Inc();
                }, TaskContinuationOptions.NotOnFaulted);

                return resp;
            }
            catch (Exception ex)
            {
                ClientGrpcCallOutCount.WithLabels(HostName, controller, method, "exception").Inc();
                Activity.Current?.RecordException(ex);
                if (request != null)
                    Activity.Current?.AddTag("grpc-request", JsonSerializer.Serialize(request));
                throw;
            }
        }
    }
}