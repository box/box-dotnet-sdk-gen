using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateGroupMembershipRequestBodyGroupField {
        /// <summary>
        /// The ID of the group to add the user to
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        public CreateGroupMembershipRequestBodyGroupField(string id) {
            Id = id;
        }
    }
}