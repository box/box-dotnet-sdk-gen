using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class UpdateFileByIdRequestBodyPermissionsField {
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
        public UpdateFileByIdRequestBodyPermissionsCanDownloadField? CanDownload { get; set; } = default;

        public UpdateFileByIdRequestBodyPermissionsField() {
            
        }
    }
}