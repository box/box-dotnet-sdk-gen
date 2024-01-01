using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class MetadataFull : Metadata, IJsonOnDeserialized {
        /// <summary>
        /// Whether the user can edit this metadata instance.
        /// </summary>
        [JsonPropertyName("$canEdit")]
        public bool? CanEdit { get; set; } = default;

        /// <summary>
        /// A UUID to identify the metadata instance.
        /// </summary>
        [JsonPropertyName("$id")]
        public string? Id { get; set; } = default;

        /// <summary>
        /// A unique identifier for the "type" of this instance. This is an
        /// internal system property and should not be used by a client
        /// application.
        /// </summary>
        [JsonPropertyName("$type")]
        public string? Type { get; set; } = default;

        /// <summary>
        /// The last-known version of the template of the object. This is an
        /// internal system property and should not be used by a client
        /// application.
        /// </summary>
        [JsonPropertyName("$typeVersion")]
        public long? TypeVersion { get; set; } = default;

        [JsonPropertyName("extraData")]
        public Dictionary<string, string>? ExtraData { get; set; } = default;

        public MetadataFull() {
            
        }
        /// <summary>
        /// Field only for SDK usage. Use ExtraData field instead. Stores additional fields returned from the api that are not mapped to the other members of this class.
        /// </summary>
        [JsonExtensionData]
        [JsonInclude]
        public Dictionary<string, JsonElement>? _additionalProperties { get; private set; } = default;

        public void OnDeserialized() {
            if (_additionalProperties != null) {
                ExtraData = new Dictionary<string, string>();
                foreach (var kvp in _additionalProperties) {
                    ExtraData.Add(kvp.Key, JsonSerializer.Deserialize<string>(kvp.Value));
                }
                _additionalProperties.Clear();
            }
        }

    }
}