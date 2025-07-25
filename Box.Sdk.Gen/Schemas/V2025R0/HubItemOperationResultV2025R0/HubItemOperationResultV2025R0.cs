using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class HubItemOperationResultV2025R0 : ISerializable {
        /// <summary>
        /// The action performed on the item.
        /// </summary>
        [JsonPropertyName("action")]
        public string? Action { get; init; }

        [JsonPropertyName("item")]
        public HubItemReferenceV2025R0? Item { get; init; }

        /// <summary>
        /// The HTTP status code of the operation.
        /// </summary>
        [JsonPropertyName("status")]
        public long? Status { get; init; }

        /// <summary>
        /// Error message if the operation failed.
        /// </summary>
        [JsonPropertyName("error")]
        public string? Error { get; init; }

        public HubItemOperationResultV2025R0() {
            
        }
        internal string? RawJson { get; set; } = default;

        void ISerializable.SetJson(string json) {
            RawJson = json;
        }

        string? ISerializable.GetJson() {
            return RawJson;
        }

        /// <summary>
        /// Returns raw json response returned from the API.
        /// </summary>
        public Dictionary<string, object?>? GetRawData() {
            return SimpleJsonSerializer.GetAllFields(this);
        }

    }
}