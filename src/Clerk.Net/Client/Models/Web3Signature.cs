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
    public partial class Web3Signature : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The attempts property</summary>
        public int? Attempts { get; set; }
        /// <summary>The expire_at property</summary>
        public int? ExpireAt { get; set; }
        /// <summary>The nonce property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Nonce { get; set; }
#nullable restore
#else
        public string Nonce { get; set; }
#endif
        /// <summary>The status property</summary>
        public global::Clerk.Net.Client.Models.Web3Signature_status? Status { get; set; }
        /// <summary>The strategy property</summary>
        public global::Clerk.Net.Client.Models.Web3Signature_strategy? Strategy { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Clerk.Net.Client.Models.Web3Signature"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Clerk.Net.Client.Models.Web3Signature CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Clerk.Net.Client.Models.Web3Signature();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "attempts", n => { Attempts = n.GetIntValue(); } },
                { "expire_at", n => { ExpireAt = n.GetIntValue(); } },
                { "nonce", n => { Nonce = n.GetStringValue(); } },
                { "status", n => { Status = n.GetEnumValue<global::Clerk.Net.Client.Models.Web3Signature_status>(); } },
                { "strategy", n => { Strategy = n.GetEnumValue<global::Clerk.Net.Client.Models.Web3Signature_strategy>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("attempts", Attempts);
            writer.WriteIntValue("expire_at", ExpireAt);
            writer.WriteStringValue("nonce", Nonce);
            writer.WriteEnumValue<global::Clerk.Net.Client.Models.Web3Signature_status>("status", Status);
            writer.WriteEnumValue<global::Clerk.Net.Client.Models.Web3Signature_strategy>("strategy", Strategy);
        }
    }
}
