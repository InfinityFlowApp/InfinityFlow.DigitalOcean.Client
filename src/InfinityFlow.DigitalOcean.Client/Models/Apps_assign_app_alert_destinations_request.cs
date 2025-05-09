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
    public partial class Apps_assign_app_alert_destinations_request : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The emails property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Emails { get; set; }
#nullable restore
#else
        public List<string> Emails { get; set; }
#endif
        /// <summary>The slack_webhooks property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::InfinityFlow.DigitalOcean.Client.Models.App_alert_slack_webhook>? SlackWebhooks { get; set; }
#nullable restore
#else
        public List<global::InfinityFlow.DigitalOcean.Client.Models.App_alert_slack_webhook> SlackWebhooks { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::InfinityFlow.DigitalOcean.Client.Models.Apps_assign_app_alert_destinations_request"/> and sets the default values.
        /// </summary>
        public Apps_assign_app_alert_destinations_request()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::InfinityFlow.DigitalOcean.Client.Models.Apps_assign_app_alert_destinations_request"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::InfinityFlow.DigitalOcean.Client.Models.Apps_assign_app_alert_destinations_request CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::InfinityFlow.DigitalOcean.Client.Models.Apps_assign_app_alert_destinations_request();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "emails", n => { Emails = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "slack_webhooks", n => { SlackWebhooks = n.GetCollectionOfObjectValues<global::InfinityFlow.DigitalOcean.Client.Models.App_alert_slack_webhook>(global::InfinityFlow.DigitalOcean.Client.Models.App_alert_slack_webhook.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("emails", Emails);
            writer.WriteCollectionOfObjectValues<global::InfinityFlow.DigitalOcean.Client.Models.App_alert_slack_webhook>("slack_webhooks", SlackWebhooks);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
