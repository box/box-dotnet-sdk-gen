using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateGroupMembershipRequestBodyArgUserField {
        [JsonPropertyName("id")]
        public string Id { get; }

        public CreateGroupMembershipRequestBodyArgUserField(string id) {
            Id = id;
        }
    }
}