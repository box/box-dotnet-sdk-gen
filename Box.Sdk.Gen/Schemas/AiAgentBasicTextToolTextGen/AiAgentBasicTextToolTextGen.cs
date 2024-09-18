using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class AiAgentBasicTextToolTextGen : AiAgentBasicTextToolBase {
        /// <summary>
        /// System messages aim at helping the LLM understand its role and what it is supposed to do.
        /// The input for `{current_date}` is optional, depending on the use.
        /// </summary>
        [JsonPropertyName("system_message")]
        public string? SystemMessage { get; init; }

        /// <summary>
        /// The prompt template contains contextual information of the request and the user prompt.
        /// 
        /// When using the `prompt_template` parameter, you **must include** input for `{user_question}`.
        /// Inputs for `{current_date}` and `{content}` are optional, depending on the use.
        /// </summary>
        [JsonPropertyName("prompt_template")]
        public string? PromptTemplate { get; init; }

        public AiAgentBasicTextToolTextGen() {
            
        }
    }
}