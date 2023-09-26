using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class FileFullPermissionsField {
        /// <summary>
        /// Specifies if the current user can delete this item.
        /// </summary>
        [JsonPropertyName("can_delete")]
        public bool CanDelete { get; set; }

        /// <summary>
        /// Specifies if the current user can download this item.
        /// </summary>
        [JsonPropertyName("can_download")]
        public bool CanDownload { get; set; }

        /// <summary>
        /// Specifies if the current user can invite new
        /// users to collaborate on this item, and if the user can
        /// update the role of a user already collaborated on this
        /// item.
        /// </summary>
        [JsonPropertyName("can_invite_collaborator")]
        public bool CanInviteCollaborator { get; set; }

        /// <summary>
        /// Specifies if the user can rename this item.
        /// </summary>
        [JsonPropertyName("can_rename")]
        public bool CanRename { get; set; }

        /// <summary>
        /// Specifies if the user can change the access level of an
        /// existing shared link on this item.
        /// </summary>
        [JsonPropertyName("can_set_share_access")]
        public bool CanSetShareAccess { get; set; }

        /// <summary>
        /// Specifies if the user can create a shared link for this item.
        /// </summary>
        [JsonPropertyName("can_share")]
        public bool CanShare { get; set; }

        /// <summary>
        /// Specifies if the user can place annotations on this file.
        /// </summary>
        [JsonPropertyName("can_annotate")]
        public bool? CanAnnotate { get; set; } = default;

        /// <summary>
        /// Specifies if the user can place comments on this file.
        /// </summary>
        [JsonPropertyName("can_comment")]
        public bool? CanComment { get; set; } = default;

        /// <summary>
        /// Specifies if the user can preview this file.
        /// </summary>
        [JsonPropertyName("can_preview")]
        public bool? CanPreview { get; set; } = default;

        /// <summary>
        /// Specifies if the user can upload a new version of this file.
        /// </summary>
        [JsonPropertyName("can_upload")]
        public bool? CanUpload { get; set; } = default;

        /// <summary>
        /// Specifies if the user view all annotations placed on this file
        /// </summary>
        [JsonPropertyName("can_view_annotations_all")]
        public bool? CanViewAnnotationsAll { get; set; } = default;

        /// <summary>
        /// Specifies if the user view annotations placed by themselves
        /// on this file
        /// </summary>
        [JsonPropertyName("can_view_annotations_self")]
        public bool? CanViewAnnotationsSelf { get; set; } = default;

        public FileFullPermissionsField(bool canDelete, bool canDownload, bool canInviteCollaborator, bool canRename, bool canSetShareAccess, bool canShare) {
            CanDelete = canDelete;
            CanDownload = canDownload;
            CanInviteCollaborator = canInviteCollaborator;
            CanRename = canRename;
            CanSetShareAccess = canSetShareAccess;
            CanShare = canShare;
        }
    }
}