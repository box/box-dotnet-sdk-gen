using System.Text.Json.Serialization;

namespace Box.Sdk.Gen {
    public class BaseUrls {
        [JsonPropertyName("base_url")]
        public string BaseUrl { get; }

        [JsonPropertyName("upload_url")]
        public string UploadUrl { get; }

        [JsonPropertyName("oauth2_url")]
        public string Oauth2Url { get; }

        public BaseUrls(string baseUrl = "https://api.box.com", string uploadUrl = "https://upload.box.com/api", string oauth2Url = "https://account.box.com/api/oauth2") {
            BaseUrl = baseUrl;
            UploadUrl = uploadUrl;
            Oauth2Url = oauth2Url;
        }
    }
}