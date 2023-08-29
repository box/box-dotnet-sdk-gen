using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class FolderFull : Folder {
        [JsonPropertyName("sync_state")]
        public FolderFullSyncStateField? SyncState { get; set; } = default;

        /// <summary>
        /// Specifies if this folder has any other collaborators.
        /// </summary>
        [JsonPropertyName("has_collaborations")]
        public bool? HasCollaborations { get; set; } = default;

        [JsonPropertyName("permissions")]
        public FolderFullPermissionsField? Permissions { get; set; } = default;

        [JsonPropertyName("tags")]
        public IReadOnlyList<string>? Tags { get; set; } = default;

        [JsonPropertyName("can_non_owners_invite")]
        public bool? CanNonOwnersInvite { get; set; } = default;

        /// <summary>
        /// Specifies if this folder is owned by a user outside of the
        /// authenticated enterprise.
        /// </summary>
        [JsonPropertyName("is_externally_owned")]
        public bool? IsExternallyOwned { get; set; } = default;

        [JsonPropertyName("metadata")]
        public FolderFullMetadataField? Metadata { get; set; } = default;

        [JsonPropertyName("is_collaboration_restricted_to_enterprise")]
        public bool? IsCollaborationRestrictedToEnterprise { get; set; } = default;

        /// <summary>
        /// A list of access levels that are available
        /// for this folder.
        /// 
        /// For some folders, like the root folder, this will always
        /// be an empty list as sharing is not allowed at that level.
        /// </summary>
        [JsonPropertyName("allowed_shared_link_access_levels")]
        public IReadOnlyList<FolderFullAllowedSharedLinkAccessLevelsField>? AllowedSharedLinkAccessLevels { get; set; } = default;

        /// <summary>
        /// A list of the types of roles that user can be invited at
        /// when sharing this folder.
        /// </summary>
        [JsonPropertyName("allowed_invitee_roles")]
        public IReadOnlyList<FolderFullAllowedInviteeRolesField>? AllowedInviteeRoles { get; set; } = default;

        [JsonPropertyName("watermark_info")]
        public FolderFullWatermarkInfoField? WatermarkInfo { get; set; } = default;

        /// <summary>
        /// Specifies if the folder can be accessed
        /// with the direct shared link or a shared link
        /// to a parent folder.
        /// </summary>
        [JsonPropertyName("is_accessible_via_shared_link")]
        public bool? IsAccessibleViaSharedLink { get; set; } = default;

        /// <summary>
        /// Specifies if collaborators who are not owners
        /// of this folder are restricted from viewing other
        /// collaborations on this folder.
        /// 
        /// It also restricts non-owners from inviting new
        /// collaborators.
        /// </summary>
        [JsonPropertyName("can_non_owners_view_collaborators")]
        public bool? CanNonOwnersViewCollaborators { get; set; } = default;

        [JsonPropertyName("classification")]
        public FolderFullClassificationField? Classification { get; set; } = default;

        public FolderFull(string id, FolderBaseTypeField type) : base(id, type) {
            
        }
    }
}