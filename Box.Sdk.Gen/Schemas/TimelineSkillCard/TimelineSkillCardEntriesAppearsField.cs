using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen.Schemas {
    public class TimelineSkillCardEntriesAppearsField {
        /// <summary>
        /// The time in seconds when an
        /// entry should start appearing on a timeline.
        /// </summary>
        [JsonPropertyName("start")]
        public long? Start { get; init; }

        /// <summary>
        /// The time in seconds when an
        /// entry should stop appearing on a timeline.
        /// </summary>
        [JsonPropertyName("end")]
        public long? End { get; init; }

        public TimelineSkillCardEntriesAppearsField() {
            
        }
    }
}