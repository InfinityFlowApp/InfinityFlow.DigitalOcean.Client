// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace InfinityFlow.DigitalOcean.Client.Models
{
    /// <summary>Permission set applied to the ACL. &apos;consume&apos; allows for messages to be consumed from the topic. &apos;produce&apos; allows for messages to be published to the topic. &apos;produceconsume&apos; allows for both &apos;consume&apos; and &apos;produce&apos; permission. &apos;admin&apos; allows for &apos;produceconsume&apos; as well as any operations to administer the topic (delete, update).</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum User_settings_acl_permission
    {
        [EnumMember(Value = "admin")]
        #pragma warning disable CS1591
        Admin,
        #pragma warning restore CS1591
        [EnumMember(Value = "consume")]
        #pragma warning disable CS1591
        Consume,
        #pragma warning restore CS1591
        [EnumMember(Value = "produce")]
        #pragma warning disable CS1591
        Produce,
        #pragma warning restore CS1591
        [EnumMember(Value = "produceconsume")]
        #pragma warning disable CS1591
        Produceconsume,
        #pragma warning restore CS1591
    }
}
