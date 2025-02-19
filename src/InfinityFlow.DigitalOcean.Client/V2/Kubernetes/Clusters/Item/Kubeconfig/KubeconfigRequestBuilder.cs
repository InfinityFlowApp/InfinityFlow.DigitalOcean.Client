// <auto-generated/>
#pragma warning disable CS0618
using InfinityFlow.DigitalOcean.Client.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace InfinityFlow.DigitalOcean.Client.V2.Kubernetes.Clusters.Item.Kubeconfig
{
    /// <summary>
    /// Builds and executes requests for operations under \v2\kubernetes\clusters\{cluster_id}\kubeconfig
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class KubeconfigRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::InfinityFlow.DigitalOcean.Client.V2.Kubernetes.Clusters.Item.Kubeconfig.KubeconfigRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public KubeconfigRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v2/kubernetes/clusters/{cluster_id}/kubeconfig{?expiry_seconds*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::InfinityFlow.DigitalOcean.Client.V2.Kubernetes.Clusters.Item.Kubeconfig.KubeconfigRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public KubeconfigRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v2/kubernetes/clusters/{cluster_id}/kubeconfig{?expiry_seconds*}", rawUrl)
        {
        }
        /// <summary>
        /// This endpoint returns a kubeconfig file in YAML format. It can be used toconnect to and administer the cluster using the Kubernetes command line tool,`kubectl`, or other programs supporting kubeconfig files (e.g., client libraries).The resulting kubeconfig file uses token-based authentication for clusterssupporting it, and certificate-based authentication otherwise. For a list ofsupported versions and more information, see &quot;[How to Connect to a DigitalOceanKubernetes Cluster](https://docs.digitalocean.com/products/kubernetes/how-to/connect-to-cluster/)&quot;.To retrieve a kubeconfig file for use with a Kubernetes cluster, send a GETrequest to `/v2/kubernetes/clusters/$K8S_CLUSTER_ID/kubeconfig`.Clusters supporting token-based authentication may define an expiration bypassing a duration in seconds as a query parameter to`/v2/kubernetes/clusters/$K8S_CLUSTER_ID/kubeconfig?expiry_seconds=$DURATION_IN_SECONDS`.If not set or 0, then the token will have a 7 day expiry. The query parameterhas no impact in certificate-based authentication.
        /// </summary>
        /// <returns>A <see cref="Stream"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::InfinityFlow.DigitalOcean.Client.Models.Error">When receiving a 401 status code</exception>
        /// <exception cref="global::InfinityFlow.DigitalOcean.Client.Models.Error">When receiving a 404 status code</exception>
        /// <exception cref="global::InfinityFlow.DigitalOcean.Client.Models.Error">When receiving a 429 status code</exception>
        /// <exception cref="global::InfinityFlow.DigitalOcean.Client.Models.Error">When receiving a 500 status code</exception>
        /// <exception cref="global::InfinityFlow.DigitalOcean.Client.Models.Error">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Stream?> GetAsync(Action<RequestConfiguration<global::InfinityFlow.DigitalOcean.Client.V2.Kubernetes.Clusters.Item.Kubeconfig.KubeconfigRequestBuilder.KubeconfigRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Stream> GetAsync(Action<RequestConfiguration<global::InfinityFlow.DigitalOcean.Client.V2.Kubernetes.Clusters.Item.Kubeconfig.KubeconfigRequestBuilder.KubeconfigRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "401", global::InfinityFlow.DigitalOcean.Client.Models.Error.CreateFromDiscriminatorValue },
                { "404", global::InfinityFlow.DigitalOcean.Client.Models.Error.CreateFromDiscriminatorValue },
                { "429", global::InfinityFlow.DigitalOcean.Client.Models.Error.CreateFromDiscriminatorValue },
                { "500", global::InfinityFlow.DigitalOcean.Client.Models.Error.CreateFromDiscriminatorValue },
                { "XXX", global::InfinityFlow.DigitalOcean.Client.Models.Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// This endpoint returns a kubeconfig file in YAML format. It can be used toconnect to and administer the cluster using the Kubernetes command line tool,`kubectl`, or other programs supporting kubeconfig files (e.g., client libraries).The resulting kubeconfig file uses token-based authentication for clusterssupporting it, and certificate-based authentication otherwise. For a list ofsupported versions and more information, see &quot;[How to Connect to a DigitalOceanKubernetes Cluster](https://docs.digitalocean.com/products/kubernetes/how-to/connect-to-cluster/)&quot;.To retrieve a kubeconfig file for use with a Kubernetes cluster, send a GETrequest to `/v2/kubernetes/clusters/$K8S_CLUSTER_ID/kubeconfig`.Clusters supporting token-based authentication may define an expiration bypassing a duration in seconds as a query parameter to`/v2/kubernetes/clusters/$K8S_CLUSTER_ID/kubeconfig?expiry_seconds=$DURATION_IN_SECONDS`.If not set or 0, then the token will have a 7 day expiry. The query parameterhas no impact in certificate-based authentication.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::InfinityFlow.DigitalOcean.Client.V2.Kubernetes.Clusters.Item.Kubeconfig.KubeconfigRequestBuilder.KubeconfigRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::InfinityFlow.DigitalOcean.Client.V2.Kubernetes.Clusters.Item.Kubeconfig.KubeconfigRequestBuilder.KubeconfigRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/yaml, application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::InfinityFlow.DigitalOcean.Client.V2.Kubernetes.Clusters.Item.Kubeconfig.KubeconfigRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::InfinityFlow.DigitalOcean.Client.V2.Kubernetes.Clusters.Item.Kubeconfig.KubeconfigRequestBuilder WithUrl(string rawUrl)
        {
            return new global::InfinityFlow.DigitalOcean.Client.V2.Kubernetes.Clusters.Item.Kubeconfig.KubeconfigRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// This endpoint returns a kubeconfig file in YAML format. It can be used toconnect to and administer the cluster using the Kubernetes command line tool,`kubectl`, or other programs supporting kubeconfig files (e.g., client libraries).The resulting kubeconfig file uses token-based authentication for clusterssupporting it, and certificate-based authentication otherwise. For a list ofsupported versions and more information, see &quot;[How to Connect to a DigitalOceanKubernetes Cluster](https://docs.digitalocean.com/products/kubernetes/how-to/connect-to-cluster/)&quot;.To retrieve a kubeconfig file for use with a Kubernetes cluster, send a GETrequest to `/v2/kubernetes/clusters/$K8S_CLUSTER_ID/kubeconfig`.Clusters supporting token-based authentication may define an expiration bypassing a duration in seconds as a query parameter to`/v2/kubernetes/clusters/$K8S_CLUSTER_ID/kubeconfig?expiry_seconds=$DURATION_IN_SECONDS`.If not set or 0, then the token will have a 7 day expiry. The query parameterhas no impact in certificate-based authentication.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class KubeconfigRequestBuilderGetQueryParameters 
        {
            /// <summary>The duration in seconds that the returned Kubernetes credentials will be valid. If not set or 0, the credentials will have a 7 day expiry.</summary>
            [QueryParameter("expiry_seconds")]
            public int? ExpirySeconds { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class KubeconfigRequestBuilderGetRequestConfiguration : RequestConfiguration<global::InfinityFlow.DigitalOcean.Client.V2.Kubernetes.Clusters.Item.Kubeconfig.KubeconfigRequestBuilder.KubeconfigRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
