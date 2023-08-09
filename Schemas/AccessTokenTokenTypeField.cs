using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<AccessTokenTokenTypeField>))]
    public enum AccessTokenTokenTypeField {
        [Description("bearer")]
        Bearer
    }
}