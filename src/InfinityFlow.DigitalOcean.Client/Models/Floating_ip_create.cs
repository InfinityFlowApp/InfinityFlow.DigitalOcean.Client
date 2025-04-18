// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace InfinityFlow.DigitalOcean.Client.Models
{
    /// <summary>
    /// Composed type wrapper for classes <see cref="global::InfinityFlow.DigitalOcean.Client.Models.Floating_ip_createMember1"/>, <see cref="global::InfinityFlow.DigitalOcean.Client.Models.Floating_ip_createMember2"/>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Floating_ip_create : IComposedTypeWrapper, IParsable
    {
        /// <summary>Composed type representation for type <see cref="global::InfinityFlow.DigitalOcean.Client.Models.Floating_ip_createMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::InfinityFlow.DigitalOcean.Client.Models.Floating_ip_createMember1? FloatingIpCreateMember1 { get; set; }
#nullable restore
#else
        public global::InfinityFlow.DigitalOcean.Client.Models.Floating_ip_createMember1 FloatingIpCreateMember1 { get; set; }
#endif
        /// <summary>Composed type representation for type <see cref="global::InfinityFlow.DigitalOcean.Client.Models.Floating_ip_createMember2"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::InfinityFlow.DigitalOcean.Client.Models.Floating_ip_createMember2? FloatingIpCreateMember2 { get; set; }
#nullable restore
#else
        public global::InfinityFlow.DigitalOcean.Client.Models.Floating_ip_createMember2 FloatingIpCreateMember2 { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::InfinityFlow.DigitalOcean.Client.Models.Floating_ip_create"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::InfinityFlow.DigitalOcean.Client.Models.Floating_ip_create CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
            var result = new global::InfinityFlow.DigitalOcean.Client.Models.Floating_ip_create();
            if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
            {
                result.FloatingIpCreateMember1 = new global::InfinityFlow.DigitalOcean.Client.Models.Floating_ip_createMember1();
            }
            else if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
            {
                result.FloatingIpCreateMember2 = new global::InfinityFlow.DigitalOcean.Client.Models.Floating_ip_createMember2();
            }
            return result;
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            if(FloatingIpCreateMember1 != null)
            {
                return FloatingIpCreateMember1.GetFieldDeserializers();
            }
            else if(FloatingIpCreateMember2 != null)
            {
                return FloatingIpCreateMember2.GetFieldDeserializers();
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
            if(FloatingIpCreateMember1 != null)
            {
                writer.WriteObjectValue<global::InfinityFlow.DigitalOcean.Client.Models.Floating_ip_createMember1>(null, FloatingIpCreateMember1);
            }
            else if(FloatingIpCreateMember2 != null)
            {
                writer.WriteObjectValue<global::InfinityFlow.DigitalOcean.Client.Models.Floating_ip_createMember2>(null, FloatingIpCreateMember2);
            }
        }
    }
}
#pragma warning restore CS0618
