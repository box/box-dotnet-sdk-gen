using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class ClientErrorContextInfoField {
        [JsonPropertyName("message")]
        public string Message { get; }

        public ClientErrorContextInfoField(string message) {
            Message = message;
        }
    }
}