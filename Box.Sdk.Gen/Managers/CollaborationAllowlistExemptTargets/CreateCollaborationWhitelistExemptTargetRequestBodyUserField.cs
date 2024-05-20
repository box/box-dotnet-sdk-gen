using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class CreateCollaborationWhitelistExemptTargetRequestBodyUserField {
        /// <summary>
        /// The ID of the user to exempt.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; }

        public CreateCollaborationWhitelistExemptTargetRequestBodyUserField(string id) {
            Id = id;
        }
    }
}