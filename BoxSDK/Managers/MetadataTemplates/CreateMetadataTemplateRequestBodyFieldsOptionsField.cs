using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateMetadataTemplateRequestBodyFieldsOptionsField {
        /// <summary>
        /// The text value of the option. This represents both the display name of the
        /// option and the internal key used when updating templates.
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }

        public CreateMetadataTemplateRequestBodyFieldsOptionsField(string key) {
            Key = key;
        }
    }
}