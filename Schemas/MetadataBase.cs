using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class MetadataBase {
        [JsonPropertyName("$parent")]
        public string Parent { get; }

        [JsonPropertyName("$template")]
        public string Template { get; }

        [JsonPropertyName("$scope")]
        public string Scope { get; }

        [JsonPropertyName("$version")]
        public int? Version { get; }

        public MetadataBase(string parent, string template, string scope, int? version) {
            Parent = parent;
            Template = template;
            Scope = scope;
            Version = version;
        }
    }
}