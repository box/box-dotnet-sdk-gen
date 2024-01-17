using System.Text.Json.Serialization;
using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using StringExtensions;
using DictionaryExtensions;
using Serializer;
using Fetch;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class TransferManager : ITransferManager {
        public IAuthentication? Auth { get; set; } = default;

        public NetworkSession NetworkSession { get; set; }

        public TransferManager(NetworkSession networkSession = default) {
            NetworkSession = networkSession ?? new NetworkSession();
        }
        /// <summary>
        /// Move all of the items (files, folders and workflows) owned by a user into
        /// another user's account
        /// 
        /// Only the root folder (`0`) can be transferred.
        /// 
        /// Folders can only be moved across users by users with administrative
        /// permissions.
        /// 
        /// All existing shared links and folder-level collaborations are transferred
        /// during the operation. Please note that while collaborations at the individual
        /// file-level are transferred during the operation, the collaborations are
        /// deleted when the original user is deleted.
        /// 
        /// This call will be performed synchronously which might lead to a slow response
        /// when the source user has a large number of items in all of its folders.
        /// 
        /// If the destination path has a metadata cascade policy attached to any of
        /// the parent folders, a metadata cascade operation will be kicked off
        /// asynchronously.
        /// 
        /// There is currently no way to check for when this operation is finished.
        /// 
        /// The destination folder's name will be in the format `{User}'s Files and
        /// Folders`, where `{User}` is the display name of the user.
        /// 
        /// To make this API call your application will need to have the "Read and write
        /// all files and folders stored in Box" scope enabled.
        /// 
        /// Please make sure the destination user has access to `Relay` or `Relay Lite`,
        /// and has access to the files and folders involved in the workflows being
        /// transferred.
        /// 
        /// Admins will receive an email when the operation is completed.
        /// </summary>
        /// <param name="userId">
        /// The ID of the user.
        /// Example: "12345"
        /// </param>
        /// <param name="requestBody">
        /// Request body of transferOwnedFolder method
        /// </param>
        /// <param name="queryParams">
        /// Query parameters of transferOwnedFolder method
        /// </param>
        /// <param name="headers">
        /// Headers of transferOwnedFolder method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<FolderFull> TransferOwnedFolderAsync(string userId, TransferOwnedFolderRequestBody requestBody, TransferOwnedFolderQueryParams? queryParams = default, TransferOwnedFolderHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            queryParams = queryParams ?? new TransferOwnedFolderQueryParams();
            headers = headers ?? new TransferOwnedFolderHeaders();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(map: new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) }, { "notify", StringUtils.ToStringRepresentation(queryParams.Notify) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/users/", StringUtils.ToStringRepresentation(userId), "/folders/0"), new FetchOptions(method: "PUT", parameters: queryParamsMap, headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<FolderFull>(response.Data);
        }

    }
}