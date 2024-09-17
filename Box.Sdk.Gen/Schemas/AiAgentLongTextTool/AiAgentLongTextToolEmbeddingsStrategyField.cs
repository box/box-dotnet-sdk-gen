using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class AiAgentLongTextToolEmbeddingsStrategyField {
        /// <summary>
        /// The strategy used for the AI agent for calculating embeddings.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        /// <summary>
        /// The number of tokens per chunk.
        /// </summary>
        [JsonPropertyName("num_tokens_per_chunk")]
        public long? NumTokensPerChunk { get; init; }

        public AiAgentLongTextToolEmbeddingsStrategyField() {
            
        }
    }
}