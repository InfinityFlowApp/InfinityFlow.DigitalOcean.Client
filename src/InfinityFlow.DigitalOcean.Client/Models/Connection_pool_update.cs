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
    public partial class Connection_pool_update : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The database for use with the connection pool.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Db { get; set; }
#nullable restore
#else
        public string Db { get; set; }
#endif
        /// <summary>The PGBouncer transaction mode for the connection pool. The allowed values are session, transaction, and statement.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Mode { get; set; }
#nullable restore
#else
        public string Mode { get; set; }
#endif
        /// <summary>The desired size of the PGBouncer connection pool. The maximum allowed size is determined by the size of the cluster&apos;s primary node. 25 backend server connections are allowed for every 1GB of RAM. Three are reserved for maintenance. For example, a primary node with 1 GB of RAM allows for a maximum of 22 backend server connections while one with 4 GB would allow for 97. Note that these are shared across all connection pools in a cluster.</summary>
        public int? Size { get; set; }
        /// <summary>The name of the user for use with the connection pool. When excluded, all sessions connect to the database as the inbound user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? User { get; set; }
#nullable restore
#else
        public string User { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::InfinityFlow.DigitalOcean.Client.Models.Connection_pool_update"/> and sets the default values.
        /// </summary>
        public Connection_pool_update()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::InfinityFlow.DigitalOcean.Client.Models.Connection_pool_update"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::InfinityFlow.DigitalOcean.Client.Models.Connection_pool_update CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::InfinityFlow.DigitalOcean.Client.Models.Connection_pool_update();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "db", n => { Db = n.GetStringValue(); } },
                { "mode", n => { Mode = n.GetStringValue(); } },
                { "size", n => { Size = n.GetIntValue(); } },
                { "user", n => { User = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("db", Db);
            writer.WriteStringValue("mode", Mode);
            writer.WriteIntValue("size", Size);
            writer.WriteStringValue("user", User);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
