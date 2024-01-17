using System.ComponentModel;
using Serializer;
using System.Text.Json.Serialization;

namespace Box.Sdk.Gen.Schemas {
    [JsonConverter(typeof(StringEnumConverter<PostOAuth2TokenRefreshAccessTokenGrantTypeField>))]
    public enum PostOAuth2TokenRefreshAccessTokenGrantTypeField {
        [Description("refresh_token")]
        RefreshToken
    }
}