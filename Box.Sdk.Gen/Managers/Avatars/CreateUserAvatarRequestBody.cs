using Box.Sdk.Gen;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen.Managers {
    public class CreateUserAvatarRequestBody {
        /// <summary>
        /// The image file to be uploaded to Box.
        /// Accepted file extensions are `.jpg` or `.png`.
        /// The maximum file size is 1MB.
        /// </summary>
        public System.IO.Stream Pic { get; }

        public string? PicFileName { get; init; }

        public string? PicContentType { get; init; }

        public CreateUserAvatarRequestBody(System.IO.Stream pic) {
            Pic = pic;
        }
    }
}