using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class UserAvatarPicUrlsField {
        /// <summary>
        /// The location of a small-sized avatar.
        /// </summary>
        [JsonPropertyName("small")]
        public string? Small { get; set; } = default;

        /// <summary>
        /// The location of a large-sized avatar.
        /// </summary>
        [JsonPropertyName("large")]
        public string? Large { get; set; } = default;

        /// <summary>
        /// The location of the avatar preview.
        /// </summary>
        [JsonPropertyName("preview")]
        public string? Preview { get; set; } = default;

        public UserAvatarPicUrlsField() {
            
        }
    }
}