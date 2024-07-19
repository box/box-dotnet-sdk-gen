using Box.Sdk.Gen;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(AiAgentAskResponseOrAiAgentTextGenResponseConverter))]
    public class AiAgentAskResponseOrAiAgentTextGenResponse : OneOf<AiAgentAskResponse, AiAgentTextGenResponse> {
        public AiAgentAskResponse? AiAgentAskResponse => _val0;
        
        public AiAgentTextGenResponse? AiAgentTextGenResponse => _val1;
        
        public AiAgentAskResponseOrAiAgentTextGenResponse(AiAgentAskResponse value) : base(value) {}
        
        public AiAgentAskResponseOrAiAgentTextGenResponse(AiAgentTextGenResponse value) : base(value) {}
        
        public static implicit operator AiAgentAskResponseOrAiAgentTextGenResponse(AiAgentAskResponse value) => new AiAgentAskResponseOrAiAgentTextGenResponse(value);
        
        public static implicit operator AiAgentAskResponseOrAiAgentTextGenResponse(AiAgentTextGenResponse value) => new AiAgentAskResponseOrAiAgentTextGenResponse(value);
        
        class AiAgentAskResponseOrAiAgentTextGenResponseConverter : JsonConverter<AiAgentAskResponseOrAiAgentTextGenResponse> {
            public override AiAgentAskResponseOrAiAgentTextGenResponse Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) {
                using var document = JsonDocument.ParseValue(ref reader);
                var discriminant0Present = document.RootElement.TryGetProperty("type", out var discriminant0);
                if (discriminant0Present) {
                    switch (discriminant0.ToString()){
                        case "ai_agent_ask":
                            return JsonSerializer.Deserialize<AiAgentAskResponse>(document) ?? throw new Exception($"Could not deserialize {document} to AiAgentAskResponse");
                        case "ai_agent_text_gen":
                            return JsonSerializer.Deserialize<AiAgentTextGenResponse>(document) ?? throw new Exception($"Could not deserialize {document} to AiAgentTextGenResponse");
                    }
                }
                throw new Exception($"Discriminant not found in json payload {document.RootElement} while try to converting to type {typeToConvert}");
            }

            public override void Write(Utf8JsonWriter writer, AiAgentAskResponseOrAiAgentTextGenResponse? value, JsonSerializerOptions options) {
                if (value?.AiAgentAskResponse != null) {
                    JsonSerializer.Serialize(writer, value.AiAgentAskResponse, options);
                    return;
                }
                if (value?.AiAgentTextGenResponse != null) {
                    JsonSerializer.Serialize(writer, value.AiAgentTextGenResponse, options);
                    return;
                }
            }

        }

    }
}