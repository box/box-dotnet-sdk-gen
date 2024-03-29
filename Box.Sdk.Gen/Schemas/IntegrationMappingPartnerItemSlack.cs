using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class IntegrationMappingPartnerItemSlack {
        /// <summary>
        /// Type of the mapped item referenced in `id`
        /// </summary>
        [JsonPropertyName("type")]
        public IntegrationMappingPartnerItemSlackTypeField Type { get; set; }

        /// <summary>
        /// ID of the mapped item (of type referenced in `type`)
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// ID of the Slack workspace with which the item is associated. Use this parameter if Box for Slack is installed at a workspace level. Do not use `slack_org_id` at the same time.
        /// </summary>
        [JsonPropertyName("slack_workspace_id")]
        public string? SlackWorkspaceId { get; set; } = default;

        /// <summary>
        /// ID of the Slack org with which the item is associated. Use this parameter if Box for Slack is installed at the org level. Do not use `slack_workspace_id` at the same time.
        /// </summary>
        [JsonPropertyName("slack_org_id")]
        public string? SlackOrgId { get; set; } = default;

        public IntegrationMappingPartnerItemSlack(IntegrationMappingPartnerItemSlackTypeField type, string id) {
            Type = type;
            Id = id;
        }
    }
}