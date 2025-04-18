// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace InfinityFlow.DigitalOcean.Client.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class Logsink_verbose : global::InfinityFlow.DigitalOcean.Client.Models.Logsink_base_verbose, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The config property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::InfinityFlow.DigitalOcean.Client.Models.Logsink_verbose.Logsink_verbose_config? Config { get; set; }
#nullable restore
#else
        public global::InfinityFlow.DigitalOcean.Client.Models.Logsink_verbose.Logsink_verbose_config Config { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::InfinityFlow.DigitalOcean.Client.Models.Logsink_verbose"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::InfinityFlow.DigitalOcean.Client.Models.Logsink_verbose CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::InfinityFlow.DigitalOcean.Client.Models.Logsink_verbose();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "config", n => { Config = n.GetObjectValue<global::InfinityFlow.DigitalOcean.Client.Models.Logsink_verbose.Logsink_verbose_config>(global::InfinityFlow.DigitalOcean.Client.Models.Logsink_verbose.Logsink_verbose_config.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<global::InfinityFlow.DigitalOcean.Client.Models.Logsink_verbose.Logsink_verbose_config>("config", Config);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::InfinityFlow.DigitalOcean.Client.Models.Elasticsearch_logsink"/>, <see cref="global::InfinityFlow.DigitalOcean.Client.Models.Opensearch_logsink"/>, <see cref="global::InfinityFlow.DigitalOcean.Client.Models.Rsyslog_logsink"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Logsink_verbose_config : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::InfinityFlow.DigitalOcean.Client.Models.Elasticsearch_logsink"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::InfinityFlow.DigitalOcean.Client.Models.Elasticsearch_logsink? ElasticsearchLogsink { get; set; }
#nullable restore
#else
            public global::InfinityFlow.DigitalOcean.Client.Models.Elasticsearch_logsink ElasticsearchLogsink { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::InfinityFlow.DigitalOcean.Client.Models.Opensearch_logsink"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::InfinityFlow.DigitalOcean.Client.Models.Opensearch_logsink? OpensearchLogsink { get; set; }
#nullable restore
#else
            public global::InfinityFlow.DigitalOcean.Client.Models.Opensearch_logsink OpensearchLogsink { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::InfinityFlow.DigitalOcean.Client.Models.Rsyslog_logsink"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::InfinityFlow.DigitalOcean.Client.Models.Rsyslog_logsink? RsyslogLogsink { get; set; }
#nullable restore
#else
            public global::InfinityFlow.DigitalOcean.Client.Models.Rsyslog_logsink RsyslogLogsink { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::InfinityFlow.DigitalOcean.Client.Models.Logsink_verbose.Logsink_verbose_config"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::InfinityFlow.DigitalOcean.Client.Models.Logsink_verbose.Logsink_verbose_config CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var result = new global::InfinityFlow.DigitalOcean.Client.Models.Logsink_verbose.Logsink_verbose_config();
                result.ElasticsearchLogsink = new global::InfinityFlow.DigitalOcean.Client.Models.Elasticsearch_logsink();
                result.OpensearchLogsink = new global::InfinityFlow.DigitalOcean.Client.Models.Opensearch_logsink();
                result.RsyslogLogsink = new global::InfinityFlow.DigitalOcean.Client.Models.Rsyslog_logsink();
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(ElasticsearchLogsink != null || OpensearchLogsink != null || RsyslogLogsink != null)
                {
                    return ParseNodeHelper.MergeDeserializersForIntersectionWrapper(ElasticsearchLogsink, OpensearchLogsink, RsyslogLogsink);
                }
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public virtual void Serialize(ISerializationWriter writer)
            {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                writer.WriteObjectValue<global::InfinityFlow.DigitalOcean.Client.Models.Elasticsearch_logsink>(null, ElasticsearchLogsink, OpensearchLogsink, RsyslogLogsink);
            }
        }
    }
}
#pragma warning restore CS0618
