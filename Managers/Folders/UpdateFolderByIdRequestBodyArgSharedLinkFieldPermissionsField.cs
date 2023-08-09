using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateFolderByIdRequestBodyArgSharedLinkFieldPermissionsField {
        [JsonPropertyName("can_download")]
        public bool? CanDownload { get; }

        public UpdateFolderByIdRequestBodyArgSharedLinkFieldPermissionsField(bool? canDownload) {
            CanDownload = canDownload;
        }
    }
}