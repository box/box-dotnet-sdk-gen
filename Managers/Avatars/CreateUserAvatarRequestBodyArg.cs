using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateUserAvatarRequestBodyArg {
        /// <summary>
        /// The image file to be uploaded to Box.
        /// Accepted file extensions are `.jpg` or `.png`.
        /// The maximum file size is 1MB.
        /// </summary>
        [JsonPropertyName("pic")]
        public Stream Pic { get; set; }

        [JsonPropertyName("picFileName")]
        public string? PicFileName { get; set; } = default;

        [JsonPropertyName("picContentType")]
        public string? PicContentType { get; set; } = default;

        public CreateUserAvatarRequestBodyArg(Stream pic) {
            Pic = pic;
        }
    }
}