// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Clerk.Net.Client.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    #pragma warning disable CS1591
    public partial class Web3Wallet : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Unix timestamp of creation</summary>
        public long? CreatedAt { get; set; }
        /// <summary>The id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>String representing the object&apos;s type. Objects of the same type share the same value.</summary>
        public global::Clerk.Net.Client.Models.Web3Wallet_object? Object { get; set; }
        /// <summary>Unix timestamp of creation</summary>
        public long? UpdatedAt { get; set; }
        /// <summary>The verification property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Clerk.Net.Client.Models.Web3Wallet.Web3Wallet_verification? Verification { get; set; }
#nullable restore
#else
        public global::Clerk.Net.Client.Models.Web3Wallet.Web3Wallet_verification Verification { get; set; }
#endif
        /// <summary>The web3_wallet property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Web3WalletProp { get; set; }
#nullable restore
#else
        public string Web3WalletProp { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Clerk.Net.Client.Models.Web3Wallet"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Clerk.Net.Client.Models.Web3Wallet CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Clerk.Net.Client.Models.Web3Wallet();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "created_at", n => { CreatedAt = n.GetLongValue(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "object", n => { Object = n.GetEnumValue<global::Clerk.Net.Client.Models.Web3Wallet_object>(); } },
                { "updated_at", n => { UpdatedAt = n.GetLongValue(); } },
                { "verification", n => { Verification = n.GetObjectValue<global::Clerk.Net.Client.Models.Web3Wallet.Web3Wallet_verification>(global::Clerk.Net.Client.Models.Web3Wallet.Web3Wallet_verification.CreateFromDiscriminatorValue); } },
                { "web3_wallet", n => { Web3WalletProp = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteLongValue("created_at", CreatedAt);
            writer.WriteStringValue("id", Id);
            writer.WriteEnumValue<global::Clerk.Net.Client.Models.Web3Wallet_object>("object", Object);
            writer.WriteLongValue("updated_at", UpdatedAt);
            writer.WriteObjectValue<global::Clerk.Net.Client.Models.Web3Wallet.Web3Wallet_verification>("verification", Verification);
            writer.WriteStringValue("web3_wallet", Web3WalletProp);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::Clerk.Net.Client.Models.Admin"/>, <see cref="global::Clerk.Net.Client.Models.Web3Signature"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
        public partial class Web3Wallet_verification : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::Clerk.Net.Client.Models.Admin"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Clerk.Net.Client.Models.Admin? Admin { get; set; }
#nullable restore
#else
            public global::Clerk.Net.Client.Models.Admin Admin { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::Clerk.Net.Client.Models.Web3Signature"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Clerk.Net.Client.Models.Web3Signature? Web3Signature { get; set; }
#nullable restore
#else
            public global::Clerk.Net.Client.Models.Web3Signature Web3Signature { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::Clerk.Net.Client.Models.Web3Wallet.Web3Wallet_verification"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::Clerk.Net.Client.Models.Web3Wallet.Web3Wallet_verification CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new global::Clerk.Net.Client.Models.Web3Wallet.Web3Wallet_verification();
                if("Admin".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.Admin = new global::Clerk.Net.Client.Models.Admin();
                }
                else if("Web3Signature".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.Web3Signature = new global::Clerk.Net.Client.Models.Web3Signature();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(Admin != null)
                {
                    return Admin.GetFieldDeserializers();
                }
                else if(Web3Signature != null)
                {
                    return Web3Signature.GetFieldDeserializers();
                }
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public virtual void Serialize(ISerializationWriter writer)
            {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                if(Admin != null)
                {
                    writer.WriteObjectValue<global::Clerk.Net.Client.Models.Admin>(null, Admin);
                }
                else if(Web3Signature != null)
                {
                    writer.WriteObjectValue<global::Clerk.Net.Client.Models.Web3Signature>(null, Web3Signature);
                }
            }
        }
    }
}
