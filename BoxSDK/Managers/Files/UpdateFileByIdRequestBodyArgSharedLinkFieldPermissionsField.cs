using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateFileByIdRequestBodyArgSharedLinkFieldPermissionsField {
        /// <summary>
        /// If the shared link allows for downloading of files.
        /// This can only be set when `access` is set to
        /// `open` or `company`.
        /// </summary>
        [JsonPropertyName("can_download")]
        public bool? CanDownload { get; set; } = default;

        public UpdateFileByIdRequestBodyArgSharedLinkFieldPermissionsField() {
            
        }
    }
}