using System.Text.Json.Serialization;
using Box.Sdk.Gen;
using Box.Sdk.Gen.Internal;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class FileFullMetadataField : IJsonOnDeserialized {
        [JsonPropertyName("extraData")]
        public Dictionary<string, Dictionary<string, MetadataFull>>? ExtraData { get; set; }

        public FileFullMetadataField() {
            
        }
        /// <summary>
        /// Field only for SDK usage. Use ExtraData field instead. Stores additional fields returned from the api that are not mapped to the other members of this class.
        /// </summary>
        [JsonExtensionData]
        [JsonInclude]
        public Dictionary<string, JsonElement>? _additionalProperties { get; private set; } = default;

        public void OnDeserialized() {
            if (_additionalProperties != null) {
                ExtraData = new Dictionary<string, Dictionary<string, MetadataFull>>();
                foreach (var kvp in _additionalProperties) {
                    var value = JsonSerializer.Deserialize<Dictionary<string, MetadataFull>>(kvp.Value);
                    if (value != null) {
                        ExtraData.Add(kvp.Key, value);
                    }
                }
                _additionalProperties.Clear();
            }
        }

    }
}