using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class UserAvatar {
        [JsonPropertyName("pic_urls")]
        public UserAvatarPicUrlsField PicUrls { get; }

        public UserAvatar(UserAvatarPicUrlsField picUrls) {
            PicUrls = picUrls;
        }
    }
}