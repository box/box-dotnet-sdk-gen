using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<GroupBaseTypeField>))]
    public enum GroupBaseTypeField {
        [Description("group")]
        Group
    }
}