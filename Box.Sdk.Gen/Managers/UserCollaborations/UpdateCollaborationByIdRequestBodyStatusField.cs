using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    [JsonConverter(typeof(StringEnumConverter<UpdateCollaborationByIdRequestBodyStatusField>))]
    public enum UpdateCollaborationByIdRequestBodyStatusField {
        [Description("pending")]
        Pending,
        [Description("accepted")]
        Accepted,
        [Description("rejected")]
        Rejected
    }
}