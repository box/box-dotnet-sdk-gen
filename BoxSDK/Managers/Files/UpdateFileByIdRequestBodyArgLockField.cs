using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateFileByIdRequestBodyArgLockField {
        /// <summary>
        /// The type of this object.
        /// </summary>
        [JsonPropertyName("access")]
        public UpdateFileByIdRequestBodyArgLockFieldAccessField? Access { get; set; } = default;

        /// <summary>
        /// Defines the time at which the lock expires.
        /// </summary>
        [JsonPropertyName("expires_at")]
        public string? ExpiresAt { get; set; } = default;

        /// <summary>
        /// Defines if the file can be downloaded while it is locked.
        /// </summary>
        [JsonPropertyName("is_download_prevented")]
        public bool? IsDownloadPrevented { get; set; } = default;

        public UpdateFileByIdRequestBodyArgLockField() {
            
        }
    }
}