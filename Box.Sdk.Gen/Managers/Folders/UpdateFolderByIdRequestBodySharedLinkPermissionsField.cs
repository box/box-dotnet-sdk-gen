using Box.Sdk.Gen;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class UpdateFolderByIdRequestBodySharedLinkPermissionsField {
        /// <summary>
        /// If the shared link allows for downloading of files.
        /// This can only be set when `access` is set to
        /// `open` or `company`.
        /// </summary>
        [JsonPropertyName("can_download")]
        public bool? CanDownload { get; init; }

        public UpdateFolderByIdRequestBodySharedLinkPermissionsField() {
            
        }
    }
}