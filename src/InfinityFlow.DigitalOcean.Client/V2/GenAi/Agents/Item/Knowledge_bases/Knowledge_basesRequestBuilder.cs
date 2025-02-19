// <auto-generated/>
#pragma warning disable CS0618
using InfinityFlow.DigitalOcean.Client.V2.GenAi.Agents.Item.Knowledge_bases.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace InfinityFlow.DigitalOcean.Client.V2.GenAi.Agents.Item.Knowledge_bases
{
    /// <summary>
    /// Builds and executes requests for operations under \v2\gen-ai\agents\{agent_uu-id}\knowledge_bases
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Knowledge_basesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the InfinityFlow.DigitalOcean.Client.v2.genAi.agents.item.knowledge_bases.item collection</summary>
        /// <param name="position">Knowledge base id</param>
        /// <returns>A <see cref="global::InfinityFlow.DigitalOcean.Client.V2.GenAi.Agents.Item.Knowledge_bases.Item.WithKnowledge_base_uuItemRequestBuilder"/></returns>
        public global::InfinityFlow.DigitalOcean.Client.V2.GenAi.Agents.Item.Knowledge_bases.Item.WithKnowledge_base_uuItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("knowledge_base_uuid", position);
                return new global::InfinityFlow.DigitalOcean.Client.V2.GenAi.Agents.Item.Knowledge_bases.Item.WithKnowledge_base_uuItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::InfinityFlow.DigitalOcean.Client.V2.GenAi.Agents.Item.Knowledge_bases.Knowledge_basesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Knowledge_basesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v2/gen-ai/agents/{agent_uu%2Did}/knowledge_bases", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::InfinityFlow.DigitalOcean.Client.V2.GenAi.Agents.Item.Knowledge_bases.Knowledge_basesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Knowledge_basesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v2/gen-ai/agents/{agent_uu%2Did}/knowledge_bases", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
