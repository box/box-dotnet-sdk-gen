using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DictionaryExtensions;
using Serializer;
using Fetch;
using StringExtensions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class ZipDownloadsManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public ZipDownloadsManager() {
            
        }
        public async System.Threading.Tasks.Task<ZipDownload> CreateZipDownload(ZipDownloadRequest requestBody, CreateZipDownloadHeadersArg? headers = default) {
            headers = headers ?? new CreateZipDownloadHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/zip_downloads"), new FetchOptions(method: "POST", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<ZipDownload>(response.Text);
        }

        public async System.Threading.Tasks.Task<System.IO.Stream> GetZipDownloadContent(string zipDownloadId, GetZipDownloadContentHeadersArg? headers = default) {
            headers = headers ?? new GetZipDownloadContentHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://dl.boxcloud.com/2.0/zip_downloads/", StringUtils.ToStringRepresentation(zipDownloadId), "/content"), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "binary", auth: this.Auth, networkSession: this.NetworkSession));
            return response.Content;
        }

        public async System.Threading.Tasks.Task<ZipDownloadStatus> GetZipDownloadStatus(string zipDownloadId, GetZipDownloadStatusHeadersArg? headers = default) {
            headers = headers ?? new GetZipDownloadStatusHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/zip_downloads/", StringUtils.ToStringRepresentation(zipDownloadId), "/status"), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<ZipDownloadStatus>(response.Text);
        }

    }
}