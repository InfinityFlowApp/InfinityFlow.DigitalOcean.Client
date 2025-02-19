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
    public partial class Droplet_next_backup_window : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A time value given in ISO8601 combined date and time format specifying the end of the Droplet&apos;s backup window.</summary>
        public DateTimeOffset? End { get; set; }
        /// <summary>A time value given in ISO8601 combined date and time format specifying the start of the Droplet&apos;s backup window.</summary>
        public DateTimeOffset? Start { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::InfinityFlow.DigitalOcean.Client.Models.Droplet_next_backup_window"/> and sets the default values.
        /// </summary>
        public Droplet_next_backup_window()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::InfinityFlow.DigitalOcean.Client.Models.Droplet_next_backup_window"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::InfinityFlow.DigitalOcean.Client.Models.Droplet_next_backup_window CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::InfinityFlow.DigitalOcean.Client.Models.Droplet_next_backup_window();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "end", n => { End = n.GetDateTimeOffsetValue(); } },
                { "start", n => { Start = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("end", End);
            writer.WriteDateTimeOffsetValue("start", Start);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
