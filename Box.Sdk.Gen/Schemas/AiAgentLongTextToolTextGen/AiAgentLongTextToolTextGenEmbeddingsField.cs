using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class AiAgentLongTextToolTextGenEmbeddingsField {
        /// <summary>
        /// The model used for the AI agent for calculating embeddings.
        /// </summary>
        [JsonPropertyName("model")]
        public string? Model { get; init; }

        [JsonPropertyName("strategy")]
        public AiAgentLongTextToolTextGenEmbeddingsStrategyField? Strategy { get; init; }

        public AiAgentLongTextToolTextGenEmbeddingsField() {
            
        }
    }
}