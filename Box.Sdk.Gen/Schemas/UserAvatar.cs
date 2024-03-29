using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class UserAvatar {
        /// <summary>
        /// Represents an object with user avatar URLs.
        /// </summary>
        [JsonPropertyName("pic_urls")]
        public UserAvatarPicUrlsField? PicUrls { get; set; } = default;

        public UserAvatar() {
            
        }
    }
}