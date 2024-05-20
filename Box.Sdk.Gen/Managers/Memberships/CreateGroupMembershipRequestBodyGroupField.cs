using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class CreateGroupMembershipRequestBodyGroupField {
        /// <summary>
        /// The ID of the group to add the user to
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; }

        public CreateGroupMembershipRequestBodyGroupField(string id) {
            Id = id;
        }
    }
}