using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DictionaryExtensions;
using System;
using Serializer;
using Fetch;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UploadsManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public UploadsManager() {
            
        }
        public async System.Threading.Tasks.Task<Files> UploadFileVersion(string fileId, UploadFileVersionRequestBodyArg requestBody, UploadFileVersionQueryParamsArg? queryParams = default, UploadFileVersionHeadersArg? headers = default) {
            queryParams = queryParams ?? new UploadFileVersionQueryParamsArg();
            headers = headers ?? new UploadFileVersionHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", Utils.ToString(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() { { "if-match", Utils.ToString(headers.IfMatch) }, { "content-md5", Utils.ToString(headers.ContentMd5) } }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://upload.box.com/api/2.0/files/", fileId, "/content"), new FetchOptions(method: "POST", parameters: queryParamsMap, headers: headersMap, multipartData: Array.AsReadOnly(new [] {new MultipartItem(partName: "attributes", body: SimpleJsonConverter.Serialize(requestBody.Attributes)),new MultipartItem(partName: "file", fileStream: requestBody.File, fileName: requestBody.FileFileName, contentType: requestBody.FileContentType)}), contentType: "multipart/form-data", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<Files>(response.Text);
        }

        public async System.Threading.Tasks.Task<Files> UploadFile(UploadFileRequestBodyArg requestBody, UploadFileQueryParamsArg? queryParams = default, UploadFileHeadersArg? headers = default) {
            queryParams = queryParams ?? new UploadFileQueryParamsArg();
            headers = headers ?? new UploadFileHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", Utils.ToString(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() { { "content-md5", Utils.ToString(headers.ContentMd5) } }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://upload.box.com/api/2.0/files/content"), new FetchOptions(method: "POST", parameters: queryParamsMap, headers: headersMap, multipartData: Array.AsReadOnly(new [] {new MultipartItem(partName: "attributes", body: SimpleJsonConverter.Serialize(requestBody.Attributes)),new MultipartItem(partName: "file", fileStream: requestBody.File, fileName: requestBody.FileFileName, contentType: requestBody.FileContentType)}), contentType: "multipart/form-data", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<Files>(response.Text);
        }

        public async System.Threading.Tasks.Task<UploadUrl> PreflightFileUpload(PreflightFileUploadRequestBodyArg? requestBody = default, PreflightFileUploadHeadersArg? headers = default) {
            requestBody = requestBody ?? new PreflightFileUploadRequestBodyArg();
            headers = headers ?? new PreflightFileUploadHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/files/content"), new FetchOptions(method: "OPTIONS", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<UploadUrl>(response.Text);
        }

    }
}