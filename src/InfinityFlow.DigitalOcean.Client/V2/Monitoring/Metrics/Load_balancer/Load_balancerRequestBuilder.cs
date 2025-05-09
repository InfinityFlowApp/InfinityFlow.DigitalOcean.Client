// <auto-generated/>
#pragma warning disable CS0618
using InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Droplets_connections;
using InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Droplets_downtime;
using InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Droplets_health_checks;
using InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Droplets_http_response_time_50p;
using InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Droplets_http_response_time_95p;
using InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Droplets_http_response_time_99p;
using InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Droplets_http_response_time_avg;
using InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Droplets_http_responses;
using InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Droplets_http_session_duration_50p;
using InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Droplets_http_session_duration_95p;
using InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Droplets_http_session_duration_avg;
using InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Droplets_queue_size;
using InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Frontend_connections_current;
using InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Frontend_connections_limit;
using InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Frontend_cpu_utilization;
using InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Frontend_firewall_dropped_bytes;
using InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Frontend_firewall_dropped_packets;
using InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Frontend_http_requests_per_second;
using InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Frontend_http_responses;
using InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Frontend_network_throughput_http;
using InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Frontend_network_throughput_tcp;
using InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Frontend_network_throughput_udp;
using InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Frontend_nlb_tcp_network_throughput;
using InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Frontend_nlb_udp_network_throughput;
using InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Frontend_tls_connections_current;
using InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Frontend_tls_connections_exceeding_rate_limit;
using InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Frontend_tls_connections_limit;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer
{
    /// <summary>
    /// Builds and executes requests for operations under \v2\monitoring\metrics\load_balancer
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Load_balancerRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The droplets_connections property</summary>
        public global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Droplets_connections.Droplets_connectionsRequestBuilder Droplets_connections
        {
            get => new global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Droplets_connections.Droplets_connectionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The droplets_downtime property</summary>
        public global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Droplets_downtime.Droplets_downtimeRequestBuilder Droplets_downtime
        {
            get => new global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Droplets_downtime.Droplets_downtimeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The droplets_health_checks property</summary>
        public global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Droplets_health_checks.Droplets_health_checksRequestBuilder Droplets_health_checks
        {
            get => new global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Droplets_health_checks.Droplets_health_checksRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The droplets_http_responses property</summary>
        public global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Droplets_http_responses.Droplets_http_responsesRequestBuilder Droplets_http_responses
        {
            get => new global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Droplets_http_responses.Droplets_http_responsesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The droplets_http_response_time_50p property</summary>
        public global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Droplets_http_response_time_50p.Droplets_http_response_time_50pRequestBuilder Droplets_http_response_time_50p
        {
            get => new global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Droplets_http_response_time_50p.Droplets_http_response_time_50pRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The droplets_http_response_time_95p property</summary>
        public global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Droplets_http_response_time_95p.Droplets_http_response_time_95pRequestBuilder Droplets_http_response_time_95p
        {
            get => new global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Droplets_http_response_time_95p.Droplets_http_response_time_95pRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The droplets_http_response_time_99p property</summary>
        public global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Droplets_http_response_time_99p.Droplets_http_response_time_99pRequestBuilder Droplets_http_response_time_99p
        {
            get => new global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Droplets_http_response_time_99p.Droplets_http_response_time_99pRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The droplets_http_response_time_avg property</summary>
        public global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Droplets_http_response_time_avg.Droplets_http_response_time_avgRequestBuilder Droplets_http_response_time_avg
        {
            get => new global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Droplets_http_response_time_avg.Droplets_http_response_time_avgRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The droplets_http_session_duration_50p property</summary>
        public global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Droplets_http_session_duration_50p.Droplets_http_session_duration_50pRequestBuilder Droplets_http_session_duration_50p
        {
            get => new global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Droplets_http_session_duration_50p.Droplets_http_session_duration_50pRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The droplets_http_session_duration_95p property</summary>
        public global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Droplets_http_session_duration_95p.Droplets_http_session_duration_95pRequestBuilder Droplets_http_session_duration_95p
        {
            get => new global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Droplets_http_session_duration_95p.Droplets_http_session_duration_95pRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The droplets_http_session_duration_avg property</summary>
        public global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Droplets_http_session_duration_avg.Droplets_http_session_duration_avgRequestBuilder Droplets_http_session_duration_avg
        {
            get => new global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Droplets_http_session_duration_avg.Droplets_http_session_duration_avgRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The droplets_queue_size property</summary>
        public global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Droplets_queue_size.Droplets_queue_sizeRequestBuilder Droplets_queue_size
        {
            get => new global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Droplets_queue_size.Droplets_queue_sizeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The frontend_connections_current property</summary>
        public global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Frontend_connections_current.Frontend_connections_currentRequestBuilder Frontend_connections_current
        {
            get => new global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Frontend_connections_current.Frontend_connections_currentRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The frontend_connections_limit property</summary>
        public global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Frontend_connections_limit.Frontend_connections_limitRequestBuilder Frontend_connections_limit
        {
            get => new global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Frontend_connections_limit.Frontend_connections_limitRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The frontend_cpu_utilization property</summary>
        public global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Frontend_cpu_utilization.Frontend_cpu_utilizationRequestBuilder Frontend_cpu_utilization
        {
            get => new global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Frontend_cpu_utilization.Frontend_cpu_utilizationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The frontend_firewall_dropped_bytes property</summary>
        public global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Frontend_firewall_dropped_bytes.Frontend_firewall_dropped_bytesRequestBuilder Frontend_firewall_dropped_bytes
        {
            get => new global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Frontend_firewall_dropped_bytes.Frontend_firewall_dropped_bytesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The frontend_firewall_dropped_packets property</summary>
        public global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Frontend_firewall_dropped_packets.Frontend_firewall_dropped_packetsRequestBuilder Frontend_firewall_dropped_packets
        {
            get => new global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Frontend_firewall_dropped_packets.Frontend_firewall_dropped_packetsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The frontend_http_requests_per_second property</summary>
        public global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Frontend_http_requests_per_second.Frontend_http_requests_per_secondRequestBuilder Frontend_http_requests_per_second
        {
            get => new global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Frontend_http_requests_per_second.Frontend_http_requests_per_secondRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The frontend_http_responses property</summary>
        public global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Frontend_http_responses.Frontend_http_responsesRequestBuilder Frontend_http_responses
        {
            get => new global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Frontend_http_responses.Frontend_http_responsesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The frontend_network_throughput_http property</summary>
        public global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Frontend_network_throughput_http.Frontend_network_throughput_httpRequestBuilder Frontend_network_throughput_http
        {
            get => new global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Frontend_network_throughput_http.Frontend_network_throughput_httpRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The frontend_network_throughput_tcp property</summary>
        public global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Frontend_network_throughput_tcp.Frontend_network_throughput_tcpRequestBuilder Frontend_network_throughput_tcp
        {
            get => new global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Frontend_network_throughput_tcp.Frontend_network_throughput_tcpRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The frontend_network_throughput_udp property</summary>
        public global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Frontend_network_throughput_udp.Frontend_network_throughput_udpRequestBuilder Frontend_network_throughput_udp
        {
            get => new global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Frontend_network_throughput_udp.Frontend_network_throughput_udpRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The frontend_nlb_tcp_network_throughput property</summary>
        public global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Frontend_nlb_tcp_network_throughput.Frontend_nlb_tcp_network_throughputRequestBuilder Frontend_nlb_tcp_network_throughput
        {
            get => new global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Frontend_nlb_tcp_network_throughput.Frontend_nlb_tcp_network_throughputRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The frontend_nlb_udp_network_throughput property</summary>
        public global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Frontend_nlb_udp_network_throughput.Frontend_nlb_udp_network_throughputRequestBuilder Frontend_nlb_udp_network_throughput
        {
            get => new global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Frontend_nlb_udp_network_throughput.Frontend_nlb_udp_network_throughputRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The frontend_tls_connections_current property</summary>
        public global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Frontend_tls_connections_current.Frontend_tls_connections_currentRequestBuilder Frontend_tls_connections_current
        {
            get => new global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Frontend_tls_connections_current.Frontend_tls_connections_currentRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The frontend_tls_connections_exceeding_rate_limit property</summary>
        public global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Frontend_tls_connections_exceeding_rate_limit.Frontend_tls_connections_exceeding_rate_limitRequestBuilder Frontend_tls_connections_exceeding_rate_limit
        {
            get => new global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Frontend_tls_connections_exceeding_rate_limit.Frontend_tls_connections_exceeding_rate_limitRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The frontend_tls_connections_limit property</summary>
        public global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Frontend_tls_connections_limit.Frontend_tls_connections_limitRequestBuilder Frontend_tls_connections_limit
        {
            get => new global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Frontend_tls_connections_limit.Frontend_tls_connections_limitRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Load_balancerRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Load_balancerRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v2/monitoring/metrics/load_balancer", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::InfinityFlow.DigitalOcean.Client.V2.Monitoring.Metrics.Load_balancer.Load_balancerRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Load_balancerRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v2/monitoring/metrics/load_balancer", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
