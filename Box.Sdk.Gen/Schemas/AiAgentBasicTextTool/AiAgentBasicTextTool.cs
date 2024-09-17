using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class AiAgentBasicTextTool : AiAgentBasicTextToolBase {
        /// <summary>
        /// System messages try to help the LLM "understand" its role and what it is supposed to do.
        /// </summary>
        [JsonPropertyName("system_message")]
        public string? SystemMessage { get; init; }

        /// <summary>
        /// The prompt template contains contextual information of the request and the user prompt.
        /// When passing `prompt_template` parameters, you **must include** inputs for `{user_question}` and `{content}`.
        /// `{current_date}` is optional, depending on the use.
        /// </summary>
        [JsonPropertyName("prompt_template")]
        public string? PromptTemplate { get; init; }

        public AiAgentBasicTextTool() {
            
        }
    }
}