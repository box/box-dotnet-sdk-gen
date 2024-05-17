using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Unions;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class TerminateGroupsSessionsRequestBody {
        /// <summary>
        /// A list of group IDs
        /// </summary>
        [JsonPropertyName("group_ids")]
        public IReadOnlyList<string> GroupIds { get; }

        public TerminateGroupsSessionsRequestBody(IReadOnlyList<string> groupIds) {
            GroupIds = groupIds;
        }
    }
}