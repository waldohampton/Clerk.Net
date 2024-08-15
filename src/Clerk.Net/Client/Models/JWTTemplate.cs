// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Clerk.Net.Client.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    #pragma warning disable CS1591
    public partial class JWTTemplate : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The allowed_clock_skew property</summary>
        public int? AllowedClockSkew { get; set; }
        /// <summary>The claims property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Clerk.Net.Client.Models.JWTTemplate_claims? Claims { get; set; }
#nullable restore
#else
        public global::Clerk.Net.Client.Models.JWTTemplate_claims Claims { get; set; }
#endif
        /// <summary>Unix timestamp of creation.</summary>
        public long? CreatedAt { get; set; }
        /// <summary>The custom_signing_key property</summary>
        public bool? CustomSigningKey { get; set; }
        /// <summary>The id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The lifetime property</summary>
        public int? Lifetime { get; set; }
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The object property</summary>
        public global::Clerk.Net.Client.Models.JWTTemplate_object? Object { get; set; }
        /// <summary>The signing_algorithm property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SigningAlgorithm { get; set; }
#nullable restore
#else
        public string SigningAlgorithm { get; set; }
#endif
        /// <summary>Unix timestamp of last update.</summary>
        public long? UpdatedAt { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Clerk.Net.Client.Models.JWTTemplate"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Clerk.Net.Client.Models.JWTTemplate CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Clerk.Net.Client.Models.JWTTemplate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "allowed_clock_skew", n => { AllowedClockSkew = n.GetIntValue(); } },
                { "claims", n => { Claims = n.GetObjectValue<global::Clerk.Net.Client.Models.JWTTemplate_claims>(global::Clerk.Net.Client.Models.JWTTemplate_claims.CreateFromDiscriminatorValue); } },
                { "created_at", n => { CreatedAt = n.GetLongValue(); } },
                { "custom_signing_key", n => { CustomSigningKey = n.GetBoolValue(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "lifetime", n => { Lifetime = n.GetIntValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "object", n => { Object = n.GetEnumValue<global::Clerk.Net.Client.Models.JWTTemplate_object>(); } },
                { "signing_algorithm", n => { SigningAlgorithm = n.GetStringValue(); } },
                { "updated_at", n => { UpdatedAt = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("allowed_clock_skew", AllowedClockSkew);
            writer.WriteObjectValue<global::Clerk.Net.Client.Models.JWTTemplate_claims>("claims", Claims);
            writer.WriteLongValue("created_at", CreatedAt);
            writer.WriteBoolValue("custom_signing_key", CustomSigningKey);
            writer.WriteStringValue("id", Id);
            writer.WriteIntValue("lifetime", Lifetime);
            writer.WriteStringValue("name", Name);
            writer.WriteEnumValue<global::Clerk.Net.Client.Models.JWTTemplate_object>("object", Object);
            writer.WriteStringValue("signing_algorithm", SigningAlgorithm);
            writer.WriteLongValue("updated_at", UpdatedAt);
        }
    }
}
