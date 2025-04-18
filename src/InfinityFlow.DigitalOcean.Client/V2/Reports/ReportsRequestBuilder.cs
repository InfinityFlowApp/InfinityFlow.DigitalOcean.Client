// <auto-generated/>
#pragma warning disable CS0618
using InfinityFlow.DigitalOcean.Client.V2.Reports.Droplet_neighbors_ids;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace InfinityFlow.DigitalOcean.Client.V2.Reports
{
    /// <summary>
    /// Builds and executes requests for operations under \v2\reports
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ReportsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The droplet_neighbors_ids property</summary>
        public global::InfinityFlow.DigitalOcean.Client.V2.Reports.Droplet_neighbors_ids.Droplet_neighbors_idsRequestBuilder Droplet_neighbors_ids
        {
            get => new global::InfinityFlow.DigitalOcean.Client.V2.Reports.Droplet_neighbors_ids.Droplet_neighbors_idsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::InfinityFlow.DigitalOcean.Client.V2.Reports.ReportsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ReportsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v2/reports", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::InfinityFlow.DigitalOcean.Client.V2.Reports.ReportsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ReportsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v2/reports", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
