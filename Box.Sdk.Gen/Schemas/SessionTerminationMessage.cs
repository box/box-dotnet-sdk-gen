using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class SessionTerminationMessage {
        /// <summary>
        /// The unique identifier for the termination job status
        /// </summary>
        [JsonPropertyName("message")]
        public string? Message { get; set; } = default;

        public SessionTerminationMessage() {
            
        }
    }
}