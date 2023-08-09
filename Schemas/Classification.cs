using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class Classification {
        [JsonPropertyName("Box__Security__Classification__Key")]
        public string BoxSecurityClassificationKey { get; }

        [JsonPropertyName("$parent")]
        public string Parent { get; }

        [JsonPropertyName("$template")]
        public ClassificationTemplateField Template { get; }

        [JsonPropertyName("$scope")]
        public string Scope { get; }

        [JsonPropertyName("$version")]
        public int? Version { get; }

        [JsonPropertyName("$type")]
        public string Type { get; }

        [JsonPropertyName("$typeVersion")]
        public int? TypeVersion { get; }

        [JsonPropertyName("$canEdit")]
        public bool? CanEdit { get; }

        public Classification(string boxSecurityClassificationKey, string parent, ClassificationTemplateField template, string scope, int? version, string type, int? typeVersion, bool? canEdit) {
            BoxSecurityClassificationKey = boxSecurityClassificationKey;
            Parent = parent;
            Template = template;
            Scope = scope;
            Version = version;
            Type = type;
            TypeVersion = typeVersion;
            CanEdit = canEdit;
        }
    }
}