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
    public partial class Alert_updatable : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The comparison operator used against the alert&apos;s threshold.</summary>
        public global::InfinityFlow.DigitalOcean.Client.Models.Alert_updatable_comparison? Comparison { get; set; }
        /// <summary>A human-friendly display name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The notification settings for a trigger alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::InfinityFlow.DigitalOcean.Client.Models.Notification? Notifications { get; set; }
#nullable restore
#else
        public global::InfinityFlow.DigitalOcean.Client.Models.Notification Notifications { get; set; }
#endif
        /// <summary>Period of time the threshold must be exceeded to trigger the alert.</summary>
        public global::InfinityFlow.DigitalOcean.Client.Models.Alert_updatable_period? Period { get; set; }
        /// <summary>The threshold at which the alert will enter a trigger state. The specific threshold is dependent on the alert type.</summary>
        public int? Threshold { get; set; }
        /// <summary>The type of alert.</summary>
        public global::InfinityFlow.DigitalOcean.Client.Models.Alert_updatable_type? Type { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::InfinityFlow.DigitalOcean.Client.Models.Alert_updatable"/> and sets the default values.
        /// </summary>
        public Alert_updatable()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::InfinityFlow.DigitalOcean.Client.Models.Alert_updatable"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::InfinityFlow.DigitalOcean.Client.Models.Alert_updatable CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::InfinityFlow.DigitalOcean.Client.Models.Alert_updatable();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "comparison", n => { Comparison = n.GetEnumValue<global::InfinityFlow.DigitalOcean.Client.Models.Alert_updatable_comparison>(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "notifications", n => { Notifications = n.GetObjectValue<global::InfinityFlow.DigitalOcean.Client.Models.Notification>(global::InfinityFlow.DigitalOcean.Client.Models.Notification.CreateFromDiscriminatorValue); } },
                { "period", n => { Period = n.GetEnumValue<global::InfinityFlow.DigitalOcean.Client.Models.Alert_updatable_period>(); } },
                { "threshold", n => { Threshold = n.GetIntValue(); } },
                { "type", n => { Type = n.GetEnumValue<global::InfinityFlow.DigitalOcean.Client.Models.Alert_updatable_type>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::InfinityFlow.DigitalOcean.Client.Models.Alert_updatable_comparison>("comparison", Comparison);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<global::InfinityFlow.DigitalOcean.Client.Models.Notification>("notifications", Notifications);
            writer.WriteEnumValue<global::InfinityFlow.DigitalOcean.Client.Models.Alert_updatable_period>("period", Period);
            writer.WriteIntValue("threshold", Threshold);
            writer.WriteEnumValue<global::InfinityFlow.DigitalOcean.Client.Models.Alert_updatable_type>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
