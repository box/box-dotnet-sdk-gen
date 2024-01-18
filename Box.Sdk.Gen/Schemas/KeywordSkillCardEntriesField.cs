using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class KeywordSkillCardEntriesField {
        /// <summary>
        /// The text of the keyword.
        /// </summary>
        [JsonPropertyName("text")]
        public string? Text { get; set; } = default;

        public KeywordSkillCardEntriesField() {
            
        }
    }
}