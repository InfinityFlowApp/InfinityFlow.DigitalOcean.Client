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
    public partial class Droplet_snapshot : global::InfinityFlow.DigitalOcean.Client.Models.Snapshots_base, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The unique identifier for the snapshot or backup.</summary>
        public int? Id { get; set; }
        /// <summary>Describes the kind of image. It may be one of `snapshot` or `backup`. This specifies whether an image is a user-generated Droplet snapshot or automatically created Droplet backup.</summary>
        public global::InfinityFlow.DigitalOcean.Client.Models.Droplet_snapshot_type? Type { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::InfinityFlow.DigitalOcean.Client.Models.Droplet_snapshot"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::InfinityFlow.DigitalOcean.Client.Models.Droplet_snapshot CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::InfinityFlow.DigitalOcean.Client.Models.Droplet_snapshot();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "id", n => { Id = n.GetIntValue(); } },
                { "type", n => { Type = n.GetEnumValue<global::InfinityFlow.DigitalOcean.Client.Models.Droplet_snapshot_type>(); } },
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
            writer.WriteIntValue("id", Id);
            writer.WriteEnumValue<global::InfinityFlow.DigitalOcean.Client.Models.Droplet_snapshot_type>("type", Type);
        }
    }
}
#pragma warning restore CS0618
