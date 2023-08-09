using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class UserAvatarPicUrlsField {
        [JsonPropertyName("small")]
        public string Small { get; }

        [JsonPropertyName("large")]
        public string Large { get; }

        [JsonPropertyName("preview")]
        public string Preview { get; }

        public UserAvatarPicUrlsField(string small, string large, string preview) {
            Small = small;
            Large = large;
            Preview = preview;
        }
    }
}