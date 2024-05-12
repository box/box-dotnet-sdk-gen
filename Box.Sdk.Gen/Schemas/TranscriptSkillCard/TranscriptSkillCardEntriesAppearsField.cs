using Unions;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    public class TranscriptSkillCardEntriesAppearsField {
        /// <summary>
        /// The time in seconds when an
        /// entry should start appearing on a timeline.
        /// </summary>
        [JsonPropertyName("start")]
        public long? Start { get; set; } = default;

        public TranscriptSkillCardEntriesAppearsField() {
            
        }
    }
}