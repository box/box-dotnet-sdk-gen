using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class SignRequestCreateRequest : SignRequestBase {
        /// <summary>
        /// List of files to create a signing document from. This is currently limited to ten files. Only the ID and type fields are required for each file.
        /// </summary>
        [JsonPropertyName("source_files")]
        public IReadOnlyList<FileBase>? SourceFiles { get; init; }

        /// <summary>
        /// Force a specific color for the signature (blue, black, or red)
        /// </summary>
        [JsonPropertyName("signature_color")]
        public SignRequestCreateRequestSignatureColorField? SignatureColor { get; init; }

        /// <summary>
        /// Array of signers for the signature request. 35 is the max number of signers permitted.
        /// </summary>
        [JsonPropertyName("signers")]
        public IReadOnlyList<SignRequestCreateSigner> Signers { get; }

        [JsonPropertyName("parent_folder")]
        public FolderMini? ParentFolder { get; init; }

        public SignRequestCreateRequest(IReadOnlyList<SignRequestCreateSigner> signers) {
            Signers = signers;
        }
    }
}