using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<CreateCollaborationWhitelistEntryRequestBodyDirectionField>))]
    public enum CreateCollaborationWhitelistEntryRequestBodyDirectionField {
        [Description("inbound")]
        Inbound,
        [Description("outbound")]
        Outbound,
        [Description("both")]
        Both
    }
}