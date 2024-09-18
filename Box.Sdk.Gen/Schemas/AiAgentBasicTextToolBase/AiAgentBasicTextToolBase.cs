using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class AiAgentBasicTextToolBase {
        /// <summary>
        /// The model used for the AI agent for basic text. For specific model values, see the [available models list](g://box-ai/supported-models).
        /// </summary>
        [JsonPropertyName("model")]
        public string? Model { get; init; }

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

        public AiAgentBasicTextToolBase() {
            
        }
    }
}