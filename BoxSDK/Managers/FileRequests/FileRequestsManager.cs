using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DictionaryExtensions;
using StringExtensions;
using Fetch;
using Serializer;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class FileRequestsManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public FileRequestsManager() {
            
        }
        /// <summary>
        /// Retrieves the information about a file request.
        /// </summary>
        /// <param name="fileRequestId">
        /// The unique identifier that represent a file request.
        /// 
        /// The ID for any file request can be determined
        /// by visiting a file request builder in the web application
        /// and copying the ID from the URL. For example,
        /// for the URL `https://*.app.box.com/filerequest/123`
        /// the `file_request_id` is `123`.
        /// Example: "123"
        /// </param>
        /// <param name="headers">
        /// Headers of getFileRequestById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<FileRequest> GetFileRequestByIdAsync(string fileRequestId, GetFileRequestByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new GetFileRequestByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/file_requests/", StringUtils.ToStringRepresentation(fileRequestId)), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<FileRequest>(response.Data);
        }

        /// <summary>
        /// Updates a file request. This can be used to activate or
        /// deactivate a file request.
        /// </summary>
        /// <param name="fileRequestId">
        /// The unique identifier that represent a file request.
        /// 
        /// The ID for any file request can be determined
        /// by visiting a file request builder in the web application
        /// and copying the ID from the URL. For example,
        /// for the URL `https://*.app.box.com/filerequest/123`
        /// the `file_request_id` is `123`.
        /// Example: "123"
        /// </param>
        /// <param name="requestBody">
        /// Request body of updateFileRequestById method
        /// </param>
        /// <param name="headers">
        /// Headers of updateFileRequestById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<FileRequest> UpdateFileRequestByIdAsync(string fileRequestId, FileRequestUpdateRequest requestBody, UpdateFileRequestByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new UpdateFileRequestByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() { { "if-match", StringUtils.ToStringRepresentation(headers.IfMatch) } }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/file_requests/", StringUtils.ToStringRepresentation(fileRequestId)), new FetchOptions(method: "PUT", headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<FileRequest>(response.Data);
        }

        /// <summary>
        /// Deletes a file request permanently.
        /// </summary>
        /// <param name="fileRequestId">
        /// The unique identifier that represent a file request.
        /// 
        /// The ID for any file request can be determined
        /// by visiting a file request builder in the web application
        /// and copying the ID from the URL. For example,
        /// for the URL `https://*.app.box.com/filerequest/123`
        /// the `file_request_id` is `123`.
        /// Example: "123"
        /// </param>
        /// <param name="headers">
        /// Headers of deleteFileRequestById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task DeleteFileRequestByIdAsync(string fileRequestId, DeleteFileRequestByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new DeleteFileRequestByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/file_requests/", StringUtils.ToStringRepresentation(fileRequestId)), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
        }

        /// <summary>
        /// Copies an existing file request that is already present on one folder,
        /// and applies it to another folder.
        /// </summary>
        /// <param name="fileRequestId">
        /// The unique identifier that represent a file request.
        /// 
        /// The ID for any file request can be determined
        /// by visiting a file request builder in the web application
        /// and copying the ID from the URL. For example,
        /// for the URL `https://*.app.box.com/filerequest/123`
        /// the `file_request_id` is `123`.
        /// Example: "123"
        /// </param>
        /// <param name="requestBody">
        /// Request body of createFileRequestCopy method
        /// </param>
        /// <param name="headers">
        /// Headers of createFileRequestCopy method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<FileRequest> CreateFileRequestCopyAsync(string fileRequestId, FileRequestCopyRequest requestBody, CreateFileRequestCopyHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new CreateFileRequestCopyHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/file_requests/", StringUtils.ToStringRepresentation(fileRequestId), "/copy"), new FetchOptions(method: "POST", headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<FileRequest>(response.Data);
        }

    }
}