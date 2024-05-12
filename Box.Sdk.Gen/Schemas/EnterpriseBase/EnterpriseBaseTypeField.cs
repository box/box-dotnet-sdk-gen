using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<EnterpriseBaseTypeField>))]
    public enum EnterpriseBaseTypeField {
        [Description("enterprise")]
        Enterprise
    }
}