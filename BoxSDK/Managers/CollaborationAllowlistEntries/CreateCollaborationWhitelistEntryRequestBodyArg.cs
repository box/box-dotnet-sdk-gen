using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CreateCollaborationWhitelistEntryRequestBodyArg {
        /// <summary>
        /// The domain to add to the list of allowed domains.
        /// </summary>
        [JsonPropertyName("domain")]
        public string Domain { get; set; }

        /// <summary>
        /// The direction in which to allow collaborations.
        /// </summary>
        [JsonPropertyName("direction")]
        public CreateCollaborationWhitelistEntryRequestBodyArgDirectionField Direction { get; set; }

        public CreateCollaborationWhitelistEntryRequestBodyArg(string domain, CreateCollaborationWhitelistEntryRequestBodyArgDirectionField direction) {
            Domain = domain;
            Direction = direction;
        }
    }
}