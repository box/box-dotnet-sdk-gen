using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class TranscriptSkillCardEntriesFieldAppearsField {
        [JsonPropertyName("start")]
        public int? Start { get; }

        public TranscriptSkillCardEntriesFieldAppearsField(int? start) {
            Start = start;
        }
    }
}