using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<CommentsOrderFieldDirectionField>))]
    public enum CommentsOrderFieldDirectionField {
        [Description("ASC")]
        Asc,
        [Description("DESC")]
        Desc
    }
}