using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<InviteInvitedToTypeField>))]
    public enum InviteInvitedToTypeField {
        [Description("enterprise")]
        Enterprise
    }
}