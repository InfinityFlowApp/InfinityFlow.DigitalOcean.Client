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
    public partial class Volume_base : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A time value given in ISO8601 combined date and time format that represents when the block storage volume was created.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedAt { get; private set; }
#nullable restore
#else
        public string CreatedAt { get; private set; }
#endif
        /// <summary>An optional free-form text field to describe a block storage volume.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>An array containing the IDs of the Droplets the volume is attached to. Note that at this time, a volume can only be attached to a single Droplet.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<int?>? DropletIds { get; private set; }
#nullable restore
#else
        public List<int?> DropletIds { get; private set; }
#endif
        /// <summary>The unique identifier for the block storage volume.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; private set; }
#nullable restore
#else
        public string Id { get; private set; }
#endif
        /// <summary>A human-readable name for the block storage volume. Must be lowercase and be composed only of numbers, letters and &quot;-&quot;, up to a limit of 64 characters. The name must begin with a letter.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The size of the block storage volume in GiB (1024^3). This field does not apply  when creating a volume from a snapshot.</summary>
        public int? SizeGigabytes { get; set; }
        /// <summary>A flat array of tag names as strings to be applied to the resource. Tag names may be for either existing or new tags.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Tags { get; set; }
#nullable restore
#else
        public List<string> Tags { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::InfinityFlow.DigitalOcean.Client.Models.Volume_base"/> and sets the default values.
        /// </summary>
        public Volume_base()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::InfinityFlow.DigitalOcean.Client.Models.Volume_base"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::InfinityFlow.DigitalOcean.Client.Models.Volume_base CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::InfinityFlow.DigitalOcean.Client.Models.Volume_base();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "created_at", n => { CreatedAt = n.GetStringValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "droplet_ids", n => { DropletIds = n.GetCollectionOfPrimitiveValues<int?>()?.AsList(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "size_gigabytes", n => { SizeGigabytes = n.GetIntValue(); } },
                { "tags", n => { Tags = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("name", Name);
            writer.WriteIntValue("size_gigabytes", SizeGigabytes);
            writer.WriteCollectionOfPrimitiveValues<string>("tags", Tags);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
