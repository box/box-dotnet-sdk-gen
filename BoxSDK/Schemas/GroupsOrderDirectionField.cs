using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<GroupsOrderDirectionField>))]
    public enum GroupsOrderDirectionField {
        [Description("ASC")]
        Asc,
        [Description("DESC")]
        Desc
    }
}