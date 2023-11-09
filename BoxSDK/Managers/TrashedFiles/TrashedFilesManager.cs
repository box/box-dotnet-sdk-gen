using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using StringExtensions;
using DictionaryExtensions;
using Serializer;
using Fetch;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class TrashedFilesManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public TrashedFilesManager() {
            
        }
        /// <summary>
        /// Restores a file that has been moved to the trash.
        /// 
        /// An optional new parent ID can be provided to restore the file to in case the
        /// original folder has been deleted.
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
        /// Request body of restoreFileFromTrash method
        /// </param>
        /// <param name="queryParams">
        /// Query parameters of restoreFileFromTrash method
        /// </param>
        /// <param name="headers">
        /// Headers of restoreFileFromTrash method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<TrashFileRestored> RestoreFileFromTrashAsync(string fileId, RestoreFileFromTrashRequestBodyArg? requestBody = default, RestoreFileFromTrashQueryParamsArg? queryParams = default, RestoreFileFromTrashHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            requestBody = requestBody ?? new RestoreFileFromTrashRequestBodyArg();
            queryParams = queryParams ?? new RestoreFileFromTrashQueryParamsArg();
            headers = headers ?? new RestoreFileFromTrashHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/files/", StringUtils.ToStringRepresentation(fileId)), new FetchOptions(method: "POST", parameters: queryParamsMap, headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<TrashFileRestored>(response.Data);
        }

        /// <summary>
        /// Retrieves a file that has been moved to the trash.
        /// 
        /// Please note that only if the file itself has been moved to the
        /// trash can it be retrieved with this API call. If instead one of
        /// its parent folders was moved to the trash, only that folder
        /// can be inspected using the
        /// [`GET /folders/:id/trash`](e://get_folders_id_trash) API.
        /// 
        /// To list all items that have been moved to the trash, please
        /// use the [`GET /folders/trash/items`](e://get-folders-trash-items/)
        /// API.
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
        /// Query parameters of getFileTrash method
        /// </param>
        /// <param name="headers">
        /// Headers of getFileTrash method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<TrashFile> GetFileTrashAsync(string fileId, GetFileTrashQueryParamsArg? queryParams = default, GetFileTrashHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            queryParams = queryParams ?? new GetFileTrashQueryParamsArg();
            headers = headers ?? new GetFileTrashHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/files/", StringUtils.ToStringRepresentation(fileId), "/trash"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<TrashFile>(response.Data);
        }

        /// <summary>
        /// Permanently deletes a file that is in the trash.
        /// This action cannot be undone.
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
        /// <param name="headers">
        /// Headers of deleteFileTrash method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task DeleteFileTrashAsync(string fileId, DeleteFileTrashHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new DeleteFileTrashHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/files/", StringUtils.ToStringRepresentation(fileId), "/trash"), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
        }

    }
}