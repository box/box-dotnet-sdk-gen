using Box.Sdk.Gen;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class CreateCollaborationWhitelistEntryRequestBody {
        /// <summary>
        /// The domain to add to the list of allowed domains.
        /// </summary>
        [JsonPropertyName("domain")]
        public string Domain { get; }

        /// <summary>
        /// The direction in which to allow collaborations.
        /// </summary>
        [JsonPropertyName("direction")]
        [JsonConverter(typeof(StringEnumConverter<CreateCollaborationWhitelistEntryRequestBodyDirectionField>))]
        public StringEnum<CreateCollaborationWhitelistEntryRequestBodyDirectionField> Direction { get; }

        public CreateCollaborationWhitelistEntryRequestBody(string domain, CreateCollaborationWhitelistEntryRequestBodyDirectionField direction) {
            Domain = domain;
            Direction = direction;
        }
        
        [JsonConstructorAttribute]
        internal CreateCollaborationWhitelistEntryRequestBody(string domain, StringEnum<CreateCollaborationWhitelistEntryRequestBodyDirectionField> direction) {
            Domain = domain;
            Direction = direction;
        }
    }
}