using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class OAuth2Error {
        /// <summary>
        /// The type of the error returned.
        /// </summary>
        [JsonPropertyName("error")]
        public string? Error { get; set; } = default;

        /// <summary>
        /// The type of the error returned.
        /// </summary>
        [JsonPropertyName("error_description")]
        public string? ErrorDescription { get; set; } = default;

        public OAuth2Error() {
            
        }
    }
}