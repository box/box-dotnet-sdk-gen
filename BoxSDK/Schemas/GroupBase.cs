using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class GroupBase {
        /// <summary>
        /// The unique identifier for this object
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        /// <summary>
        /// `group`
        /// </summary>
        [JsonPropertyName("type")]
        public GroupBaseTypeField? Type { get; set; } = default;

        public GroupBase() {
            
        }
    }
}