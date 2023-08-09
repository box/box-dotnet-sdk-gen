using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateMetadataCascadePolicyRequestBodyArg {
        [JsonPropertyName("folder_id")]
        public string FolderId { get; }

        [JsonPropertyName("scope")]
        public CreateMetadataCascadePolicyRequestBodyArgScopeField Scope { get; }

        [JsonPropertyName("templateKey")]
        public string TemplateKey { get; }

        public CreateMetadataCascadePolicyRequestBodyArg(string folderId, CreateMetadataCascadePolicyRequestBodyArgScopeField scope, string templateKey) {
            FolderId = folderId;
            Scope = scope;
            TemplateKey = templateKey;
        }
    }
}