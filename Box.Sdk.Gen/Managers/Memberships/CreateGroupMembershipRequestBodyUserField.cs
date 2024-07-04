using Box.Sdk.Gen;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using System;
using Box.Sdk.Gen.Schemas;

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