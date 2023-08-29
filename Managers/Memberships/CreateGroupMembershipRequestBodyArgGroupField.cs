using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateGroupMembershipRequestBodyArgGroupField {
        /// <summary>
        /// The ID of the group to add the user to
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        public CreateGroupMembershipRequestBodyArgGroupField(string id) {
            Id = id;
        }
    }
}