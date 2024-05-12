using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
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