using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class UserMini : UserBase {
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

        public UserMini(string id, UserBaseTypeField type) : base(id, type) {
            
        }
    }
}