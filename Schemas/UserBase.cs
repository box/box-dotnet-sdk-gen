using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class UserBase {
        /// <summary>
        /// The unique identifier for this user
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        /// <summary>
        /// `user`
        /// </summary>
        [JsonPropertyName("type")]
        public UserBaseTypeField Type { get; set; }

        public UserBase(UserBaseTypeField type) {
            Type = type;
        }
    }
}