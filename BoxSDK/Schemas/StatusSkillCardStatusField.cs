using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class StatusSkillCardStatusField {
        /// <summary>
        /// A code for the status of this Skill invocation. By
        /// default each of these will have their own accompanied
        /// messages. These can be adjusted by setting the `message`
        /// value on this object.
        /// </summary>
        [JsonPropertyName("code")]
        public StatusSkillCardStatusCodeField Code { get; set; }

        /// <summary>
        /// A custom message that can be provided with this status.
        /// This will be shown in the web app to the end user.
        /// </summary>
        [JsonPropertyName("message")]
        public string? Message { get; set; } = default;

        public StatusSkillCardStatusField(StatusSkillCardStatusCodeField code) {
            Code = code;
        }
    }
}