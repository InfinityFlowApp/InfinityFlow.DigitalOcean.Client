// <auto-generated/>
#pragma warning disable CS0618
using InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Droplet.Bandwidth;
using InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Droplet.Cpu;
using InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Droplet.Filesystem_free;
using InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Droplet.Filesystem_size;
using InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Droplet.Load_15;
using InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Droplet.Load_1;
using InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Droplet.Load_5;
using InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Droplet.Memory_available;
using InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Droplet.Memory_cached;
using InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Droplet.Memory_free;
using InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Droplet.Memory_total;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Droplet
{
    /// <summary>
    /// Builds and executes requests for operations under \v2\monitoring\metrics\droplet
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class DropletRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The bandwidth property</summary>
        public global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Droplet.Bandwidth.BandwidthRequestBuilder Bandwidth
        {
            get => new global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Droplet.Bandwidth.BandwidthRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The cpu property</summary>
        public global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Droplet.Cpu.CpuRequestBuilder Cpu
        {
            get => new global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Droplet.Cpu.CpuRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The filesystem_free property</summary>
        public global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Droplet.Filesystem_free.Filesystem_freeRequestBuilder Filesystem_free
        {
            get => new global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Droplet.Filesystem_free.Filesystem_freeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The filesystem_size property</summary>
        public global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Droplet.Filesystem_size.Filesystem_sizeRequestBuilder Filesystem_size
        {
            get => new global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Droplet.Filesystem_size.Filesystem_sizeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The load_1 property</summary>
        public global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Droplet.Load_1.Load_1RequestBuilder Load_1
        {
            get => new global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Droplet.Load_1.Load_1RequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The load_15 property</summary>
        public global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Droplet.Load_15.Load_15RequestBuilder Load_15
        {
            get => new global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Droplet.Load_15.Load_15RequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The load_5 property</summary>
        public global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Droplet.Load_5.Load_5RequestBuilder Load_5
        {
            get => new global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Droplet.Load_5.Load_5RequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The memory_available property</summary>
        public global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Droplet.Memory_available.Memory_availableRequestBuilder Memory_available
        {
            get => new global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Droplet.Memory_available.Memory_availableRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The memory_cached property</summary>
        public global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Droplet.Memory_cached.Memory_cachedRequestBuilder Memory_cached
        {
            get => new global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Droplet.Memory_cached.Memory_cachedRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The memory_free property</summary>
        public global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Droplet.Memory_free.Memory_freeRequestBuilder Memory_free
        {
            get => new global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Droplet.Memory_free.Memory_freeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The memory_total property</summary>
        public global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Droplet.Memory_total.Memory_totalRequestBuilder Memory_total
        {
            get => new global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Droplet.Memory_total.Memory_totalRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Droplet.DropletRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DropletRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v2/monitoring/metrics/droplet", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Droplet.DropletRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DropletRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v2/monitoring/metrics/droplet", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
