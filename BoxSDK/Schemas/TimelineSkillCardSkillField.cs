using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class TimelineSkillCardSkillField {
        /// <summary>
        /// `service`
        /// </summary>
        [JsonPropertyName("type")]
        public TimelineSkillCardSkillTypeField Type { get; set; }

        /// <summary>
        /// A custom identifier that represent the service that
        /// applied this metadata.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        public TimelineSkillCardSkillField(TimelineSkillCardSkillTypeField type, string id) {
            Type = type;
            Id = id;
        }
    }
}