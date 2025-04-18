// <auto-generated/>
#pragma warning disable CS0618
using InfinityFlow.DigitalOcean.Client.Models;
using InfinityFlow.DigitalOcean.Client.V2.Apps.Tiers.Instance_sizes.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace InfinityFlow.DigitalOcean.Client.V2.Apps.Tiers.Instance_sizes
{
    /// <summary>
    /// Builds and executes requests for operations under \v2\apps\tiers\instance_sizes
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Instance_sizesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the InfinityFlow.DigitalOcean.Client.v2.apps.tiers.instance_sizes.item collection</summary>
        /// <param name="position">The slug of the instance size</param>
        /// <returns>A <see cref="global::InfinityFlow.DigitalOcean.Client.V2.Apps.Tiers.Instance_sizes.Item.WithSlugItemRequestBuilder"/></returns>
        public global::InfinityFlow.DigitalOcean.Client.V2.Apps.Tiers.Instance_sizes.Item.WithSlugItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("slug", position);
                return new global::InfinityFlow.DigitalOcean.Client.V2.Apps.Tiers.Instance_sizes.Item.WithSlugItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::InfinityFlow.DigitalOcean.Client.V2.Apps.Tiers.Instance_sizes.Instance_sizesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Instance_sizesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v2/apps/tiers/instance_sizes", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::InfinityFlow.DigitalOcean.Client.V2.Apps.Tiers.Instance_sizes.Instance_sizesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Instance_sizesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v2/apps/tiers/instance_sizes", rawUrl)
        {
        }
        /// <summary>
        /// List all instance sizes for `service`, `worker`, and `job` components.
        /// </summary>
        /// <returns>A <see cref="global::InfinityFlow.DigitalOcean.Client.Models.Apps_list_instance_sizes_response"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::InfinityFlow.DigitalOcean.Client.Models.Error">When receiving a 401 status code</exception>
        /// <exception cref="global::InfinityFlow.DigitalOcean.Client.Models.Error">When receiving a 429 status code</exception>
        /// <exception cref="global::InfinityFlow.DigitalOcean.Client.Models.Error">When receiving a 500 status code</exception>
        /// <exception cref="global::InfinityFlow.DigitalOcean.Client.Models.Error">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::InfinityFlow.DigitalOcean.Client.Models.Apps_list_instance_sizes_response?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::InfinityFlow.DigitalOcean.Client.Models.Apps_list_instance_sizes_response> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "401", global::InfinityFlow.DigitalOcean.Client.Models.Error.CreateFromDiscriminatorValue },
                { "429", global::InfinityFlow.DigitalOcean.Client.Models.Error.CreateFromDiscriminatorValue },
                { "500", global::InfinityFlow.DigitalOcean.Client.Models.Error.CreateFromDiscriminatorValue },
                { "XXX", global::InfinityFlow.DigitalOcean.Client.Models.Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::InfinityFlow.DigitalOcean.Client.Models.Apps_list_instance_sizes_response>(requestInfo, global::InfinityFlow.DigitalOcean.Client.Models.Apps_list_instance_sizes_response.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// List all instance sizes for `service`, `worker`, and `job` components.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::InfinityFlow.DigitalOcean.Client.V2.Apps.Tiers.Instance_sizes.Instance_sizesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::InfinityFlow.DigitalOcean.Client.V2.Apps.Tiers.Instance_sizes.Instance_sizesRequestBuilder WithUrl(string rawUrl)
        {
            return new global::InfinityFlow.DigitalOcean.Client.V2.Apps.Tiers.Instance_sizes.Instance_sizesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Instance_sizesRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
