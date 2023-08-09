using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateFileUpdateSharedLinkRequestBodyArgSharedLinkFieldPermissionsField {
        [JsonPropertyName("can_download")]
        public bool? CanDownload { get; }

        [JsonPropertyName("can_preview")]
        public bool? CanPreview { get; }

        [JsonPropertyName("can_edit")]
        public bool? CanEdit { get; }

        public UpdateFileUpdateSharedLinkRequestBodyArgSharedLinkFieldPermissionsField(bool? canDownload, bool? canPreview, bool? canEdit) {
            CanDownload = canDownload;
            CanPreview = canPreview;
            CanEdit = canEdit;
        }
    }
}