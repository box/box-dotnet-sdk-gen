using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class AiAgentLongTextToolEmbeddingsField {
        /// <summary>
        /// The model used for the AI Agent for calculating embeddings.
        /// </summary>
        [JsonPropertyName("model")]
        public string? Model { get; init; }

        [JsonPropertyName("strategy")]
        public AiAgentLongTextToolEmbeddingsStrategyField? Strategy { get; init; }

        public AiAgentLongTextToolEmbeddingsField() {
            
        }
    }
}