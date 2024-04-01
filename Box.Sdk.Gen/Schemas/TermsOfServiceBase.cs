using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class TermsOfServiceBase {
        /// <summary>
        /// The unique identifier for this terms of service.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// `terms_of_service`
        /// </summary>
        [JsonPropertyName("type")]
        public TermsOfServiceBaseTypeField Type { get; set; }

        public TermsOfServiceBase(string id, TermsOfServiceBaseTypeField type = TermsOfServiceBaseTypeField.TermsOfService) {
            Id = id;
            Type = type;
        }
    }
}