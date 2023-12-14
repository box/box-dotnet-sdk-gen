using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateGroupMembershipRequestBodyUserField {
        /// <summary>
        /// The ID of the user to add to the group
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        public CreateGroupMembershipRequestBodyUserField(string id) {
            Id = id;
        }
    }
}