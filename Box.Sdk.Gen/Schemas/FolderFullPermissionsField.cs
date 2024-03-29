using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class FolderFullPermissionsField {
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
        /// Specifies if the user can upload into this folder.
        /// </summary>
        [JsonPropertyName("can_upload")]
        public bool? CanUpload { get; set; } = default;

        public FolderFullPermissionsField(bool canDelete, bool canDownload, bool canInviteCollaborator, bool canRename, bool canSetShareAccess, bool canShare) {
            CanDelete = canDelete;
            CanDownload = canDownload;
            CanInviteCollaborator = canInviteCollaborator;
            CanRename = canRename;
            CanSetShareAccess = canSetShareAccess;
            CanShare = canShare;
        }
    }
}