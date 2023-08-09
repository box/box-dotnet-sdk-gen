using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateCollaborationWhitelistEntryRequestBodyArg {
        [JsonPropertyName("domain")]
        public string Domain { get; }

        [JsonPropertyName("direction")]
        public CreateCollaborationWhitelistEntryRequestBodyArgDirectionField Direction { get; }

        public CreateCollaborationWhitelistEntryRequestBodyArg(string domain, CreateCollaborationWhitelistEntryRequestBodyArgDirectionField direction) {
            Domain = domain;
            Direction = direction;
        }
    }
}