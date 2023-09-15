using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using DictionaryExtensions;
using Fetch;
using Serializer;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class FilesManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public FilesManager() {
            
        }
        public async System.Threading.Tasks.Task<FileFull> GetFileById(string fileId, GetFileByIdQueryParamsArg? queryParams = default, GetFileByIdHeadersArg? headers = default) {
            queryParams = queryParams ?? new GetFileByIdQueryParamsArg();
            headers = headers ?? new GetFileByIdHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", Utils.ToString(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() { { "if-none-match", Utils.ToString(headers.IfNoneMatch) }, { "boxapi", Utils.ToString(headers.Boxapi) }, { "x-rep-hints", Utils.ToString(headers.XRepHints) } }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/files/", fileId), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<FileFull>(response.Text);
        }

        public async System.Threading.Tasks.Task<FileFull> UpdateFileById(string fileId, UpdateFileByIdRequestBodyArg? requestBody = default, UpdateFileByIdQueryParamsArg? queryParams = default, UpdateFileByIdHeadersArg? headers = default) {
            requestBody = requestBody ?? new UpdateFileByIdRequestBodyArg();
            queryParams = queryParams ?? new UpdateFileByIdQueryParamsArg();
            headers = headers ?? new UpdateFileByIdHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", Utils.ToString(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() { { "if-match", Utils.ToString(headers.IfMatch) } }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/files/", fileId), new FetchOptions(method: "PUT", parameters: queryParamsMap, headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<FileFull>(response.Text);
        }

        public async System.Threading.Tasks.Task DeleteFileById(string fileId, DeleteFileByIdHeadersArg? headers = default) {
            headers = headers ?? new DeleteFileByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() { { "if-match", Utils.ToString(headers.IfMatch) } }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/files/", fileId), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession));
        }

        public async System.Threading.Tasks.Task<FileFull> CopyFile(string fileId, CopyFileRequestBodyArg requestBody, CopyFileQueryParamsArg? queryParams = default, CopyFileHeadersArg? headers = default) {
            queryParams = queryParams ?? new CopyFileQueryParamsArg();
            headers = headers ?? new CopyFileHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", Utils.ToString(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/files/", fileId, "/copy"), new FetchOptions(method: "POST", parameters: queryParamsMap, headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<FileFull>(response.Text);
        }

        public async System.Threading.Tasks.Task<System.IO.Stream> GetFileThumbnailById(string fileId, GetFileThumbnailByIdExtensionArg extension, GetFileThumbnailByIdQueryParamsArg? queryParams = default, GetFileThumbnailByIdHeadersArg? headers = default) {
            queryParams = queryParams ?? new GetFileThumbnailByIdQueryParamsArg();
            headers = headers ?? new GetFileThumbnailByIdHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "min_height", Utils.ToString(queryParams.MinHeight) }, { "min_width", Utils.ToString(queryParams.MinWidth) }, { "max_height", Utils.ToString(queryParams.MaxHeight) }, { "max_width", Utils.ToString(queryParams.MaxWidth) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/files/", fileId, "/thumbnail.", extension), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "binary", auth: this.Auth, networkSession: this.NetworkSession));
            return response.Content;
        }

    }
}