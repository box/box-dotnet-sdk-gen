using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class OAuth2Error {
        [JsonPropertyName("error")]
        public string Error { get; }

        [JsonPropertyName("error_description")]
        public string ErrorDescription { get; }

        public OAuth2Error(string error, string errorDescription) {
            Error = error;
            ErrorDescription = errorDescription;
        }
    }
}