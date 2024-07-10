using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class FolderFullMetadataField : IJsonOnDeserialized {
        [JsonPropertyName("extraData")]
        public Dictionary<string, Dictionary<string, Metadata>>? ExtraData { get; set; }

        public FolderFullMetadataField() {
            
        }
        /// <summary>
        /// Field only for SDK usage. Use ExtraData field instead. Stores additional fields returned from the api that are not mapped to the other members of this class.
        /// </summary>
        [JsonExtensionData]
        [JsonInclude]
        public Dictionary<string, JsonElement>? _additionalProperties { get; private set; } = default;

        public void OnDeserialized() {
            if (_additionalProperties != null) {
                ExtraData = new Dictionary<string, Dictionary<string, Metadata>>();
                foreach (var kvp in _additionalProperties) {
                    ExtraData.Add(kvp.Key, JsonSerializer.Deserialize<Dictionary<string, Metadata>>(kvp.Value));
                }
                _additionalProperties.Clear();
            }
        }

    }
}