using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<GetSearchQueryParamsArgScopeField>))]
    public enum GetSearchQueryParamsArgScopeField {
        [Description("user_content")]
        UserContent,
        [Description("enterprise_content")]
        EnterpriseContent
    }
}