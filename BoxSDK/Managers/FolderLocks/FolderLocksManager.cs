using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using StringExtensions;
using DictionaryExtensions;
using Fetch;
using Serializer;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class FolderLocksManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public FolderLocksManager() {
            
        }
        /// <summary>
        /// Retrieves folder lock details for a given folder.
        /// 
        /// You must be authenticated as the owner or co-owner of the folder to
        /// use this endpoint.
        /// </summary>
        /// <param name="queryParams">
        /// Query parameters of getFolderLocks method
        /// </param>
        /// <param name="headers">
        /// Headers of getFolderLocks method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<FolderLocks> GetFolderLocksAsync(GetFolderLocksQueryParamsArg queryParams, GetFolderLocksHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new GetFolderLocksHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(map: new Dictionary<string, string?>() { { "folder_id", StringUtils.ToStringRepresentation(queryParams.FolderId) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/folder_locks"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<FolderLocks>(response.Data);
        }

        /// <summary>
        /// Creates a folder lock on a folder, preventing it from being moved and/or
        /// deleted.
        /// 
        /// You must be authenticated as the owner or co-owner of the folder to
        /// use this endpoint.
        /// </summary>
        /// <param name="requestBody">
        /// Request body of createFolderLock method
        /// </param>
        /// <param name="headers">
        /// Headers of createFolderLock method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<FolderLock> CreateFolderLockAsync(CreateFolderLockRequestBodyArg requestBody, CreateFolderLockHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new CreateFolderLockHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/folder_locks"), new FetchOptions(method: "POST", headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<FolderLock>(response.Data);
        }

        /// <summary>
        /// Deletes a folder lock on a given folder.
        /// 
        /// You must be authenticated as the owner or co-owner of the folder to
        /// use this endpoint.
        /// </summary>
        /// <param name="folderLockId">
        /// The ID of the folder lock.
        /// Example: "12345"
        /// </param>
        /// <param name="headers">
        /// Headers of deleteFolderLockById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task DeleteFolderLockByIdAsync(string folderLockId, DeleteFolderLockByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new DeleteFolderLockByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/folder_locks/", StringUtils.ToStringRepresentation(folderLockId)), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
        }

    }
}