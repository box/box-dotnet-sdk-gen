using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateSkillInvocationByIdRequestBodyArgUsageField {
        /// <summary>
        /// `file`
        /// </summary>
        [JsonPropertyName("unit")]
        public string? Unit { get; set; } = default;

        /// <summary>
        /// `1`
        /// </summary>
        [JsonPropertyName("value")]
        public int? Value { get; set; } = default;

        public UpdateSkillInvocationByIdRequestBodyArgUsageField() {
            
        }
    }
}