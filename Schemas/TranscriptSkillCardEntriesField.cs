using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class TranscriptSkillCardEntriesField {
        [JsonPropertyName("text")]
        public string Text { get; }

        [JsonPropertyName("appears")]
        public IReadOnlyList<TranscriptSkillCardEntriesFieldAppearsField> Appears { get; }

        public TranscriptSkillCardEntriesField(string text, IReadOnlyList<TranscriptSkillCardEntriesFieldAppearsField> appears) {
            Text = text;
            Appears = appears;
        }
    }
}