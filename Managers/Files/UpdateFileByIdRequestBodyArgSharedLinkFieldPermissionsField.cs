using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateFileByIdRequestBodyArgSharedLinkFieldPermissionsField {
        [JsonPropertyName("can_download")]
        public bool? CanDownload { get; }

        public UpdateFileByIdRequestBodyArgSharedLinkFieldPermissionsField(bool? canDownload) {
            CanDownload = canDownload;
        }
    }
}