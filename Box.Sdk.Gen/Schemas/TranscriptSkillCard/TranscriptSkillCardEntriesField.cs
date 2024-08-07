using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Sdk.Gen.Schemas {
    public class TranscriptSkillCardEntriesField {
        /// <summary>
        /// The text of the entry. This would be the transcribed text assigned
        /// to the entry on the timeline.
        /// </summary>
        [JsonPropertyName("text")]
        public string? Text { get; init; }

        /// <summary>
        /// Defines when a transcribed bit of text appears. This only includes a
        /// start time and no end time.
        /// </summary>
        [JsonPropertyName("appears")]
        public IReadOnlyList<TranscriptSkillCardEntriesAppearsField>? Appears { get; init; }

        public TranscriptSkillCardEntriesField() {
            
        }
    }
}