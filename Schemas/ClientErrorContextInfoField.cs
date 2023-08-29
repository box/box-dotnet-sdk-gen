using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class ClientErrorContextInfoField {
        /// <summary>
        /// More details on the error.
        /// </summary>
        [JsonPropertyName("message")]
        public string? Message { get; set; } = default;

        public ClientErrorContextInfoField() {
            
        }
    }
}