using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateFileByIdRequestBodyArgPermissionsField {
        [JsonPropertyName("can_download")]
        public UpdateFileByIdRequestBodyArgPermissionsFieldCanDownloadField CanDownload { get; }

        public UpdateFileByIdRequestBodyArgPermissionsField(UpdateFileByIdRequestBodyArgPermissionsFieldCanDownloadField canDownload) {
            CanDownload = canDownload;
        }
    }
}