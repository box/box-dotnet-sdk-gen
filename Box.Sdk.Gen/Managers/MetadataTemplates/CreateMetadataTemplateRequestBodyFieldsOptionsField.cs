using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class CreateMetadataTemplateRequestBodyFieldsOptionsField {
        /// <summary>
        /// The text value of the option. This represents both the display name of the
        /// option and the internal key used when updating templates.
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; }

        public CreateMetadataTemplateRequestBodyFieldsOptionsField(string key) {
            Key = key;
        }
    }
}