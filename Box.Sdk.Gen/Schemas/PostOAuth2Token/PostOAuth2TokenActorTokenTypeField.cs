using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<PostOAuth2TokenActorTokenTypeField>))]
    public enum PostOAuth2TokenActorTokenTypeField {
        [Description("urn:ietf:params:oauth:token-type:id_token")]
        UrnIetfParamsOauthTokenTypeIdToken
    }
}