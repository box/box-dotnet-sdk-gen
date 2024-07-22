using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen.Schemas {
    public class AiLlmEndpointParamsOpenAi {
        /// <summary>
        /// The type of the AI LLM endpoint params object for OpenAI.
        /// This parameter is **required**.
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<AiLlmEndpointParamsOpenAiTypeField>))]
        public StringEnum<AiLlmEndpointParamsOpenAiTypeField> Type { get; }

        /// <summary>
        /// What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output more random, 
        /// while lower values like 0.2 will make it more focused and deterministic. 
        /// We generally recommend altering this or `top_p` but not both.
        /// </summary>
        [JsonPropertyName("temperature")]
        public double? Temperature { get; init; }

        /// <summary>
        /// An alternative to sampling with temperature, called nucleus sampling, where the model considers the results 
        /// of the tokens with `top_p` probability mass. So 0.1 means only the tokens comprising the top 10% probability 
        /// mass are considered. We generally recommend altering this or temperature but not both.
        /// </summary>
        [JsonPropertyName("top_p")]
        public double? TopP { get; init; }

        /// <summary>
        /// Number between -2.0 and 2.0. Positive values penalize new tokens based on their existing frequency in the 
        /// text so far, decreasing the model's likelihood to repeat the same line verbatim.
        /// </summary>
        [JsonPropertyName("frequency_penalty")]
        public double? FrequencyPenalty { get; init; }

        /// <summary>
        /// Number between -2.0 and 2.0. Positive values penalize new tokens based on whether they appear in the text so far, 
        /// increasing the model's likelihood to talk about new topics.
        /// </summary>
        [JsonPropertyName("presence_penalty")]
        public double? PresencePenalty { get; init; }

        /// <summary>
        /// Up to 4 sequences where the API will stop generating further tokens.
        /// </summary>
        [JsonPropertyName("stop")]
        public string? Stop { get; init; }

        public AiLlmEndpointParamsOpenAi(AiLlmEndpointParamsOpenAiTypeField type = AiLlmEndpointParamsOpenAiTypeField.OpenaiParams) {
            Type = type;
        }
        
        [JsonConstructorAttribute]
        internal AiLlmEndpointParamsOpenAi(StringEnum<AiLlmEndpointParamsOpenAiTypeField> type) {
            Type = AiLlmEndpointParamsOpenAiTypeField.OpenaiParams;
        }
    }
}