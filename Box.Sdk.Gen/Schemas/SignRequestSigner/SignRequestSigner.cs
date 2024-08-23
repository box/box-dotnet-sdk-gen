using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class SignRequestSigner : SignRequestCreateSigner {
        [JsonInclude]
        [JsonPropertyName("_issigner_decisionSet")]
        protected bool _isSignerDecisionSet { get; set; }

        [JsonInclude]
        [JsonPropertyName("_isembed_urlSet")]
        protected bool _isEmbedUrlSet { get; set; }

        [JsonInclude]
        [JsonPropertyName("_isiframeable_embed_urlSet")]
        protected bool _isIframeableEmbedUrlSet { get; set; }

        protected SignRequestSignerSignerDecisionField? _signerDecision { get; set; }

        protected string? _embedUrl { get; set; }

        protected string? _iframeableEmbedUrl { get; set; }

        /// <summary>
        /// Set to `true` if the signer views the document
        /// </summary>
        [JsonPropertyName("has_viewed_document")]
        public bool? HasViewedDocument { get; init; }

        /// <summary>
        /// Final decision made by the signer.
        /// </summary>
        [JsonPropertyName("signer_decision")]
        public SignRequestSignerSignerDecisionField? SignerDecision { get => _signerDecision; init { _signerDecision = value; _isSignerDecisionSet = true; } }

        [JsonPropertyName("inputs")]
        public IReadOnlyList<SignRequestSignerInput>? Inputs { get; init; }

        /// <summary>
        /// URL to direct a signer to for signing
        /// </summary>
        [JsonPropertyName("embed_url")]
        public string? EmbedUrl { get => _embedUrl; init { _embedUrl = value; _isEmbedUrlSet = true; } }

        /// <summary>
        /// This URL is specifically designed for
        /// signing documents within an HTML `iframe` tag.
        /// It will be returned in the response
        /// only if the `embed_url_external_user_id`
        /// parameter was passed in the
        /// `create Box Sign request` call.
        /// </summary>
        [JsonPropertyName("iframeable_embed_url")]
        public string? IframeableEmbedUrl { get => _iframeableEmbedUrl; init { _iframeableEmbedUrl = value; _isIframeableEmbedUrlSet = true; } }

        public SignRequestSigner() {
            
        }
    }
}