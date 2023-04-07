<!-- markdownlint-capture -->
<!-- markdownlint-disable -->

# Code Metrics

This file is dynamically maintained by a bot, *please do not* edit this by hand. It represents various [code metrics](https://aka.ms/dotnet/code-metrics), such as cyclomatic complexity, maintainability index, and so on.

<div id='myjetwallet-sdk-grpcmetrics'></div>

## MyJetWallet.Sdk.GrpcMetrics :exploding_head:

The *MyJetWallet.Sdk.GrpcMetrics.csproj* project file contains:

- 1 namespaces.
- 4 named types.
- 432 total lines of source code.
- Approximately 121 lines of executable code.
- The highest cyclomatic complexity is 17 :exploding_head:.

<details>
<summary>
  <strong id="myjetwallet-sdk-grpcmetrics">
    MyJetWallet.Sdk.GrpcMetrics :exploding_head:
  </strong>
</summary>
<br>

The `MyJetWallet.Sdk.GrpcMetrics` namespace contains 4 named types.

- 4 named types.
- 432 total lines of source code.
- Approximately 121 lines of executable code.
- The highest cyclomatic complexity is 17 :exploding_head:.

<details>
<summary>
  <strong id="clientfactoryhelper">
    ClientFactoryHelper :heavy_check_mark:
  </strong>
</summary>
<br>

- The `ClientFactoryHelper` contains 1 members.
- 15 total lines of source code.
- Approximately 6 lines of executable code.
- The highest cyclomatic complexity is 1 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/MyJetWallet/MyJetWallet.Sdk.GrpcMetrics/blob/master/src/MyJetWallet.Sdk.GrpcMetrics/ClientFactoryHelper.cs#L11' title='CallInvoker ClientFactoryHelper.CreateCallInvoker(string grpcServiceUrl)'>11</a> | 72 | 1 :heavy_check_mark: | 0 | 5 | 12 / 6 |

<a href="#ClientFactoryHelper-class-diagram">:link: to `ClientFactoryHelper` class diagram</a>

<a href="#myjetwallet-sdk-grpcmetrics">:top: back to MyJetWallet.Sdk.GrpcMetrics</a>

</details>

<details>
<summary>
  <strong id="grpcmetricsmanager">
    GrpcMetricsManager :heavy_check_mark:
  </strong>
</summary>
<br>

- The `GrpcMetricsManager` contains 9 members.
- 170 total lines of source code.
- Approximately 40 lines of executable code.
- The highest cyclomatic complexity is 4 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Field | <a href='https://github.com/MyJetWallet/MyJetWallet.Sdk.GrpcMetrics/blob/master/src/MyJetWallet.Sdk.GrpcMetrics/GrpcMetricsManager.cs#L10' title='Dictionary<string, Metric> GrpcMetricsManager.ClientMetrics'>10</a> | 93 | 0 :heavy_check_mark: | 0 | 2 | 1 / 1 |
| Method | <a href='https://github.com/MyJetWallet/MyJetWallet.Sdk.GrpcMetrics/blob/master/src/MyJetWallet.Sdk.GrpcMetrics/GrpcMetricsManager.cs#L160' title='string GrpcMetricsManager.GetKey(string service, string method)'>160</a> | 97 | 1 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Method | <a href='https://github.com/MyJetWallet/MyJetWallet.Sdk.GrpcMetrics/blob/master/src/MyJetWallet.Sdk.GrpcMetrics/GrpcMetricsManager.cs#L163' title='string GrpcMetricsManager.GetOwner()'>163</a> | 73 | 4 :heavy_check_mark: | 0 | 1 | 13 / 5 |
| Method | <a href='https://github.com/MyJetWallet/MyJetWallet.Sdk.GrpcMetrics/blob/master/src/MyJetWallet.Sdk.GrpcMetrics/GrpcMetricsManager.cs#L52' title='void GrpcMetricsManager.HandleFailedRequestClient(string clientName, string version, string method, string controller)'>52</a> | 63 | 2 :heavy_check_mark: | 0 | 6 | 34 / 8 |
| Method | <a href='https://github.com/MyJetWallet/MyJetWallet.Sdk.GrpcMetrics/blob/master/src/MyJetWallet.Sdk.GrpcMetrics/GrpcMetricsManager.cs#L125' title='void GrpcMetricsManager.HandleFailedRequestServer(string service, string version, string method, string controller)'>125</a> | 63 | 2 :heavy_check_mark: | 0 | 6 | 34 / 8 |
| Method | <a href='https://github.com/MyJetWallet/MyJetWallet.Sdk.GrpcMetrics/blob/master/src/MyJetWallet.Sdk.GrpcMetrics/GrpcMetricsManager.cs#L14' title='void GrpcMetricsManager.HandleSuccessfulRequestClient(string clientName, string version, string method, string controller, TimeSpan executionTime)'>14</a> | 62 | 2 :heavy_check_mark: | 0 | 7 | 37 / 8 |
| Method | <a href='https://github.com/MyJetWallet/MyJetWallet.Sdk.GrpcMetrics/blob/master/src/MyJetWallet.Sdk.GrpcMetrics/GrpcMetricsManager.cs#L87' title='void GrpcMetricsManager.HandleSuccessfulRequestServer(string service, string version, string method, string controller, TimeSpan executionTime)'>87</a> | 62 | 2 :heavy_check_mark: | 0 | 7 | 37 / 8 |
| Property | <a href='https://github.com/MyJetWallet/MyJetWallet.Sdk.GrpcMetrics/blob/master/src/MyJetWallet.Sdk.GrpcMetrics/GrpcMetricsManager.cs#L12' title='string GrpcMetricsManager.OwnerName'>12</a> | 100 | 2 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/MyJetWallet/MyJetWallet.Sdk.GrpcMetrics/blob/master/src/MyJetWallet.Sdk.GrpcMetrics/GrpcMetricsManager.cs#L9' title='Dictionary<string, Metric> GrpcMetricsManager.ServiceMetrics'>9</a> | 93 | 0 :heavy_check_mark: | 0 | 2 | 1 / 1 |

<a href="#GrpcMetricsManager-class-diagram">:link: to `GrpcMetricsManager` class diagram</a>

<a href="#myjetwallet-sdk-grpcmetrics">:top: back to MyJetWallet.Sdk.GrpcMetrics</a>

</details>

<details>
<summary>
  <strong id="metric">
    Metric :heavy_check_mark:
  </strong>
</summary>
<br>

- The `Metric` contains 10 members.
- 13 total lines of source code.
- Approximately 0 lines of executable code.
- The highest cyclomatic complexity is 2 :heavy_check_mark:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Property | <a href='https://github.com/MyJetWallet/MyJetWallet.Sdk.GrpcMetrics/blob/master/src/MyJetWallet.Sdk.GrpcMetrics/GrpcMetricsManager.cs#L189' title='double Metric.AvgTimeInSec'>189</a> | 100 | 2 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Property | <a href='https://github.com/MyJetWallet/MyJetWallet.Sdk.GrpcMetrics/blob/master/src/MyJetWallet.Sdk.GrpcMetrics/GrpcMetricsManager.cs#L184' title='string Metric.ControllerName'>184</a> | 100 | 2 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Property | <a href='https://github.com/MyJetWallet/MyJetWallet.Sdk.GrpcMetrics/blob/master/src/MyJetWallet.Sdk.GrpcMetrics/GrpcMetricsManager.cs#L188' title='int Metric.ErrorCount'>188</a> | 100 | 2 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Property | <a href='https://github.com/MyJetWallet/MyJetWallet.Sdk.GrpcMetrics/blob/master/src/MyJetWallet.Sdk.GrpcMetrics/GrpcMetricsManager.cs#L185' title='DateTime Metric.FirstRequestTime'>185</a> | 100 | 2 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | <a href='https://github.com/MyJetWallet/MyJetWallet.Sdk.GrpcMetrics/blob/master/src/MyJetWallet.Sdk.GrpcMetrics/GrpcMetricsManager.cs#L186' title='DateTime Metric.LastRequestTime'>186</a> | 100 | 2 :heavy_check_mark: | 0 | 1 | 1 / 0 |
| Property | <a href='https://github.com/MyJetWallet/MyJetWallet.Sdk.GrpcMetrics/blob/master/src/MyJetWallet.Sdk.GrpcMetrics/GrpcMetricsManager.cs#L183' title='string Metric.MethodName'>183</a> | 100 | 2 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Property | <a href='https://github.com/MyJetWallet/MyJetWallet.Sdk.GrpcMetrics/blob/master/src/MyJetWallet.Sdk.GrpcMetrics/GrpcMetricsManager.cs#L180' title='string Metric.OwnerName'>180</a> | 100 | 2 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Property | <a href='https://github.com/MyJetWallet/MyJetWallet.Sdk.GrpcMetrics/blob/master/src/MyJetWallet.Sdk.GrpcMetrics/GrpcMetricsManager.cs#L187' title='int Metric.RequestCount'>187</a> | 100 | 2 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Property | <a href='https://github.com/MyJetWallet/MyJetWallet.Sdk.GrpcMetrics/blob/master/src/MyJetWallet.Sdk.GrpcMetrics/GrpcMetricsManager.cs#L181' title='string Metric.ServiceName'>181</a> | 100 | 2 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Property | <a href='https://github.com/MyJetWallet/MyJetWallet.Sdk.GrpcMetrics/blob/master/src/MyJetWallet.Sdk.GrpcMetrics/GrpcMetricsManager.cs#L182' title='string Metric.Version'>182</a> | 100 | 2 :heavy_check_mark: | 0 | 0 | 1 / 0 |

<a href="#Metric-class-diagram">:link: to `Metric` class diagram</a>

<a href="#myjetwallet-sdk-grpcmetrics">:top: back to MyJetWallet.Sdk.GrpcMetrics</a>

</details>

<details>
<summary>
  <strong id="prometheusmetricsinterceptor">
    PrometheusMetricsInterceptor :exploding_head:
  </strong>
</summary>
<br>

- The `PrometheusMetricsInterceptor` contains 19 members.
- 226 total lines of source code.
- Approximately 75 lines of executable code.
- The highest cyclomatic complexity is 17 :exploding_head:.

| Member kind | Line number | Maintainability index | Cyclomatic complexity | Depth of inheritance | Class coupling | Lines of source / executable code |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| Method | <a href='https://github.com/MyJetWallet/MyJetWallet.Sdk.GrpcMetrics/blob/master/src/MyJetWallet.Sdk.GrpcMetrics/PrometheusMetricsInterceptor.cs#L75' title='PrometheusMetricsInterceptor.PrometheusMetricsInterceptor()'>75</a> | 70 | 8 :warning: | 0 | 1 | 13 / 5 |
| Property | <a href='https://github.com/MyJetWallet/MyJetWallet.Sdk.GrpcMetrics/blob/master/src/MyJetWallet.Sdk.GrpcMetrics/PrometheusMetricsInterceptor.cs#L18' title='string PrometheusMetricsInterceptor.AppHost'>18</a> | 100 | 2 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Property | <a href='https://github.com/MyJetWallet/MyJetWallet.Sdk.GrpcMetrics/blob/master/src/MyJetWallet.Sdk.GrpcMetrics/PrometheusMetricsInterceptor.cs#L16' title='string PrometheusMetricsInterceptor.AppName'>16</a> | 100 | 2 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Property | <a href='https://github.com/MyJetWallet/MyJetWallet.Sdk.GrpcMetrics/blob/master/src/MyJetWallet.Sdk.GrpcMetrics/PrometheusMetricsInterceptor.cs#L17' title='string PrometheusMetricsInterceptor.AppVersion'>17</a> | 100 | 2 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Method | <a href='https://github.com/MyJetWallet/MyJetWallet.Sdk.GrpcMetrics/blob/master/src/MyJetWallet.Sdk.GrpcMetrics/PrometheusMetricsInterceptor.cs#L180' title='AsyncUnaryCall<TResponse> PrometheusMetricsInterceptor.AsyncUnaryCall<TRequest, TResponse>(TRequest request, ClientInterceptorContext<TRequest, TResponse> context, AsyncUnaryCallContinuation<TRequest, TResponse> continuation)'>180</a> | 49 | 7 :heavy_check_mark: | 0 | 8 | 59 / 26 |
| Method | <a href='https://github.com/MyJetWallet/MyJetWallet.Sdk.GrpcMetrics/blob/master/src/MyJetWallet.Sdk.GrpcMetrics/PrometheusMetricsInterceptor.cs#L137' title='TResponse PrometheusMetricsInterceptor.BlockingUnaryCall<TRequest, TResponse>(TRequest request, ClientInterceptorContext<TRequest, TResponse> context, BlockingUnaryCallContinuation<TRequest, TResponse> continuation)'>137</a> | 53 | 7 :heavy_check_mark: | 0 | 7 | 42 / 18 |
| Field | <a href='https://github.com/MyJetWallet/MyJetWallet.Sdk.GrpcMetrics/blob/master/src/MyJetWallet.Sdk.GrpcMetrics/PrometheusMetricsInterceptor.cs#L64' title='Histogram PrometheusMetricsInterceptor.ClientGrpcCallDelaySec'>64</a> | 84 | 0 :heavy_check_mark: | 0 | 3 | 7 / 1 |
| Field | <a href='https://github.com/MyJetWallet/MyJetWallet.Sdk.GrpcMetrics/blob/master/src/MyJetWallet.Sdk.GrpcMetrics/PrometheusMetricsInterceptor.cs#L49' title='Counter PrometheusMetricsInterceptor.ClientGrpcCallInCount'>49</a> | 85 | 0 :heavy_check_mark: | 0 | 3 | 3 / 1 |
| Field | <a href='https://github.com/MyJetWallet/MyJetWallet.Sdk.GrpcMetrics/blob/master/src/MyJetWallet.Sdk.GrpcMetrics/PrometheusMetricsInterceptor.cs#L54' title='Counter PrometheusMetricsInterceptor.ClientGrpcCallOutCount'>54</a> | 84 | 0 :heavy_check_mark: | 0 | 3 | 3 / 1 |
| Field | <a href='https://github.com/MyJetWallet/MyJetWallet.Sdk.GrpcMetrics/blob/master/src/MyJetWallet.Sdk.GrpcMetrics/PrometheusMetricsInterceptor.cs#L59' title='Gauge PrometheusMetricsInterceptor.ClientGrpcCallProcessCount'>59</a> | 85 | 0 :heavy_check_mark: | 0 | 3 | 3 / 1 |
| Field | <a href='https://github.com/MyJetWallet/MyJetWallet.Sdk.GrpcMetrics/blob/master/src/MyJetWallet.Sdk.GrpcMetrics/PrometheusMetricsInterceptor.cs#L22' title='string PrometheusMetricsInterceptor.GrpcSourceAppHostHeader'>22</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/MyJetWallet/MyJetWallet.Sdk.GrpcMetrics/blob/master/src/MyJetWallet.Sdk.GrpcMetrics/PrometheusMetricsInterceptor.cs#L20' title='string PrometheusMetricsInterceptor.GrpcSourceAppNameHeader'>20</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/MyJetWallet/MyJetWallet.Sdk.GrpcMetrics/blob/master/src/MyJetWallet.Sdk.GrpcMetrics/PrometheusMetricsInterceptor.cs#L21' title='string PrometheusMetricsInterceptor.GrpcSourceAppVersionHeader'>21</a> | 93 | 0 :heavy_check_mark: | 0 | 0 | 1 / 1 |
| Field | <a href='https://github.com/MyJetWallet/MyJetWallet.Sdk.GrpcMetrics/blob/master/src/MyJetWallet.Sdk.GrpcMetrics/PrometheusMetricsInterceptor.cs#L73' title='string PrometheusMetricsInterceptor.HostName'>73</a> | 100 | 0 :heavy_check_mark: | 0 | 0 | 1 / 0 |
| Field | <a href='https://github.com/MyJetWallet/MyJetWallet.Sdk.GrpcMetrics/blob/master/src/MyJetWallet.Sdk.GrpcMetrics/PrometheusMetricsInterceptor.cs#L39' title='Histogram PrometheusMetricsInterceptor.ServerGrpcCallDelaySec'>39</a> | 84 | 0 :heavy_check_mark: | 0 | 3 | 7 / 1 |
| Field | <a href='https://github.com/MyJetWallet/MyJetWallet.Sdk.GrpcMetrics/blob/master/src/MyJetWallet.Sdk.GrpcMetrics/PrometheusMetricsInterceptor.cs#L24' title='Counter PrometheusMetricsInterceptor.ServerGrpcCallInCount'>24</a> | 85 | 0 :heavy_check_mark: | 0 | 3 | 3 / 1 |
| Field | <a href='https://github.com/MyJetWallet/MyJetWallet.Sdk.GrpcMetrics/blob/master/src/MyJetWallet.Sdk.GrpcMetrics/PrometheusMetricsInterceptor.cs#L29' title='Counter PrometheusMetricsInterceptor.ServerGrpcCallOutCount'>29</a> | 84 | 0 :heavy_check_mark: | 0 | 3 | 3 / 1 |
| Field | <a href='https://github.com/MyJetWallet/MyJetWallet.Sdk.GrpcMetrics/blob/master/src/MyJetWallet.Sdk.GrpcMetrics/PrometheusMetricsInterceptor.cs#L34' title='Gauge PrometheusMetricsInterceptor.ServerGrpcCallProcessCount'>34</a> | 85 | 0 :heavy_check_mark: | 0 | 3 | 3 / 1 |
| Method | <a href='https://github.com/MyJetWallet/MyJetWallet.Sdk.GrpcMetrics/blob/master/src/MyJetWallet.Sdk.GrpcMetrics/PrometheusMetricsInterceptor.cs#L89' title='Task<TResponse> PrometheusMetricsInterceptor.UnaryServerHandler<TRequest, TResponse>(TRequest request, ServerCallContext context, UnaryServerMethod<TRequest, TResponse> continuation)'>89</a> | 49 | 17 :exploding_head: | 0 | 8 | 47 / 22 |

<a href="#PrometheusMetricsInterceptor-class-diagram">:link: to `PrometheusMetricsInterceptor` class diagram</a>

<a href="#myjetwallet-sdk-grpcmetrics">:top: back to MyJetWallet.Sdk.GrpcMetrics</a>

</details>

</details>

<a href="#myjetwallet-sdk-grpcmetrics">:top: back to MyJetWallet.Sdk.GrpcMetrics</a>

## Metric definitions

  - **Maintainability index**: Measures ease of code maintenance. Higher values are better.
  - **Cyclomatic complexity**: Measures the number of branches. Lower values are better.
  - **Depth of inheritance**: Measures length of object inheritance hierarchy. Lower values are better.
  - **Class coupling**: Measures the number of classes that are referenced. Lower values are better.
  - **Lines of source code**: Exact number of lines of source code. Lower values are better.
  - **Lines of executable code**: Approximates the lines of executable code. Lower values are better.

## Mermaid class diagrams

<div id="ClientFactoryHelper-class-diagram"></div>

##### `ClientFactoryHelper` class diagram

```mermaid
classDiagram
class ClientFactoryHelper{
    +CreateCallInvoker(string grpcServiceUrl)$ CallInvoker
}

```

<div id="GrpcMetricsManager-class-diagram"></div>

##### `GrpcMetricsManager` class diagram

```mermaid
classDiagram
class GrpcMetricsManager{
    -Dictionary<string, Metric> ServiceMetrics$
    -Dictionary<string, Metric> ClientMetrics$
    +string OwnerName$
    +HandleSuccessfulRequestClient(string clientName, string version, string method, string controller, TimeSpan executionTime)$ void
    +HandleFailedRequestClient(string clientName, string version, string method, string controller)$ void
    +HandleSuccessfulRequestServer(string service, string version, string method, string controller, TimeSpan executionTime)$ void
    +HandleFailedRequestServer(string service, string version, string method, string controller)$ void
    +GetKey(string service, string method)$ string
    +GetOwner()$ string
}

```

<div id="Metric-class-diagram"></div>

##### `Metric` class diagram

```mermaid
classDiagram
class Metric{
    +string OwnerName
    +string ServiceName
    +string Version
    +string MethodName
    +string ControllerName
    +DateTime FirstRequestTime
    +DateTime LastRequestTime
    +int RequestCount
    +int ErrorCount
    +double AvgTimeInSec
}

```

<div id="PrometheusMetricsInterceptor-class-diagram"></div>

##### `PrometheusMetricsInterceptor` class diagram

```mermaid
classDiagram
class PrometheusMetricsInterceptor{
    -string GrpcSourceAppNameHeader$
    -string GrpcSourceAppVersionHeader$
    -string GrpcSourceAppHostHeader$
    -Counter ServerGrpcCallInCount$
    -Counter ServerGrpcCallOutCount$
    -Gauge ServerGrpcCallProcessCount$
    -Histogram ServerGrpcCallDelaySec$
    -Counter ClientGrpcCallInCount$
    -Counter ClientGrpcCallOutCount$
    -Gauge ClientGrpcCallProcessCount$
    -Histogram ClientGrpcCallDelaySec$
    -string HostName$
    +string AppName$
    +string AppVersion$
    +string AppHost$
    +.ctor() PrometheusMetricsInterceptor
    +UnaryServerHandler<TRequest, TResponse>(TRequest request, ServerCallContext context, UnaryServerMethod<TRequest, TResponse> continuation) Task<TResponse>
    +BlockingUnaryCall<TRequest, TResponse>(TRequest request, ClientInterceptorContext<TRequest, TResponse> context, BlockingUnaryCallContinuation<TRequest, TResponse> continuation) TResponse
    +AsyncUnaryCall<TRequest, TResponse>(TRequest request, ClientInterceptorContext<TRequest, TResponse> context, AsyncUnaryCallContinuation<TRequest, TResponse> continuation) AsyncUnaryCall<TResponse>
}

```

*This file is maintained by a bot.*

<!-- markdownlint-restore -->
