using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class PromoteFileVersionRequestBodyArg {
        /// <summary>
        /// The file version ID
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        /// <summary>
        /// The type to promote
        /// </summary>
        [JsonPropertyName("type")]
        public PromoteFileVersionRequestBodyArgTypeField? Type { get; set; } = default;

        public PromoteFileVersionRequestBodyArg() {
            
        }
    }
}