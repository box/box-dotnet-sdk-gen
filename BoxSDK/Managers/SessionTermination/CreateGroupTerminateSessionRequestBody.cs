using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateGroupTerminateSessionRequestBody {
        /// <summary>
        /// A list of group IDs
        /// </summary>
        [JsonPropertyName("group_ids")]
        public IReadOnlyList<string> GroupIds { get; set; }

        public CreateGroupTerminateSessionRequestBody(IReadOnlyList<string> groupIds) {
            GroupIds = groupIds;
        }
    }
}