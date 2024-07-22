using Box.Sdk.Gen;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(AiAgentAskOrAiAgentTextGenConverter))]
    public class AiAgentAskOrAiAgentTextGen : OneOf<AiAgentAsk, AiAgentTextGen> {
        public AiAgentAsk? AiAgentAsk => _val0;
        
        public AiAgentTextGen? AiAgentTextGen => _val1;
        
        public AiAgentAskOrAiAgentTextGen(AiAgentAsk value) : base(value) {}
        
        public AiAgentAskOrAiAgentTextGen(AiAgentTextGen value) : base(value) {}
        
        public static implicit operator AiAgentAskOrAiAgentTextGen(AiAgentAsk value) => new AiAgentAskOrAiAgentTextGen(value);
        
        public static implicit operator AiAgentAskOrAiAgentTextGen(AiAgentTextGen value) => new AiAgentAskOrAiAgentTextGen(value);
        
        class AiAgentAskOrAiAgentTextGenConverter : JsonConverter<AiAgentAskOrAiAgentTextGen> {
            public override AiAgentAskOrAiAgentTextGen Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) {
                using var document = JsonDocument.ParseValue(ref reader);
                var discriminant0Present = document.RootElement.TryGetProperty("type", out var discriminant0);
                if (discriminant0Present) {
                    switch (discriminant0.ToString()){
                        case "ai_agent_ask":
                            return JsonSerializer.Deserialize<AiAgentAsk>(document) ?? throw new Exception($"Could not deserialize {document} to AiAgentAsk");
                        case "ai_agent_text_gen":
                            return JsonSerializer.Deserialize<AiAgentTextGen>(document) ?? throw new Exception($"Could not deserialize {document} to AiAgentTextGen");
                    }
                }
                throw new Exception($"Discriminant not found in json payload {document.RootElement} while try to converting to type {typeToConvert}");
            }

            public override void Write(Utf8JsonWriter writer, AiAgentAskOrAiAgentTextGen? value, JsonSerializerOptions options) {
                if (value?.AiAgentAsk != null) {
                    JsonSerializer.Serialize(writer, value.AiAgentAsk, options);
                    return;
                }
                if (value?.AiAgentTextGen != null) {
                    JsonSerializer.Serialize(writer, value.AiAgentTextGen, options);
                    return;
                }
            }

        }

    }
}