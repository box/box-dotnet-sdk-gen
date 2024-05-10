using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<UserFullEnterpriseTypeField>))]
    public enum UserFullEnterpriseTypeField {
        [Description("enterprise")]
        Enterprise
    }
}