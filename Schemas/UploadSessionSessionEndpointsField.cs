using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class UploadSessionSessionEndpointsField {
        [JsonPropertyName("upload_part")]
        public string UploadPart { get; }

        [JsonPropertyName("commit")]
        public string Commit { get; }

        [JsonPropertyName("abort")]
        public string Abort { get; }

        [JsonPropertyName("list_parts")]
        public string ListParts { get; }

        [JsonPropertyName("status")]
        public string Status { get; }

        [JsonPropertyName("log_event")]
        public string LogEvent { get; }

        public UploadSessionSessionEndpointsField(string uploadPart, string commit, string abort, string listParts, string status, string logEvent) {
            UploadPart = uploadPart;
            Commit = commit;
            Abort = abort;
            ListParts = listParts;
            Status = status;
            LogEvent = logEvent;
        }
    }
}