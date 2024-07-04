using Box.Sdk.Gen;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class SignRequest : SignRequestBase {
        /// <summary>
        /// object type
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(StringEnumConverter<SignRequestTypeField>))]
        public StringEnum<SignRequestTypeField>? Type { get; init; }

        /// <summary>
        /// List of files to create a signing document from. This is currently limited to ten files. Only the ID and type fields are required for each file.
        /// </summary>
        [JsonPropertyName("source_files")]
        public IReadOnlyList<FileBase>? SourceFiles { get; init; }

        /// <summary>
        /// Array of signers for the signature request.
        /// </summary>
        [JsonPropertyName("signers")]
        public IReadOnlyList<SignRequestSigner>? Signers { get; init; }

        /// <summary>
        /// Force a specific color for the signature (blue, black, or red).
        /// </summary>
        [JsonPropertyName("signature_color")]
        public string? SignatureColor { get; init; }

        /// <summary>
        /// Box Sign request ID.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; init; }

        /// <summary>
        /// This URL is returned if `is_document_preparation_needed` is
        /// set to `true` in the request. The parameter is used to prepare
        /// the signature request
        /// using the UI. The signature request is not
        /// sent until the preparation
        /// phase is complete.
        /// </summary>
        [JsonPropertyName("prepare_url")]
        public string? PrepareUrl { get; init; }

        [JsonPropertyName("signing_log")]
        public FileMini? SigningLog { get; init; }

        /// <summary>
        /// Describes the status of the signature request.
        /// </summary>
        [JsonPropertyName("status")]
        [JsonConverter(typeof(StringEnumConverter<SignRequestStatusField>))]
        public StringEnum<SignRequestStatusField>? Status { get; init; }

        /// <summary>
        /// List of files that will be signed, which are copies of the original
        /// source files. A new version of these files are created as signers sign
        /// and can be downloaded at any point in the signing process.
        /// </summary>
        [JsonPropertyName("sign_files")]
        public SignRequestSignFilesField? SignFiles { get; init; }

        /// <summary>
        /// Uses `days_valid` to calculate the date and time, in GMT, the sign request will expire if unsigned.
        /// </summary>
        [JsonPropertyName("auto_expire_at")]
        public System.DateTimeOffset? AutoExpireAt { get; init; }

        [JsonPropertyName("parent_folder")]
        public FolderMini? ParentFolder { get; init; }

        public SignRequest() {
            
        }
    }
}