using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateMetadataTemplateSchemaRequestBodyArg {
        [JsonPropertyName("op")]
        public UpdateMetadataTemplateSchemaRequestBodyArgOpField Op { get; }

        [JsonPropertyName("data")]
        public Dictionary<string, string> Data { get; }

        [JsonPropertyName("fieldKey")]
        public string FieldKey { get; }

        [JsonPropertyName("fieldKeys")]
        public IReadOnlyList<string> FieldKeys { get; }

        [JsonPropertyName("enumOptionKey")]
        public string EnumOptionKey { get; }

        [JsonPropertyName("enumOptionKeys")]
        public IReadOnlyList<string> EnumOptionKeys { get; }

        [JsonPropertyName("multiSelectOptionKey")]
        public string MultiSelectOptionKey { get; }

        [JsonPropertyName("multiSelectOptionKeys")]
        public IReadOnlyList<string> MultiSelectOptionKeys { get; }

        public UpdateMetadataTemplateSchemaRequestBodyArg(UpdateMetadataTemplateSchemaRequestBodyArgOpField op, Dictionary<string, string> data, string fieldKey, IReadOnlyList<string> fieldKeys, string enumOptionKey, IReadOnlyList<string> enumOptionKeys, string multiSelectOptionKey, IReadOnlyList<string> multiSelectOptionKeys) {
            Op = op;
            Data = data;
            FieldKey = fieldKey;
            FieldKeys = fieldKeys;
            EnumOptionKey = enumOptionKey;
            EnumOptionKeys = enumOptionKeys;
            MultiSelectOptionKey = multiSelectOptionKey;
            MultiSelectOptionKeys = multiSelectOptionKeys;
        }
    }
}