using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    [JsonConverter(typeof(IntegrationMappingPartnerItemFieldConverter))]
    public class IntegrationMappingPartnerItemField : OneOf<IntegrationMappingPartnerItemSlack> {
        public IntegrationMappingPartnerItemSlack IntegrationMappingPartnerItemSlack => _val0;
        
        public IntegrationMappingPartnerItemField(IntegrationMappingPartnerItemSlack value) : base(value) {}
        
        public static implicit operator IntegrationMappingPartnerItemField(IntegrationMappingPartnerItemSlack value) => new IntegrationMappingPartnerItemField(value);
        
        class IntegrationMappingPartnerItemFieldConverter : JsonConverter<IntegrationMappingPartnerItemField> {

            public override IntegrationMappingPartnerItemField Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) {
                using var document = JsonDocument.ParseValue(ref reader);
                var discriminant0Present = document.RootElement.TryGetProperty("type", out var discriminant0);
                if (discriminant0Present) {
                    switch (discriminant0.ToString()){
                        case "channel":
                            return JsonSerializer.Deserialize<IntegrationMappingPartnerItemSlack>(document);
                    }
                }
                throw new Exception($"Discriminant not found in json payload {document.RootElement} while try to converting to type {typeToConvert}");
            }

            public override void Write(Utf8JsonWriter writer, IntegrationMappingPartnerItemField value, JsonSerializerOptions options) {
                if (value.IntegrationMappingPartnerItemSlack != null) {
                    JsonSerializer.Serialize(writer, value.IntegrationMappingPartnerItemSlack, options);
                    return;
                }
            }

        }

    }
}