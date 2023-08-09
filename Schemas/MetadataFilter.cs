using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class MetadataFilter {
        [JsonPropertyName("scope")]
        public MetadataFilterScopeField Scope { get; }

        [JsonPropertyName("templateKey")]
        public string TemplateKey { get; }

        [JsonPropertyName("filters")]
        public MetadataFilterFiltersField Filters { get; }

        public MetadataFilter(MetadataFilterScopeField scope, string templateKey, MetadataFilterFiltersField filters) {
            Scope = scope;
            TemplateKey = templateKey;
            Filters = filters;
        }
    }
}