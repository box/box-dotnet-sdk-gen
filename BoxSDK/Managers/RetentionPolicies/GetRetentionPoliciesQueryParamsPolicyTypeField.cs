using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<GetRetentionPoliciesQueryParamsPolicyTypeField>))]
    public enum GetRetentionPoliciesQueryParamsPolicyTypeField {
        [Description("finite")]
        Finite,
        [Description("indefinite")]
        Indefinite
    }
}