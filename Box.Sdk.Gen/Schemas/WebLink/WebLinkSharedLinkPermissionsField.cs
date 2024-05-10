using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Unions;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class WebLinkSharedLinkPermissionsField {
        /// <summary>
        /// Defines if the shared link allows for the item to be downloaded. For
        /// shared links on folders, this also applies to any items in the folder.
        /// 
        /// This value can be set to `true` when the effective access level is
        /// set to `open` or `company`, not `collaborators`.
        /// </summary>
        [JsonPropertyName("can_download")]
        public bool CanDownload { get; set; }

        /// <summary>
        /// Defines if the shared link allows for the item to be previewed.
        /// 
        /// This value is always `true`. For shared links on folders this also
        /// applies to any items in the folder.
        /// </summary>
        [JsonPropertyName("can_preview")]
        public bool CanPreview { get; set; }

        /// <summary>
        /// Defines if the shared link allows for the item to be edited.
        /// 
        /// This value can only be `true` if `can_download` is also `true` and if
        /// the item has a type of `file`.
        /// </summary>
        [JsonPropertyName("can_edit")]
        public bool CanEdit { get; set; }

        public WebLinkSharedLinkPermissionsField(bool canDownload, bool canPreview, bool canEdit) {
            CanDownload = canDownload;
            CanPreview = canPreview;
            CanEdit = canEdit;
        }
    }
}