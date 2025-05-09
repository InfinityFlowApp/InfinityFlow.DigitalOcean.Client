// <auto-generated/>
#pragma warning disable CS0618
using InfinityFlow.DigitalOcean.Client.Models;
using InfinityFlow.DigitalOcean.Client.V2.Databases.Item.Ca;
using InfinityFlow.DigitalOcean.Client.V2.Databases.Item.Config;
using InfinityFlow.DigitalOcean.Client.V2.Databases.Item.Dbs;
using InfinityFlow.DigitalOcean.Client.V2.Databases.Item.Events;
using InfinityFlow.DigitalOcean.Client.V2.Databases.Item.Eviction_policy;
using InfinityFlow.DigitalOcean.Client.V2.Databases.Item.Firewall;
using InfinityFlow.DigitalOcean.Client.V2.Databases.Item.Indexes;
using InfinityFlow.DigitalOcean.Client.V2.Databases.Item.Install_update;
using InfinityFlow.DigitalOcean.Client.V2.Databases.Item.Logsink;
using InfinityFlow.DigitalOcean.Client.V2.Databases.Item.Maintenance;
using InfinityFlow.DigitalOcean.Client.V2.Databases.Item.Migrate;
using InfinityFlow.DigitalOcean.Client.V2.Databases.Item.OnlineMigration;
using InfinityFlow.DigitalOcean.Client.V2.Databases.Item.Pools;
using InfinityFlow.DigitalOcean.Client.V2.Databases.Item.Replicas;
using InfinityFlow.DigitalOcean.Client.V2.Databases.Item.Resize;
using InfinityFlow.DigitalOcean.Client.V2.Databases.Item.Sql_mode;
using InfinityFlow.DigitalOcean.Client.V2.Databases.Item.Topics;
using InfinityFlow.DigitalOcean.Client.V2.Databases.Item.Upgrade;
using InfinityFlow.DigitalOcean.Client.V2.Databases.Item.Users;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace InfinityFlow.DigitalOcean.Client.V2.Databases.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \v2\databases\{database_cluster_uuid}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WithDatabase_cluster_uuItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The ca property</summary>
        public global::InfinityFlow.DigitalOcean.Client.V2.Databases.Item.Ca.CaRequestBuilder Ca
        {
            get => new global::InfinityFlow.DigitalOcean.Client.V2.Databases.Item.Ca.CaRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The config property</summary>
        public global::InfinityFlow.DigitalOcean.Client.V2.Databases.Item.Config.ConfigRequestBuilder Config
        {
            get => new global::InfinityFlow.DigitalOcean.Client.V2.Databases.Item.Config.ConfigRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The dbs property</summary>
        public global::InfinityFlow.DigitalOcean.Client.V2.Databases.Item.Dbs.DbsRequestBuilder Dbs
        {
            get => new global::InfinityFlow.DigitalOcean.Client.V2.Databases.Item.Dbs.DbsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The events property</summary>
        public global::InfinityFlow.DigitalOcean.Client.V2.Databases.Item.Events.EventsRequestBuilder Events
        {
            get => new global::InfinityFlow.DigitalOcean.Client.V2.Databases.Item.Events.EventsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The eviction_policy property</summary>
        public global::InfinityFlow.DigitalOcean.Client.V2.Databases.Item.Eviction_policy.Eviction_policyRequestBuilder Eviction_policy
        {
            get => new global::InfinityFlow.DigitalOcean.Client.V2.Databases.Item.Eviction_policy.Eviction_policyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The firewall property</summary>
        public global::InfinityFlow.DigitalOcean.Client.V2.Databases.Item.Firewall.FirewallRequestBuilder Firewall
        {
            get => new global::InfinityFlow.DigitalOcean.Client.V2.Databases.Item.Firewall.FirewallRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The indexes property</summary>
        public global::InfinityFlow.DigitalOcean.Client.V2.Databases.Item.Indexes.IndexesRequestBuilder Indexes
        {
            get => new global::InfinityFlow.DigitalOcean.Client.V2.Databases.Item.Indexes.IndexesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The install_update property</summary>
        public global::InfinityFlow.DigitalOcean.Client.V2.Databases.Item.Install_update.Install_updateRequestBuilder Install_update
        {
            get => new global::InfinityFlow.DigitalOcean.Client.V2.Databases.Item.Install_update.Install_updateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The logsink property</summary>
        public global::InfinityFlow.DigitalOcean.Client.V2.Databases.Item.Logsink.LogsinkRequestBuilder Logsink
        {
            get => new global::InfinityFlow.DigitalOcean.Client.V2.Databases.Item.Logsink.LogsinkRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The maintenance property</summary>
        public global::InfinityFlow.DigitalOcean.Client.V2.Databases.Item.Maintenance.MaintenanceRequestBuilder Maintenance
        {
            get => new global::InfinityFlow.DigitalOcean.Client.V2.Databases.Item.Maintenance.MaintenanceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The migrate property</summary>
        public global::InfinityFlow.DigitalOcean.Client.V2.Databases.Item.Migrate.MigrateRequestBuilder Migrate
        {
            get => new global::InfinityFlow.DigitalOcean.Client.V2.Databases.Item.Migrate.MigrateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The onlineMigration property</summary>
        public global::InfinityFlow.DigitalOcean.Client.V2.Databases.Item.OnlineMigration.OnlineMigrationRequestBuilder OnlineMigration
        {
            get => new global::InfinityFlow.DigitalOcean.Client.V2.Databases.Item.OnlineMigration.OnlineMigrationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The pools property</summary>
        public global::InfinityFlow.DigitalOcean.Client.V2.Databases.Item.Pools.PoolsRequestBuilder Pools
        {
            get => new global::InfinityFlow.DigitalOcean.Client.V2.Databases.Item.Pools.PoolsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The replicas property</summary>
        public global::InfinityFlow.DigitalOcean.Client.V2.Databases.Item.Replicas.ReplicasRequestBuilder Replicas
        {
            get => new global::InfinityFlow.DigitalOcean.Client.V2.Databases.Item.Replicas.ReplicasRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The resize property</summary>
        public global::InfinityFlow.DigitalOcean.Client.V2.Databases.Item.Resize.ResizeRequestBuilder Resize
        {
            get => new global::InfinityFlow.DigitalOcean.Client.V2.Databases.Item.Resize.ResizeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The sql_mode property</summary>
        public global::InfinityFlow.DigitalOcean.Client.V2.Databases.Item.Sql_mode.Sql_modeRequestBuilder Sql_mode
        {
            get => new global::InfinityFlow.DigitalOcean.Client.V2.Databases.Item.Sql_mode.Sql_modeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The topics property</summary>
        public global::InfinityFlow.DigitalOcean.Client.V2.Databases.Item.Topics.TopicsRequestBuilder Topics
        {
            get => new global::InfinityFlow.DigitalOcean.Client.V2.Databases.Item.Topics.TopicsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The upgrade property</summary>
        public global::InfinityFlow.DigitalOcean.Client.V2.Databases.Item.Upgrade.UpgradeRequestBuilder Upgrade
        {
            get => new global::InfinityFlow.DigitalOcean.Client.V2.Databases.Item.Upgrade.UpgradeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The users property</summary>
        public global::InfinityFlow.DigitalOcean.Client.V2.Databases.Item.Users.UsersRequestBuilder Users
        {
            get => new global::InfinityFlow.DigitalOcean.Client.V2.Databases.Item.Users.UsersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::InfinityFlow.DigitalOcean.Client.V2.Databases.Item.WithDatabase_cluster_uuItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithDatabase_cluster_uuItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v2/databases/{database_cluster_uuid}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::InfinityFlow.DigitalOcean.Client.V2.Databases.Item.WithDatabase_cluster_uuItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithDatabase_cluster_uuItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v2/databases/{database_cluster_uuid}", rawUrl)
        {
        }
        /// <summary>
        /// To destroy a specific database, send a DELETE request to `/v2/databases/$DATABASE_ID`.A status of 204 will be given. This indicates that the request was processed successfully, but that no response body is needed.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::InfinityFlow.DigitalOcean.Client.Models.Error">When receiving a 401 status code</exception>
        /// <exception cref="global::InfinityFlow.DigitalOcean.Client.Models.Error">When receiving a 404 status code</exception>
        /// <exception cref="global::InfinityFlow.DigitalOcean.Client.Models.Error">When receiving a 429 status code</exception>
        /// <exception cref="global::InfinityFlow.DigitalOcean.Client.Models.Error">When receiving a 500 status code</exception>
        /// <exception cref="global::InfinityFlow.DigitalOcean.Client.Models.Error">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
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
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// To show information about an existing database cluster, send a GET request to `/v2/databases/$DATABASE_ID`.The response will be a JSON object with a database key. This will be set to an object containing the standard database cluster attributes.The embedded `connection` and `private_connection` objects will contain the information needed to access the database cluster. For multi-node clusters, the `standby_connection` and `standby_private_connection` objects contain the information needed to connect to the cluster&apos;s standby node(s).The embedded maintenance_window object will contain information about any scheduled maintenance for the database cluster.
        /// </summary>
        /// <returns>A <see cref="global::InfinityFlow.DigitalOcean.Client.V2.Databases.Item.WithDatabase_cluster_uuGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::InfinityFlow.DigitalOcean.Client.Models.Error">When receiving a 401 status code</exception>
        /// <exception cref="global::InfinityFlow.DigitalOcean.Client.Models.Error">When receiving a 404 status code</exception>
        /// <exception cref="global::InfinityFlow.DigitalOcean.Client.Models.Error">When receiving a 429 status code</exception>
        /// <exception cref="global::InfinityFlow.DigitalOcean.Client.Models.Error">When receiving a 500 status code</exception>
        /// <exception cref="global::InfinityFlow.DigitalOcean.Client.Models.Error">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::InfinityFlow.DigitalOcean.Client.V2.Databases.Item.WithDatabase_cluster_uuGetResponse?> GetAsWithDatabase_cluster_uuGetResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::InfinityFlow.DigitalOcean.Client.V2.Databases.Item.WithDatabase_cluster_uuGetResponse> GetAsWithDatabase_cluster_uuGetResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
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
            return await RequestAdapter.SendAsync<global::InfinityFlow.DigitalOcean.Client.V2.Databases.Item.WithDatabase_cluster_uuGetResponse>(requestInfo, global::InfinityFlow.DigitalOcean.Client.V2.Databases.Item.WithDatabase_cluster_uuGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// To show information about an existing database cluster, send a GET request to `/v2/databases/$DATABASE_ID`.The response will be a JSON object with a database key. This will be set to an object containing the standard database cluster attributes.The embedded `connection` and `private_connection` objects will contain the information needed to access the database cluster. For multi-node clusters, the `standby_connection` and `standby_private_connection` objects contain the information needed to connect to the cluster&apos;s standby node(s).The embedded maintenance_window object will contain information about any scheduled maintenance for the database cluster.
        /// </summary>
        /// <returns>A <see cref="global::InfinityFlow.DigitalOcean.Client.V2.Databases.Item.WithDatabase_cluster_uuResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::InfinityFlow.DigitalOcean.Client.Models.Error">When receiving a 401 status code</exception>
        /// <exception cref="global::InfinityFlow.DigitalOcean.Client.Models.Error">When receiving a 404 status code</exception>
        /// <exception cref="global::InfinityFlow.DigitalOcean.Client.Models.Error">When receiving a 429 status code</exception>
        /// <exception cref="global::InfinityFlow.DigitalOcean.Client.Models.Error">When receiving a 500 status code</exception>
        /// <exception cref="global::InfinityFlow.DigitalOcean.Client.Models.Error">When receiving a 4XX or 5XX status code</exception>
        [Obsolete("This method is obsolete. Use GetAsWithDatabase_cluster_uuGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::InfinityFlow.DigitalOcean.Client.V2.Databases.Item.WithDatabase_cluster_uuResponse?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::InfinityFlow.DigitalOcean.Client.V2.Databases.Item.WithDatabase_cluster_uuResponse> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
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
            return await RequestAdapter.SendAsync<global::InfinityFlow.DigitalOcean.Client.V2.Databases.Item.WithDatabase_cluster_uuResponse>(requestInfo, global::InfinityFlow.DigitalOcean.Client.V2.Databases.Item.WithDatabase_cluster_uuResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// To destroy a specific database, send a DELETE request to `/v2/databases/$DATABASE_ID`.A status of 204 will be given. This indicates that the request was processed successfully, but that no response body is needed.
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
        /// To show information about an existing database cluster, send a GET request to `/v2/databases/$DATABASE_ID`.The response will be a JSON object with a database key. This will be set to an object containing the standard database cluster attributes.The embedded `connection` and `private_connection` objects will contain the information needed to access the database cluster. For multi-node clusters, the `standby_connection` and `standby_private_connection` objects contain the information needed to connect to the cluster&apos;s standby node(s).The embedded maintenance_window object will contain information about any scheduled maintenance for the database cluster.
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
        /// <returns>A <see cref="global::InfinityFlow.DigitalOcean.Client.V2.Databases.Item.WithDatabase_cluster_uuItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::InfinityFlow.DigitalOcean.Client.V2.Databases.Item.WithDatabase_cluster_uuItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::InfinityFlow.DigitalOcean.Client.V2.Databases.Item.WithDatabase_cluster_uuItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class WithDatabase_cluster_uuItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class WithDatabase_cluster_uuItemRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
