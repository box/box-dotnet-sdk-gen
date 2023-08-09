using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class SignTemplate {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("name")]
        public string Name { get; }

        [JsonPropertyName("email_subject")]
        public string EmailSubject { get; }

        [JsonPropertyName("email_message")]
        public string EmailMessage { get; }

        [JsonPropertyName("days_valid")]
        public int? DaysValid { get; }

        [JsonPropertyName("parent_folder")]
        public FolderMini ParentFolder { get; }

        [JsonPropertyName("source_files")]
        public IReadOnlyList<FileMini> SourceFiles { get; }

        [JsonPropertyName("are_fields_locked")]
        public bool? AreFieldsLocked { get; }

        [JsonPropertyName("are_options_locked")]
        public bool? AreOptionsLocked { get; }

        [JsonPropertyName("are_recipients_locked")]
        public bool? AreRecipientsLocked { get; }

        [JsonPropertyName("are_email_settings_locked")]
        public bool? AreEmailSettingsLocked { get; }

        [JsonPropertyName("are_files_locked")]
        public bool? AreFilesLocked { get; }

        [JsonPropertyName("signers")]
        public IReadOnlyList<TemplateSigner> Signers { get; }

        [JsonPropertyName("additional_info")]
        public SignTemplateAdditionalInfoField AdditionalInfo { get; }

        [JsonPropertyName("ready_sign_link")]
        public SignTemplateReadySignLinkField ReadySignLink { get; }

        [JsonPropertyName("custom_branding")]
        public SignTemplateCustomBrandingField CustomBranding { get; }

        public SignTemplate(string id, string name, string emailSubject, string emailMessage, int? daysValid, FolderMini parentFolder, IReadOnlyList<FileMini> sourceFiles, bool? areFieldsLocked, bool? areOptionsLocked, bool? areRecipientsLocked, bool? areEmailSettingsLocked, bool? areFilesLocked, IReadOnlyList<TemplateSigner> signers, SignTemplateAdditionalInfoField additionalInfo, SignTemplateReadySignLinkField readySignLink, SignTemplateCustomBrandingField customBranding) {
            Id = id;
            Name = name;
            EmailSubject = emailSubject;
            EmailMessage = emailMessage;
            DaysValid = daysValid;
            ParentFolder = parentFolder;
            SourceFiles = sourceFiles;
            AreFieldsLocked = areFieldsLocked;
            AreOptionsLocked = areOptionsLocked;
            AreRecipientsLocked = areRecipientsLocked;
            AreEmailSettingsLocked = areEmailSettingsLocked;
            AreFilesLocked = areFilesLocked;
            Signers = signers;
            AdditionalInfo = additionalInfo;
            ReadySignLink = readySignLink;
            CustomBranding = customBranding;
        }
    }
}