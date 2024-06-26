using Unions;
using System.Text.Json.Serialization;
using Box.Sdk.Gen;
using Serializer;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;
using System.Linq;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class FileFull : File {
        /// <summary>
        /// The version number of this file
        /// </summary>
        [JsonPropertyName("version_number")]
        public string? VersionNumber { get; init; }

        /// <summary>
        /// The number of comments on this file
        /// </summary>
        [JsonPropertyName("comment_count")]
        public long? CommentCount { get; init; }

        [JsonPropertyName("permissions")]
        public FileFullPermissionsField? Permissions { get; init; }

        [JsonPropertyName("tags")]
        public IReadOnlyList<string>? Tags { get; init; }

        [JsonPropertyName("lock")]
        public FileFullLockField? Lock { get; init; }

        /// <summary>
        /// Indicates the (optional) file extension for this file. By default,
        /// this is set to an empty string.
        /// </summary>
        [JsonPropertyName("extension")]
        public string? Extension { get; init; }

        /// <summary>
        /// Indicates if the file is a package. Packages are commonly used
        /// by Mac Applications and can include iWork files.
        /// </summary>
        [JsonPropertyName("is_package")]
        public bool? IsPackage { get; init; }

        [JsonPropertyName("expiring_embed_link")]
        public FileFullExpiringEmbedLinkField? ExpiringEmbedLink { get; init; }

        [JsonPropertyName("watermark_info")]
        public FileFullWatermarkInfoField? WatermarkInfo { get; init; }

        /// <summary>
        /// Specifies if the file can be accessed
        /// via the direct shared link or a shared link
        /// to a parent folder.
        /// </summary>
        [JsonPropertyName("is_accessible_via_shared_link")]
        public bool? IsAccessibleViaSharedLink { get; init; }

        /// <summary>
        /// A list of the types of roles that user can be invited at
        /// when sharing this file.
        /// </summary>
        [JsonPropertyName("allowed_invitee_roles")]
        [JsonConverter(typeof(StringEnumListConverter<FileFullAllowedInviteeRolesField>))]
        public IReadOnlyList<StringEnum<FileFullAllowedInviteeRolesField>> AllowedInviteeRoles { get; init; }

        /// <summary>
        /// Specifies if this file is owned by a user outside of the
        /// authenticated enterprise.
        /// </summary>
        [JsonPropertyName("is_externally_owned")]
        public bool? IsExternallyOwned { get; init; }

        /// <summary>
        /// Specifies if this file has any other collaborators.
        /// </summary>
        [JsonPropertyName("has_collaborations")]
        public bool? HasCollaborations { get; init; }

        [JsonPropertyName("metadata")]
        public FileFullMetadataField? Metadata { get; init; }

        /// <summary>
        /// When the file will automatically be deleted
        /// </summary>
        [JsonPropertyName("expires_at")]
        public System.DateTimeOffset? ExpiresAt { get; init; }

        [JsonPropertyName("representations")]
        public FileFullRepresentationsField? Representations { get; init; }

        [JsonPropertyName("classification")]
        public FileFullClassificationField? Classification { get; init; }

        [JsonPropertyName("uploader_display_name")]
        public string? UploaderDisplayName { get; init; }

        /// <summary>
        /// The retention expiration timestamp for the given file
        /// </summary>
        [JsonPropertyName("disposition_at")]
        public System.DateTimeOffset? DispositionAt { get; init; }

        /// <summary>
        /// A list of the types of roles that user can be invited at
        /// when sharing this file.
        /// </summary>
        [JsonPropertyName("shared_link_permission_options")]
        [JsonConverter(typeof(StringEnumListConverter<FileFullSharedLinkPermissionOptionsField>))]
        public IReadOnlyList<StringEnum<FileFullSharedLinkPermissionOptionsField>> SharedLinkPermissionOptions { get; init; }

        public FileFull(string id, FileBaseTypeField type = FileBaseTypeField.File) : base(id, type) {
            
        }
        
        [JsonConstructorAttribute]
        internal FileFull(string id, StringEnum<FileBaseTypeField> type) : base(id, type ?? new StringEnum<FileBaseTypeField>(FileBaseTypeField.File)) {
            
        }
    }
}