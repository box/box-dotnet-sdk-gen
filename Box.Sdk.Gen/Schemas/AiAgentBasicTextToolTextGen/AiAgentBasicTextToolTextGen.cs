using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class AiAgentBasicTextToolTextGen {
        /// <summary>
        /// The model to be used for the AI Agent for basic text.
        /// </summary>
        [JsonPropertyName("model")]
        public string? Model { get; init; }

        /// <summary>
        /// System messages try to help the LLM "understand" its role and what it is supposed to do.
        /// This parameter requires using `{current_date}`.
        /// </summary>
        [JsonPropertyName("system_message")]
        public string? SystemMessage { get; init; }

        /// <summary>
        /// The prompt template contains contextual information of the request and the user prompt.
        /// 
        /// When using the `prompt_template` parameter, you **must include** input for `{user_question}`.
        /// Inputs for  `{current_date}` and`{content}` are optional, depending on the use.
        /// </summary>
        [JsonPropertyName("prompt_template")]
        public string? PromptTemplate { get; init; }

        /// <summary>
        /// The number of tokens for completion.
        /// </summary>
        [JsonPropertyName("num_tokens_for_completion")]
        public long? NumTokensForCompletion { get; init; }

        [JsonPropertyName("llm_endpoint_params")]
        public AiLlmEndpointParamsGoogleOrAiLlmEndpointParamsOpenAi? LlmEndpointParams { get; init; }

        public AiAgentBasicTextToolTextGen() {
            
        }
    }
}