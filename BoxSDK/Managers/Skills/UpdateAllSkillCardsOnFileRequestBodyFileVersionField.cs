using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateAllSkillCardsOnFileRequestBodyFileVersionField {
        /// <summary>
        /// `file_version`
        /// </summary>
        [JsonPropertyName("type")]
        public UpdateAllSkillCardsOnFileRequestBodyFileVersionTypeField? Type { get; set; } = default;

        /// <summary>
        /// The ID of the file version
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        public UpdateAllSkillCardsOnFileRequestBodyFileVersionField() {
            
        }
    }
}