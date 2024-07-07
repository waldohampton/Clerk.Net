// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Clerk.Net.Client.Saml_connections
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    #pragma warning disable CS1591
    public partial class Saml_connectionsPostRequestBody : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Define the attribute name mapping between Identity Provider and Clerk&apos;s user properties</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Clerk.Net.Client.Saml_connections.Saml_connectionsPostRequestBody_attribute_mapping? AttributeMapping { get; set; }
#nullable restore
#else
        public global::Clerk.Net.Client.Saml_connections.Saml_connectionsPostRequestBody_attribute_mapping AttributeMapping { get; set; }
#endif
        /// <summary>The domain of your organization. Sign in flows using an email with this domain, will use this SAML Connection.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Domain { get; set; }
#nullable restore
#else
        public string Domain { get; set; }
#endif
        /// <summary>The X.509 certificate as provided by the IdP</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IdpCertificate { get; set; }
#nullable restore
#else
        public string IdpCertificate { get; set; }
#endif
        /// <summary>The Entity ID as provided by the IdP</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IdpEntityId { get; set; }
#nullable restore
#else
        public string IdpEntityId { get; set; }
#endif
        /// <summary>The XML content of the IdP metadata file. If present, it takes priority over the corresponding individual properties</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IdpMetadata { get; set; }
#nullable restore
#else
        public string IdpMetadata { get; set; }
#endif
        /// <summary>The URL which serves the IdP metadata. If present, it takes priority over the corresponding individual properties</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IdpMetadataUrl { get; set; }
#nullable restore
#else
        public string IdpMetadataUrl { get; set; }
#endif
        /// <summary>The Single-Sign On URL as provided by the IdP</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IdpSsoUrl { get; set; }
#nullable restore
#else
        public string IdpSsoUrl { get; set; }
#endif
        /// <summary>The name to use as a label for this SAML Connection</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The IdP provider of the connection.</summary>
        public global::Clerk.Net.Client.Saml_connections.Saml_connectionsPostRequestBody_provider? Provider { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Clerk.Net.Client.Saml_connections.Saml_connectionsPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Clerk.Net.Client.Saml_connections.Saml_connectionsPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Clerk.Net.Client.Saml_connections.Saml_connectionsPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "attribute_mapping", n => { AttributeMapping = n.GetObjectValue<global::Clerk.Net.Client.Saml_connections.Saml_connectionsPostRequestBody_attribute_mapping>(global::Clerk.Net.Client.Saml_connections.Saml_connectionsPostRequestBody_attribute_mapping.CreateFromDiscriminatorValue); } },
                { "domain", n => { Domain = n.GetStringValue(); } },
                { "idp_certificate", n => { IdpCertificate = n.GetStringValue(); } },
                { "idp_entity_id", n => { IdpEntityId = n.GetStringValue(); } },
                { "idp_metadata", n => { IdpMetadata = n.GetStringValue(); } },
                { "idp_metadata_url", n => { IdpMetadataUrl = n.GetStringValue(); } },
                { "idp_sso_url", n => { IdpSsoUrl = n.GetStringValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "provider", n => { Provider = n.GetEnumValue<global::Clerk.Net.Client.Saml_connections.Saml_connectionsPostRequestBody_provider>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Clerk.Net.Client.Saml_connections.Saml_connectionsPostRequestBody_attribute_mapping>("attribute_mapping", AttributeMapping);
            writer.WriteStringValue("domain", Domain);
            writer.WriteStringValue("idp_certificate", IdpCertificate);
            writer.WriteStringValue("idp_entity_id", IdpEntityId);
            writer.WriteStringValue("idp_metadata", IdpMetadata);
            writer.WriteStringValue("idp_metadata_url", IdpMetadataUrl);
            writer.WriteStringValue("idp_sso_url", IdpSsoUrl);
            writer.WriteStringValue("name", Name);
            writer.WriteEnumValue<global::Clerk.Net.Client.Saml_connections.Saml_connectionsPostRequestBody_provider>("provider", Provider);
        }
    }
}
