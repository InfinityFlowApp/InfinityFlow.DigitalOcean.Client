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
    public partial class Account : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The total number of Droplets current user or team may have active at one time.</summary>
        public int? DropletLimit { get; set; }
        /// <summary>The email address used by the current user to register for DigitalOcean.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Email { get; set; }
#nullable restore
#else
        public string Email { get; set; }
#endif
        /// <summary>If true, the user has verified their account via email. False otherwise.</summary>
        public bool? EmailVerified { get; set; }
        /// <summary>The total number of Floating IPs the current user or team may have.</summary>
        public int? FloatingIpLimit { get; set; }
        /// <summary>The display name for the current user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>This value is one of &quot;active&quot;, &quot;warning&quot; or &quot;locked&quot;.</summary>
        public global::InfinityFlow.DigitalOcean.Client.Models.Account_status? Status { get; set; }
        /// <summary>A human-readable message giving more details about the status of the account.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StatusMessage { get; set; }
#nullable restore
#else
        public string StatusMessage { get; set; }
#endif
        /// <summary>When authorized in a team context, includes information about the current team.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::InfinityFlow.DigitalOcean.Client.Models.Account_team? Team { get; set; }
#nullable restore
#else
        public global::InfinityFlow.DigitalOcean.Client.Models.Account_team Team { get; set; }
#endif
        /// <summary>The unique universal identifier for the current user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Uuid { get; set; }
#nullable restore
#else
        public string Uuid { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::InfinityFlow.DigitalOcean.Client.Models.Account"/> and sets the default values.
        /// </summary>
        public Account()
        {
            AdditionalData = new Dictionary<string, object>();
            Status = global::InfinityFlow.DigitalOcean.Client.Models.Account_status.Active;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::InfinityFlow.DigitalOcean.Client.Models.Account"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::InfinityFlow.DigitalOcean.Client.Models.Account CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::InfinityFlow.DigitalOcean.Client.Models.Account();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "droplet_limit", n => { DropletLimit = n.GetIntValue(); } },
                { "email", n => { Email = n.GetStringValue(); } },
                { "email_verified", n => { EmailVerified = n.GetBoolValue(); } },
                { "floating_ip_limit", n => { FloatingIpLimit = n.GetIntValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "status", n => { Status = n.GetEnumValue<global::InfinityFlow.DigitalOcean.Client.Models.Account_status>(); } },
                { "status_message", n => { StatusMessage = n.GetStringValue(); } },
                { "team", n => { Team = n.GetObjectValue<global::InfinityFlow.DigitalOcean.Client.Models.Account_team>(global::InfinityFlow.DigitalOcean.Client.Models.Account_team.CreateFromDiscriminatorValue); } },
                { "uuid", n => { Uuid = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("droplet_limit", DropletLimit);
            writer.WriteStringValue("email", Email);
            writer.WriteBoolValue("email_verified", EmailVerified);
            writer.WriteIntValue("floating_ip_limit", FloatingIpLimit);
            writer.WriteStringValue("name", Name);
            writer.WriteEnumValue<global::InfinityFlow.DigitalOcean.Client.Models.Account_status>("status", Status);
            writer.WriteStringValue("status_message", StatusMessage);
            writer.WriteObjectValue<global::InfinityFlow.DigitalOcean.Client.Models.Account_team>("team", Team);
            writer.WriteStringValue("uuid", Uuid);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
