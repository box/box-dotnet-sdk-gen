using System.IO;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateGroupTerminateSessionRequestBodyArg {
        [JsonPropertyName("group_ids")]
        public IReadOnlyList<string> GroupIds { get; }

        public CreateGroupTerminateSessionRequestBodyArg(IReadOnlyList<string> groupIds) {
            GroupIds = groupIds;
        }
    }
}