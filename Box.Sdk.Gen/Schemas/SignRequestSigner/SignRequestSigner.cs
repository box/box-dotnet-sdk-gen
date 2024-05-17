using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class SignRequestSigner : SignRequestCreateSigner {
        /// <summary>
        /// Set to `true` if the signer views the document
        /// </summary>
        [JsonPropertyName("has_viewed_document")]
        public bool? HasViewedDocument { get; init; }

        /// <summary>
        /// Final decision made by the signer.
        /// </summary>
        [JsonPropertyName("signer_decision")]
        public SignRequestSignerSignerDecisionField? SignerDecision { get; init; }

        [JsonPropertyName("inputs")]
        public IReadOnlyList<SignRequestSignerInput>? Inputs { get; init; }

        /// <summary>
        /// URL to direct a signer to for signing
        /// </summary>
        [JsonPropertyName("embed_url")]
        public string? EmbedUrl { get; init; }

        /// <summary>
        /// This URL is specifically designed for
        /// signing documents within an HTML `iframe` tag.
        /// It will be returned in the response
        /// only if the `embed_url_external_user_id`
        /// parameter was passed in the
        /// `create Box Sign request` call.
        /// </summary>
        [JsonPropertyName("iframeable_embed_url")]
        public string? IframeableEmbedUrl { get; init; }

        public SignRequestSigner() {
            
        }
    }
}