using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class UpdateTermsOfServiceStatusForUserByIdRequestBody {
        /// <summary>
        /// Whether the user has accepted the terms.
        /// </summary>
        [JsonPropertyName("is_accepted")]
        public bool IsAccepted { get; set; }

        public UpdateTermsOfServiceStatusForUserByIdRequestBody(bool isAccepted) {
            IsAccepted = isAccepted;
        }
    }
}