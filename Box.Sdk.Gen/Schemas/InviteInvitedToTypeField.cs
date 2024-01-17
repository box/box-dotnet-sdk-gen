using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<InviteInvitedToTypeField>))]
    public enum InviteInvitedToTypeField {
        [Description("enterprise")]
        Enterprise
    }
}