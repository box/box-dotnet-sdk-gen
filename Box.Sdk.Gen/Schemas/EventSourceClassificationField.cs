using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class EventSourceClassificationField {
        /// <summary>
        /// The classification's name
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; } = default;

        public EventSourceClassificationField() {
            
        }
    }
}