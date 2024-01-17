using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class SignTemplate {
        /// <summary>
        /// object type
        /// </summary>
        [JsonPropertyName("type")]
        public SignTemplateTypeField? Type { get; set; } = default;

        /// <summary>
        /// Template identifier.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        /// <summary>
        /// The name of the template.
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; } = default;

        /// <summary>
        /// Subject of signature request email. This is cleaned by sign request. If this field is not passed, a default subject will be used.
        /// </summary>
        [JsonPropertyName("email_subject")]
        public string? EmailSubject { get; set; } = default;

        /// <summary>
        /// Message to include in signature request email. The field is cleaned through sanitization of specific characters. However, some html tags are allowed. Links included in the message are also converted to hyperlinks in the email. The message may contain the following html tags including `a`, `abbr`, `acronym`, `b`, `blockquote`, `code`, `em`, `i`, `ul`, `li`, `ol`, and `strong`. Be aware that when the text to html ratio is too high, the email may end up in spam filters. Custom styles on these tags are not allowed. If this field is not passed, a default message will be used.
        /// </summary>
        [JsonPropertyName("email_message")]
        public string? EmailMessage { get; set; } = default;

        /// <summary>
        /// Set the number of days after which the created signature request will automatically expire if not completed. By default, we do not apply any expiration date on signature requests, and the signature request does not expire.
        /// </summary>
        [JsonPropertyName("days_valid")]
        public long? DaysValid { get; set; } = default;

        [JsonPropertyName("parent_folder")]
        public FolderMini? ParentFolder { get; set; } = default;

        /// <summary>
        /// List of files to create a signing document from. Only the ID and type fields are required for each file.
        /// </summary>
        [JsonPropertyName("source_files")]
        public IReadOnlyList<FileMini>? SourceFiles { get; set; } = default;

        /// <summary>
        /// Indicates if the template input fields are editable or not.
        /// </summary>
        [JsonPropertyName("are_fields_locked")]
        public bool? AreFieldsLocked { get; set; } = default;

        /// <summary>
        /// Indicates if the template document options are editable or not, for example renaming the document.
        /// </summary>
        [JsonPropertyName("are_options_locked")]
        public bool? AreOptionsLocked { get; set; } = default;

        /// <summary>
        /// Indicates if the template signers are editable or not.
        /// </summary>
        [JsonPropertyName("are_recipients_locked")]
        public bool? AreRecipientsLocked { get; set; } = default;

        /// <summary>
        /// Indicates if the template email settings are editable or not.
        /// </summary>
        [JsonPropertyName("are_email_settings_locked")]
        public bool? AreEmailSettingsLocked { get; set; } = default;

        /// <summary>
        /// Indicates if the template files are editable or not. This includes deleting or renaming template files.
        /// </summary>
        [JsonPropertyName("are_files_locked")]
        public bool? AreFilesLocked { get; set; } = default;

        /// <summary>
        /// Array of signers for the template.
        /// </summary>
        [JsonPropertyName("signers")]
        public IReadOnlyList<TemplateSigner>? Signers { get; set; } = default;

        /// <summary>
        /// Additional information on which fields are required and which fields are not editable.
        /// </summary>
        [JsonPropertyName("additional_info")]
        public SignTemplateAdditionalInfoField? AdditionalInfo { get; set; } = default;

        /// <summary>
        /// Box's ready-sign link feature enables you to create a link to a signature request that you've created from a template. Use this link when you want to post a signature request on a public form — such as an email, social media post, or web page — without knowing who the signers will be. Note: The ready-sign link feature is limited to Enterprise Plus customers and not available to Box Verified Enterprises.
        /// </summary>
        [JsonPropertyName("ready_sign_link")]
        public SignTemplateReadySignLinkField? ReadySignLink { get; set; } = default;

        /// <summary>
        /// Custom branding applied to notifications
        /// and signature requests.
        /// </summary>
        [JsonPropertyName("custom_branding")]
        public SignTemplateCustomBrandingField? CustomBranding { get; set; } = default;

        public SignTemplate() {
            
        }
    }
}