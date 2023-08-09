using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class FolderSharedLinkFieldPermissionsField {
        [JsonPropertyName("can_download")]
        public bool CanDownload { get; }

        [JsonPropertyName("can_preview")]
        public bool CanPreview { get; }

        [JsonPropertyName("can_edit")]
        public bool CanEdit { get; }

        public FolderSharedLinkFieldPermissionsField(bool canDownload, bool canPreview, bool canEdit) {
            CanDownload = canDownload;
            CanPreview = canPreview;
            CanEdit = canEdit;
        }
    }
}