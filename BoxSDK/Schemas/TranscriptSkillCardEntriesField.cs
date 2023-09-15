using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class TranscriptSkillCardEntriesField {
        /// <summary>
        /// The text of the entry. This would be the transcribed text assigned
        /// to the entry on the timeline.
        /// </summary>
        [JsonPropertyName("text")]
        public string? Text { get; set; } = default;

        /// <summary>
        /// Defines when a transcribed bit of text appears. This only includes a
        /// start time and no end time.
        /// </summary>
        [JsonPropertyName("appears")]
        public IReadOnlyList<TranscriptSkillCardEntriesFieldAppearsField>? Appears { get; set; } = default;

        public TranscriptSkillCardEntriesField() {
            
        }
    }
}