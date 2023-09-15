using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class UploadSession {
        /// <summary>
        /// The unique identifier for this session
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        /// <summary>
        /// `upload_session`
        /// </summary>
        [JsonPropertyName("type")]
        public UploadSessionTypeField? Type { get; set; } = default;

        /// <summary>
        /// The date and time when this session expires.
        /// </summary>
        [JsonPropertyName("session_expires_at")]
        public string? SessionExpiresAt { get; set; } = default;

        /// <summary>
        /// The  size in bytes that must be used for all parts of of the
        /// upload.
        /// 
        /// Only the last part is allowed to be of a smaller size.
        /// </summary>
        [JsonPropertyName("part_size")]
        public long? PartSize { get; set; } = default;

        /// <summary>
        /// The total number of parts expected in this upload session,
        /// as determined by the file size and part size.
        /// </summary>
        [JsonPropertyName("total_parts")]
        public int? TotalParts { get; set; } = default;

        /// <summary>
        /// The number of parts that have been uploaded and processed
        /// by the server. This starts at `0`.
        /// 
        /// When committing a file files, inspecting this property can
        /// provide insight if all parts have been uploaded correctly.
        /// </summary>
        [JsonPropertyName("num_parts_processed")]
        public int? NumPartsProcessed { get; set; } = default;

        [JsonPropertyName("session_endpoints")]
        public UploadSessionSessionEndpointsField? SessionEndpoints { get; set; } = default;

        public UploadSession() {
            
        }
    }
}