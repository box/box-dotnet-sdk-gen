using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class InviteInvitedToField {
        /// <summary>
        /// The unique identifier for this enterprise.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        /// <summary>
        /// `enterprise`
        /// </summary>
        [JsonPropertyName("type")]
        public InviteInvitedToTypeField? Type { get; set; } = default;

        /// <summary>
        /// The name of the enterprise
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; } = default;

        public InviteInvitedToField() {
            
        }
    }
}