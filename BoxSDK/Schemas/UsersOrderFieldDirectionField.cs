using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<UsersOrderFieldDirectionField>))]
    public enum UsersOrderFieldDirectionField {
        [Description("ASC")]
        Asc,
        [Description("DESC")]
        Desc
    }
}