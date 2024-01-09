using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class SkillInvocationStatusField {
        /// <summary>
        /// The state of this event.
        /// 
        /// * `invoked` - Triggered the skill with event details to start
        ///   applying skill on the file.
        /// * `processing` - Currently processing.
        /// * `success` - Completed processing with a success.
        /// * `transient_failure` - Encountered an issue which can be
        ///   retried.
        /// * `permanent_failure` -  Encountered a permanent issue and
        ///   retry would not help.
        /// </summary>
        [JsonPropertyName("state")]
        public SkillInvocationStatusStateField? State { get; set; } = default;

        /// <summary>
        /// Status information
        /// </summary>
        [JsonPropertyName("message")]
        public string? Message { get; set; } = default;

        /// <summary>
        /// Error code information, if error occurred.
        /// </summary>
        [JsonPropertyName("error_code")]
        public string? ErrorCode { get; set; } = default;

        /// <summary>
        /// Additional status information.
        /// </summary>
        [JsonPropertyName("additional_info")]
        public string? AdditionalInfo { get; set; } = default;

        public SkillInvocationStatusField() {
            
        }
    }
}