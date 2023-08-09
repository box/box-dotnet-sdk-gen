using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class GroupFull : Group {
        [JsonPropertyName("provenance")]
        public string Provenance { get; }

        [JsonPropertyName("external_sync_identifier")]
        public string ExternalSyncIdentifier { get; }

        [JsonPropertyName("description")]
        public string Description { get; }

        [JsonPropertyName("invitability_level")]
        public GroupFullInvitabilityLevelField InvitabilityLevel { get; }

        [JsonPropertyName("member_viewability_level")]
        public GroupFullMemberViewabilityLevelField MemberViewabilityLevel { get; }

        [JsonPropertyName("permissions")]
        public GroupFullPermissionsField Permissions { get; }

        public GroupFull(string id, GroupBaseTypeField type, string name, GroupMiniGroupTypeField groupType, string createdAt, string modifiedAt, string provenance, string externalSyncIdentifier, string description, GroupFullInvitabilityLevelField invitabilityLevel, GroupFullMemberViewabilityLevelField memberViewabilityLevel, GroupFullPermissionsField permissions) : base(id, type, name, groupType, createdAt, modifiedAt) {
            Provenance = provenance;
            ExternalSyncIdentifier = externalSyncIdentifier;
            Description = description;
            InvitabilityLevel = invitabilityLevel;
            MemberViewabilityLevel = memberViewabilityLevel;
            Permissions = permissions;
        }
    }
}