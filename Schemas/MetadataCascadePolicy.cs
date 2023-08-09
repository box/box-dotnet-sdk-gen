using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class MetadataCascadePolicy {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public MetadataCascadePolicyTypeField Type { get; }

        [JsonPropertyName("owner_enterprise")]
        public MetadataCascadePolicyOwnerEnterpriseField OwnerEnterprise { get; }

        [JsonPropertyName("parent")]
        public MetadataCascadePolicyParentField Parent { get; }

        [JsonPropertyName("scope")]
        public MetadataCascadePolicyScopeField Scope { get; }

        [JsonPropertyName("templateKey")]
        public string TemplateKey { get; }

        public MetadataCascadePolicy(string id, MetadataCascadePolicyTypeField type, MetadataCascadePolicyOwnerEnterpriseField ownerEnterprise, MetadataCascadePolicyParentField parent, MetadataCascadePolicyScopeField scope, string templateKey) {
            Id = id;
            Type = type;
            OwnerEnterprise = ownerEnterprise;
            Parent = parent;
            Scope = scope;
            TemplateKey = templateKey;
        }
    }
}