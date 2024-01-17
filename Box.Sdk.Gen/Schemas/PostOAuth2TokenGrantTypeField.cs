using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<PostOAuth2TokenGrantTypeField>))]
    public enum PostOAuth2TokenGrantTypeField {
        [Description("authorization_code")]
        AuthorizationCode,
        [Description("refresh_token")]
        RefreshToken,
        [Description("client_credentials")]
        ClientCredentials,
        [Description("urn:ietf:params:oauth:grant-type:jwt-bearer")]
        UrnIetfParamsOauthGrantTypeJwtBearer,
        [Description("urn:ietf:params:oauth:grant-type:token-exchange")]
        UrnIetfParamsOauthGrantTypeTokenExchange
    }
}