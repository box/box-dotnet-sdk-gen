using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class UserCollaborations : UserBase {
        /// <summary>
        /// The display name of this user. If the collaboration status is `pending`, an empty string is returned.
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; } = default;

        /// <summary>
        /// The primary email address of this user. If the collaboration status is `pending`, an empty string is returned.
        /// </summary>
        [JsonPropertyName("login")]
        public string? Login { get; set; } = default;

        public UserCollaborations(string id, UserBaseTypeField type) : base(id, type) {
            
        }
    }
}