using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class AiAgentLongTextToolTextGen : AiAgentBasicTextToolTextGen {
        [JsonPropertyName("embeddings")]
        public AiAgentLongTextToolTextGenEmbeddingsField? Embeddings { get; init; }

        public AiAgentLongTextToolTextGen() {
            
        }
    }
}