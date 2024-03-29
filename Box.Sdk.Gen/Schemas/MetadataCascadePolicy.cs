using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class MetadataCascadePolicy {
        /// <summary>
        /// The ID of the metadata cascade policy object
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// `metadata_cascade_policy`
        /// </summary>
        [JsonPropertyName("type")]
        public MetadataCascadePolicyTypeField Type { get; set; }

        /// <summary>
        /// The enterprise that owns this policy.
        /// </summary>
        [JsonPropertyName("owner_enterprise")]
        public MetadataCascadePolicyOwnerEnterpriseField? OwnerEnterprise { get; set; } = default;

        /// <summary>
        /// Represent the folder the policy is applied to.
        /// </summary>
        [JsonPropertyName("parent")]
        public MetadataCascadePolicyParentField? Parent { get; set; } = default;

        /// <summary>
        /// The scope of the metadata cascade policy can either be `global` or
        /// `enterprise_*`. The `global` scope is used for policies that are
        /// available to any Box enterprise. The `enterprise_*` scope represents
        /// policies that have been created within a specific enterprise, where `*`
        /// will be the ID of that enterprise.
        /// </summary>
        [JsonPropertyName("scope")]
        public string? Scope { get; set; } = default;

        /// <summary>
        /// The key of the template that is cascaded down to the folder's
        /// children.
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
        public string? TemplateKey { get; set; } = default;

        public MetadataCascadePolicy(string id, MetadataCascadePolicyTypeField type) {
            Id = id;
            Type = type;
        }
    }
}