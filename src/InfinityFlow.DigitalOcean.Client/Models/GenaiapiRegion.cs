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
    /// Description for a specific Region
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class GenaiapiRegion : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Url for inference server</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InferenceUrl { get; set; }
#nullable restore
#else
        public string InferenceUrl { get; set; }
#endif
        /// <summary>Region code</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Region { get; set; }
#nullable restore
#else
        public string Region { get; set; }
#endif
        /// <summary>This datacenter is capable of running batch jobs</summary>
        public bool? ServesBatch { get; set; }
        /// <summary>This datacenter is capable of serving inference</summary>
        public bool? ServesInference { get; set; }
        /// <summary>The url for the inference streaming server</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StreamInferenceUrl { get; set; }
#nullable restore
#else
        public string StreamInferenceUrl { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::InfinityFlow.DigitalOcean.Client.Models.GenaiapiRegion"/> and sets the default values.
        /// </summary>
        public GenaiapiRegion()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::InfinityFlow.DigitalOcean.Client.Models.GenaiapiRegion"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::InfinityFlow.DigitalOcean.Client.Models.GenaiapiRegion CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::InfinityFlow.DigitalOcean.Client.Models.GenaiapiRegion();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "inference_url", n => { InferenceUrl = n.GetStringValue(); } },
                { "region", n => { Region = n.GetStringValue(); } },
                { "serves_batch", n => { ServesBatch = n.GetBoolValue(); } },
                { "serves_inference", n => { ServesInference = n.GetBoolValue(); } },
                { "stream_inference_url", n => { StreamInferenceUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("inference_url", InferenceUrl);
            writer.WriteStringValue("region", Region);
            writer.WriteBoolValue("serves_batch", ServesBatch);
            writer.WriteBoolValue("serves_inference", ServesInference);
            writer.WriteStringValue("stream_inference_url", StreamInferenceUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
