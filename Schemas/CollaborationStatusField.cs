using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    [JsonConverter(typeof(StringEnumConverter<CollaborationStatusField>))]
    public enum CollaborationStatusField {
        [Description("accepted")]
        Accepted,
        [Description("pending")]
        Pending,
        [Description("rejected")]
        Rejected
    }
}