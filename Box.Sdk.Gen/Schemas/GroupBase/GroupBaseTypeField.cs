using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<GroupBaseTypeField>))]
    public enum GroupBaseTypeField {
        [Description("group")]
        Group
    }
}