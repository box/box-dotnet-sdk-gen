using Box.Sdk.Gen;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class SignRequestBase : ISerializable {
        [JsonInclude]
        [JsonPropertyName("_isredirect_urlSet")]
        protected bool _isRedirectUrlSet { get; set; }

        [JsonInclude]
        [JsonPropertyName("_isdeclined_redirect_urlSet")]
        protected bool _isDeclinedRedirectUrlSet { get; set; }

        [JsonInclude]
        [JsonPropertyName("_isemail_subjectSet")]
        protected bool _isEmailSubjectSet { get; set; }

        [JsonInclude]
        [JsonPropertyName("_isemail_messageSet")]
        protected bool _isEmailMessageSet { get; set; }

        [JsonInclude]
        [JsonPropertyName("_isdays_validSet")]
        protected bool _isDaysValidSet { get; set; }

        [JsonInclude]
        [JsonPropertyName("_isexternal_idSet")]
        protected bool _isExternalIdSet { get; set; }

        [JsonInclude]
        [JsonPropertyName("_isis_phone_verification_required_to_viewSet")]
        protected bool _isIsPhoneVerificationRequiredToViewSet { get; set; }

        [JsonInclude]
        [JsonPropertyName("_istemplate_idSet")]
        protected bool _isTemplateIdSet { get; set; }

        [JsonInclude]
        [JsonPropertyName("_isexternal_system_nameSet")]
        protected bool _isExternalSystemNameSet { get; set; }

        protected string? _redirectUrl { get; set; }

        protected string? _declinedRedirectUrl { get; set; }

        protected string? _emailSubject { get; set; }

        protected string? _emailMessage { get; set; }

        protected long? _daysValid { get; set; }

        protected string? _externalId { get; set; }

        protected bool? _isPhoneVerificationRequiredToView { get; set; }

        protected string? _templateId { get; set; }

        protected string? _externalSystemName { get; set; }

        /// <summary>
        /// Indicates if the sender should receive a `prepare_url` in the response to complete document preparation using the UI.
        /// </summary>
        [JsonPropertyName("is_document_preparation_needed")]
        public bool? IsDocumentPreparationNeeded { get; init; }

        /// <summary>
        /// When specified, the signature request will be redirected to this url when a document is signed.
        /// </summary>
        [JsonPropertyName("redirect_url")]
        public string? RedirectUrl { get => _redirectUrl; init { _redirectUrl = value; _isRedirectUrlSet = true; } }

        /// <summary>
        /// The uri that a signer will be redirected to after declining to sign a document.
        /// </summary>
        [JsonPropertyName("declined_redirect_url")]
        public string? DeclinedRedirectUrl { get => _declinedRedirectUrl; init { _declinedRedirectUrl = value; _isDeclinedRedirectUrlSet = true; } }

        /// <summary>
        /// Disables the usage of signatures generated by typing (text).
        /// </summary>
        [JsonPropertyName("are_text_signatures_enabled")]
        public bool? AreTextSignaturesEnabled { get; init; }

        /// <summary>
        /// Subject of sign request email. This is cleaned by sign request. If this field is not passed, a default subject will be used.
        /// </summary>
        [JsonPropertyName("email_subject")]
        public string? EmailSubject { get => _emailSubject; init { _emailSubject = value; _isEmailSubjectSet = true; } }

        /// <summary>
        /// Message to include in sign request email. The field is cleaned through sanitization of specific characters. However, some html tags are allowed. Links included in the message are also converted to hyperlinks in the email. The message may contain the following html tags including `a`, `abbr`, `acronym`, `b`, `blockquote`, `code`, `em`, `i`, `ul`, `li`, `ol`, and `strong`. Be aware that when the text to html ratio is too high, the email may end up in spam filters. Custom styles on these tags are not allowed. If this field is not passed, a default message will be used.
        /// </summary>
        [JsonPropertyName("email_message")]
        public string? EmailMessage { get => _emailMessage; init { _emailMessage = value; _isEmailMessageSet = true; } }

        /// <summary>
        /// Reminds signers to sign a document on day 3, 8, 13 and 18. Reminders are only sent to outstanding signers.
        /// </summary>
        [JsonPropertyName("are_reminders_enabled")]
        public bool? AreRemindersEnabled { get; init; }

        /// <summary>
        /// Name of the signature request.
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; init; }

        /// <summary>
        /// When a document contains sign-related tags in the content, you can prefill them using this `prefill_tags` by referencing the 'id' of the tag as the `external_id` field of the prefill tag.
        /// </summary>
        [JsonPropertyName("prefill_tags")]
        public IReadOnlyList<SignRequestPrefillTag>? PrefillTags { get; init; }

        /// <summary>
        /// Set the number of days after which the created signature request will automatically expire if not completed. By default, we do not apply any expiration date on signature requests, and the signature request does not expire.
        /// </summary>
        [JsonPropertyName("days_valid")]
        public long? DaysValid { get => _daysValid; init { _daysValid = value; _isDaysValidSet = true; } }

        /// <summary>
        /// This can be used to reference an ID in an external system that the sign request is related to.
        /// </summary>
        [JsonPropertyName("external_id")]
        public string? ExternalId { get => _externalId; init { _externalId = value; _isExternalIdSet = true; } }

        /// <summary>
        /// Forces signers to verify a text message prior to viewing the document. You must specify the phone number of signers to have this setting apply to them.
        /// </summary>
        [JsonPropertyName("is_phone_verification_required_to_view")]
        public bool? IsPhoneVerificationRequiredToView { get => _isPhoneVerificationRequiredToView; init { _isPhoneVerificationRequiredToView = value; _isIsPhoneVerificationRequiredToViewSet = true; } }

        /// <summary>
        /// When a signature request is created from a template this field will indicate the id of that template.
        /// </summary>
        [JsonPropertyName("template_id")]
        public string? TemplateId { get => _templateId; init { _templateId = value; _isTemplateIdSet = true; } }

        /// <summary>
        /// Used as an optional system name to appear in the signature log next to the signers who have been assigned the `embed_url_external_id`.
        /// </summary>
        [JsonPropertyName("external_system_name")]
        public string? ExternalSystemName { get => _externalSystemName; init { _externalSystemName = value; _isExternalSystemNameSet = true; } }

        public SignRequestBase() {
            
        }
        internal string? RawJson { get; set; } = default;

        void ISerializable.SetJson(string json) {
            RawJson = json;
        }

        string? ISerializable.GetJson() {
            return RawJson;
        }

        /// <summary>
        /// Returns raw json response returned from the API.
        /// </summary>
        public Dictionary<string, object?>? GetRawData() {
            return SimpleJsonSerializer.GetAllFields(this);
        }

    }
}