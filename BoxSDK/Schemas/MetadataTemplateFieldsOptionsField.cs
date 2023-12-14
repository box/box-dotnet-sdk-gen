using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class MetadataTemplateFieldsOptionsField {
        /// <summary>
        /// The text value of the option. This represents both the display name of the
        /// option and the internal key used when updating templates.
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// The internal unique identifier of the the option.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        public MetadataTemplateFieldsOptionsField(string key) {
            Key = key;
        }
    }
}