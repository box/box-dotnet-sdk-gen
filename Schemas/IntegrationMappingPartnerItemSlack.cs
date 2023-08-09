using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class IntegrationMappingPartnerItemSlack {
        [JsonPropertyName("type")]
        public IntegrationMappingPartnerItemSlackTypeField Type { get; }

        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("slack_workspace_id")]
        public string SlackWorkspaceId { get; }

        [JsonPropertyName("slack_org_id")]
        public string SlackOrgId { get; }

        public IntegrationMappingPartnerItemSlack(IntegrationMappingPartnerItemSlackTypeField type, string id, string slackWorkspaceId, string slackOrgId) {
            Type = type;
            Id = id;
            SlackWorkspaceId = slackWorkspaceId;
            SlackOrgId = slackOrgId;
        }
    }
}