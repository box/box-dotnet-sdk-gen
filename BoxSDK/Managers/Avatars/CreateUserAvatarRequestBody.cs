using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateUserAvatarRequestBody {
        /// <summary>
        /// The image file to be uploaded to Box.
        /// Accepted file extensions are `.jpg` or `.png`.
        /// The maximum file size is 1MB.
        /// </summary>
        public System.IO.Stream Pic { get; set; }

        public string? PicFileName { get; set; } = default;

        public string? PicContentType { get; set; } = default;

        public CreateUserAvatarRequestBody(System.IO.Stream pic) {
            Pic = pic;
        }
    }
}