using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<GetStoragePolicyAssignmentsQueryParamsArgResolvedForTypeField>))]
    public enum GetStoragePolicyAssignmentsQueryParamsArgResolvedForTypeField {
        [Description("user")]
        User,
        [Description("enterprise")]
        Enterprise
    }
}