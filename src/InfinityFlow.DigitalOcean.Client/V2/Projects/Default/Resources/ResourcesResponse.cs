// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace InfinityFlow.DigitalOcean.Client.V2.Projects.Default.Resources
{
    [Obsolete("This class is obsolete. Use ResourcesGetResponse instead.")]
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class ResourcesResponse : global::InfinityFlow.DigitalOcean.Client.V2.Projects.Default.Resources.ResourcesGetResponse, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::InfinityFlow.DigitalOcean.Client.V2.Projects.Default.Resources.ResourcesResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::InfinityFlow.DigitalOcean.Client.V2.Projects.Default.Resources.ResourcesResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::InfinityFlow.DigitalOcean.Client.V2.Projects.Default.Resources.ResourcesResponse();
        }
    }
}
#pragma warning restore CS0618
