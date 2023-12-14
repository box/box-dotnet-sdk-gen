using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UploadFileHeaders {
        /// <summary>
        /// An optional header containing the SHA1 hash of the file to
        /// ensure that the file was not corrupted in transit.
        /// </summary>
        public string? ContentMd5 { get; set; } = default;

        /// <summary>
        /// Extra headers that will be included in the HTTP request.
        /// </summary>
        public Dictionary<string, string?> ExtraHeaders { get; set; } = new Dictionary<string, string?>() {  };

        public UploadFileHeaders() {
            
        }
    }
}