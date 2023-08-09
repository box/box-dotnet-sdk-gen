using System.IO;
using Unions;
using System.Text.Json.Serialization;

namespace Box.Schemas {
    public class PostOAuth2Token {
        [JsonPropertyName("grant_type")]
        public PostOAuth2TokenGrantTypeField GrantType { get; }

        [JsonPropertyName("client_id")]
        public string ClientId { get; }

        [JsonPropertyName("client_secret")]
        public string ClientSecret { get; }

        [JsonPropertyName("code")]
        public string Code { get; }

        [JsonPropertyName("refresh_token")]
        public string RefreshToken { get; }

        [JsonPropertyName("assertion")]
        public string Assertion { get; }

        [JsonPropertyName("subject_token")]
        public string SubjectToken { get; }

        [JsonPropertyName("subject_token_type")]
        public PostOAuth2TokenSubjectTokenTypeField SubjectTokenType { get; }

        [JsonPropertyName("actor_token")]
        public string ActorToken { get; }

        [JsonPropertyName("actor_token_type")]
        public PostOAuth2TokenActorTokenTypeField ActorTokenType { get; }

        [JsonPropertyName("scope")]
        public string Scope { get; }

        [JsonPropertyName("resource")]
        public string Resource { get; }

        [JsonPropertyName("box_subject_type")]
        public PostOAuth2TokenBoxSubjectTypeField BoxSubjectType { get; }

        [JsonPropertyName("box_subject_id")]
        public string BoxSubjectId { get; }

        [JsonPropertyName("box_shared_link")]
        public string BoxSharedLink { get; }

        public PostOAuth2Token(PostOAuth2TokenGrantTypeField grantType, string clientId, string clientSecret, string code, string refreshToken, string assertion, string subjectToken, PostOAuth2TokenSubjectTokenTypeField subjectTokenType, string actorToken, PostOAuth2TokenActorTokenTypeField actorTokenType, string scope, string resource, PostOAuth2TokenBoxSubjectTypeField boxSubjectType, string boxSubjectId, string boxSharedLink) {
            GrantType = grantType;
            ClientId = clientId;
            ClientSecret = clientSecret;
            Code = code;
            RefreshToken = refreshToken;
            Assertion = assertion;
            SubjectToken = subjectToken;
            SubjectTokenType = subjectTokenType;
            ActorToken = actorToken;
            ActorTokenType = actorTokenType;
            Scope = scope;
            Resource = resource;
            BoxSubjectType = boxSubjectType;
            BoxSubjectId = boxSubjectId;
            BoxSharedLink = boxSharedLink;
        }
    }
}