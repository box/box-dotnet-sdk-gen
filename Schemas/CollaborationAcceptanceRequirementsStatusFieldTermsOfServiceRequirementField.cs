using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class CollaborationAcceptanceRequirementsStatusFieldTermsOfServiceRequirementField {
        /// <summary>
        /// Whether or not the terms of service have been accepted.  The
        /// field is `null` when there is no terms of service required.
        /// </summary>
        [JsonPropertyName("is_accepted")]
        public bool? IsAccepted { get; set; } = default;

        [JsonPropertyName("terms_of_service")]
        public TermsOfServiceBase? TermsOfService { get; set; } = default;

        public CollaborationAcceptanceRequirementsStatusFieldTermsOfServiceRequirementField() {
            
        }
    }
}