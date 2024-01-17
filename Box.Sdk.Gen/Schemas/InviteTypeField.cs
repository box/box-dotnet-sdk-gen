using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<InviteTypeField>))]
    public enum InviteTypeField {
        [Description("invite")]
        Invite
    }
}