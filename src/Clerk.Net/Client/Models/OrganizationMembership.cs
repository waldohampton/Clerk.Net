// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Clerk.Net.Client.Models
{
    /// <summary>
    /// Hello world
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class OrganizationMembership : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Unix timestamp of creation.</summary>
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
        public global::Clerk.Net.Client.Models.OrganizationMembership_object? Object { get; set; }
        /// <summary>The organization property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Clerk.Net.Client.Models.OrganizationMembership_organization? Organization { get; set; }
#nullable restore
#else
        public global::Clerk.Net.Client.Models.OrganizationMembership_organization Organization { get; set; }
#endif
        /// <summary>The permissions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Permissions { get; set; }
#nullable restore
#else
        public List<string> Permissions { get; set; }
#endif
        /// <summary>Metadata saved on the organization membership, accessible only from the Backend API</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Clerk.Net.Client.Models.OrganizationMembership_private_metadata? PrivateMetadata { get; set; }
#nullable restore
#else
        public global::Clerk.Net.Client.Models.OrganizationMembership_private_metadata PrivateMetadata { get; set; }
#endif
        /// <summary>Metadata saved on the organization membership, accessible from both Frontend and Backend APIs</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Clerk.Net.Client.Models.OrganizationMembership_public_metadata? PublicMetadata { get; set; }
#nullable restore
#else
        public global::Clerk.Net.Client.Models.OrganizationMembership_public_metadata PublicMetadata { get; set; }
#endif
        /// <summary>The public_user_data property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Clerk.Net.Client.Models.OrganizationMembership_public_user_data? PublicUserData { get; set; }
#nullable restore
#else
        public global::Clerk.Net.Client.Models.OrganizationMembership_public_user_data PublicUserData { get; set; }
#endif
        /// <summary>The role property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Role { get; set; }
#nullable restore
#else
        public string Role { get; set; }
#endif
        /// <summary>Unix timestamp of last update.</summary>
        public long? UpdatedAt { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Clerk.Net.Client.Models.OrganizationMembership"/> and sets the default values.
        /// </summary>
        public OrganizationMembership()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Clerk.Net.Client.Models.OrganizationMembership"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Clerk.Net.Client.Models.OrganizationMembership CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Clerk.Net.Client.Models.OrganizationMembership();
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
                { "object", n => { Object = n.GetEnumValue<global::Clerk.Net.Client.Models.OrganizationMembership_object>(); } },
                { "organization", n => { Organization = n.GetObjectValue<global::Clerk.Net.Client.Models.OrganizationMembership_organization>(global::Clerk.Net.Client.Models.OrganizationMembership_organization.CreateFromDiscriminatorValue); } },
                { "permissions", n => { Permissions = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "private_metadata", n => { PrivateMetadata = n.GetObjectValue<global::Clerk.Net.Client.Models.OrganizationMembership_private_metadata>(global::Clerk.Net.Client.Models.OrganizationMembership_private_metadata.CreateFromDiscriminatorValue); } },
                { "public_metadata", n => { PublicMetadata = n.GetObjectValue<global::Clerk.Net.Client.Models.OrganizationMembership_public_metadata>(global::Clerk.Net.Client.Models.OrganizationMembership_public_metadata.CreateFromDiscriminatorValue); } },
                { "public_user_data", n => { PublicUserData = n.GetObjectValue<global::Clerk.Net.Client.Models.OrganizationMembership_public_user_data>(global::Clerk.Net.Client.Models.OrganizationMembership_public_user_data.CreateFromDiscriminatorValue); } },
                { "role", n => { Role = n.GetStringValue(); } },
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
            writer.WriteLongValue("created_at", CreatedAt);
            writer.WriteStringValue("id", Id);
            writer.WriteEnumValue<global::Clerk.Net.Client.Models.OrganizationMembership_object>("object", Object);
            writer.WriteObjectValue<global::Clerk.Net.Client.Models.OrganizationMembership_organization>("organization", Organization);
            writer.WriteCollectionOfPrimitiveValues<string>("permissions", Permissions);
            writer.WriteObjectValue<global::Clerk.Net.Client.Models.OrganizationMembership_private_metadata>("private_metadata", PrivateMetadata);
            writer.WriteObjectValue<global::Clerk.Net.Client.Models.OrganizationMembership_public_metadata>("public_metadata", PublicMetadata);
            writer.WriteObjectValue<global::Clerk.Net.Client.Models.OrganizationMembership_public_user_data>("public_user_data", PublicUserData);
            writer.WriteStringValue("role", Role);
            writer.WriteLongValue("updated_at", UpdatedAt);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
