using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class SignRequestBase {
        [JsonPropertyName("is_document_preparation_needed")]
        public bool? IsDocumentPreparationNeeded { get; }

        [JsonPropertyName("redirect_url")]
        public string RedirectUrl { get; }

        [JsonPropertyName("declined_redirect_url")]
        public string DeclinedRedirectUrl { get; }

        [JsonPropertyName("are_text_signatures_enabled")]
        public bool? AreTextSignaturesEnabled { get; }

        [JsonPropertyName("email_subject")]
        public string EmailSubject { get; }

        [JsonPropertyName("email_message")]
        public string EmailMessage { get; }

        [JsonPropertyName("are_reminders_enabled")]
        public bool? AreRemindersEnabled { get; }

        [JsonPropertyName("parent_folder")]
        public FolderMini ParentFolder { get; }

        [JsonPropertyName("name")]
        public string Name { get; }

        [JsonPropertyName("prefill_tags")]
        public IReadOnlyList<SignRequestPrefillTag> PrefillTags { get; }

        [JsonPropertyName("days_valid")]
        public int? DaysValid { get; }

        [JsonPropertyName("external_id")]
        public string ExternalId { get; }

        [JsonPropertyName("is_phone_verification_required_to_view")]
        public bool? IsPhoneVerificationRequiredToView { get; }

        [JsonPropertyName("template_id")]
        public string TemplateId { get; }

        public SignRequestBase(bool? isDocumentPreparationNeeded, string redirectUrl, string declinedRedirectUrl, bool? areTextSignaturesEnabled, string emailSubject, string emailMessage, bool? areRemindersEnabled, FolderMini parentFolder, string name, IReadOnlyList<SignRequestPrefillTag> prefillTags, int? daysValid, string externalId, bool? isPhoneVerificationRequiredToView, string templateId) {
            IsDocumentPreparationNeeded = isDocumentPreparationNeeded;
            RedirectUrl = redirectUrl;
            DeclinedRedirectUrl = declinedRedirectUrl;
            AreTextSignaturesEnabled = areTextSignaturesEnabled;
            EmailSubject = emailSubject;
            EmailMessage = emailMessage;
            AreRemindersEnabled = areRemindersEnabled;
            ParentFolder = parentFolder;
            Name = name;
            PrefillTags = prefillTags;
            DaysValid = daysValid;
            ExternalId = externalId;
            IsPhoneVerificationRequiredToView = isPhoneVerificationRequiredToView;
            TemplateId = templateId;
        }
    }
}