using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class FileRequest {
        /// <summary>
        /// The unique identifier for this file request.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        /// <summary>
        /// `file_request`
        /// </summary>
        [JsonPropertyName("type")]
        public FileRequestTypeField? Type { get; set; } = default;

        /// <summary>
        /// The title of file request. This is shown
        /// in the Box UI to users uploading files.
        /// 
        /// This defaults to title of the file request that was
        /// copied to create this file request.
        /// </summary>
        [JsonPropertyName("title")]
        public string? Title { get; set; } = default;

        /// <summary>
        /// The optional description of this file request. This is
        /// shown in the Box UI to users uploading files.
        /// 
        /// This defaults to description of the file request that was
        /// copied to create this file request.
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; } = default;

        /// <summary>
        /// The status of the file request. This defaults
        /// to `active`.
        /// 
        /// When the status is set to `inactive`, the file request
        /// will no longer accept new submissions, and any visitor
        /// to the file request URL will receive a `HTTP 404` status
        /// code.
        /// 
        /// This defaults to status of file request that was
        /// copied to create this file request.
        /// </summary>
        [JsonPropertyName("status")]
        public FileRequestStatusField? Status { get; set; } = default;

        /// <summary>
        /// Whether a file request submitter is required to provide
        /// their email address.
        /// 
        /// When this setting is set to true, the Box UI will show
        /// an email field on the file request form.
        /// 
        /// This defaults to setting of file request that was
        /// copied to create this file request.
        /// </summary>
        [JsonPropertyName("is_email_required")]
        public bool? IsEmailRequired { get; set; } = default;

        /// <summary>
        /// Whether a file request submitter is required to provide
        /// a description of the files they are submitting.
        /// 
        /// When this setting is set to true, the Box UI will show
        /// a description field on the file request form.
        /// 
        /// This defaults to setting of file request that was
        /// copied to create this file request.
        /// </summary>
        [JsonPropertyName("is_description_required")]
        public bool? IsDescriptionRequired { get; set; } = default;

        /// <summary>
        /// The date after which a file request will no longer accept new
        /// submissions.
        /// 
        /// After this date, the `status` will automatically be set to
        /// `inactive`.
        /// </summary>
        [JsonPropertyName("expires_at")]
        public string? ExpiresAt { get; set; } = default;

        [JsonPropertyName("folder")]
        public FolderMini Folder { get; set; }

        /// <summary>
        /// The generated URL for this file request. This URL can be shared
        /// with users to let them upload files to the associated folder.
        /// </summary>
        [JsonPropertyName("url")]
        public string? Url { get; set; } = default;

        /// <summary>
        /// The HTTP `etag` of this file. This can be used in combination with
        /// the `If-Match` header when updating a file request. By providing that
        /// header, a change will only be performed on the  file request if the `etag`
        /// on the file request still matches the `etag` provided in the `If-Match`
        /// header.
        /// </summary>
        [JsonPropertyName("etag")]
        public string? Etag { get; set; } = default;

        [JsonPropertyName("created_by")]
        public UserMini? CreatedBy { get; set; } = default;

        /// <summary>
        /// The date and time when the file request was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; }

        [JsonPropertyName("updated_by")]
        public UserMini? UpdatedBy { get; set; } = default;

        /// <summary>
        /// The date and time when the file request was last updated.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public string UpdatedAt { get; set; }

        public FileRequest(FolderMini folder, string createdAt, string updatedAt) {
            Folder = folder;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }
    }
}