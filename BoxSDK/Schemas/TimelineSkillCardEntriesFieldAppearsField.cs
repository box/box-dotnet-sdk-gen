using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class TimelineSkillCardEntriesFieldAppearsField {
        /// <summary>
        /// The time in seconds when an
        /// entry should start appearing on a timeline.
        /// </summary>
        [JsonPropertyName("start")]
        public long? Start { get; set; } = default;

        /// <summary>
        /// The time in seconds when an
        /// entry should stop appearing on a timeline.
        /// </summary>
        [JsonPropertyName("end")]
        public long? End { get; set; } = default;

        public TimelineSkillCardEntriesFieldAppearsField() {
            
        }
    }
}