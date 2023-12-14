using System.Text.Json.Serialization;

namespace Box {
    public class BaseUrls {
        [JsonPropertyName("base_url")]
        public string BaseUrl { get; set; }

        [JsonPropertyName("upload_url")]
        public string UploadUrl { get; set; }

        [JsonPropertyName("oauth2_url")]
        public string Oauth2Url { get; set; }

        public BaseUrls(string baseUrl = "https://api.box.com/2.0", string uploadUrl = "https://upload.box.com/api/2.0", string oauth2Url = "https://account.box.com/api/oauth2") {
            BaseUrl = baseUrl;
            UploadUrl = uploadUrl;
            Oauth2Url = oauth2Url;
        }
    }
}