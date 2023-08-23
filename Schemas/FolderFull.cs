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
        public FolderFullSyncStateField SyncState { get; }

        [JsonPropertyName("has_collaborations")]
        public bool? HasCollaborations { get; }

        [JsonPropertyName("permissions")]
        public FolderFullPermissionsField Permissions { get; }

        [JsonPropertyName("tags")]
        public IReadOnlyList<string> Tags { get; }

        [JsonPropertyName("can_non_owners_invite")]
        public bool? CanNonOwnersInvite { get; }

        [JsonPropertyName("is_externally_owned")]
        public bool? IsExternallyOwned { get; }

        [JsonPropertyName("metadata")]
        public FolderFullMetadataField Metadata { get; }

        [JsonPropertyName("is_collaboration_restricted_to_enterprise")]
        public bool? IsCollaborationRestrictedToEnterprise { get; }

        [JsonPropertyName("allowed_shared_link_access_levels")]
        public IReadOnlyList<FolderFullAllowedSharedLinkAccessLevelsField> AllowedSharedLinkAccessLevels { get; }

        [JsonPropertyName("allowed_invitee_roles")]
        public IReadOnlyList<FolderFullAllowedInviteeRolesField> AllowedInviteeRoles { get; }

        [JsonPropertyName("watermark_info")]
        public FolderFullWatermarkInfoField WatermarkInfo { get; }

        [JsonPropertyName("is_accessible_via_shared_link")]
        public bool? IsAccessibleViaSharedLink { get; }

        [JsonPropertyName("can_non_owners_view_collaborators")]
        public bool? CanNonOwnersViewCollaborators { get; }

        [JsonPropertyName("classification")]
        public FolderFullClassificationField Classification { get; }

        public FolderFull(string id, string etag, FolderBaseTypeField type, string name, string sequenceId, string createdAt, string modifiedAt, string description, long? size, FolderPathCollectionField pathCollection, UserMini createdBy, UserMini modifiedBy, string trashedAt, string purgedAt, string contentCreatedAt, string contentModifiedAt, UserMini ownedBy, FolderSharedLinkField sharedLink, FolderFolderUploadEmailField folderUploadEmail, FolderMini parent, FolderItemStatusField itemStatus, Items itemCollection, FolderFullSyncStateField syncState, bool? hasCollaborations, FolderFullPermissionsField permissions, IReadOnlyList<string> tags, bool? canNonOwnersInvite, bool? isExternallyOwned, FolderFullMetadataField metadata, bool? isCollaborationRestrictedToEnterprise, IReadOnlyList<FolderFullAllowedSharedLinkAccessLevelsField> allowedSharedLinkAccessLevels, IReadOnlyList<FolderFullAllowedInviteeRolesField> allowedInviteeRoles, FolderFullWatermarkInfoField watermarkInfo, bool? isAccessibleViaSharedLink, bool? canNonOwnersViewCollaborators, FolderFullClassificationField classification) : base(id, etag, type, name, sequenceId, createdAt, modifiedAt, description, size, pathCollection, createdBy, modifiedBy, trashedAt, purgedAt, contentCreatedAt, contentModifiedAt, ownedBy, sharedLink, folderUploadEmail, parent, itemStatus, itemCollection) {
            SyncState = syncState;
            HasCollaborations = hasCollaborations;
            Permissions = permissions;
            Tags = tags;
            CanNonOwnersInvite = canNonOwnersInvite;
            IsExternallyOwned = isExternallyOwned;
            Metadata = metadata;
            IsCollaborationRestrictedToEnterprise = isCollaborationRestrictedToEnterprise;
            AllowedSharedLinkAccessLevels = allowedSharedLinkAccessLevels;
            AllowedInviteeRoles = allowedInviteeRoles;
            WatermarkInfo = watermarkInfo;
            IsAccessibleViaSharedLink = isAccessibleViaSharedLink;
            CanNonOwnersViewCollaborators = canNonOwnersViewCollaborators;
            Classification = classification;
        }
    }
}