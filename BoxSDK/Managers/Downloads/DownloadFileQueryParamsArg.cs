using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class DownloadFileQueryParamsArg {
        /// <summary>
        /// The file version to download
        /// </summary>
        public string? Version { get; set; } = default;

        /// <summary>
        /// An optional access token that can be used to pre-authenticate this request, which means that a download link can be shared with a browser or a third party service without them needing to know how to handle the authentication.
        /// When using this parameter, please make sure that the access token is sufficiently scoped down to only allow read access to that file and no other files or folders.
        /// </summary>
        public string? AccessTokenField { get; set; } = default;

        public DownloadFileQueryParamsArg() {
            
        }
    }
}