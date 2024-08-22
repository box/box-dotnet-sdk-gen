using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class AiAgentBasicGenTool : AiAgentLongTextToolTextGen {
        /// <summary>
        /// How the content should be included in a request to the LLM.
        /// Input for `{content}` is optional, depending on the use.
        /// </summary>
        [JsonPropertyName("content_template")]
        public string? ContentTemplate { get; init; }

        public AiAgentBasicGenTool() {
            
        }
    }
}