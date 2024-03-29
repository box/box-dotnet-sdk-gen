using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class UserIntegrationMappings : UserBase {
        /// <summary>
        /// The display name of this user
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; } = default;

        /// <summary>
        /// The primary email address of this user
        /// </summary>
        [JsonPropertyName("login")]
        public string? Login { get; set; } = default;

        public UserIntegrationMappings(string id, UserBaseTypeField type = UserBaseTypeField.User) : base(id, type) {
            
        }
    }
}