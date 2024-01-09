using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<UserFullEnterpriseTypeField>))]
    public enum UserFullEnterpriseTypeField {
        [Description("enterprise")]
        Enterprise
    }
}