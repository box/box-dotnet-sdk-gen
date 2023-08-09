using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class TimelineSkillCardEntriesField {
        [JsonPropertyName("text")]
        public string Text { get; }

        [JsonPropertyName("appears")]
        public IReadOnlyList<TimelineSkillCardEntriesFieldAppearsField> Appears { get; }

        [JsonPropertyName("image_url")]
        public string ImageUrl { get; }

        public TimelineSkillCardEntriesField(string text, IReadOnlyList<TimelineSkillCardEntriesFieldAppearsField> appears, string imageUrl) {
            Text = text;
            Appears = appears;
            ImageUrl = imageUrl;
        }
    }
}