using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen;
using Serializer;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class UpdateFileByIdRequestBodyLockField {
        /// <summary>
        /// The type of this object.
        /// </summary>
        [JsonPropertyName("access")]
        [JsonConverter(typeof(StringEnumConverter<UpdateFileByIdRequestBodyLockAccessField>))]
        public StringEnum<UpdateFileByIdRequestBodyLockAccessField>? Access { get; init; }

        /// <summary>
        /// Defines the time at which the lock expires.
        /// </summary>
        [JsonPropertyName("expires_at")]
        public System.DateTimeOffset? ExpiresAt { get; init; }

        /// <summary>
        /// Defines if the file can be downloaded while it is locked.
        /// </summary>
        [JsonPropertyName("is_download_prevented")]
        public bool? IsDownloadPrevented { get; init; }

        public UpdateFileByIdRequestBodyLockField() {
            
        }
    }
}