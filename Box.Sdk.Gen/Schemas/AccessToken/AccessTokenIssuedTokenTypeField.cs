using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<AccessTokenIssuedTokenTypeField>))]
    public enum AccessTokenIssuedTokenTypeField {
        [Description("urn:ietf:params:oauth:token-type:access_token")]
        UrnIetfParamsOauthTokenTypeAccessToken
    }
}