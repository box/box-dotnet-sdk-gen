using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class SignRequest : SignRequestBase {
        /// <summary>
        /// object type
        /// </summary>
        [JsonPropertyName("type")]
        public SignRequestTypeField? Type { get; set; } = default;

        /// <summary>
        /// List of files to create a signing document from. This is currently limited to ten files. Only the ID and type fields are required for each file.
        /// </summary>
        [JsonPropertyName("source_files")]
        public IReadOnlyList<FileBase>? SourceFiles { get; set; } = default;

        /// <summary>
        /// Array of signers for the sign request
        /// </summary>
        [JsonPropertyName("signers")]
        public IReadOnlyList<SignRequestSigner>? Signers { get; set; } = default;

        /// <summary>
        /// Force a specific color for the signature (blue, black, or red).
        /// </summary>
        [JsonPropertyName("signature_color")]
        public string? SignatureColor { get; set; } = default;

        /// <summary>
        /// Sign request ID
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; } = default;

        /// <summary>
        /// This URL is returned if `is_document_preparation_needed` is
        /// set to `true` in the request. It is used to prepare the sign request
        /// via UI. The sign request is not sent until preparation is complete.
        /// </summary>
        [JsonPropertyName("prepare_url")]
        public string? PrepareUrl { get; set; } = default;

        [JsonPropertyName("signing_log")]
        public FileMini? SigningLog { get; set; } = default;

        /// <summary>
        /// Describes the status of the sign request
        /// </summary>
        [JsonPropertyName("status")]
        public SignRequestStatusField? Status { get; set; } = default;

        /// <summary>
        /// List of files that will be signed, which are copies of the original
        /// source files. A new version of these files are created as signers sign
        /// and can be downloaded at any point in the signing process.
        /// </summary>
        [JsonPropertyName("sign_files")]
        public SignRequestSignFilesField? SignFiles { get; set; } = default;

        /// <summary>
        /// Uses `days_valid` to calculate the date and time, in GMT, the sign request will expire if unsigned.
        /// </summary>
        [JsonPropertyName("auto_expire_at")]
        public string? AutoExpireAt { get; set; } = default;

        public SignRequest(FolderMini parentFolder) : base(parentFolder) {
            
        }
    }
}