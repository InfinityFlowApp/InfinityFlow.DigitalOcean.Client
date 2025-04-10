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
namespace InfinityFlow.DigitalOcean.Client.V2.GenAi.Agents.Item.Child_agents.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \v2\gen-ai\agents\{agent_uu-id}\child_agents\{child_agent_uuid}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WithChild_agent_uuItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::InfinityFlow.DigitalOcean.Client.V2.GenAi.Agents.Item.Child_agents.Item.WithChild_agent_uuItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithChild_agent_uuItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v2/gen-ai/agents/{agent_uu%2Did}/child_agents/{child_agent_uuid}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::InfinityFlow.DigitalOcean.Client.V2.GenAi.Agents.Item.Child_agents.Item.WithChild_agent_uuItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithChild_agent_uuItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v2/gen-ai/agents/{agent_uu%2Did}/child_agents/{child_agent_uuid}", rawUrl)
        {
        }
        /// <summary>
        /// To delete an agent route from a parent agent, send a DELETE request to `/v2/gen-ai/agents/{parent_agent_uuid}/child_agents/{child_agent_uuid}`.
        /// </summary>
        /// <returns>A <see cref="global::InfinityFlow.DigitalOcean.Client.Models.ApiUnlinkAgentOutput"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::InfinityFlow.DigitalOcean.Client.Models.Error">When receiving a 401 status code</exception>
        /// <exception cref="global::InfinityFlow.DigitalOcean.Client.Models.Error">When receiving a 404 status code</exception>
        /// <exception cref="global::InfinityFlow.DigitalOcean.Client.Models.Error">When receiving a 429 status code</exception>
        /// <exception cref="global::InfinityFlow.DigitalOcean.Client.Models.Error">When receiving a 500 status code</exception>
        /// <exception cref="global::InfinityFlow.DigitalOcean.Client.Models.Error">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::InfinityFlow.DigitalOcean.Client.Models.ApiUnlinkAgentOutput?> DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::InfinityFlow.DigitalOcean.Client.Models.ApiUnlinkAgentOutput> DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "401", global::InfinityFlow.DigitalOcean.Client.Models.Error.CreateFromDiscriminatorValue },
                { "404", global::InfinityFlow.DigitalOcean.Client.Models.Error.CreateFromDiscriminatorValue },
                { "429", global::InfinityFlow.DigitalOcean.Client.Models.Error.CreateFromDiscriminatorValue },
                { "500", global::InfinityFlow.DigitalOcean.Client.Models.Error.CreateFromDiscriminatorValue },
                { "XXX", global::InfinityFlow.DigitalOcean.Client.Models.Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::InfinityFlow.DigitalOcean.Client.Models.ApiUnlinkAgentOutput>(requestInfo, global::InfinityFlow.DigitalOcean.Client.Models.ApiUnlinkAgentOutput.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// To add an agent route to an agent, send a POST request to `/v2/gen-ai/agents/{parent_agent_uuid}/child_agents/{child_agent_uuid}`.
        /// </summary>
        /// <returns>A <see cref="global::InfinityFlow.DigitalOcean.Client.Models.ApiLinkAgentOutput"/></returns>
        /// <param name="body">Information for linking an agent</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::InfinityFlow.DigitalOcean.Client.Models.Error">When receiving a 401 status code</exception>
        /// <exception cref="global::InfinityFlow.DigitalOcean.Client.Models.Error">When receiving a 404 status code</exception>
        /// <exception cref="global::InfinityFlow.DigitalOcean.Client.Models.Error">When receiving a 429 status code</exception>
        /// <exception cref="global::InfinityFlow.DigitalOcean.Client.Models.Error">When receiving a 500 status code</exception>
        /// <exception cref="global::InfinityFlow.DigitalOcean.Client.Models.Error">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::InfinityFlow.DigitalOcean.Client.Models.ApiLinkAgentOutput?> PostAsync(global::InfinityFlow.DigitalOcean.Client.Models.ApiLinkAgentInputPublic body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::InfinityFlow.DigitalOcean.Client.Models.ApiLinkAgentOutput> PostAsync(global::InfinityFlow.DigitalOcean.Client.Models.ApiLinkAgentInputPublic body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "401", global::InfinityFlow.DigitalOcean.Client.Models.Error.CreateFromDiscriminatorValue },
                { "404", global::InfinityFlow.DigitalOcean.Client.Models.Error.CreateFromDiscriminatorValue },
                { "429", global::InfinityFlow.DigitalOcean.Client.Models.Error.CreateFromDiscriminatorValue },
                { "500", global::InfinityFlow.DigitalOcean.Client.Models.Error.CreateFromDiscriminatorValue },
                { "XXX", global::InfinityFlow.DigitalOcean.Client.Models.Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::InfinityFlow.DigitalOcean.Client.Models.ApiLinkAgentOutput>(requestInfo, global::InfinityFlow.DigitalOcean.Client.Models.ApiLinkAgentOutput.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// To update an agent route for an agent, send a PUT request to `/v2/gen-ai/agents/{parent_agent_uuid}/child_agents/{child_agent_uuid}`.
        /// </summary>
        /// <returns>A <see cref="global::InfinityFlow.DigitalOcean.Client.Models.ApiUpdateLinkedAgentOutput"/></returns>
        /// <param name="body">Information about updating the linkage of an agent</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::InfinityFlow.DigitalOcean.Client.Models.Error">When receiving a 401 status code</exception>
        /// <exception cref="global::InfinityFlow.DigitalOcean.Client.Models.Error">When receiving a 404 status code</exception>
        /// <exception cref="global::InfinityFlow.DigitalOcean.Client.Models.Error">When receiving a 429 status code</exception>
        /// <exception cref="global::InfinityFlow.DigitalOcean.Client.Models.Error">When receiving a 500 status code</exception>
        /// <exception cref="global::InfinityFlow.DigitalOcean.Client.Models.Error">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::InfinityFlow.DigitalOcean.Client.Models.ApiUpdateLinkedAgentOutput?> PutAsync(global::InfinityFlow.DigitalOcean.Client.Models.ApiUpdateLinkedAgentInputPublic body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::InfinityFlow.DigitalOcean.Client.Models.ApiUpdateLinkedAgentOutput> PutAsync(global::InfinityFlow.DigitalOcean.Client.Models.ApiUpdateLinkedAgentInputPublic body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPutRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "401", global::InfinityFlow.DigitalOcean.Client.Models.Error.CreateFromDiscriminatorValue },
                { "404", global::InfinityFlow.DigitalOcean.Client.Models.Error.CreateFromDiscriminatorValue },
                { "429", global::InfinityFlow.DigitalOcean.Client.Models.Error.CreateFromDiscriminatorValue },
                { "500", global::InfinityFlow.DigitalOcean.Client.Models.Error.CreateFromDiscriminatorValue },
                { "XXX", global::InfinityFlow.DigitalOcean.Client.Models.Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::InfinityFlow.DigitalOcean.Client.Models.ApiUpdateLinkedAgentOutput>(requestInfo, global::InfinityFlow.DigitalOcean.Client.Models.ApiUpdateLinkedAgentOutput.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// To delete an agent route from a parent agent, send a DELETE request to `/v2/gen-ai/agents/{parent_agent_uuid}/child_agents/{child_agent_uuid}`.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// To add an agent route to an agent, send a POST request to `/v2/gen-ai/agents/{parent_agent_uuid}/child_agents/{child_agent_uuid}`.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">Information for linking an agent</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::InfinityFlow.DigitalOcean.Client.Models.ApiLinkAgentInputPublic body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::InfinityFlow.DigitalOcean.Client.Models.ApiLinkAgentInputPublic body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// To update an agent route for an agent, send a PUT request to `/v2/gen-ai/agents/{parent_agent_uuid}/child_agents/{child_agent_uuid}`.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">Information about updating the linkage of an agent</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(global::InfinityFlow.DigitalOcean.Client.Models.ApiUpdateLinkedAgentInputPublic body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(global::InfinityFlow.DigitalOcean.Client.Models.ApiUpdateLinkedAgentInputPublic body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PUT, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::InfinityFlow.DigitalOcean.Client.V2.GenAi.Agents.Item.Child_agents.Item.WithChild_agent_uuItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::InfinityFlow.DigitalOcean.Client.V2.GenAi.Agents.Item.Child_agents.Item.WithChild_agent_uuItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::InfinityFlow.DigitalOcean.Client.V2.GenAi.Agents.Item.Child_agents.Item.WithChild_agent_uuItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class WithChild_agent_uuItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class WithChild_agent_uuItemRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class WithChild_agent_uuItemRequestBuilderPutRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
