using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(UpdateSkillInvocationByIdRequestBodyArgMetadataFieldCardsFieldConverter))]
    public class UpdateSkillInvocationByIdRequestBodyArgMetadataFieldCardsField : OneOf<KeywordSkillCard, TimelineSkillCard, TranscriptSkillCard, StatusSkillCard> {
        public KeywordSkillCard? KeywordSkillCard => _val0;
        
        public TimelineSkillCard? TimelineSkillCard => _val1;
        
        public TranscriptSkillCard? TranscriptSkillCard => _val2;
        
        public StatusSkillCard? StatusSkillCard => _val3;
        
        public UpdateSkillInvocationByIdRequestBodyArgMetadataFieldCardsField(KeywordSkillCard value) : base(value) {}
        
        public UpdateSkillInvocationByIdRequestBodyArgMetadataFieldCardsField(TimelineSkillCard value) : base(value) {}
        
        public UpdateSkillInvocationByIdRequestBodyArgMetadataFieldCardsField(TranscriptSkillCard value) : base(value) {}
        
        public UpdateSkillInvocationByIdRequestBodyArgMetadataFieldCardsField(StatusSkillCard value) : base(value) {}
        
        public static implicit operator UpdateSkillInvocationByIdRequestBodyArgMetadataFieldCardsField(KeywordSkillCard value) => new UpdateSkillInvocationByIdRequestBodyArgMetadataFieldCardsField(value);
        
        public static implicit operator UpdateSkillInvocationByIdRequestBodyArgMetadataFieldCardsField(TimelineSkillCard value) => new UpdateSkillInvocationByIdRequestBodyArgMetadataFieldCardsField(value);
        
        public static implicit operator UpdateSkillInvocationByIdRequestBodyArgMetadataFieldCardsField(TranscriptSkillCard value) => new UpdateSkillInvocationByIdRequestBodyArgMetadataFieldCardsField(value);
        
        public static implicit operator UpdateSkillInvocationByIdRequestBodyArgMetadataFieldCardsField(StatusSkillCard value) => new UpdateSkillInvocationByIdRequestBodyArgMetadataFieldCardsField(value);
        
        class UpdateSkillInvocationByIdRequestBodyArgMetadataFieldCardsFieldConverter : JsonConverter<UpdateSkillInvocationByIdRequestBodyArgMetadataFieldCardsField> {

            public override UpdateSkillInvocationByIdRequestBodyArgMetadataFieldCardsField Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) {
                using var document = JsonDocument.ParseValue(ref reader);
                var discriminant0Present = document.RootElement.TryGetProperty("skill_card_type", out var discriminant0);
                if (discriminant0Present) {
                    switch (discriminant0.ToString()){
                        case "keyword":
                            return JsonSerializer.Deserialize<KeywordSkillCard>(document) ?? throw new Exception($"Could not deserialize {document} to KeywordSkillCard");
                        case "timeline":
                            return JsonSerializer.Deserialize<TimelineSkillCard>(document) ?? throw new Exception($"Could not deserialize {document} to TimelineSkillCard");
                        case "transcript":
                            return JsonSerializer.Deserialize<TranscriptSkillCard>(document) ?? throw new Exception($"Could not deserialize {document} to TranscriptSkillCard");
                        case "status":
                            return JsonSerializer.Deserialize<StatusSkillCard>(document) ?? throw new Exception($"Could not deserialize {document} to StatusSkillCard");
                    }
                }
                throw new Exception($"Discriminant not found in json payload {document.RootElement} while try to converting to type {typeToConvert}");
            }

            public override void Write(Utf8JsonWriter writer, UpdateSkillInvocationByIdRequestBodyArgMetadataFieldCardsField? value, JsonSerializerOptions options) {
                if (value?.KeywordSkillCard != null) {
                    JsonSerializer.Serialize(writer, value.KeywordSkillCard, options);
                    return;
                }
                if (value?.TimelineSkillCard != null) {
                    JsonSerializer.Serialize(writer, value.TimelineSkillCard, options);
                    return;
                }
                if (value?.TranscriptSkillCard != null) {
                    JsonSerializer.Serialize(writer, value.TranscriptSkillCard, options);
                    return;
                }
                if (value?.StatusSkillCard != null) {
                    JsonSerializer.Serialize(writer, value.StatusSkillCard, options);
                    return;
                }
            }

        }

    }
}