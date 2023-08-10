using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class InviteInvitedToField {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public InviteInvitedToFieldTypeField Type { get; }

        [JsonPropertyName("name")]
        public string Name { get; }

        public InviteInvitedToField(string id, InviteInvitedToFieldTypeField type, string name) {
            Id = id;
            Type = type;
            Name = name;
        }
    }
}