using System;
using System.Collections.Generic;
using System.Reflection;

namespace MyJetWallet.Sdk.GrpcMetrics;

public static class GrpcMetricsManager
{
    public static object _gate = new();
    public static readonly Dictionary<string, Metric> ServiceMetrics = new();
    public static readonly Dictionary<string, Metric> ClientMetrics = new();

    private static string OwnerName { get; set; }

    public static void HandleSuccessfulRequestClient(string clientName, string version, string method,
        string controller, TimeSpan executionTime)
    {
        try
        {
            lock (_gate)
            {
                if (ClientMetrics.TryGetValue(GetKey(clientName, method), out var metric))
                {
                    metric.LastRequestTime = DateTime.UtcNow;
                    metric.RequestCount++;
                    metric.AvgTimeInSec =
                        (metric.AvgTimeInSec * (metric.RequestCount - 1) + executionTime.TotalSeconds) /
                        metric.RequestCount;
                }
                else
                {
                    metric = new Metric
                    {
                        OwnerName = GetOwner(),
                        ServiceName = clientName,
                        Version = version,
                        MethodName = method,
                        ControllerName = controller,
                        FirstRequestTime = DateTime.UtcNow,
                        LastRequestTime = DateTime.UtcNow,
                        RequestCount = 1,
                        ErrorCount = 0,
                        AvgTimeInSec = executionTime.TotalSeconds
                    };
                }

                ClientMetrics[GetKey(clientName, method)] = metric;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }

    public static void HandleFailedRequestClient(string clientName, string version, string method, string controller)
    {
        try
        {
            lock (_gate)
            {
                if (ClientMetrics.TryGetValue(GetKey(clientName, method), out var metric))
                {
                    metric.LastRequestTime = DateTime.UtcNow;
                    metric.RequestCount++;
                    metric.ErrorCount++;
                }
                else
                {
                    metric = new Metric
                    {
                        OwnerName = GetOwner(),
                        ServiceName = clientName,
                        Version = version,
                        MethodName = method,
                        ControllerName = controller,
                        FirstRequestTime = DateTime.UtcNow,
                        LastRequestTime = DateTime.UtcNow,
                        RequestCount = 1,
                        ErrorCount = 1,
                        AvgTimeInSec = 0
                    };
                }

                ClientMetrics[GetKey(clientName, method)] = metric;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }

    public static void HandleSuccessfulRequestServer(string service, string version, string method, string controller,
        TimeSpan executionTime)
    {
        try
        {
            lock (_gate)
            {
                if (ServiceMetrics.TryGetValue(GetKey(service, method), out var metric))
                {
                    metric.LastRequestTime = DateTime.UtcNow;
                    metric.RequestCount++;
                    metric.AvgTimeInSec =
                        ((metric.AvgTimeInSec * (metric.RequestCount - 1) + executionTime.TotalSeconds) /
                         metric.RequestCount);
                }
                else
                {
                    metric = new Metric
                    {
                        OwnerName = GetOwner(),
                        ServiceName = service,
                        Version = version,
                        MethodName = method,
                        ControllerName = controller,
                        FirstRequestTime = DateTime.UtcNow,
                        LastRequestTime = DateTime.UtcNow,
                        RequestCount = 1,
                        ErrorCount = 0,
                        AvgTimeInSec = executionTime.TotalSeconds
                    };
                }

                ServiceMetrics[GetKey(service, method)] = metric;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }

    public static void HandleFailedRequestServer(string service, string version, string method, string controller)
    {
        try
        {
            lock (_gate)
            {
                if (ServiceMetrics.TryGetValue(GetKey(service, method), out var metric))
                {
                    metric.LastRequestTime = DateTime.UtcNow;
                    metric.RequestCount++;
                    metric.ErrorCount++;
                }
                else
                {
                    metric = new Metric
                    {
                        OwnerName = GetOwner(),
                        ServiceName = service,
                        Version = version,
                        MethodName = method,
                        ControllerName = controller,
                        FirstRequestTime = DateTime.UtcNow,
                        LastRequestTime = DateTime.UtcNow,
                        RequestCount = 1,
                        ErrorCount = 1,
                        AvgTimeInSec = 0
                    };
                }

                ServiceMetrics[GetKey(service, method)] = metric;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }

    private static string GetKey(string service, string method) => $"{service}|{method}";


    private static string GetOwner()
    {
        if (!string.IsNullOrEmpty(OwnerName))
            return OwnerName;

        var appName = Environment.GetEnvironmentVariable("ENV_INFO");
        if (appName == null)
        {
            appName = Assembly.GetEntryAssembly()?.GetName().Name;
        }

        return appName;
    }
}

public class Metric
{
    public string OwnerName { get; set; }
    public string ServiceName { get; set; }
    public string Version { get; set; }
    public string MethodName { get; set; }
    public string ControllerName { get; set; }
    public DateTime FirstRequestTime { get; set; }
    public DateTime LastRequestTime { get; set; }
    public int RequestCount { get; set; }
    public int ErrorCount { get; set; }
    public double AvgTimeInSec { get; set; }
}