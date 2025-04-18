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
    /// Information about updating an agent function
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ApiUpdateAgentFunctionInputPublic : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Agent id</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AgentUuid { get; set; }
#nullable restore
#else
        public string AgentUuid { get; set; }
#endif
        /// <summary>Funciton description</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The name of the function in the DigitalOcean functions platform</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FaasName { get; set; }
#nullable restore
#else
        public string FaasName { get; set; }
#endif
        /// <summary>The namespace of the function in the DigitalOcean functions platform</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FaasNamespace { get; set; }
#nullable restore
#else
        public string FaasNamespace { get; set; }
#endif
        /// <summary>Function name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FunctionName { get; set; }
#nullable restore
#else
        public string FunctionName { get; set; }
#endif
        /// <summary>Function id</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FunctionUuid { get; set; }
#nullable restore
#else
        public string FunctionUuid { get; set; }
#endif
        /// <summary>Describe the input schema for the function so the agent may call it</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::InfinityFlow.DigitalOcean.Client.Models.ApiUpdateAgentFunctionInputPublic_input_schema? InputSchema { get; set; }
#nullable restore
#else
        public global::InfinityFlow.DigitalOcean.Client.Models.ApiUpdateAgentFunctionInputPublic_input_schema InputSchema { get; set; }
#endif
        /// <summary>Describe the output schema for the function so the agent handle its response</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::InfinityFlow.DigitalOcean.Client.Models.ApiUpdateAgentFunctionInputPublic_output_schema? OutputSchema { get; set; }
#nullable restore
#else
        public global::InfinityFlow.DigitalOcean.Client.Models.ApiUpdateAgentFunctionInputPublic_output_schema OutputSchema { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::InfinityFlow.DigitalOcean.Client.Models.ApiUpdateAgentFunctionInputPublic"/> and sets the default values.
        /// </summary>
        public ApiUpdateAgentFunctionInputPublic()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::InfinityFlow.DigitalOcean.Client.Models.ApiUpdateAgentFunctionInputPublic"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::InfinityFlow.DigitalOcean.Client.Models.ApiUpdateAgentFunctionInputPublic CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::InfinityFlow.DigitalOcean.Client.Models.ApiUpdateAgentFunctionInputPublic();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "agent_uuid", n => { AgentUuid = n.GetStringValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "faas_name", n => { FaasName = n.GetStringValue(); } },
                { "faas_namespace", n => { FaasNamespace = n.GetStringValue(); } },
                { "function_name", n => { FunctionName = n.GetStringValue(); } },
                { "function_uuid", n => { FunctionUuid = n.GetStringValue(); } },
                { "input_schema", n => { InputSchema = n.GetObjectValue<global::InfinityFlow.DigitalOcean.Client.Models.ApiUpdateAgentFunctionInputPublic_input_schema>(global::InfinityFlow.DigitalOcean.Client.Models.ApiUpdateAgentFunctionInputPublic_input_schema.CreateFromDiscriminatorValue); } },
                { "output_schema", n => { OutputSchema = n.GetObjectValue<global::InfinityFlow.DigitalOcean.Client.Models.ApiUpdateAgentFunctionInputPublic_output_schema>(global::InfinityFlow.DigitalOcean.Client.Models.ApiUpdateAgentFunctionInputPublic_output_schema.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("agent_uuid", AgentUuid);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("faas_name", FaasName);
            writer.WriteStringValue("faas_namespace", FaasNamespace);
            writer.WriteStringValue("function_name", FunctionName);
            writer.WriteStringValue("function_uuid", FunctionUuid);
            writer.WriteObjectValue<global::InfinityFlow.DigitalOcean.Client.Models.ApiUpdateAgentFunctionInputPublic_input_schema>("input_schema", InputSchema);
            writer.WriteObjectValue<global::InfinityFlow.DigitalOcean.Client.Models.ApiUpdateAgentFunctionInputPublic_output_schema>("output_schema", OutputSchema);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
