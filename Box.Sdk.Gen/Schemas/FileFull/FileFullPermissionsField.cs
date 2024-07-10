using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class FileFullPermissionsField {
        /// <summary>
        /// Specifies if the current user can delete this item.
        /// </summary>
        [JsonPropertyName("can_delete")]
        public bool CanDelete { get; }

        /// <summary>
        /// Specifies if the current user can download this item.
        /// </summary>
        [JsonPropertyName("can_download")]
        public bool CanDownload { get; }

        /// <summary>
        /// Specifies if the current user can invite new
        /// users to collaborate on this item, and if the user can
        /// update the role of a user already collaborated on this
        /// item.
        /// </summary>
        [JsonPropertyName("can_invite_collaborator")]
        public bool CanInviteCollaborator { get; }

        /// <summary>
        /// Specifies if the user can rename this item.
        /// </summary>
        [JsonPropertyName("can_rename")]
        public bool CanRename { get; }

        /// <summary>
        /// Specifies if the user can change the access level of an
        /// existing shared link on this item.
        /// </summary>
        [JsonPropertyName("can_set_share_access")]
        public bool CanSetShareAccess { get; }

        /// <summary>
        /// Specifies if the user can create a shared link for this item.
        /// </summary>
        [JsonPropertyName("can_share")]
        public bool CanShare { get; }

        /// <summary>
        /// Specifies if the user can place annotations on this file.
        /// </summary>
        [JsonPropertyName("can_annotate")]
        public bool? CanAnnotate { get; init; }

        /// <summary>
        /// Specifies if the user can place comments on this file.
        /// </summary>
        [JsonPropertyName("can_comment")]
        public bool? CanComment { get; init; }

        /// <summary>
        /// Specifies if the user can preview this file.
        /// </summary>
        [JsonPropertyName("can_preview")]
        public bool? CanPreview { get; init; }

        /// <summary>
        /// Specifies if the user can upload a new version of this file.
        /// </summary>
        [JsonPropertyName("can_upload")]
        public bool? CanUpload { get; init; }

        /// <summary>
        /// Specifies if the user view all annotations placed on this file
        /// </summary>
        [JsonPropertyName("can_view_annotations_all")]
        public bool? CanViewAnnotationsAll { get; init; }

        /// <summary>
        /// Specifies if the user view annotations placed by themselves
        /// on this file
        /// </summary>
        [JsonPropertyName("can_view_annotations_self")]
        public bool? CanViewAnnotationsSelf { get; init; }

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