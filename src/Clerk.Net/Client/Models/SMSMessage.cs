// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Clerk.Net.Client.Models {
    public class SMSMessage : IParsable {
        /// <summary>The data property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SMSMessage_data? Data { get; set; }
#nullable restore
#else
        public SMSMessage_data Data { get; set; }
#endif
        /// <summary>The delivered_by_clerk property</summary>
        public bool? DeliveredByClerk { get; set; }
        /// <summary>The from_phone_number property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FromPhoneNumber { get; set; }
#nullable restore
#else
        public string FromPhoneNumber { get; set; }
#endif
        /// <summary>The id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The message property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Message { get; set; }
#nullable restore
#else
        public string Message { get; set; }
#endif
        /// <summary>The object property</summary>
        public SMSMessage_object? Object { get; set; }
        /// <summary>The phone_number_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PhoneNumberId { get; set; }
#nullable restore
#else
        public string PhoneNumberId { get; set; }
#endif
        /// <summary>The slug property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Slug { get; set; }
#nullable restore
#else
        public string Slug { get; set; }
#endif
        /// <summary>The status property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Status { get; set; }
#nullable restore
#else
        public string Status { get; set; }
#endif
        /// <summary>The to_phone_number property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ToPhoneNumber { get; set; }
#nullable restore
#else
        public string ToPhoneNumber { get; set; }
#endif
        /// <summary>The user_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserId { get; set; }
#nullable restore
#else
        public string UserId { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SMSMessage CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SMSMessage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"data", n => { Data = n.GetObjectValue<SMSMessage_data>(SMSMessage_data.CreateFromDiscriminatorValue); } },
                {"delivered_by_clerk", n => { DeliveredByClerk = n.GetBoolValue(); } },
                {"from_phone_number", n => { FromPhoneNumber = n.GetStringValue(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"message", n => { Message = n.GetStringValue(); } },
                {"object", n => { Object = n.GetEnumValue<SMSMessage_object>(); } },
                {"phone_number_id", n => { PhoneNumberId = n.GetStringValue(); } },
                {"slug", n => { Slug = n.GetStringValue(); } },
                {"status", n => { Status = n.GetStringValue(); } },
                {"to_phone_number", n => { ToPhoneNumber = n.GetStringValue(); } },
                {"user_id", n => { UserId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<SMSMessage_data>("data", Data);
            writer.WriteBoolValue("delivered_by_clerk", DeliveredByClerk);
            writer.WriteStringValue("from_phone_number", FromPhoneNumber);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("message", Message);
            writer.WriteEnumValue<SMSMessage_object>("object", Object);
            writer.WriteStringValue("phone_number_id", PhoneNumberId);
            writer.WriteStringValue("slug", Slug);
            writer.WriteStringValue("status", Status);
            writer.WriteStringValue("to_phone_number", ToPhoneNumber);
            writer.WriteStringValue("user_id", UserId);
        }
    }
}
