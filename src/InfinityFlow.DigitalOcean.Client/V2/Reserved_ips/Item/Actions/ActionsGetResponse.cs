// <auto-generated/>
#pragma warning disable CS0618
using InfinityFlow.DigitalOcean.Client.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace InfinityFlow.DigitalOcean.Client.V2.Reserved_ips.Item.Actions
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class ActionsGetResponse : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The actions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::InfinityFlow.DigitalOcean.Client.Models.ActionObject>? Actions { get; set; }
#nullable restore
#else
        public List<global::InfinityFlow.DigitalOcean.Client.Models.ActionObject> Actions { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The links property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::InfinityFlow.DigitalOcean.Client.Models.Page_links? Links { get; set; }
#nullable restore
#else
        public global::InfinityFlow.DigitalOcean.Client.Models.Page_links Links { get; set; }
#endif
        /// <summary>The meta property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::InfinityFlow.DigitalOcean.Client.Models.Meta_properties? Meta { get; set; }
#nullable restore
#else
        public global::InfinityFlow.DigitalOcean.Client.Models.Meta_properties Meta { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::InfinityFlow.DigitalOcean.Client.V2.Reserved_ips.Item.Actions.ActionsGetResponse"/> and sets the default values.
        /// </summary>
        public ActionsGetResponse()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::InfinityFlow.DigitalOcean.Client.V2.Reserved_ips.Item.Actions.ActionsGetResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::InfinityFlow.DigitalOcean.Client.V2.Reserved_ips.Item.Actions.ActionsGetResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::InfinityFlow.DigitalOcean.Client.V2.Reserved_ips.Item.Actions.ActionsGetResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "actions", n => { Actions = n.GetCollectionOfObjectValues<global::InfinityFlow.DigitalOcean.Client.Models.ActionObject>(global::InfinityFlow.DigitalOcean.Client.Models.ActionObject.CreateFromDiscriminatorValue)?.AsList(); } },
                { "links", n => { Links = n.GetObjectValue<global::InfinityFlow.DigitalOcean.Client.Models.Page_links>(global::InfinityFlow.DigitalOcean.Client.Models.Page_links.CreateFromDiscriminatorValue); } },
                { "meta", n => { Meta = n.GetObjectValue<global::InfinityFlow.DigitalOcean.Client.Models.Meta_properties>(global::InfinityFlow.DigitalOcean.Client.Models.Meta_properties.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::InfinityFlow.DigitalOcean.Client.Models.ActionObject>("actions", Actions);
            writer.WriteObjectValue<global::InfinityFlow.DigitalOcean.Client.Models.Page_links>("links", Links);
            writer.WriteObjectValue<global::InfinityFlow.DigitalOcean.Client.Models.Meta_properties>("meta", Meta);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
