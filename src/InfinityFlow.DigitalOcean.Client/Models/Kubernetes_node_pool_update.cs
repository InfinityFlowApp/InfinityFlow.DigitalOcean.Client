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
    public partial class Kubernetes_node_pool_update : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A boolean value indicating whether auto-scaling is enabled for this node pool.</summary>
        public bool? AutoScale { get; set; }
        /// <summary>The number of Droplet instances in the node pool.</summary>
        public int? Count { get; set; }
        /// <summary>A unique ID that can be used to identify and reference a specific node pool.</summary>
        public Guid? Id { get; private set; }
        /// <summary>An object of key/value mappings specifying labels to apply to all nodes in a pool. Labels will automatically be applied to all existing nodes and any subsequent nodes added to the pool. Note that when a label is removed, it is not deleted from the nodes in the pool.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::InfinityFlow.DigitalOcean.Client.Models.Kubernetes_node_pool_update_labels? Labels { get; set; }
#nullable restore
#else
        public global::InfinityFlow.DigitalOcean.Client.Models.Kubernetes_node_pool_update_labels Labels { get; set; }
#endif
        /// <summary>The maximum number of nodes that this node pool can be auto-scaled to. The value will be `0` if `auto_scale` is set to `false`.</summary>
        public int? MaxNodes { get; set; }
        /// <summary>The minimum number of nodes that this node pool can be auto-scaled to. The value will be `0` if `auto_scale` is set to `false`.</summary>
        public int? MinNodes { get; set; }
        /// <summary>A human-readable name for the node pool.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>An object specifying the details of a specific worker node in a node pool.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::InfinityFlow.DigitalOcean.Client.Models.Node>? Nodes { get; private set; }
#nullable restore
#else
        public List<global::InfinityFlow.DigitalOcean.Client.Models.Node> Nodes { get; private set; }
#endif
        /// <summary>An array containing the tags applied to the node pool. All node pools are automatically tagged `k8s`, `k8s-worker`, and `k8s:$K8S_CLUSTER_ID`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Tags { get; set; }
#nullable restore
#else
        public List<string> Tags { get; set; }
#endif
        /// <summary>An array of taints to apply to all nodes in a pool. Taints will automatically be applied to all existing nodes and any subsequent nodes added to the pool. When a taint is removed, it is deleted from all nodes in the pool.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::InfinityFlow.DigitalOcean.Client.Models.Kubernetes_node_pool_taint>? Taints { get; set; }
#nullable restore
#else
        public List<global::InfinityFlow.DigitalOcean.Client.Models.Kubernetes_node_pool_taint> Taints { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::InfinityFlow.DigitalOcean.Client.Models.Kubernetes_node_pool_update"/> and sets the default values.
        /// </summary>
        public Kubernetes_node_pool_update()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::InfinityFlow.DigitalOcean.Client.Models.Kubernetes_node_pool_update"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::InfinityFlow.DigitalOcean.Client.Models.Kubernetes_node_pool_update CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::InfinityFlow.DigitalOcean.Client.Models.Kubernetes_node_pool_update();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "auto_scale", n => { AutoScale = n.GetBoolValue(); } },
                { "count", n => { Count = n.GetIntValue(); } },
                { "id", n => { Id = n.GetGuidValue(); } },
                { "labels", n => { Labels = n.GetObjectValue<global::InfinityFlow.DigitalOcean.Client.Models.Kubernetes_node_pool_update_labels>(global::InfinityFlow.DigitalOcean.Client.Models.Kubernetes_node_pool_update_labels.CreateFromDiscriminatorValue); } },
                { "max_nodes", n => { MaxNodes = n.GetIntValue(); } },
                { "min_nodes", n => { MinNodes = n.GetIntValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "nodes", n => { Nodes = n.GetCollectionOfObjectValues<global::InfinityFlow.DigitalOcean.Client.Models.Node>(global::InfinityFlow.DigitalOcean.Client.Models.Node.CreateFromDiscriminatorValue)?.AsList(); } },
                { "tags", n => { Tags = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "taints", n => { Taints = n.GetCollectionOfObjectValues<global::InfinityFlow.DigitalOcean.Client.Models.Kubernetes_node_pool_taint>(global::InfinityFlow.DigitalOcean.Client.Models.Kubernetes_node_pool_taint.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("auto_scale", AutoScale);
            writer.WriteIntValue("count", Count);
            writer.WriteObjectValue<global::InfinityFlow.DigitalOcean.Client.Models.Kubernetes_node_pool_update_labels>("labels", Labels);
            writer.WriteIntValue("max_nodes", MaxNodes);
            writer.WriteIntValue("min_nodes", MinNodes);
            writer.WriteStringValue("name", Name);
            writer.WriteCollectionOfPrimitiveValues<string>("tags", Tags);
            writer.WriteCollectionOfObjectValues<global::InfinityFlow.DigitalOcean.Client.Models.Kubernetes_node_pool_taint>("taints", Taints);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
