using System.IO;
using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class DownloadFileQueryParamsArg {
        public string Version { get; }

        public string AccessToken { get; }

        public DownloadFileQueryParamsArg(string version, string accessToken) {
            Version = version;
            AccessToken = accessToken;
        }
    }
}