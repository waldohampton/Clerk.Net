// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Clerk.Net.Client.Models {
    public class Invitation : IParsable {
        /// <summary>Unix timestamp of creation.</summary>
        public long? CreatedAt { get; set; }
        /// <summary>The email_address property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EmailAddress { get; set; }
#nullable restore
#else
        public string EmailAddress { get; set; }
#endif
        /// <summary>The id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The object property</summary>
        public Invitation_object? Object { get; set; }
        /// <summary>The public_metadata property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Invitation_public_metadata? PublicMetadata { get; set; }
#nullable restore
#else
        public Invitation_public_metadata PublicMetadata { get; set; }
#endif
        /// <summary>The revoked property</summary>
        public bool? Revoked { get; set; }
        /// <summary>The status property</summary>
        public Invitation_status? Status { get; set; }
        /// <summary>Unix timestamp of last update.</summary>
        public long? UpdatedAt { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Invitation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Invitation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"created_at", n => { CreatedAt = n.GetLongValue(); } },
                {"email_address", n => { EmailAddress = n.GetStringValue(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"object", n => { Object = n.GetEnumValue<Invitation_object>(); } },
                {"public_metadata", n => { PublicMetadata = n.GetObjectValue<Invitation_public_metadata>(Invitation_public_metadata.CreateFromDiscriminatorValue); } },
                {"revoked", n => { Revoked = n.GetBoolValue(); } },
                {"status", n => { Status = n.GetEnumValue<Invitation_status>(); } },
                {"updated_at", n => { UpdatedAt = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteLongValue("created_at", CreatedAt);
            writer.WriteStringValue("email_address", EmailAddress);
            writer.WriteStringValue("id", Id);
            writer.WriteEnumValue<Invitation_object>("object", Object);
            writer.WriteObjectValue<Invitation_public_metadata>("public_metadata", PublicMetadata);
            writer.WriteBoolValue("revoked", Revoked);
            writer.WriteEnumValue<Invitation_status>("status", Status);
            writer.WriteLongValue("updated_at", UpdatedAt);
        }
    }
}
