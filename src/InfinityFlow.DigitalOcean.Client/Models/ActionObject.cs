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
    public partial class ActionObject : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A time value given in ISO8601 combined date and time format that represents when the action was completed.</summary>
        public DateTimeOffset? CompletedAt { get; set; }
        /// <summary>A unique numeric ID that can be used to identify and reference an action.</summary>
        public int? Id { get; set; }
        /// <summary>The region property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::InfinityFlow.DigitalOcean.Client.Models.Region? Region { get; set; }
#nullable restore
#else
        public global::InfinityFlow.DigitalOcean.Client.Models.Region Region { get; set; }
#endif
        /// <summary>A human-readable string that is used as a unique identifier for each region.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RegionSlug { get; set; }
#nullable restore
#else
        public string RegionSlug { get; set; }
#endif
        /// <summary>A unique identifier for the resource that the action is associated with.</summary>
        public int? ResourceId { get; set; }
        /// <summary>The type of resource that the action is associated with.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResourceType { get; set; }
#nullable restore
#else
        public string ResourceType { get; set; }
#endif
        /// <summary>A time value given in ISO8601 combined date and time format that represents when the action was initiated.</summary>
        public DateTimeOffset? StartedAt { get; set; }
        /// <summary>The current status of the action. This can be &quot;in-progress&quot;, &quot;completed&quot;, or &quot;errored&quot;.</summary>
        public global::InfinityFlow.DigitalOcean.Client.Models.Action_status? Status { get; set; }
        /// <summary>This is the type of action that the object represents. For example, this could be &quot;transfer&quot; to represent the state of an image transfer action.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type { get; set; }
#nullable restore
#else
        public string Type { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::InfinityFlow.DigitalOcean.Client.Models.ActionObject"/> and sets the default values.
        /// </summary>
        public ActionObject()
        {
            AdditionalData = new Dictionary<string, object>();
            Status = global::InfinityFlow.DigitalOcean.Client.Models.Action_status.InProgress;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::InfinityFlow.DigitalOcean.Client.Models.ActionObject"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::InfinityFlow.DigitalOcean.Client.Models.ActionObject CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::InfinityFlow.DigitalOcean.Client.Models.ActionObject();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "completed_at", n => { CompletedAt = n.GetDateTimeOffsetValue(); } },
                { "id", n => { Id = n.GetIntValue(); } },
                { "region", n => { Region = n.GetObjectValue<global::InfinityFlow.DigitalOcean.Client.Models.Region>(global::InfinityFlow.DigitalOcean.Client.Models.Region.CreateFromDiscriminatorValue); } },
                { "region_slug", n => { RegionSlug = n.GetStringValue(); } },
                { "resource_id", n => { ResourceId = n.GetIntValue(); } },
                { "resource_type", n => { ResourceType = n.GetStringValue(); } },
                { "started_at", n => { StartedAt = n.GetDateTimeOffsetValue(); } },
                { "status", n => { Status = n.GetEnumValue<global::InfinityFlow.DigitalOcean.Client.Models.Action_status>(); } },
                { "type", n => { Type = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("completed_at", CompletedAt);
            writer.WriteIntValue("id", Id);
            writer.WriteObjectValue<global::InfinityFlow.DigitalOcean.Client.Models.Region>("region", Region);
            writer.WriteStringValue("region_slug", RegionSlug);
            writer.WriteIntValue("resource_id", ResourceId);
            writer.WriteStringValue("resource_type", ResourceType);
            writer.WriteDateTimeOffsetValue("started_at", StartedAt);
            writer.WriteEnumValue<global::InfinityFlow.DigitalOcean.Client.Models.Action_status>("status", Status);
            writer.WriteStringValue("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
