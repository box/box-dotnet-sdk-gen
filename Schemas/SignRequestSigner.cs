using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class SignRequestSigner : SignRequestCreateSigner {
        [JsonPropertyName("has_viewed_document")]
        public bool? HasViewedDocument { get; }

        [JsonPropertyName("signer_decision")]
        public SignRequestSignerSignerDecisionField SignerDecision { get; }

        [JsonPropertyName("inputs")]
        public IReadOnlyList<SignRequestSignerInput> Inputs { get; }

        [JsonPropertyName("embed_url")]
        public string EmbedUrl { get; }

        public SignRequestSigner(string email, SignRequestCreateSignerRoleField role, bool? isInPerson, int? order, string embedUrlExternalUserId, string redirectUrl, string declinedRedirectUrl, bool? loginRequired, string verificationPhoneNumber, string password, bool? hasViewedDocument, SignRequestSignerSignerDecisionField signerDecision, IReadOnlyList<SignRequestSignerInput> inputs, string embedUrl) : base(email, role, isInPerson, order, embedUrlExternalUserId, redirectUrl, declinedRedirectUrl, loginRequired, verificationPhoneNumber, password) {
            HasViewedDocument = hasViewedDocument;
            SignerDecision = signerDecision;
            Inputs = inputs;
            EmbedUrl = embedUrl;
        }
    }
}