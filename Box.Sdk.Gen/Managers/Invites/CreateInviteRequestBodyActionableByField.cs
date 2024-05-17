using System.Text.Json.Serialization;
using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class CreateInviteRequestBodyActionableByField {
        /// <summary>
        /// The login of the invited user
        /// </summary>
        [JsonPropertyName("login")]
        public string? Login { get; init; }

        public CreateInviteRequestBodyActionableByField() {
            
        }
    }
}