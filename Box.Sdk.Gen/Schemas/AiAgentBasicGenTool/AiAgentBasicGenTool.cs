using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class AiAgentBasicGenTool : AiAgentLongTextTool {
        /// <summary>
        /// How the content should be included in a request to the LLM.
        /// When passing this parameter, you must include `{content}`.
        /// </summary>
        [JsonPropertyName("content_template")]
        public string? ContentTemplate { get; init; }

        public AiAgentBasicGenTool() {
            
        }
    }
}