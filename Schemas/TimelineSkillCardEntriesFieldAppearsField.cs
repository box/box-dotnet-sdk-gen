using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class TimelineSkillCardEntriesFieldAppearsField {
        [JsonPropertyName("start")]
        public int? Start { get; }

        [JsonPropertyName("end")]
        public int? End { get; }

        public TimelineSkillCardEntriesFieldAppearsField(int? start, int? end) {
            Start = start;
            End = end;
        }
    }
}