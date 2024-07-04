using Box.Sdk.Gen;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class UpdateAllSkillCardsOnFileRequestBodyUsageField {
        /// <summary>
        /// `file`
        /// </summary>
        [JsonPropertyName("unit")]
        public string? Unit { get; init; }

        /// <summary>
        /// `1`
        /// </summary>
        [JsonPropertyName("value")]
        public double? Value { get; init; }

        public UpdateAllSkillCardsOnFileRequestBodyUsageField() {
            
        }
    }
}