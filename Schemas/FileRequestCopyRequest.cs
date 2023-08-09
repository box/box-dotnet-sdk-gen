using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class FileRequestCopyRequest : FileRequestUpdateRequest {
        [JsonPropertyName("folder")]
        public FileRequestCopyRequestFolderField Folder { get; }

        public FileRequestCopyRequest(string title, string description, FileRequestUpdateRequestStatusField status, bool? isEmailRequired, bool? isDescriptionRequired, string expiresAt, FileRequestCopyRequestFolderField folder) : base(title, description, status, isEmailRequired, isDescriptionRequired, expiresAt) {
            Folder = folder;
        }
    }
}