using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class FolderFolderUploadEmailField {
        [JsonPropertyName("access")]
        public FolderFolderUploadEmailFieldAccessField Access { get; }

        [JsonPropertyName("email")]
        public string Email { get; }

        public FolderFolderUploadEmailField(FolderFolderUploadEmailFieldAccessField access, string email) {
            Access = access;
            Email = email;
        }
    }
}