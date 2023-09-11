using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    [JsonConverter(typeof(StringEnumConverter<GetAuthorizeQueryParamsArgResponseTypeField>))]
    public enum GetAuthorizeQueryParamsArgResponseTypeField {
        [Description("code")]
        Code
    }
}