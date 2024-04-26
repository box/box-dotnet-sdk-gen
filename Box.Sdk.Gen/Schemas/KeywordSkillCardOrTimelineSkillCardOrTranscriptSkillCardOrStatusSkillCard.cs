using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(KeywordSkillCardOrTimelineSkillCardOrTranscriptSkillCardOrStatusSkillCardConverter))]
    public class KeywordSkillCardOrTimelineSkillCardOrTranscriptSkillCardOrStatusSkillCard : OneOf<KeywordSkillCard, StatusSkillCard, TimelineSkillCard, TranscriptSkillCard> {
        public KeywordSkillCard? KeywordSkillCard => _val0;
        
        public StatusSkillCard? StatusSkillCard => _val1;
        
        public TimelineSkillCard? TimelineSkillCard => _val2;
        
        public TranscriptSkillCard? TranscriptSkillCard => _val3;
        
        public KeywordSkillCardOrTimelineSkillCardOrTranscriptSkillCardOrStatusSkillCard(KeywordSkillCard value) : base(value) {}
        
        public KeywordSkillCardOrTimelineSkillCardOrTranscriptSkillCardOrStatusSkillCard(StatusSkillCard value) : base(value) {}
        
        public KeywordSkillCardOrTimelineSkillCardOrTranscriptSkillCardOrStatusSkillCard(TimelineSkillCard value) : base(value) {}
        
        public KeywordSkillCardOrTimelineSkillCardOrTranscriptSkillCardOrStatusSkillCard(TranscriptSkillCard value) : base(value) {}
        
        public static implicit operator KeywordSkillCardOrTimelineSkillCardOrTranscriptSkillCardOrStatusSkillCard(KeywordSkillCard value) => new KeywordSkillCardOrTimelineSkillCardOrTranscriptSkillCardOrStatusSkillCard(value);
        
        public static implicit operator KeywordSkillCardOrTimelineSkillCardOrTranscriptSkillCardOrStatusSkillCard(StatusSkillCard value) => new KeywordSkillCardOrTimelineSkillCardOrTranscriptSkillCardOrStatusSkillCard(value);
        
        public static implicit operator KeywordSkillCardOrTimelineSkillCardOrTranscriptSkillCardOrStatusSkillCard(TimelineSkillCard value) => new KeywordSkillCardOrTimelineSkillCardOrTranscriptSkillCardOrStatusSkillCard(value);
        
        public static implicit operator KeywordSkillCardOrTimelineSkillCardOrTranscriptSkillCardOrStatusSkillCard(TranscriptSkillCard value) => new KeywordSkillCardOrTimelineSkillCardOrTranscriptSkillCardOrStatusSkillCard(value);
        
        class KeywordSkillCardOrTimelineSkillCardOrTranscriptSkillCardOrStatusSkillCardConverter : JsonConverter<KeywordSkillCardOrTimelineSkillCardOrTranscriptSkillCardOrStatusSkillCard> {
            public override KeywordSkillCardOrTimelineSkillCardOrTranscriptSkillCardOrStatusSkillCard Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) {
                using var document = JsonDocument.ParseValue(ref reader);
                var discriminant0Present = document.RootElement.TryGetProperty("skill_card_type", out var discriminant0);
                if (discriminant0Present) {
                    switch (discriminant0.ToString()){
                        case "keyword":
                            return JsonSerializer.Deserialize<KeywordSkillCard>(document) ?? throw new Exception($"Could not deserialize {document} to KeywordSkillCard");
                        case "status":
                            return JsonSerializer.Deserialize<StatusSkillCard>(document) ?? throw new Exception($"Could not deserialize {document} to StatusSkillCard");
                        case "timeline":
                            return JsonSerializer.Deserialize<TimelineSkillCard>(document) ?? throw new Exception($"Could not deserialize {document} to TimelineSkillCard");
                        case "transcript":
                            return JsonSerializer.Deserialize<TranscriptSkillCard>(document) ?? throw new Exception($"Could not deserialize {document} to TranscriptSkillCard");
                    }
                }
                throw new Exception($"Discriminant not found in json payload {document.RootElement} while try to converting to type {typeToConvert}");
            }

            public override void Write(Utf8JsonWriter writer, KeywordSkillCardOrTimelineSkillCardOrTranscriptSkillCardOrStatusSkillCard? value, JsonSerializerOptions options) {
                if (value?.KeywordSkillCard != null) {
                    JsonSerializer.Serialize(writer, value.KeywordSkillCard, options);
                    return;
                }
                if (value?.StatusSkillCard != null) {
                    JsonSerializer.Serialize(writer, value.StatusSkillCard, options);
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
            }

        }

    }
}