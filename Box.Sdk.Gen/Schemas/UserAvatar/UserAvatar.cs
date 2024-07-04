using Box.Sdk.Gen;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    public class UserAvatar {
        /// <summary>
        /// Represents an object with user avatar URLs.
        /// </summary>
        [JsonPropertyName("pic_urls")]
        public UserAvatarPicUrlsField? PicUrls { get; init; }

        public UserAvatar() {
            
        }
    }
}