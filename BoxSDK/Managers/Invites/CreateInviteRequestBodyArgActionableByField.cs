using System.Text.Json.Serialization;
using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateInviteRequestBodyArgActionableByField {
        /// <summary>
        /// The login of the invited user
        /// </summary>
        [JsonPropertyName("login")]
        public string? Login { get; set; } = default;

        public CreateInviteRequestBodyArgActionableByField() {
            
        }
    }
}