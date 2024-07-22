using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class AiAgentBasicTextToolAsk {
        /// <summary>
        /// The model used for the AI Agent for basic text.
        /// </summary>
        [JsonPropertyName("model")]
        public string? Model { get; init; }

        /// <summary>
        /// System messages try to help the LLM "understand" its role and what it is supposed to do.
        /// </summary>
        [JsonPropertyName("system_message")]
        public string? SystemMessage { get; init; }

        /// <summary>
        /// The prompt template contains contextual information of the request and the user prompt. 
        /// 
        /// When passing `prompt_template` parameters, you **must include** inputs for `{current_date}`, `{user_question}`, and `{content}`.
        /// </summary>
        [JsonPropertyName("prompt_template")]
        public string? PromptTemplate { get; init; }

        /// <summary>
        /// The number of tokens for completion.
        /// </summary>
        [JsonPropertyName("num_tokens_for_completion")]
        public long? NumTokensForCompletion { get; init; }

        /// <summary>
        /// The parameters for the LLM endpoint specific to OpenAI / Google models.
        /// </summary>
        [JsonPropertyName("llm_endpoint_params")]
        public AiLlmEndpointParamsGoogleOrAiLlmEndpointParamsOpenAi? LlmEndpointParams { get; init; }

        public AiAgentBasicTextToolAsk() {
            
        }
    }
}