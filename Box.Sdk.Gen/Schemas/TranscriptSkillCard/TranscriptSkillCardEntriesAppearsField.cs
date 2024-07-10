using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen.Schemas {
    public class TranscriptSkillCardEntriesAppearsField {
        /// <summary>
        /// The time in seconds when an
        /// entry should start appearing on a timeline.
        /// </summary>
        [JsonPropertyName("start")]
        public long? Start { get; init; }

        public TranscriptSkillCardEntriesAppearsField() {
            
        }
    }
}