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
    [JsonConverter(typeof(UpdateFileMetadataGlobalBoxSkillsCardRequestBodyArgItemValueFieldConverter))]
    public class UpdateFileMetadataGlobalBoxSkillsCardRequestBodyArgItemValueField : OneOf<KeywordSkillCard, TimelineSkillCard, TranscriptSkillCard, StatusSkillCard> {
        public KeywordSkillCard KeywordSkillCard => _val0;
        
        public TimelineSkillCard TimelineSkillCard => _val1;
        
        public TranscriptSkillCard TranscriptSkillCard => _val2;
        
        public StatusSkillCard StatusSkillCard => _val3;
        
        public UpdateFileMetadataGlobalBoxSkillsCardRequestBodyArgItemValueField(KeywordSkillCard value) : base(value) {}
        
        public UpdateFileMetadataGlobalBoxSkillsCardRequestBodyArgItemValueField(TimelineSkillCard value) : base(value) {}
        
        public UpdateFileMetadataGlobalBoxSkillsCardRequestBodyArgItemValueField(TranscriptSkillCard value) : base(value) {}
        
        public UpdateFileMetadataGlobalBoxSkillsCardRequestBodyArgItemValueField(StatusSkillCard value) : base(value) {}
        
        public static implicit operator UpdateFileMetadataGlobalBoxSkillsCardRequestBodyArgItemValueField(KeywordSkillCard value) => new UpdateFileMetadataGlobalBoxSkillsCardRequestBodyArgItemValueField(value);
        
        public static implicit operator UpdateFileMetadataGlobalBoxSkillsCardRequestBodyArgItemValueField(TimelineSkillCard value) => new UpdateFileMetadataGlobalBoxSkillsCardRequestBodyArgItemValueField(value);
        
        public static implicit operator UpdateFileMetadataGlobalBoxSkillsCardRequestBodyArgItemValueField(TranscriptSkillCard value) => new UpdateFileMetadataGlobalBoxSkillsCardRequestBodyArgItemValueField(value);
        
        public static implicit operator UpdateFileMetadataGlobalBoxSkillsCardRequestBodyArgItemValueField(StatusSkillCard value) => new UpdateFileMetadataGlobalBoxSkillsCardRequestBodyArgItemValueField(value);
        
        class UpdateFileMetadataGlobalBoxSkillsCardRequestBodyArgItemValueFieldConverter : JsonConverter<UpdateFileMetadataGlobalBoxSkillsCardRequestBodyArgItemValueField> {

            public override UpdateFileMetadataGlobalBoxSkillsCardRequestBodyArgItemValueField Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) {
                using var document = JsonDocument.ParseValue(ref reader);
                var discriminant0Present = document.RootElement.TryGetProperty("skill_card_type", out var discriminant0);
                if (discriminant0Present) {
                    switch (discriminant0.ToString()){
                        case "keyword":
                            return JsonSerializer.Deserialize<KeywordSkillCard>(document);
                        case "timeline":
                            return JsonSerializer.Deserialize<TimelineSkillCard>(document);
                        case "transcript":
                            return JsonSerializer.Deserialize<TranscriptSkillCard>(document);
                        case "status":
                            return JsonSerializer.Deserialize<StatusSkillCard>(document);
                    }
                }
                throw new Exception($"Discriminant not found in json payload {document.RootElement} while try to converting to type {typeToConvert}");
            }

            public override void Write(Utf8JsonWriter writer, UpdateFileMetadataGlobalBoxSkillsCardRequestBodyArgItemValueField value, JsonSerializerOptions options) {
                if (value.KeywordSkillCard != null) {
                    JsonSerializer.Serialize(writer, value.KeywordSkillCard, options);
                    return;
                }
                if (value.TimelineSkillCard != null) {
                    JsonSerializer.Serialize(writer, value.TimelineSkillCard, options);
                    return;
                }
                if (value.TranscriptSkillCard != null) {
                    JsonSerializer.Serialize(writer, value.TranscriptSkillCard, options);
                    return;
                }
                if (value.StatusSkillCard != null) {
                    JsonSerializer.Serialize(writer, value.StatusSkillCard, options);
                    return;
                }
            }

        }

    }
}