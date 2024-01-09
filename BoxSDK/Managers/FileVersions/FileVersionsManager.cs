using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using StringExtensions;
using DictionaryExtensions;
using Fetch;
using Serializer;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class FileVersionsManager : IFileVersionsManager {
        public IAuthentication? Auth { get; set; } = default;

        public NetworkSession NetworkSession { get; set; }

        public FileVersionsManager(NetworkSession networkSession = default) {
            NetworkSession = networkSession ?? new NetworkSession();
        }
        /// <summary>
        /// Retrieve a list of the past versions for a file.
        /// 
        /// Versions are only tracked by Box users with premium accounts. To fetch the ID
        /// of the current version of a file, use the `GET /file/:id` API.
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
        /// <param name="queryParams">
        /// Query parameters of getFileVersions method
        /// </param>
        /// <param name="headers">
        /// Headers of getFileVersions method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<FileVersions> GetFileVersionsAsync(string fileId, GetFileVersionsQueryParams? queryParams = default, GetFileVersionsHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            queryParams = queryParams ?? new GetFileVersionsQueryParams();
            headers = headers ?? new GetFileVersionsHeaders();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(map: new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) }, { "limit", StringUtils.ToStringRepresentation(queryParams.Limit) }, { "offset", StringUtils.ToStringRepresentation(queryParams.Offset) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/files/", StringUtils.ToStringRepresentation(fileId), "/versions"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<FileVersions>(response.Data);
        }

        /// <summary>
        /// Retrieve a specific version of a file.
        /// 
        /// Versions are only tracked for Box users with premium accounts.
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
        /// <param name="fileVersionId">
        /// The ID of the file version
        /// Example: "1234"
        /// </param>
        /// <param name="queryParams">
        /// Query parameters of getFileVersionById method
        /// </param>
        /// <param name="headers">
        /// Headers of getFileVersionById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<FileVersionFull> GetFileVersionByIdAsync(string fileId, string fileVersionId, GetFileVersionByIdQueryParams? queryParams = default, GetFileVersionByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            queryParams = queryParams ?? new GetFileVersionByIdQueryParams();
            headers = headers ?? new GetFileVersionByIdHeaders();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(map: new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/files/", StringUtils.ToStringRepresentation(fileId), "/versions/", StringUtils.ToStringRepresentation(fileVersionId)), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<FileVersionFull>(response.Data);
        }

        /// <summary>
        /// Restores a specific version of a file after it was deleted.
        /// Don't use this endpoint to restore Box Notes,
        /// as it works with file formats such as PDF, DOC,
        /// PPTX or similar.
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
        /// <param name="fileVersionId">
        /// The ID of the file version
        /// Example: "1234"
        /// </param>
        /// <param name="requestBody">
        /// Request body of updateFileVersionById method
        /// </param>
        /// <param name="headers">
        /// Headers of updateFileVersionById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<FileVersionFull> UpdateFileVersionByIdAsync(string fileId, string fileVersionId, UpdateFileVersionByIdRequestBody? requestBody = default, UpdateFileVersionByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            requestBody = requestBody ?? new UpdateFileVersionByIdRequestBody();
            headers = headers ?? new UpdateFileVersionByIdHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/files/", StringUtils.ToStringRepresentation(fileId), "/versions/", StringUtils.ToStringRepresentation(fileVersionId)), new FetchOptions(method: "PUT", headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<FileVersionFull>(response.Data);
        }

        /// <summary>
        /// Move a file version to the trash.
        /// 
        /// Versions are only tracked for Box users with premium accounts.
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
        /// <param name="fileVersionId">
        /// The ID of the file version
        /// Example: "1234"
        /// </param>
        /// <param name="headers">
        /// Headers of deleteFileVersionById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task DeleteFileVersionByIdAsync(string fileId, string fileVersionId, DeleteFileVersionByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new DeleteFileVersionByIdHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() { { "if-match", StringUtils.ToStringRepresentation(headers.IfMatch) } }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/files/", StringUtils.ToStringRepresentation(fileId), "/versions/", StringUtils.ToStringRepresentation(fileVersionId)), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
        }

        /// <summary>
        /// Promote a specific version of a file.
        /// 
        /// If previous versions exist, this method can be used to
        /// promote one of the older versions to the top of the version history.
        /// 
        /// This creates a new copy of the old version and puts it at the
        /// top of the versions history. The file will have the exact same contents
        /// as the older version, with the the same hash digest, `etag`, and
        /// name as the original.
        /// 
        /// Other properties such as comments do not get updated to their
        /// former values.
        /// 
        /// Don't use this endpoint to restore Box Notes,
        /// as it works with file formats such as PDF, DOC,
        /// PPTX or similar.
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
        /// Request body of promoteFileVersion method
        /// </param>
        /// <param name="queryParams">
        /// Query parameters of promoteFileVersion method
        /// </param>
        /// <param name="headers">
        /// Headers of promoteFileVersion method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<FileVersionFull> PromoteFileVersionAsync(string fileId, PromoteFileVersionRequestBody? requestBody = default, PromoteFileVersionQueryParams? queryParams = default, PromoteFileVersionHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            requestBody = requestBody ?? new PromoteFileVersionRequestBody();
            queryParams = queryParams ?? new PromoteFileVersionQueryParams();
            headers = headers ?? new PromoteFileVersionHeaders();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(map: new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/files/", StringUtils.ToStringRepresentation(fileId), "/versions/current"), new FetchOptions(method: "POST", parameters: queryParamsMap, headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<FileVersionFull>(response.Data);
        }

    }
}