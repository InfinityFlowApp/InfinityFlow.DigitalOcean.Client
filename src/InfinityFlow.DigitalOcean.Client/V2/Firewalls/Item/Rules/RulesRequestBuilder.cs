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
namespace InfinityFlow.DigitalOcean.Client.V2.Firewalls.Item.Rules
{
    /// <summary>
    /// Builds and executes requests for operations under \v2\firewalls\{firewall_id}\rules
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class RulesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::InfinityFlow.DigitalOcean.Client.V2.Firewalls.Item.Rules.RulesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RulesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v2/firewalls/{firewall_id}/rules", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::InfinityFlow.DigitalOcean.Client.V2.Firewalls.Item.Rules.RulesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RulesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v2/firewalls/{firewall_id}/rules", rawUrl)
        {
        }
        /// <summary>
        /// To remove access rules from a firewall, send a DELETE request to`/v2/firewalls/$FIREWALL_ID/rules`. The body of the request may include an`inbound_rules` and/or `outbound_rules` attribute containing an array of rulesto be removed.No response body will be sent back, but the response code will indicatesuccess. Specifically, the response code will be a 204, which means that theaction was successful with no returned body data.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::InfinityFlow.DigitalOcean.Client.Models.Error">When receiving a 400 status code</exception>
        /// <exception cref="global::InfinityFlow.DigitalOcean.Client.Models.Error">When receiving a 401 status code</exception>
        /// <exception cref="global::InfinityFlow.DigitalOcean.Client.Models.Error">When receiving a 404 status code</exception>
        /// <exception cref="global::InfinityFlow.DigitalOcean.Client.Models.Error">When receiving a 429 status code</exception>
        /// <exception cref="global::InfinityFlow.DigitalOcean.Client.Models.Error">When receiving a 500 status code</exception>
        /// <exception cref="global::InfinityFlow.DigitalOcean.Client.Models.Error">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(global::InfinityFlow.DigitalOcean.Client.Models.Firewall_rules body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task DeleteAsync(global::InfinityFlow.DigitalOcean.Client.Models.Firewall_rules body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToDeleteRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::InfinityFlow.DigitalOcean.Client.Models.Error.CreateFromDiscriminatorValue },
                { "401", global::InfinityFlow.DigitalOcean.Client.Models.Error.CreateFromDiscriminatorValue },
                { "404", global::InfinityFlow.DigitalOcean.Client.Models.Error.CreateFromDiscriminatorValue },
                { "429", global::InfinityFlow.DigitalOcean.Client.Models.Error.CreateFromDiscriminatorValue },
                { "500", global::InfinityFlow.DigitalOcean.Client.Models.Error.CreateFromDiscriminatorValue },
                { "XXX", global::InfinityFlow.DigitalOcean.Client.Models.Error.CreateFromDiscriminatorValue },
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// To add additional access rules to a firewall, send a POST request to`/v2/firewalls/$FIREWALL_ID/rules`. The body of the request may include aninbound_rules and/or outbound_rules attribute containing an array of rules tobe added.No response body will be sent back, but the response code will indicatesuccess. Specifically, the response code will be a 204, which means that theaction was successful with no returned body data.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::InfinityFlow.DigitalOcean.Client.Models.Error">When receiving a 400 status code</exception>
        /// <exception cref="global::InfinityFlow.DigitalOcean.Client.Models.Error">When receiving a 401 status code</exception>
        /// <exception cref="global::InfinityFlow.DigitalOcean.Client.Models.Error">When receiving a 404 status code</exception>
        /// <exception cref="global::InfinityFlow.DigitalOcean.Client.Models.Error">When receiving a 429 status code</exception>
        /// <exception cref="global::InfinityFlow.DigitalOcean.Client.Models.Error">When receiving a 500 status code</exception>
        /// <exception cref="global::InfinityFlow.DigitalOcean.Client.Models.Error">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task PostAsync(global::InfinityFlow.DigitalOcean.Client.Models.Firewall_rules body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task PostAsync(global::InfinityFlow.DigitalOcean.Client.Models.Firewall_rules body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::InfinityFlow.DigitalOcean.Client.Models.Error.CreateFromDiscriminatorValue },
                { "401", global::InfinityFlow.DigitalOcean.Client.Models.Error.CreateFromDiscriminatorValue },
                { "404", global::InfinityFlow.DigitalOcean.Client.Models.Error.CreateFromDiscriminatorValue },
                { "429", global::InfinityFlow.DigitalOcean.Client.Models.Error.CreateFromDiscriminatorValue },
                { "500", global::InfinityFlow.DigitalOcean.Client.Models.Error.CreateFromDiscriminatorValue },
                { "XXX", global::InfinityFlow.DigitalOcean.Client.Models.Error.CreateFromDiscriminatorValue },
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// To remove access rules from a firewall, send a DELETE request to`/v2/firewalls/$FIREWALL_ID/rules`. The body of the request may include an`inbound_rules` and/or `outbound_rules` attribute containing an array of rulesto be removed.No response body will be sent back, but the response code will indicatesuccess. Specifically, the response code will be a 204, which means that theaction was successful with no returned body data.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(global::InfinityFlow.DigitalOcean.Client.Models.Firewall_rules body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(global::InfinityFlow.DigitalOcean.Client.Models.Firewall_rules body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// To add additional access rules to a firewall, send a POST request to`/v2/firewalls/$FIREWALL_ID/rules`. The body of the request may include aninbound_rules and/or outbound_rules attribute containing an array of rules tobe added.No response body will be sent back, but the response code will indicatesuccess. Specifically, the response code will be a 204, which means that theaction was successful with no returned body data.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::InfinityFlow.DigitalOcean.Client.Models.Firewall_rules body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::InfinityFlow.DigitalOcean.Client.Models.Firewall_rules body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::InfinityFlow.DigitalOcean.Client.V2.Firewalls.Item.Rules.RulesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::InfinityFlow.DigitalOcean.Client.V2.Firewalls.Item.Rules.RulesRequestBuilder WithUrl(string rawUrl)
        {
            return new global::InfinityFlow.DigitalOcean.Client.V2.Firewalls.Item.Rules.RulesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class RulesRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class RulesRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
