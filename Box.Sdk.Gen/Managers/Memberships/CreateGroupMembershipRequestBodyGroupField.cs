using Box.Sdk.Gen;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using System;
using Box.Sdk.Gen.Schemas;

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