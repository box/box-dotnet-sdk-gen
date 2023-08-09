using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateUserAvatarRequestBodyArg {
        [JsonPropertyName("pic")]
        public Stream Pic { get; }

        [JsonPropertyName("picFileName")]
        public string PicFileName { get; }

        [JsonPropertyName("picContentType")]
        public string PicContentType { get; }

        public CreateUserAvatarRequestBodyArg(Stream pic, string picFileName, string picContentType) {
            Pic = pic;
            PicFileName = picFileName;
            PicContentType = picContentType;
        }
    }
}