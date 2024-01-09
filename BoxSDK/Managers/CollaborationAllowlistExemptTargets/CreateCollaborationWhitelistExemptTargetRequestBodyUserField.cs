using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateCollaborationWhitelistExemptTargetRequestBodyUserField {
        /// <summary>
        /// The ID of the user to exempt.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        public CreateCollaborationWhitelistExemptTargetRequestBodyUserField(string id) {
            Id = id;
        }
    }
}