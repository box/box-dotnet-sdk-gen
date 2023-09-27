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
    public class FileVersionsManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public FileVersionsManager() {
            
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
        public async System.Threading.Tasks.Task<FileVersions> GetFileVersionsAsync(string fileId, GetFileVersionsQueryParamsArg? queryParams = default, GetFileVersionsHeadersArg? headers = default) {
            queryParams = queryParams ?? new GetFileVersionsQueryParamsArg();
            headers = headers ?? new GetFileVersionsHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) }, { "limit", StringUtils.ToStringRepresentation(queryParams.Limit) }, { "offset", StringUtils.ToStringRepresentation(queryParams.Offset) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/files/", StringUtils.ToStringRepresentation(fileId), "/versions"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<FileVersions>(response.Text);
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
        public async System.Threading.Tasks.Task<FileVersionFull> GetFileVersionByIdAsync(string fileId, string fileVersionId, GetFileVersionByIdQueryParamsArg? queryParams = default, GetFileVersionByIdHeadersArg? headers = default) {
            queryParams = queryParams ?? new GetFileVersionByIdQueryParamsArg();
            headers = headers ?? new GetFileVersionByIdHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/files/", StringUtils.ToStringRepresentation(fileId), "/versions/", StringUtils.ToStringRepresentation(fileVersionId)), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<FileVersionFull>(response.Text);
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
        public async System.Threading.Tasks.Task<FileVersionFull> UpdateFileVersionByIdAsync(string fileId, string fileVersionId, UpdateFileVersionByIdRequestBodyArg? requestBody = default, UpdateFileVersionByIdHeadersArg? headers = default) {
            requestBody = requestBody ?? new UpdateFileVersionByIdRequestBodyArg();
            headers = headers ?? new UpdateFileVersionByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/files/", StringUtils.ToStringRepresentation(fileId), "/versions/", StringUtils.ToStringRepresentation(fileVersionId)), new FetchOptions(method: "PUT", headers: headersMap, body: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<FileVersionFull>(response.Text);
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
        public async System.Threading.Tasks.Task DeleteFileVersionByIdAsync(string fileId, string fileVersionId, DeleteFileVersionByIdHeadersArg? headers = default) {
            headers = headers ?? new DeleteFileVersionByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() { { "if-match", StringUtils.ToStringRepresentation(headers.IfMatch) } }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/files/", StringUtils.ToStringRepresentation(fileId), "/versions/", StringUtils.ToStringRepresentation(fileVersionId)), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession)).ConfigureAwait(false);
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
        public async System.Threading.Tasks.Task<FileVersionFull> PromoteFileVersionAsync(string fileId, PromoteFileVersionRequestBodyArg? requestBody = default, PromoteFileVersionQueryParamsArg? queryParams = default, PromoteFileVersionHeadersArg? headers = default) {
            requestBody = requestBody ?? new PromoteFileVersionRequestBodyArg();
            queryParams = queryParams ?? new PromoteFileVersionQueryParamsArg();
            headers = headers ?? new PromoteFileVersionHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/files/", StringUtils.ToStringRepresentation(fileId), "/versions/current"), new FetchOptions(method: "POST", parameters: queryParamsMap, headers: headersMap, body: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<FileVersionFull>(response.Text);
        }

    }
}