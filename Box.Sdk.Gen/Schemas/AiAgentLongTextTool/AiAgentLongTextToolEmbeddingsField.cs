using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class AiAgentLongTextToolEmbeddingsField : ISerializable {
        /// <summary>
        /// The model used for the AI agent for calculating embeddings.
        /// </summary>
        [JsonPropertyName("model")]
        public string? Model { get; init; }

        [JsonPropertyName("strategy")]
        public AiAgentLongTextToolEmbeddingsStrategyField? Strategy { get; init; }

        public AiAgentLongTextToolEmbeddingsField() {
            
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