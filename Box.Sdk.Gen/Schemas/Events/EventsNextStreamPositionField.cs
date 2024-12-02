using Box.Sdk.Gen;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(EventsNextStreamPositionFieldConverter))]
    public class EventsNextStreamPositionField : OneOf<string, double> {
        public string? StringVal => _val0;
        
        public double? DoubleVal => _val1;
        
        public EventsNextStreamPositionField(string value) : base(value) {}
        
        public EventsNextStreamPositionField(double value) : base(value) {}
        
        public static implicit operator EventsNextStreamPositionField(string value) => new EventsNextStreamPositionField(value);
        
        public static implicit operator EventsNextStreamPositionField(double value) => new EventsNextStreamPositionField(value);
        
        class EventsNextStreamPositionFieldConverter : JsonConverter<EventsNextStreamPositionField> {
            public override EventsNextStreamPositionField Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) {
                using var document = JsonDocument.ParseValue(ref reader);
                try {
                    var result = JsonSerializer.Deserialize<string>(document, new JsonSerializerOptions() { UnmappedMemberHandling = JsonUnmappedMemberHandling.Disallow });
                    if (result != null) {
                        return result;
                    }
                } catch {
                    
                }
                try {
                    var result = JsonSerializer.Deserialize<double>(document, new JsonSerializerOptions() { UnmappedMemberHandling = JsonUnmappedMemberHandling.Disallow });
                    return result;
                } catch {
                    
                }
                throw new Exception($"Discriminant not found in json payload {document.RootElement} while try to converting to type {typeToConvert}");
            }

            public override void Write(Utf8JsonWriter writer, EventsNextStreamPositionField? value, JsonSerializerOptions options) {
                if (value?.StringVal != null) {
                    JsonSerializer.Serialize(writer, value.StringVal, options);
                    return;
                }
                if (value?.DoubleVal != null) {
                    JsonSerializer.Serialize(writer, value.DoubleVal, options);
                    return;
                }
            }

        }

    }
}