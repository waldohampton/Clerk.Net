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
    public partial class Template : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>list of variables that are available for use in the template body</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AvailableVariables { get; set; }
#nullable restore
#else
        public List<string> AvailableVariables { get; set; }
#endif
        /// <summary>the template body before variable interpolation</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Body { get; set; }
#nullable restore
#else
        public string Body { get; set; }
#endif
        /// <summary>whether this template can be deleted</summary>
        public bool? CanDelete { get; set; }
        /// <summary>whether this template can be reverted to the corresponding system default</summary>
        public bool? CanRevert { get; set; }
        /// <summary>whether this template can be enabled or disabled, true only for notification SMS templates</summary>
        public bool? CanToggle { get; set; }
        /// <summary>Unix timestamp of creation.</summary>
        public long? CreatedAt { get; set; }
        /// <summary>The delivered_by_clerk property</summary>
        public bool? DeliveredByClerk { get; set; }
        /// <summary>The enabled property</summary>
        public bool? Enabled { get; set; }
        /// <summary>The from_email_name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FromEmailName { get; set; }
#nullable restore
#else
        public string FromEmailName { get; set; }
#endif
        /// <summary>The id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>the id of the instance the template belongs to</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InstanceId { get; set; }
#nullable restore
#else
        public string InstanceId { get; set; }
#endif
        /// <summary>the editor markup used to generate the body of the template</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Markup { get; set; }
#nullable restore
#else
        public string Markup { get; set; }
#endif
        /// <summary>user-friendly name of the template</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>String representing the object&apos;s type. Objects of the same type share the same value.</summary>
        public global::Clerk.Net.Client.Models.Template_object? Object { get; set; }
        /// <summary>position with the listing of templates</summary>
        public int? Position { get; set; }
        /// <summary>The reply_to_email_name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReplyToEmailName { get; set; }
#nullable restore
#else
        public string ReplyToEmailName { get; set; }
#endif
        /// <summary>list of variables that must be contained in the template body</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RequiredVariables { get; set; }
#nullable restore
#else
        public List<string> RequiredVariables { get; set; }
#endif
        /// <summary>whether this is a system (default) or user overridden) template</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResourceType { get; set; }
#nullable restore
#else
        public string ResourceType { get; set; }
#endif
        /// <summary>machine-friendly name of the template</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Slug { get; set; }
#nullable restore
#else
        public string Slug { get; set; }
#endif
        /// <summary>email subject</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Subject { get; set; }
#nullable restore
#else
        public string Subject { get; set; }
#endif
        /// <summary>whether this is an email or SMS template</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TemplateType { get; set; }
#nullable restore
#else
        public string TemplateType { get; set; }
#endif
        /// <summary>Unix timestamp of last update.</summary>
        public long? UpdatedAt { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Clerk.Net.Client.Models.Template"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Clerk.Net.Client.Models.Template CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Clerk.Net.Client.Models.Template();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "available_variables", n => { AvailableVariables = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "body", n => { Body = n.GetStringValue(); } },
                { "can_delete", n => { CanDelete = n.GetBoolValue(); } },
                { "can_revert", n => { CanRevert = n.GetBoolValue(); } },
                { "can_toggle", n => { CanToggle = n.GetBoolValue(); } },
                { "created_at", n => { CreatedAt = n.GetLongValue(); } },
                { "delivered_by_clerk", n => { DeliveredByClerk = n.GetBoolValue(); } },
                { "enabled", n => { Enabled = n.GetBoolValue(); } },
                { "from_email_name", n => { FromEmailName = n.GetStringValue(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "instance_id", n => { InstanceId = n.GetStringValue(); } },
                { "markup", n => { Markup = n.GetStringValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "object", n => { Object = n.GetEnumValue<global::Clerk.Net.Client.Models.Template_object>(); } },
                { "position", n => { Position = n.GetIntValue(); } },
                { "reply_to_email_name", n => { ReplyToEmailName = n.GetStringValue(); } },
                { "required_variables", n => { RequiredVariables = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "resource_type", n => { ResourceType = n.GetStringValue(); } },
                { "slug", n => { Slug = n.GetStringValue(); } },
                { "subject", n => { Subject = n.GetStringValue(); } },
                { "template_type", n => { TemplateType = n.GetStringValue(); } },
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
            writer.WriteCollectionOfPrimitiveValues<string>("available_variables", AvailableVariables);
            writer.WriteStringValue("body", Body);
            writer.WriteBoolValue("can_delete", CanDelete);
            writer.WriteBoolValue("can_revert", CanRevert);
            writer.WriteBoolValue("can_toggle", CanToggle);
            writer.WriteLongValue("created_at", CreatedAt);
            writer.WriteBoolValue("delivered_by_clerk", DeliveredByClerk);
            writer.WriteBoolValue("enabled", Enabled);
            writer.WriteStringValue("from_email_name", FromEmailName);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("instance_id", InstanceId);
            writer.WriteStringValue("markup", Markup);
            writer.WriteStringValue("name", Name);
            writer.WriteEnumValue<global::Clerk.Net.Client.Models.Template_object>("object", Object);
            writer.WriteIntValue("position", Position);
            writer.WriteStringValue("reply_to_email_name", ReplyToEmailName);
            writer.WriteCollectionOfPrimitiveValues<string>("required_variables", RequiredVariables);
            writer.WriteStringValue("resource_type", ResourceType);
            writer.WriteStringValue("slug", Slug);
            writer.WriteStringValue("subject", Subject);
            writer.WriteStringValue("template_type", TemplateType);
            writer.WriteLongValue("updated_at", UpdatedAt);
        }
    }
}
