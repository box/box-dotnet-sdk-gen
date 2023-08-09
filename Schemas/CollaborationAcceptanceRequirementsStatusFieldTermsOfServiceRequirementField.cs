using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class CollaborationAcceptanceRequirementsStatusFieldTermsOfServiceRequirementField {
        [JsonPropertyName("is_accepted")]
        public bool? IsAccepted { get; }

        [JsonPropertyName("terms_of_service")]
        public TermsOfServiceBase TermsOfService { get; }

        public CollaborationAcceptanceRequirementsStatusFieldTermsOfServiceRequirementField(bool? isAccepted, TermsOfServiceBase termsOfService) {
            IsAccepted = isAccepted;
            TermsOfService = termsOfService;
        }
    }
}