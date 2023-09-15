using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<UserFullEnterpriseFieldTypeField>))]
    public enum UserFullEnterpriseFieldTypeField {
        [Description("enterprise")]
        Enterprise
    }
}