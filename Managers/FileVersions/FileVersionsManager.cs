using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using DictionaryExtensions;
using Fetch;
using Serializer;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class FileVersionsManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public FileVersionsManager() {
            
        }
        public async System.Threading.Tasks.Task<FileVersions> GetFileVersions(string fileId, GetFileVersionsQueryParamsArg? queryParams = default, GetFileVersionsHeadersArg? headers = default) {
            queryParams = queryParams ?? new GetFileVersionsQueryParamsArg();
            headers = headers ?? new GetFileVersionsHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", Utils.ToString(queryParams.Fields) }, { "limit", Utils.ToString(queryParams.Limit) }, { "offset", Utils.ToString(queryParams.Offset) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/files/", fileId, "/versions"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<FileVersions>(response.Text);
        }

        public async System.Threading.Tasks.Task<FileVersionFull> GetFileVersionById(string fileId, string fileVersionId, GetFileVersionByIdQueryParamsArg? queryParams = default, GetFileVersionByIdHeadersArg? headers = default) {
            queryParams = queryParams ?? new GetFileVersionByIdQueryParamsArg();
            headers = headers ?? new GetFileVersionByIdHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", Utils.ToString(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/files/", fileId, "/versions/", fileVersionId), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<FileVersionFull>(response.Text);
        }

        public async System.Threading.Tasks.Task<FileVersionFull> UpdateFileVersionById(string fileId, string fileVersionId, UpdateFileVersionByIdRequestBodyArg? requestBody = default, UpdateFileVersionByIdHeadersArg? headers = default) {
            requestBody = requestBody ?? new UpdateFileVersionByIdRequestBodyArg();
            headers = headers ?? new UpdateFileVersionByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/files/", fileId, "/versions/", fileVersionId), new FetchOptions(method: "PUT", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<FileVersionFull>(response.Text);
        }

        public async System.Threading.Tasks.Task DeleteFileVersionById(string fileId, string fileVersionId, DeleteFileVersionByIdHeadersArg? headers = default) {
            headers = headers ?? new DeleteFileVersionByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() { { "if-match", Utils.ToString(headers.IfMatch) } }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/files/", fileId, "/versions/", fileVersionId), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession));
        }

        public async System.Threading.Tasks.Task<FileVersionFull> PromoteFileVersion(string fileId, PromoteFileVersionRequestBodyArg? requestBody = default, PromoteFileVersionQueryParamsArg? queryParams = default, PromoteFileVersionHeadersArg? headers = default) {
            requestBody = requestBody ?? new PromoteFileVersionRequestBodyArg();
            queryParams = queryParams ?? new PromoteFileVersionQueryParamsArg();
            headers = headers ?? new PromoteFileVersionHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", Utils.ToString(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/files/", fileId, "/versions/current"), new FetchOptions(method: "POST", parameters: queryParamsMap, headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<FileVersionFull>(response.Text);
        }

    }
}