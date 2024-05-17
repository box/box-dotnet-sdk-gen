using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class CreateGroupMembershipRequestBodyUserField {
        /// <summary>
        /// The ID of the user to add to the group
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; }

        public CreateGroupMembershipRequestBodyUserField(string id) {
            Id = id;
        }
    }
}