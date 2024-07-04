using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class Folder : FolderMini {
        /// <summary>
        /// The date and time when the folder was created. This value may
        /// be `null` for some folders such as the root folder or the trash
        /// folder.
        /// </summary>
        [JsonPropertyName("created_at")]
        public System.DateTimeOffset? CreatedAt { get; init; }

        /// <summary>
        /// The date and time when the folder was last updated. This value may
        /// be `null` for some folders such as the root folder or the trash
        /// folder.
        /// </summary>
        [JsonPropertyName("modified_at")]
        public System.DateTimeOffset? ModifiedAt { get; init; }

        [JsonPropertyName("description")]
        public string? Description { get; init; }

        /// <summary>
        /// The folder size in bytes.
        /// 
        /// Be careful parsing this integer as its
        /// value can get very large.
        /// </summary>
        [JsonPropertyName("size")]
        public long? Size { get; init; }

        [JsonPropertyName("path_collection")]
        public FolderPathCollectionField? PathCollection { get; init; }

        [JsonPropertyName("created_by")]
        public UserMini? CreatedBy { get; init; }

        [JsonPropertyName("modified_by")]
        public UserMini? ModifiedBy { get; init; }

        /// <summary>
        /// The time at which this folder was put in the trash.
        /// </summary>
        [JsonPropertyName("trashed_at")]
        public System.DateTimeOffset? TrashedAt { get; init; }

        /// <summary>
        /// The time at which this folder is expected to be purged
        /// from the trash.
        /// </summary>
        [JsonPropertyName("purged_at")]
        public System.DateTimeOffset? PurgedAt { get; init; }

        /// <summary>
        /// The date and time at which this folder was originally
        /// created.
        /// </summary>
        [JsonPropertyName("content_created_at")]
        public System.DateTimeOffset? ContentCreatedAt { get; init; }

        /// <summary>
        /// The date and time at which this folder was last updated.
        /// </summary>
        [JsonPropertyName("content_modified_at")]
        public System.DateTimeOffset? ContentModifiedAt { get; init; }

        [JsonPropertyName("owned_by")]
        public UserMini? OwnedBy { get; init; }

        [JsonPropertyName("shared_link")]
        public FolderSharedLinkField? SharedLink { get; init; }

        /// <summary>
        /// The `folder_upload_email` parameter is not `null` if one of the following options is **true**:
        /// 
        ///   * The **Allow uploads to this folder via email** and the **Only allow email uploads from collaborators in this folder** are [enabled for a folder in the Admin Console](https://support.box.com/hc/en-us/articles/360043697534-Upload-to-Box-Through-Email), and the user has at least **Upload** permissions granted.
        /// 
        ///   * The **Allow uploads to this folder via email** setting is enabled for a folder in the Admin Console, and the **Only allow email uploads from collaborators in this folder** setting is deactivated (unchecked).
        /// 
        /// If the conditions are not met, the parameter will have the following value: `folder_upload_email: null`
        /// </summary>
        [JsonPropertyName("folder_upload_email")]
        public FolderFolderUploadEmailField? FolderUploadEmail { get; init; }

        [JsonPropertyName("parent")]
        public FolderMini? Parent { get; init; }

        /// <summary>
        /// Defines if this item has been deleted or not.
        /// 
        /// * `active` when the item has is not in the trash
        /// * `trashed` when the item has been moved to the trash but not deleted
        /// * `deleted` when the item has been permanently deleted.
        /// </summary>
        [JsonPropertyName("item_status")]
        [JsonConverter(typeof(StringEnumConverter<FolderItemStatusField>))]
        public StringEnum<FolderItemStatusField>? ItemStatus { get; init; }

        [JsonPropertyName("item_collection")]
        public Items? ItemCollection { get; init; }

        public Folder(string id, FolderBaseTypeField type = FolderBaseTypeField.Folder) : base(id, type) {
            
        }
        
        [JsonConstructorAttribute]
        internal Folder(string id, StringEnum<FolderBaseTypeField> type) : base(id, type ?? new StringEnum<FolderBaseTypeField>(FolderBaseTypeField.Folder)) {
            
        }
    }
}