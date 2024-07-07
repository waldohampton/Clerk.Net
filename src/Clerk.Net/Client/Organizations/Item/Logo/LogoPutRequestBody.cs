// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Clerk.Net.Client.Organizations.Item.Logo
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    #pragma warning disable CS1591
    public partial class LogoPutRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The file property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? File { get; set; }
#nullable restore
#else
        public string File { get; set; }
#endif
        /// <summary>The ID of the user that will be credited with the image upload.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UploaderUserId { get; set; }
#nullable restore
#else
        public string UploaderUserId { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Clerk.Net.Client.Organizations.Item.Logo.LogoPutRequestBody"/> and sets the default values.
        /// </summary>
        public LogoPutRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Clerk.Net.Client.Organizations.Item.Logo.LogoPutRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Clerk.Net.Client.Organizations.Item.Logo.LogoPutRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Clerk.Net.Client.Organizations.Item.Logo.LogoPutRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "file", n => { File = n.GetStringValue(); } },
                { "uploader_user_id", n => { UploaderUserId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("file", File);
            writer.WriteStringValue("uploader_user_id", UploaderUserId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
