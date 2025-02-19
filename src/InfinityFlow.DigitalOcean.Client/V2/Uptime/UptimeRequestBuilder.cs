// <auto-generated/>
#pragma warning disable CS0618
using InfinityFlow.DigitalOcean.Client.V2.Uptime.Checks;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace InfinityFlow.DigitalOcean.Client.V2.Uptime
{
    /// <summary>
    /// Builds and executes requests for operations under \v2\uptime
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class UptimeRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The checks property</summary>
        public global::InfinityFlow.DigitalOcean.Client.V2.Uptime.Checks.ChecksRequestBuilder Checks
        {
            get => new global::InfinityFlow.DigitalOcean.Client.V2.Uptime.Checks.ChecksRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::InfinityFlow.DigitalOcean.Client.V2.Uptime.UptimeRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UptimeRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v2/uptime", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::InfinityFlow.DigitalOcean.Client.V2.Uptime.UptimeRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UptimeRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v2/uptime", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
