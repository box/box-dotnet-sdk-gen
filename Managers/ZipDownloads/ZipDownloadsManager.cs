using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DictionaryExtensions;
using Serializer;
using Fetch;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class ZipDownloadsManager {
        public IAuth Auth { get; }

        public NetworkSession NetworkSession { get; }

        public ZipDownloadsManager(IAuth auth, NetworkSession networkSession) {
            Auth = auth;
            NetworkSession = networkSession;
        }
        public async System.Threading.Tasks.Task<ZipDownload> CreateZipDownload(ZipDownloadRequest requestBody, CreateZipDownloadHeadersArg headers) {
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/zip_downloads"), new FetchOptions(method: "POST", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<ZipDownload>(response.Text);
        }

        public async System.Threading.Tasks.Task<Stream> GetZipDownloadContent(string zipDownloadId, GetZipDownloadContentHeadersArg headers) {
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://dl.boxcloud.com/2.0/zip_downloads/", zipDownloadId, "/content"), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "binary", auth: this.Auth, networkSession: this.NetworkSession));
            return response.Content;
        }

        public async System.Threading.Tasks.Task<ZipDownloadStatus> GetZipDownloadStatus(string zipDownloadId, GetZipDownloadStatusHeadersArg headers) {
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/zip_downloads/", zipDownloadId, "/status"), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<ZipDownloadStatus>(response.Text);
        }

    }
}