using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class UploadSessionSessionEndpointsField {
        /// <summary>
        /// The URL to upload parts to
        /// </summary>
        [JsonPropertyName("upload_part")]
        public string? UploadPart { get; set; } = default;

        /// <summary>
        /// The URL used to commit the file
        /// </summary>
        [JsonPropertyName("commit")]
        public string? Commit { get; set; } = default;

        /// <summary>
        /// The URL for used to abort the session.
        /// </summary>
        [JsonPropertyName("abort")]
        public string? Abort { get; set; } = default;

        /// <summary>
        /// The URL users to list all parts.
        /// </summary>
        [JsonPropertyName("list_parts")]
        public string? ListParts { get; set; } = default;

        /// <summary>
        /// The URL used to get the status of the upload.
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; } = default;

        /// <summary>
        /// The URL used to get the upload log from.
        /// </summary>
        [JsonPropertyName("log_event")]
        public string? LogEvent { get; set; } = default;

        public UploadSessionSessionEndpointsField() {
            
        }
    }
}