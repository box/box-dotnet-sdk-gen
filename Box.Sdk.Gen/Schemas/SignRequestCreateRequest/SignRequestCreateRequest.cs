using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Serializer;
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
        [JsonConverter(typeof(StringEnumConverter<SignRequestCreateRequestSignatureColorField>))]
        public StringEnum<SignRequestCreateRequestSignatureColorField>? SignatureColor { get; init; }

        /// <summary>
        /// Array of signers for the signature request. 35 is the
        /// max number of signers permitted.
        /// 
        /// **Note**: It may happen that some signers belong to conflicting [segments](r://shield-information-barrier-segment-member) (user groups).
        /// This means that due to the security policies, users are assigned to segments to prevent exchanges or communication that could lead to ethical conflicts.
        /// In such a case, an attempt to send the sign request will result in an error.
        /// 
        /// Read more about [segments and ethical walls](https://support.box.com/hc/en-us/articles/9920431507603-Understanding-Information-Barriers#h_01GFVJEHQA06N7XEZ4GCZ9GFAQ).
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