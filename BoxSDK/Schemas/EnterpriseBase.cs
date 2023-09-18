using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class EnterpriseBase {
        /// <summary>
        /// The unique identifier for this enterprise
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        /// <summary>
        /// `enterprise`
        /// </summary>
        [JsonPropertyName("type")]
        public EnterpriseBaseTypeField? Type { get; set; } = default;

        public EnterpriseBase() {
            
        }
    }
}