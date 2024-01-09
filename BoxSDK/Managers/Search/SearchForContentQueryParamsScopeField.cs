using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<SearchForContentQueryParamsScopeField>))]
    public enum SearchForContentQueryParamsScopeField {
        [Description("user_content")]
        UserContent,
        [Description("enterprise_content")]
        EnterpriseContent
    }
}