using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class CreateCollaborationWhitelistExemptTargetRequestBody {
        /// <summary>
        /// The user to exempt.
        /// </summary>
        [JsonPropertyName("user")]
        public CreateCollaborationWhitelistExemptTargetRequestBodyUserField User { get; }

        public CreateCollaborationWhitelistExemptTargetRequestBody(CreateCollaborationWhitelistExemptTargetRequestBodyUserField user) {
            User = user;
        }
    }
}