using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class AiAgentLongTextTool : AiAgentBasicTextToolTextGen {
        [JsonPropertyName("embeddings")]
        public AiAgentLongTextToolEmbeddingsField? Embeddings { get; init; }

        public AiAgentLongTextTool() {
            
        }
    }
}