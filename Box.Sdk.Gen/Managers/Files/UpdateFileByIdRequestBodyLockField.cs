using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class UpdateFileByIdRequestBodyLockField {
        /// <summary>
        /// The type of this object.
        /// </summary>
        [JsonPropertyName("access")]
        public UpdateFileByIdRequestBodyLockAccessField? Access { get; set; } = default;

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

        public UpdateFileByIdRequestBodyLockField() {
            
        }
    }
}