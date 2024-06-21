using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using Serializer;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class UpdateTermsOfServiceStatusForUserByIdRequestBody {
        /// <summary>
        /// Whether the user has accepted the terms.
        /// </summary>
        [JsonPropertyName("is_accepted")]
        public bool IsAccepted { get; }

        public UpdateTermsOfServiceStatusForUserByIdRequestBody(bool isAccepted) {
            IsAccepted = isAccepted;
        }
    }
}