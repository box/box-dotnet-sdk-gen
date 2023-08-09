using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateGroupByIdRequestBodyArg {
        [JsonPropertyName("name")]
        public string Name { get; }

        [JsonPropertyName("provenance")]
        public string Provenance { get; }

        [JsonPropertyName("external_sync_identifier")]
        public string ExternalSyncIdentifier { get; }

        [JsonPropertyName("description")]
        public string Description { get; }

        [JsonPropertyName("invitability_level")]
        public UpdateGroupByIdRequestBodyArgInvitabilityLevelField InvitabilityLevel { get; }

        [JsonPropertyName("member_viewability_level")]
        public UpdateGroupByIdRequestBodyArgMemberViewabilityLevelField MemberViewabilityLevel { get; }

        public UpdateGroupByIdRequestBodyArg(string name, string provenance, string externalSyncIdentifier, string description, UpdateGroupByIdRequestBodyArgInvitabilityLevelField invitabilityLevel, UpdateGroupByIdRequestBodyArgMemberViewabilityLevelField memberViewabilityLevel) {
            Name = name;
            Provenance = provenance;
            ExternalSyncIdentifier = externalSyncIdentifier;
            Description = description;
            InvitabilityLevel = invitabilityLevel;
            MemberViewabilityLevel = memberViewabilityLevel;
        }
    }
}