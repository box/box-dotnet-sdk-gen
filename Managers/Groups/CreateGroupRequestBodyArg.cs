using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateGroupRequestBodyArg {
        [JsonPropertyName("name")]
        public string Name { get; }

        [JsonPropertyName("provenance")]
        public string Provenance { get; }

        [JsonPropertyName("external_sync_identifier")]
        public string ExternalSyncIdentifier { get; }

        [JsonPropertyName("description")]
        public string Description { get; }

        [JsonPropertyName("invitability_level")]
        public CreateGroupRequestBodyArgInvitabilityLevelField InvitabilityLevel { get; }

        [JsonPropertyName("member_viewability_level")]
        public CreateGroupRequestBodyArgMemberViewabilityLevelField MemberViewabilityLevel { get; }

        public CreateGroupRequestBodyArg(string name, string provenance, string externalSyncIdentifier, string description, CreateGroupRequestBodyArgInvitabilityLevelField invitabilityLevel, CreateGroupRequestBodyArgMemberViewabilityLevelField memberViewabilityLevel) {
            Name = name;
            Provenance = provenance;
            ExternalSyncIdentifier = externalSyncIdentifier;
            Description = description;
            InvitabilityLevel = invitabilityLevel;
            MemberViewabilityLevel = memberViewabilityLevel;
        }
    }
}