using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class FileFull : File {
        [JsonPropertyName("version_number")]
        public string VersionNumber { get; }

        [JsonPropertyName("comment_count")]
        public int? CommentCount { get; }

        [JsonPropertyName("permissions")]
        public FileFullPermissionsField Permissions { get; }

        [JsonPropertyName("tags")]
        public IReadOnlyList<string> Tags { get; }

        [JsonPropertyName("lock")]
        public FileFullLockField Lock { get; }

        [JsonPropertyName("extension")]
        public string Extension { get; }

        [JsonPropertyName("is_package")]
        public bool? IsPackage { get; }

        [JsonPropertyName("expiring_embed_link")]
        public FileFullExpiringEmbedLinkField ExpiringEmbedLink { get; }

        [JsonPropertyName("watermark_info")]
        public FileFullWatermarkInfoField WatermarkInfo { get; }

        [JsonPropertyName("is_accessible_via_shared_link")]
        public bool? IsAccessibleViaSharedLink { get; }

        [JsonPropertyName("allowed_invitee_roles")]
        public IReadOnlyList<FileFullAllowedInviteeRolesField> AllowedInviteeRoles { get; }

        [JsonPropertyName("is_externally_owned")]
        public bool? IsExternallyOwned { get; }

        [JsonPropertyName("has_collaborations")]
        public bool? HasCollaborations { get; }

        [JsonPropertyName("metadata")]
        public FileFullMetadataField Metadata { get; }

        [JsonPropertyName("expires_at")]
        public string ExpiresAt { get; }

        [JsonPropertyName("representations")]
        public FileFullRepresentationsField Representations { get; }

        [JsonPropertyName("classification")]
        public FileFullClassificationField Classification { get; }

        [JsonPropertyName("uploader_display_name")]
        public string UploaderDisplayName { get; }

        [JsonPropertyName("disposition_at")]
        public string DispositionAt { get; }

        [JsonPropertyName("shared_link_permission_options")]
        public IReadOnlyList<FileFullSharedLinkPermissionOptionsField> SharedLinkPermissionOptions { get; }

        public FileFull(string id, string etag, FileBaseTypeField type, string sequenceId, string name, string sha1, FileVersionMini fileVersion, string description, int? size, FilePathCollectionField pathCollection, string createdAt, string modifiedAt, string trashedAt, string purgedAt, string contentCreatedAt, string contentModifiedAt, UserMini createdBy, UserMini modifiedBy, UserMini ownedBy, FileSharedLinkField sharedLink, FolderMini parent, FileItemStatusField itemStatus, string versionNumber, int? commentCount, FileFullPermissionsField permissions, IReadOnlyList<string> tags, FileFullLockField lockParam, string extension, bool? isPackage, FileFullExpiringEmbedLinkField expiringEmbedLink, FileFullWatermarkInfoField watermarkInfo, bool? isAccessibleViaSharedLink, IReadOnlyList<FileFullAllowedInviteeRolesField> allowedInviteeRoles, bool? isExternallyOwned, bool? hasCollaborations, FileFullMetadataField metadata, string expiresAt, FileFullRepresentationsField representations, FileFullClassificationField classification, string uploaderDisplayName, string dispositionAt, IReadOnlyList<FileFullSharedLinkPermissionOptionsField> sharedLinkPermissionOptions) : base(id, etag, type, sequenceId, name, sha1, fileVersion, description, size, pathCollection, createdAt, modifiedAt, trashedAt, purgedAt, contentCreatedAt, contentModifiedAt, createdBy, modifiedBy, ownedBy, sharedLink, parent, itemStatus) {
            VersionNumber = versionNumber;
            CommentCount = commentCount;
            Permissions = permissions;
            Tags = tags;
            Lock = lockParam;
            Extension = extension;
            IsPackage = isPackage;
            ExpiringEmbedLink = expiringEmbedLink;
            WatermarkInfo = watermarkInfo;
            IsAccessibleViaSharedLink = isAccessibleViaSharedLink;
            AllowedInviteeRoles = allowedInviteeRoles;
            IsExternallyOwned = isExternallyOwned;
            HasCollaborations = hasCollaborations;
            Metadata = metadata;
            ExpiresAt = expiresAt;
            Representations = representations;
            Classification = classification;
            UploaderDisplayName = uploaderDisplayName;
            DispositionAt = dispositionAt;
            SharedLinkPermissionOptions = sharedLinkPermissionOptions;
        }
    }
}