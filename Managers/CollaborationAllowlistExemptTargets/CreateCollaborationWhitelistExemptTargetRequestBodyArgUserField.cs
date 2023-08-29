using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateCollaborationWhitelistExemptTargetRequestBodyArgUserField {
        /// <summary>
        /// The ID of the user to exempt.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        public CreateCollaborationWhitelistExemptTargetRequestBodyArgUserField(string id) {
            Id = id;
        }
    }
}