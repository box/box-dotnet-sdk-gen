using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
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