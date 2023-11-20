using System.Text.Json.Serialization;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using DictionaryExtensions;
using Serializer;
using Fetch;
using StringExtensions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class ChunkedUploadsManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public ChunkedUploadsManager() {
            
        }
        /// <summary>
        /// Creates an upload session for a new file.
        /// </summary>
        /// <param name="requestBody">
        /// Request body of createFileUploadSession method
        /// </param>
        /// <param name="headers">
        /// Headers of createFileUploadSession method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<UploadSession> CreateFileUploadSessionAsync(CreateFileUploadSessionRequestBodyArg requestBody, CreateFileUploadSessionHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new CreateFileUploadSessionHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://upload.box.com/api/2.0/files/upload_sessions"), new FetchOptions(method: "POST", headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<UploadSession>(response.Data);
        }

        /// <summary>
        /// Creates an upload session for an existing file.
        /// </summary>
        /// <param name="fileId">
        /// The unique identifier that represents a file.
        /// 
        /// The ID for any file can be determined
        /// by visiting a file in the web application
        /// and copying the ID from the URL. For example,
        /// for the URL `https://*.app.box.com/files/123`
        /// the `file_id` is `123`.
        /// Example: "12345"
        /// </param>
        /// <param name="requestBody">
        /// Request body of createFileUploadSessionForExistingFile method
        /// </param>
        /// <param name="headers">
        /// Headers of createFileUploadSessionForExistingFile method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<UploadSession> CreateFileUploadSessionForExistingFileAsync(string fileId, CreateFileUploadSessionForExistingFileRequestBodyArg requestBody, CreateFileUploadSessionForExistingFileHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new CreateFileUploadSessionForExistingFileHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://upload.box.com/api/2.0/files/", StringUtils.ToStringRepresentation(fileId), "/upload_sessions"), new FetchOptions(method: "POST", headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<UploadSession>(response.Data);
        }

        /// <summary>
        /// Return information about an upload session.
        /// </summary>
        /// <param name="uploadSessionId">
        /// The ID of the upload session.
        /// Example: "D5E3F7A"
        /// </param>
        /// <param name="headers">
        /// Headers of getFileUploadSessionById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<UploadSession> GetFileUploadSessionByIdAsync(string uploadSessionId, GetFileUploadSessionByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new GetFileUploadSessionByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://upload.box.com/api/2.0/files/upload_sessions/", StringUtils.ToStringRepresentation(uploadSessionId)), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<UploadSession>(response.Data);
        }

        /// <summary>
        /// Updates a chunk of an upload session for a file.
        /// </summary>
        /// <param name="uploadSessionId">
        /// The ID of the upload session.
        /// Example: "D5E3F7A"
        /// </param>
        /// <param name="requestBody">
        /// Request body of uploadFilePart method
        /// </param>
        /// <param name="headers">
        /// Headers of uploadFilePart method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<UploadedPart> UploadFilePartAsync(string uploadSessionId, System.IO.Stream requestBody, UploadFilePartHeadersArg headers, System.Threading.CancellationToken? cancellationToken = null) {
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() { { "digest", StringUtils.ToStringRepresentation(headers.Digest) }, { "content-range", StringUtils.ToStringRepresentation(headers.ContentRange) } }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://upload.box.com/api/2.0/files/upload_sessions/", StringUtils.ToStringRepresentation(uploadSessionId)), new FetchOptions(method: "PUT", headers: headersMap, fileStream: requestBody, contentType: "application/octet-stream", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<UploadedPart>(response.Data);
        }

        /// <summary>
        /// Abort an upload session and discard all data uploaded.
        /// 
        /// This cannot be reversed.
        /// </summary>
        /// <param name="uploadSessionId">
        /// The ID of the upload session.
        /// Example: "D5E3F7A"
        /// </param>
        /// <param name="headers">
        /// Headers of deleteFileUploadSessionById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task DeleteFileUploadSessionByIdAsync(string uploadSessionId, DeleteFileUploadSessionByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new DeleteFileUploadSessionByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://upload.box.com/api/2.0/files/upload_sessions/", StringUtils.ToStringRepresentation(uploadSessionId)), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
        }

        /// <summary>
        /// Return a list of the chunks uploaded to the upload
        /// session so far.
        /// </summary>
        /// <param name="uploadSessionId">
        /// The ID of the upload session.
        /// Example: "D5E3F7A"
        /// </param>
        /// <param name="queryParams">
        /// Query parameters of getFileUploadSessionParts method
        /// </param>
        /// <param name="headers">
        /// Headers of getFileUploadSessionParts method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<UploadParts> GetFileUploadSessionPartsAsync(string uploadSessionId, GetFileUploadSessionPartsQueryParamsArg? queryParams = default, GetFileUploadSessionPartsHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            queryParams = queryParams ?? new GetFileUploadSessionPartsQueryParamsArg();
            headers = headers ?? new GetFileUploadSessionPartsHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(map: new Dictionary<string, string?>() { { "offset", StringUtils.ToStringRepresentation(queryParams.Offset) }, { "limit", StringUtils.ToStringRepresentation(queryParams.Limit) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://upload.box.com/api/2.0/files/upload_sessions/", StringUtils.ToStringRepresentation(uploadSessionId), "/parts"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<UploadParts>(response.Data);
        }

        /// <summary>
        /// Close an upload session and create a file from the
        /// uploaded chunks.
        /// </summary>
        /// <param name="uploadSessionId">
        /// The ID of the upload session.
        /// Example: "D5E3F7A"
        /// </param>
        /// <param name="requestBody">
        /// Request body of createFileUploadSessionCommit method
        /// </param>
        /// <param name="headers">
        /// Headers of createFileUploadSessionCommit method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<Files> CreateFileUploadSessionCommitAsync(string uploadSessionId, CreateFileUploadSessionCommitRequestBodyArg requestBody, CreateFileUploadSessionCommitHeadersArg headers, System.Threading.CancellationToken? cancellationToken = null) {
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() { { "digest", StringUtils.ToStringRepresentation(headers.Digest) }, { "if-match", StringUtils.ToStringRepresentation(headers.IfMatch) }, { "if-none-match", StringUtils.ToStringRepresentation(headers.IfNoneMatch) } }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://upload.box.com/api/2.0/files/upload_sessions/", StringUtils.ToStringRepresentation(uploadSessionId), "/commit"), new FetchOptions(method: "POST", headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<Files>(response.Data);
        }

    }
}