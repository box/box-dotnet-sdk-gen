using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class FolderFullPermissionsField {
        [JsonPropertyName("can_delete")]
        public bool CanDelete { get; }

        [JsonPropertyName("can_download")]
        public bool CanDownload { get; }

        [JsonPropertyName("can_invite_collaborator")]
        public bool CanInviteCollaborator { get; }

        [JsonPropertyName("can_rename")]
        public bool CanRename { get; }

        [JsonPropertyName("can_set_share_access")]
        public bool CanSetShareAccess { get; }

        [JsonPropertyName("can_share")]
        public bool CanShare { get; }

        [JsonPropertyName("can_upload")]
        public bool? CanUpload { get; }

        public FolderFullPermissionsField(bool canDelete, bool canDownload, bool canInviteCollaborator, bool canRename, bool canSetShareAccess, bool canShare, bool? canUpload) {
            CanDelete = canDelete;
            CanDownload = canDownload;
            CanInviteCollaborator = canInviteCollaborator;
            CanRename = canRename;
            CanSetShareAccess = canSetShareAccess;
            CanShare = canShare;
            CanUpload = canUpload;
        }
    }
}