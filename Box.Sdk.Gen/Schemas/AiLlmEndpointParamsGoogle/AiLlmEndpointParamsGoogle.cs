using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen.Schemas {
    public class AiLlmEndpointParamsGoogle {
        /// <summary>
        /// The type of the AI LLM endpoint params object for Google.
        /// This parameter is **required**.
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<AiLlmEndpointParamsGoogleTypeField>))]
        public StringEnum<AiLlmEndpointParamsGoogleTypeField> Type { get; }

        /// <summary>
        /// The temperature is used for sampling during response generation, which occurs when `top-P` and `top-K` are applied. 
        /// Temperature controls the degree of randomness in token selection.
        /// </summary>
        [JsonPropertyName("temperature")]
        public double? Temperature { get; init; }

        /// <summary>
        /// `Top-P` changes how the model selects tokens for output. Tokens are selected from the most (see `top-K`) to least probable
        /// until the sum of their probabilities equals the `top-P` value.
        /// </summary>
        [JsonPropertyName("top_p")]
        public double? TopP { get; init; }

        /// <summary>
        /// `Top-K` changes how the model selects tokens for output. A `top-K` of 1 means the next selected token is
        /// the most probable among all tokens in the model's vocabulary (also called greedy decoding),
        /// while a `top-K` of 3 means that the next token is selected from among the three most probable tokens by using temperature.
        /// </summary>
        [JsonPropertyName("top_k")]
        public double? TopK { get; init; }

        public AiLlmEndpointParamsGoogle(AiLlmEndpointParamsGoogleTypeField type = AiLlmEndpointParamsGoogleTypeField.GoogleParams) {
            Type = type;
        }
        
        [JsonConstructorAttribute]
        internal AiLlmEndpointParamsGoogle(StringEnum<AiLlmEndpointParamsGoogleTypeField> type) {
            Type = AiLlmEndpointParamsGoogleTypeField.GoogleParams;
        }
    }
}