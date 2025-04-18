// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace InfinityFlow.DigitalOcean.Client.Models
{
    /// <summary>A status string indicating the state of a custom image. This may be `NEW`, `available`, `pending`, `deleted`, or `retired`.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum Image_status
    {
        [EnumMember(Value = "NEW")]
        #pragma warning disable CS1591
        NEW,
        #pragma warning restore CS1591
        [EnumMember(Value = "available")]
        #pragma warning disable CS1591
        Available,
        #pragma warning restore CS1591
        [EnumMember(Value = "pending")]
        #pragma warning disable CS1591
        Pending,
        #pragma warning restore CS1591
        [EnumMember(Value = "deleted")]
        #pragma warning disable CS1591
        Deleted,
        #pragma warning restore CS1591
        [EnumMember(Value = "retired")]
        #pragma warning disable CS1591
        Retired,
        #pragma warning restore CS1591
    }
}
