using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class SessionTerminationMessage {
        [JsonPropertyName("message")]
        public string Message { get; }

        public SessionTerminationMessage(string message) {
            Message = message;
        }
    }
}