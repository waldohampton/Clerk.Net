// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Clerk.Net.Client.Sessions.Item.Tokens.Item {
    public class WithTemplate_namePostResponse : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The jwt property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Jwt { get; set; }
#nullable restore
#else
        public string Jwt { get; set; }
#endif
        /// <summary>The object property</summary>
        public WithTemplate_namePostResponse_object? Object { get; set; }
        /// <summary>
        /// Instantiates a new WithTemplate_namePostResponse and sets the default values.
        /// </summary>
        public WithTemplate_namePostResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static WithTemplate_namePostResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WithTemplate_namePostResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"jwt", n => { Jwt = n.GetStringValue(); } },
                {"object", n => { Object = n.GetEnumValue<WithTemplate_namePostResponse_object>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("jwt", Jwt);
            writer.WriteEnumValue<WithTemplate_namePostResponse_object>("object", Object);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
