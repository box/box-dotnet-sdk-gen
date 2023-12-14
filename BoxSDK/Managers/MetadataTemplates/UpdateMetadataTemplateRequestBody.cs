using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateMetadataTemplateRequestBody {
        /// <summary>
        /// The type of change to perform on the template. Some
        /// of these are hazardous as they will change existing templates.
        /// </summary>
        [JsonPropertyName("op")]
        public UpdateMetadataTemplateRequestBodyOpField Op { get; set; }

        /// <summary>
        /// The data for the operation. This will vary depending on the
        /// operation being performed.
        /// </summary>
        [JsonPropertyName("data")]
        public Dictionary<string, string>? Data { get; set; } = default;

        /// <summary>
        /// For operations that affect a single field this defines the key of
        /// the field that is affected.
        /// </summary>
        [JsonPropertyName("fieldKey")]
        public string? FieldKey { get; set; } = default;

        /// <summary>
        /// For operations that affect multiple fields this defines the keys
        /// of the fields that are affected.
        /// </summary>
        [JsonPropertyName("fieldKeys")]
        public IReadOnlyList<string>? FieldKeys { get; set; } = default;

        /// <summary>
        /// For operations that affect a single `enum` option this defines
        /// the key of the option that is affected.
        /// </summary>
        [JsonPropertyName("enumOptionKey")]
        public string? EnumOptionKey { get; set; } = default;

        /// <summary>
        /// For operations that affect multiple `enum` options this defines
        /// the keys of the options that are affected.
        /// </summary>
        [JsonPropertyName("enumOptionKeys")]
        public IReadOnlyList<string>? EnumOptionKeys { get; set; } = default;

        /// <summary>
        /// For operations that affect a single multi select option this
        /// defines the key of the option that is affected.
        /// </summary>
        [JsonPropertyName("multiSelectOptionKey")]
        public string? MultiSelectOptionKey { get; set; } = default;

        /// <summary>
        /// For operations that affect multiple multi select options this
        /// defines the keys of the options that are affected.
        /// </summary>
        [JsonPropertyName("multiSelectOptionKeys")]
        public IReadOnlyList<string>? MultiSelectOptionKeys { get; set; } = default;

        public UpdateMetadataTemplateRequestBody(UpdateMetadataTemplateRequestBodyOpField op) {
            Op = op;
        }
    }
}