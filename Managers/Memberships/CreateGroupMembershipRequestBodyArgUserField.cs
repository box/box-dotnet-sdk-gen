using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateGroupMembershipRequestBodyArgUserField {
        /// <summary>
        /// The ID of the user to add to the group
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        public CreateGroupMembershipRequestBodyArgUserField(string id) {
            Id = id;
        }
    }
}