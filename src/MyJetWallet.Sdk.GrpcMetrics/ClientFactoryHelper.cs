using System;
using System.Net.Http;
using Grpc.Core;
using Grpc.Core.Interceptors;
using Grpc.Net.Client;

namespace MyJetWallet.Sdk.GrpcMetrics;

public static class ClientFactoryHelper
{
    public static CallInvoker CreateCallInvoker(string grpcServiceUrl)
    {
        AppContext.SetSwitch("System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);
            
        var httpHandler = new HttpClientHandler();
        httpHandler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;
            
        var channel = GrpcChannel.ForAddress(grpcServiceUrl,  new GrpcChannelOptions { HttpHandler = httpHandler });
        var invoker = channel.Intercept(new PrometheusMetricsInterceptor());

        return invoker;
    }
}