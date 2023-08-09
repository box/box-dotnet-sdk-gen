using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateFolderByIdRequestBodyArg {
        [JsonPropertyName("name")]
        public string Name { get; }

        [JsonPropertyName("description")]
        public string Description { get; }

        [JsonPropertyName("sync_state")]
        public UpdateFolderByIdRequestBodyArgSyncStateField SyncState { get; }

        [JsonPropertyName("can_non_owners_invite")]
        public bool? CanNonOwnersInvite { get; }

        [JsonPropertyName("parent")]
        public UpdateFolderByIdRequestBodyArgParentField Parent { get; }

        [JsonPropertyName("shared_link")]
        public UpdateFolderByIdRequestBodyArgSharedLinkField SharedLink { get; }

        [JsonPropertyName("folder_upload_email")]
        public UpdateFolderByIdRequestBodyArgFolderUploadEmailField FolderUploadEmail { get; }

        [JsonPropertyName("tags")]
        public IReadOnlyList<string> Tags { get; }

        [JsonPropertyName("is_collaboration_restricted_to_enterprise")]
        public bool? IsCollaborationRestrictedToEnterprise { get; }

        [JsonPropertyName("collections")]
        public IReadOnlyList<UpdateFolderByIdRequestBodyArgCollectionsField> Collections { get; }

        [JsonPropertyName("can_non_owners_view_collaborators")]
        public bool? CanNonOwnersViewCollaborators { get; }

        public UpdateFolderByIdRequestBodyArg(string name, string description, UpdateFolderByIdRequestBodyArgSyncStateField syncState, bool? canNonOwnersInvite, UpdateFolderByIdRequestBodyArgParentField parent, UpdateFolderByIdRequestBodyArgSharedLinkField sharedLink, UpdateFolderByIdRequestBodyArgFolderUploadEmailField folderUploadEmail, IReadOnlyList<string> tags, bool? isCollaborationRestrictedToEnterprise, IReadOnlyList<UpdateFolderByIdRequestBodyArgCollectionsField> collections, bool? canNonOwnersViewCollaborators) {
            Name = name;
            Description = description;
            SyncState = syncState;
            CanNonOwnersInvite = canNonOwnersInvite;
            Parent = parent;
            SharedLink = sharedLink;
            FolderUploadEmail = folderUploadEmail;
            Tags = tags;
            IsCollaborationRestrictedToEnterprise = isCollaborationRestrictedToEnterprise;
            Collections = collections;
            CanNonOwnersViewCollaborators = canNonOwnersViewCollaborators;
        }
    }
}