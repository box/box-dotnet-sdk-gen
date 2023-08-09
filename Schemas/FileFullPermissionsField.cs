using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class FileFullPermissionsField {
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

        [JsonPropertyName("can_annotate")]
        public bool? CanAnnotate { get; }

        [JsonPropertyName("can_comment")]
        public bool? CanComment { get; }

        [JsonPropertyName("can_preview")]
        public bool? CanPreview { get; }

        [JsonPropertyName("can_upload")]
        public bool? CanUpload { get; }

        [JsonPropertyName("can_view_annotations_all")]
        public bool? CanViewAnnotationsAll { get; }

        [JsonPropertyName("can_view_annotations_self")]
        public bool? CanViewAnnotationsSelf { get; }

        public FileFullPermissionsField(bool canDelete, bool canDownload, bool canInviteCollaborator, bool canRename, bool canSetShareAccess, bool canShare, bool? canAnnotate, bool? canComment, bool? canPreview, bool? canUpload, bool? canViewAnnotationsAll, bool? canViewAnnotationsSelf) {
            CanDelete = canDelete;
            CanDownload = canDownload;
            CanInviteCollaborator = canInviteCollaborator;
            CanRename = canRename;
            CanSetShareAccess = canSetShareAccess;
            CanShare = canShare;
            CanAnnotate = canAnnotate;
            CanComment = canComment;
            CanPreview = canPreview;
            CanUpload = canUpload;
            CanViewAnnotationsAll = canViewAnnotationsAll;
            CanViewAnnotationsSelf = canViewAnnotationsSelf;
        }
    }
}