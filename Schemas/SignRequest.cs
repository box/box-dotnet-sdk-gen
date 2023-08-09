using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class SignRequest : SignRequestBase {
        [JsonPropertyName("type")]
        public SignRequestTypeField Type { get; }

        [JsonPropertyName("source_files")]
        public IReadOnlyList<FileBase> SourceFiles { get; }

        [JsonPropertyName("signers")]
        public IReadOnlyList<SignRequestSigner> Signers { get; }

        [JsonPropertyName("signature_color")]
        public string SignatureColor { get; }

        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("prepare_url")]
        public string PrepareUrl { get; }

        [JsonPropertyName("signing_log")]
        public FileMini SigningLog { get; }

        [JsonPropertyName("status")]
        public SignRequestStatusField Status { get; }

        [JsonPropertyName("sign_files")]
        public SignRequestSignFilesField SignFiles { get; }

        [JsonPropertyName("auto_expire_at")]
        public string AutoExpireAt { get; }

        public SignRequest(bool? isDocumentPreparationNeeded, string redirectUrl, string declinedRedirectUrl, bool? areTextSignaturesEnabled, string emailSubject, string emailMessage, bool? areRemindersEnabled, FolderMini parentFolder, string name, IReadOnlyList<SignRequestPrefillTag> prefillTags, int? daysValid, string externalId, bool? isPhoneVerificationRequiredToView, string templateId, SignRequestTypeField type, IReadOnlyList<FileBase> sourceFiles, IReadOnlyList<SignRequestSigner> signers, string signatureColor, string id, string prepareUrl, FileMini signingLog, SignRequestStatusField status, SignRequestSignFilesField signFiles, string autoExpireAt) : base(isDocumentPreparationNeeded, redirectUrl, declinedRedirectUrl, areTextSignaturesEnabled, emailSubject, emailMessage, areRemindersEnabled, parentFolder, name, prefillTags, daysValid, externalId, isPhoneVerificationRequiredToView, templateId) {
            Type = type;
            SourceFiles = sourceFiles;
            Signers = signers;
            SignatureColor = signatureColor;
            Id = id;
            PrepareUrl = prepareUrl;
            SigningLog = signingLog;
            Status = status;
            SignFiles = signFiles;
            AutoExpireAt = autoExpireAt;
        }
    }
}