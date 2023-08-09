using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<CreateCollaborationWhitelistEntryRequestBodyArgDirectionField>))]
    public enum CreateCollaborationWhitelistEntryRequestBodyArgDirectionField {
        [Description("inbound")]
        Inbound,
        [Description("outbound")]
        Outbound,
        [Description("both")]
        Both
    }
}