using System.IO;
using System.Text.Json.Serialization;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using DictionaryExtensions;
using Serializer;
using Fetch;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class ChunkedUploadsManager {
        public IAuth Auth { get; }

        public NetworkSession NetworkSession { get; }

        public ChunkedUploadsManager(IAuth auth, NetworkSession networkSession) {
            Auth = auth;
            NetworkSession = networkSession;
        }
        public async System.Threading.Tasks.Task<UploadSession> CreateFileUploadSession(CreateFileUploadSessionRequestBodyArg requestBody, CreateFileUploadSessionHeadersArg headers) {
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://upload.box.com/api/2.0/files/upload_sessions"), new FetchOptions(method: "POST", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<UploadSession>(response.Text);
        }

        public async System.Threading.Tasks.Task<UploadSession> CreateFileUploadSessionForExistingFile(string fileId, CreateFileUploadSessionForExistingFileRequestBodyArg requestBody, CreateFileUploadSessionForExistingFileHeadersArg headers) {
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://upload.box.com/api/2.0/files/", fileId, "/upload_sessions"), new FetchOptions(method: "POST", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<UploadSession>(response.Text);
        }

        public async System.Threading.Tasks.Task<UploadSession> GetFileUploadSessionById(string uploadSessionId, GetFileUploadSessionByIdHeadersArg headers) {
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://upload.box.com/api/2.0/files/upload_sessions/", uploadSessionId), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<UploadSession>(response.Text);
        }

        public async System.Threading.Tasks.Task<UploadedPart> UploadFilePart(string uploadSessionId, string requestBody, UploadFilePartHeadersArg headers) {
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() { { "digest", Utils.ToString(headers.Digest) }, { "content-range", Utils.ToString(headers.ContentRange) } }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://upload.box.com/api/2.0/files/upload_sessions/", uploadSessionId), new FetchOptions(method: "PUT", headers: headersMap, body: requestBody, contentType: "application/octet-stream", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<UploadedPart>(response.Text);
        }

        public async System.Threading.Tasks.Task DeleteFileUploadSessionById(string uploadSessionId, DeleteFileUploadSessionByIdHeadersArg headers) {
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://upload.box.com/api/2.0/files/upload_sessions/", uploadSessionId), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession));
        }

        public async System.Threading.Tasks.Task<UploadParts> GetFileUploadSessionParts(string uploadSessionId, GetFileUploadSessionPartsQueryParamsArg queryParams, GetFileUploadSessionPartsHeadersArg headers) {
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string>() { { "offset", Utils.ToString(queryParams.Offset) }, { "limit", Utils.ToString(queryParams.Limit) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://upload.box.com/api/2.0/files/upload_sessions/", uploadSessionId, "/parts"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<UploadParts>(response.Text);
        }

        public async System.Threading.Tasks.Task<Files> CreateFileUploadSessionCommit(string uploadSessionId, CreateFileUploadSessionCommitRequestBodyArg requestBody, CreateFileUploadSessionCommitHeadersArg headers) {
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() { { "digest", Utils.ToString(headers.Digest) }, { "if-match", Utils.ToString(headers.IfMatch) }, { "if-none-match", Utils.ToString(headers.IfNoneMatch) } }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://upload.box.com/api/2.0/files/upload_sessions/", uploadSessionId, "/commit"), new FetchOptions(method: "POST", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<Files>(response.Text);
        }

    }
}