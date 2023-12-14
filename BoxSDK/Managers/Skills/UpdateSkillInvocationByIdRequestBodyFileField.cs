using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateSkillInvocationByIdRequestBodyFileField {
        /// <summary>
        /// `file`
        /// </summary>
        [JsonPropertyName("type")]
        public UpdateSkillInvocationByIdRequestBodyFileTypeField? Type { get; set; } = default;

        /// <summary>
        /// The ID of the file
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        public UpdateSkillInvocationByIdRequestBodyFileField() {
            
        }
    }
}