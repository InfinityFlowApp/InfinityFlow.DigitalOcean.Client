// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace InfinityFlow.DigitalOcean.Client.Models
{
    /// <summary>Specifies the default TOAST compression method for values of compressible columns (the default is lz4).</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum Postgres_advanced_config_default_toast_compression
    {
        [EnumMember(Value = "lz4")]
        #pragma warning disable CS1591
        Lz4,
        #pragma warning restore CS1591
        [EnumMember(Value = "pglz")]
        #pragma warning disable CS1591
        Pglz,
        #pragma warning restore CS1591
    }
}
