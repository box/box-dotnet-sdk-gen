using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using StringExtensions;
using DictionaryExtensions;
using Fetch;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class DownloadsManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public DownloadsManager() {
            
        }
        public async System.Threading.Tasks.Task<System.IO.Stream> DownloadFile(string fileId, DownloadFileQueryParamsArg? queryParams = default, DownloadFileHeadersArg? headers = default) {
            queryParams = queryParams ?? new DownloadFileQueryParamsArg();
            headers = headers ?? new DownloadFileHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "version", StringUtils.ToStringRepresentation(queryParams.Version) }, { "access_token", StringUtils.ToStringRepresentation(queryParams.AccessTokenField) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() { { "range", StringUtils.ToStringRepresentation(headers.Range) }, { "boxapi", StringUtils.ToStringRepresentation(headers.Boxapi) } }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/files/", StringUtils.ToStringRepresentation(fileId), "/content"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "binary", auth: this.Auth, networkSession: this.NetworkSession));
            return response.Content;
        }

    }
}