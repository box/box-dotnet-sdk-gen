using Unions;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    public class UserAvatarPicUrlsField {
        /// <summary>
        /// The location of a small-sized avatar.
        /// </summary>
        [JsonPropertyName("small")]
        public string? Small { get; init; }

        /// <summary>
        /// The location of a large-sized avatar.
        /// </summary>
        [JsonPropertyName("large")]
        public string? Large { get; init; }

        /// <summary>
        /// The location of the avatar preview.
        /// </summary>
        [JsonPropertyName("preview")]
        public string? Preview { get; init; }

        public UserAvatarPicUrlsField() {
            
        }
    }
}