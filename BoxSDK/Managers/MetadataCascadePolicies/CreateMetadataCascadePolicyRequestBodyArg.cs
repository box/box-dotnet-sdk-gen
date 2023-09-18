using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateMetadataCascadePolicyRequestBodyArg {
        /// <summary>
        /// The ID of the folder to apply the policy to. This folder will
        /// need to already have an instance of the targeted metadata
        /// template applied to it.
        /// </summary>
        [JsonPropertyName("folder_id")]
        public string FolderId { get; set; }

        /// <summary>
        /// The scope of the targeted metadata template. This template will
        /// need to already have an instance applied to the targeted folder.
        /// </summary>
        [JsonPropertyName("scope")]
        public CreateMetadataCascadePolicyRequestBodyArgScopeField Scope { get; set; }

        /// <summary>
        /// The key of the targeted metadata template. This template will
        /// need to already have an instance applied to the targeted folder.
        /// 
        /// In many cases the template key is automatically derived
        /// of its display name, for example `Contract Template` would
        /// become `contractTemplate`. In some cases the creator of the
        /// template will have provided its own template key.
        /// 
        /// Please [list the templates for an enterprise][list], or
        /// get all instances on a [file][file] or [folder][folder]
        /// to inspect a template's key.
        /// 
        /// [list]: e://get-metadata-templates-enterprise
        /// [file]: e://get-files-id-metadata
        /// [folder]: e://get-folders-id-metadata
        /// </summary>
        [JsonPropertyName("templateKey")]
        public string TemplateKey { get; set; }

        public CreateMetadataCascadePolicyRequestBodyArg(string folderId, CreateMetadataCascadePolicyRequestBodyArgScopeField scope, string templateKey) {
            FolderId = folderId;
            Scope = scope;
            TemplateKey = templateKey;
        }
    }
}