using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<PostOAuth2TokenSubjectTokenTypeField>))]
    public enum PostOAuth2TokenSubjectTokenTypeField {
        [Description("urn:ietf:params:oauth:token-type:access_token")]
        UrnIetfParamsOauthTokenTypeAccessToken
    }
}