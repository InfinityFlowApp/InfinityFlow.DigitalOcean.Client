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
    public partial class Firewall : global::InfinityFlow.DigitalOcean.Client.Models.Firewall_rules, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>A time value given in ISO8601 combined date and time format that represents when the firewall was created.</summary>
        public DateTimeOffset? CreatedAt { get; private set; }
        /// <summary>An array containing the IDs of the Droplets assigned to the firewall.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<int?>? DropletIds { get; set; }
#nullable restore
#else
        public List<int?> DropletIds { get; set; }
#endif
        /// <summary>A unique ID that can be used to identify and reference a firewall.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; private set; }
#nullable restore
#else
        public string Id { get; private set; }
#endif
        /// <summary>A human-readable name for a firewall. The name must begin with an alphanumeric character. Subsequent characters must either be alphanumeric characters, a period (.), or a dash (-).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>An array of objects each containing the fields &quot;droplet_id&quot;, &quot;removing&quot;, and &quot;status&quot;. It is provided to detail exactly which Droplets are having their security policies updated. When empty, all changes have been successfully applied.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::InfinityFlow.DigitalOcean.Client.Models.Firewall_pending_changes>? PendingChanges { get; private set; }
#nullable restore
#else
        public List<global::InfinityFlow.DigitalOcean.Client.Models.Firewall_pending_changes> PendingChanges { get; private set; }
#endif
        /// <summary>A status string indicating the current state of the firewall. This can be &quot;waiting&quot;, &quot;succeeded&quot;, or &quot;failed&quot;.</summary>
        public global::InfinityFlow.DigitalOcean.Client.Models.Firewall_status? Status { get; private set; }
        /// <summary>The tags property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Tags { get; set; }
#nullable restore
#else
        public List<string> Tags { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::InfinityFlow.DigitalOcean.Client.Models.Firewall"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::InfinityFlow.DigitalOcean.Client.Models.Firewall CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::InfinityFlow.DigitalOcean.Client.Models.Firewall();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "droplet_ids", n => { DropletIds = n.GetCollectionOfPrimitiveValues<int?>()?.AsList(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "pending_changes", n => { PendingChanges = n.GetCollectionOfObjectValues<global::InfinityFlow.DigitalOcean.Client.Models.Firewall_pending_changes>(global::InfinityFlow.DigitalOcean.Client.Models.Firewall_pending_changes.CreateFromDiscriminatorValue)?.AsList(); } },
                { "status", n => { Status = n.GetEnumValue<global::InfinityFlow.DigitalOcean.Client.Models.Firewall_status>(); } },
                { "tags", n => { Tags = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
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
            writer.WriteCollectionOfPrimitiveValues<int?>("droplet_ids", DropletIds);
            writer.WriteStringValue("name", Name);
            writer.WriteCollectionOfPrimitiveValues<string>("tags", Tags);
        }
    }
}
#pragma warning restore CS0618
