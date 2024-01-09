using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateCollaborationWhitelistExemptTargetRequestBody {
        /// <summary>
        /// The user to exempt.
        /// </summary>
        [JsonPropertyName("user")]
        public CreateCollaborationWhitelistExemptTargetRequestBodyUserField User { get; set; }

        public CreateCollaborationWhitelistExemptTargetRequestBody(CreateCollaborationWhitelistExemptTargetRequestBodyUserField user) {
            User = user;
        }
    }
}