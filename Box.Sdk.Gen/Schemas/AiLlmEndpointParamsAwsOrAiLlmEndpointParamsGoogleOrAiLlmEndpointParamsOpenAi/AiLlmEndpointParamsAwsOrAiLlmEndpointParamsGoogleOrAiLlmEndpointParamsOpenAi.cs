using Box.Sdk.Gen;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(AiLlmEndpointParamsAwsOrAiLlmEndpointParamsGoogleOrAiLlmEndpointParamsOpenAiConverter))]
    public class AiLlmEndpointParamsAwsOrAiLlmEndpointParamsGoogleOrAiLlmEndpointParamsOpenAi : OneOf<AiLlmEndpointParamsAws, AiLlmEndpointParamsGoogle, AiLlmEndpointParamsOpenAi> {
        public AiLlmEndpointParamsAws? AiLlmEndpointParamsAws => _val0;
        
        public AiLlmEndpointParamsGoogle? AiLlmEndpointParamsGoogle => _val1;
        
        public AiLlmEndpointParamsOpenAi? AiLlmEndpointParamsOpenAi => _val2;
        
        public AiLlmEndpointParamsAwsOrAiLlmEndpointParamsGoogleOrAiLlmEndpointParamsOpenAi(AiLlmEndpointParamsAws value) : base(value) {}
        
        public AiLlmEndpointParamsAwsOrAiLlmEndpointParamsGoogleOrAiLlmEndpointParamsOpenAi(AiLlmEndpointParamsGoogle value) : base(value) {}
        
        public AiLlmEndpointParamsAwsOrAiLlmEndpointParamsGoogleOrAiLlmEndpointParamsOpenAi(AiLlmEndpointParamsOpenAi value) : base(value) {}
        
        public static implicit operator AiLlmEndpointParamsAwsOrAiLlmEndpointParamsGoogleOrAiLlmEndpointParamsOpenAi(AiLlmEndpointParamsAws value) => new AiLlmEndpointParamsAwsOrAiLlmEndpointParamsGoogleOrAiLlmEndpointParamsOpenAi(value);
        
        public static implicit operator AiLlmEndpointParamsAwsOrAiLlmEndpointParamsGoogleOrAiLlmEndpointParamsOpenAi(AiLlmEndpointParamsGoogle value) => new AiLlmEndpointParamsAwsOrAiLlmEndpointParamsGoogleOrAiLlmEndpointParamsOpenAi(value);
        
        public static implicit operator AiLlmEndpointParamsAwsOrAiLlmEndpointParamsGoogleOrAiLlmEndpointParamsOpenAi(AiLlmEndpointParamsOpenAi value) => new AiLlmEndpointParamsAwsOrAiLlmEndpointParamsGoogleOrAiLlmEndpointParamsOpenAi(value);
        
        class AiLlmEndpointParamsAwsOrAiLlmEndpointParamsGoogleOrAiLlmEndpointParamsOpenAiConverter : JsonConverter<AiLlmEndpointParamsAwsOrAiLlmEndpointParamsGoogleOrAiLlmEndpointParamsOpenAi> {
            public override AiLlmEndpointParamsAwsOrAiLlmEndpointParamsGoogleOrAiLlmEndpointParamsOpenAi Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) {
                using var document = JsonDocument.ParseValue(ref reader);
                var discriminant0Present = document.RootElement.TryGetProperty("type", out var discriminant0);
                if (discriminant0Present) {
                    switch (discriminant0.ToString()){
                        case "aws_params":
                            return JsonSerializer.Deserialize<AiLlmEndpointParamsAws>(document) ?? throw new Exception($"Could not deserialize {document} to AiLlmEndpointParamsAws");
                        case "google_params":
                            return JsonSerializer.Deserialize<AiLlmEndpointParamsGoogle>(document) ?? throw new Exception($"Could not deserialize {document} to AiLlmEndpointParamsGoogle");
                        case "openai_params":
                            return JsonSerializer.Deserialize<AiLlmEndpointParamsOpenAi>(document) ?? throw new Exception($"Could not deserialize {document} to AiLlmEndpointParamsOpenAi");
                    }
                }
                throw new Exception($"Discriminant not found in json payload {document.RootElement} while try to converting to type {typeToConvert}");
            }

            public override void Write(Utf8JsonWriter writer, AiLlmEndpointParamsAwsOrAiLlmEndpointParamsGoogleOrAiLlmEndpointParamsOpenAi? value, JsonSerializerOptions options) {
                if (value?.AiLlmEndpointParamsAws != null) {
                    JsonSerializer.Serialize(writer, value.AiLlmEndpointParamsAws, options);
                    return;
                }
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