using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateSkillInvocationByIdRequestBodyArgFileField {
        /// <summary>
        /// `file`
        /// </summary>
        [JsonPropertyName("type")]
        public UpdateSkillInvocationByIdRequestBodyArgFileFieldTypeField? Type { get; set; } = default;

        /// <summary>
        /// The ID of the file
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        public UpdateSkillInvocationByIdRequestBodyArgFileField() {
            
        }
    }
}