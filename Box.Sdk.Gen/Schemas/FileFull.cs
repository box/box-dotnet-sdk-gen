using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class FileFull : File {
        /// <summary>
        /// The version number of this file
        /// </summary>
        [JsonPropertyName("version_number")]
        public string? VersionNumber { get; set; } = default;

        /// <summary>
        /// The number of comments on this file
        /// </summary>
        [JsonPropertyName("comment_count")]
        public long? CommentCount { get; set; } = default;

        [JsonPropertyName("permissions")]
        public FileFullPermissionsField? Permissions { get; set; } = default;

        [JsonPropertyName("tags")]
        public IReadOnlyList<string>? Tags { get; set; } = default;

        [JsonPropertyName("lock")]
        public FileFullLockField? Lock { get; set; } = default;

        /// <summary>
        /// Indicates the (optional) file extension for this file. By default,
        /// this is set to an empty string.
        /// </summary>
        [JsonPropertyName("extension")]
        public string? Extension { get; set; } = default;

        /// <summary>
        /// Indicates if the file is a package. Packages are commonly used
        /// by Mac Applications and can include iWork files.
        /// </summary>
        [JsonPropertyName("is_package")]
        public bool? IsPackage { get; set; } = default;

        [JsonPropertyName("expiring_embed_link")]
        public FileFullExpiringEmbedLinkField? ExpiringEmbedLink { get; set; } = default;

        [JsonPropertyName("watermark_info")]
        public FileFullWatermarkInfoField? WatermarkInfo { get; set; } = default;

        /// <summary>
        /// Specifies if the file can be accessed
        /// via the direct shared link or a shared link
        /// to a parent folder.
        /// </summary>
        [JsonPropertyName("is_accessible_via_shared_link")]
        public bool? IsAccessibleViaSharedLink { get; set; } = default;

        /// <summary>
        /// A list of the types of roles that user can be invited at
        /// when sharing this file.
        /// </summary>
        [JsonPropertyName("allowed_invitee_roles")]
        public IReadOnlyList<FileFullAllowedInviteeRolesField>? AllowedInviteeRoles { get; set; } = default;

        /// <summary>
        /// Specifies if this file is owned by a user outside of the
        /// authenticated enterprise.
        /// </summary>
        [JsonPropertyName("is_externally_owned")]
        public bool? IsExternallyOwned { get; set; } = default;

        /// <summary>
        /// Specifies if this file has any other collaborators.
        /// </summary>
        [JsonPropertyName("has_collaborations")]
        public bool? HasCollaborations { get; set; } = default;

        [JsonPropertyName("metadata")]
        public FileFullMetadataField? Metadata { get; set; } = default;

        /// <summary>
        /// When the file will automatically be deleted
        /// </summary>
        [JsonPropertyName("expires_at")]
        public System.DateTimeOffset? ExpiresAt { get; set; } = default;

        [JsonPropertyName("representations")]
        public FileFullRepresentationsField? Representations { get; set; } = default;

        [JsonPropertyName("classification")]
        public FileFullClassificationField? Classification { get; set; } = default;

        [JsonPropertyName("uploader_display_name")]
        public string? UploaderDisplayName { get; set; } = default;

        /// <summary>
        /// The retention expiration timestamp for the given file
        /// </summary>
        [JsonPropertyName("disposition_at")]
        public System.DateTimeOffset? DispositionAt { get; set; } = default;

        /// <summary>
        /// A list of the types of roles that user can be invited at
        /// when sharing this file.
        /// </summary>
        [JsonPropertyName("shared_link_permission_options")]
        public IReadOnlyList<FileFullSharedLinkPermissionOptionsField>? SharedLinkPermissionOptions { get; set; } = default;

        public FileFull(string id, FileBaseTypeField type) : base(id, type) {
            
        }
    }
}