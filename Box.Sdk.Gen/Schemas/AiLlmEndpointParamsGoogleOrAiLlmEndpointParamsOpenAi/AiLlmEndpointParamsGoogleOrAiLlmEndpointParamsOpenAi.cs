using Box.Sdk.Gen;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(AiLlmEndpointParamsGoogleOrAiLlmEndpointParamsOpenAiConverter))]
    public class AiLlmEndpointParamsGoogleOrAiLlmEndpointParamsOpenAi : OneOf<AiLlmEndpointParamsGoogle, AiLlmEndpointParamsOpenAi> {
        public AiLlmEndpointParamsGoogle? AiLlmEndpointParamsGoogle => _val0;
        
        public AiLlmEndpointParamsOpenAi? AiLlmEndpointParamsOpenAi => _val1;
        
        public AiLlmEndpointParamsGoogleOrAiLlmEndpointParamsOpenAi(AiLlmEndpointParamsGoogle value) : base(value) {}
        
        public AiLlmEndpointParamsGoogleOrAiLlmEndpointParamsOpenAi(AiLlmEndpointParamsOpenAi value) : base(value) {}
        
        public static implicit operator AiLlmEndpointParamsGoogleOrAiLlmEndpointParamsOpenAi(AiLlmEndpointParamsGoogle value) => new AiLlmEndpointParamsGoogleOrAiLlmEndpointParamsOpenAi(value);
        
        public static implicit operator AiLlmEndpointParamsGoogleOrAiLlmEndpointParamsOpenAi(AiLlmEndpointParamsOpenAi value) => new AiLlmEndpointParamsGoogleOrAiLlmEndpointParamsOpenAi(value);
        
        class AiLlmEndpointParamsGoogleOrAiLlmEndpointParamsOpenAiConverter : JsonConverter<AiLlmEndpointParamsGoogleOrAiLlmEndpointParamsOpenAi> {
            public override AiLlmEndpointParamsGoogleOrAiLlmEndpointParamsOpenAi Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) {
                using var document = JsonDocument.ParseValue(ref reader);
                var discriminant0Present = document.RootElement.TryGetProperty("type", out var discriminant0);
                if (discriminant0Present) {
                    switch (discriminant0.ToString()){
                        case "google_params":
                            return JsonSerializer.Deserialize<AiLlmEndpointParamsGoogle>(document) ?? throw new Exception($"Could not deserialize {document} to AiLlmEndpointParamsGoogle");
                        case "openai_params":
                            return JsonSerializer.Deserialize<AiLlmEndpointParamsOpenAi>(document) ?? throw new Exception($"Could not deserialize {document} to AiLlmEndpointParamsOpenAi");
                    }
                }
                throw new Exception($"Discriminant not found in json payload {document.RootElement} while try to converting to type {typeToConvert}");
            }

            public override void Write(Utf8JsonWriter writer, AiLlmEndpointParamsGoogleOrAiLlmEndpointParamsOpenAi? value, JsonSerializerOptions options) {
                if (value?.AiLlmEndpointParamsGoogle != null) {
                    JsonSerializer.Serialize(writer, value.AiLlmEndpointParamsGoogle, options);
                    return;
                }
                if (value?.AiLlmEndpointParamsOpenAi != null) {
                    JsonSerializer.Serialize(writer, value.AiLlmEndpointParamsOpenAi, options);
                    return;
                }
            }

        }

    }
}