using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<EmailAliasTypeField>))]
    public enum EmailAliasTypeField {
        [Description("email_alias")]
        EmailAlias
    }
}