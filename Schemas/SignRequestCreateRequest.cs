using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class SignRequestCreateRequest : SignRequestBase {
        [JsonPropertyName("source_files")]
        public IReadOnlyList<FileBase> SourceFiles { get; }

        [JsonPropertyName("signers")]
        public IReadOnlyList<SignRequestCreateSigner> Signers { get; }

        public SignRequestCreateRequest(bool? isDocumentPreparationNeeded, string redirectUrl, string declinedRedirectUrl, bool? areTextSignaturesEnabled, string emailSubject, string emailMessage, bool? areRemindersEnabled, FolderMini parentFolder, string name, IReadOnlyList<SignRequestPrefillTag> prefillTags, int? daysValid, string externalId, bool? isPhoneVerificationRequiredToView, string templateId, IReadOnlyList<FileBase> sourceFiles, IReadOnlyList<SignRequestCreateSigner> signers) : base(isDocumentPreparationNeeded, redirectUrl, declinedRedirectUrl, areTextSignaturesEnabled, emailSubject, emailMessage, areRemindersEnabled, parentFolder, name, prefillTags, daysValid, externalId, isPhoneVerificationRequiredToView, templateId) {
            SourceFiles = sourceFiles;
            Signers = signers;
        }
    }
}