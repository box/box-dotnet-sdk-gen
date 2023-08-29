using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateFileByIdRequestBodyArgPermissionsField {
        /// <summary>
        /// Defines who is allowed to download this file. The possible
        /// values are either `open` for everyone or `company` for
        /// the other members of the user's enterprise.
        /// 
        /// This setting overrides the download permissions that are
        /// normally part of the `role` of a collaboration. When set to
        /// `company`, this essentially removes the download option for
        /// external users with `viewer` or `editor` a roles.
        /// </summary>
        [JsonPropertyName("can_download")]
        public UpdateFileByIdRequestBodyArgPermissionsFieldCanDownloadField? CanDownload { get; set; } = default;

        public UpdateFileByIdRequestBodyArgPermissionsField() {
            
        }
    }
}