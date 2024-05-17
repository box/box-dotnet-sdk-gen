using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DictionaryExtensions;
using StringExtensions;
using Fetch;
using System;
using Serializer;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class AvatarsManager : IAvatarsManager {
        public IAuthentication? Auth { get; init; }

        public NetworkSession NetworkSession { get; }

        public AvatarsManager(NetworkSession networkSession = default) {
            NetworkSession = networkSession ?? new NetworkSession();
        }
        /// <summary>
        /// Retrieves an image of a the user's avatar.
        /// </summary>
        /// <param name="userId">
        /// The ID of the user.
        /// Example: "12345"
        /// </param>
        /// <param name="headers">
        /// Headers of getUserAvatar method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<System.IO.Stream> GetUserAvatarAsync(string userId, GetUserAvatarHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new GetUserAvatarHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/2.0/users/", StringUtils.ToStringRepresentation(userId), "/avatar"), new FetchOptions(networkSession: this.NetworkSession) { Method = "GET", Headers = headersMap, ResponseFormat = "binary", Auth = this.Auth, CancellationToken = cancellationToken }).ConfigureAwait(false);
            return response.Content;
        }

        /// <summary>
        /// Adds or updates a user avatar.
        /// </summary>
        /// <param name="userId">
        /// The ID of the user.
        /// Example: "12345"
        /// </param>
        /// <param name="requestBody">
        /// Request body of createUserAvatar method
        /// </param>
        /// <param name="headers">
        /// Headers of createUserAvatar method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<UserAvatar> CreateUserAvatarAsync(string userId, CreateUserAvatarRequestBody requestBody, CreateUserAvatarHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new CreateUserAvatarHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/2.0/users/", StringUtils.ToStringRepresentation(userId), "/avatar"), new FetchOptions(networkSession: this.NetworkSession) { Method = "POST", Headers = headersMap, MultipartData = Array.AsReadOnly(new [] {new MultipartItem(partName: "pic") { FileStream = requestBody.Pic, FileName = requestBody.PicFileName, ContentType = requestBody.PicContentType }}), ContentType = "multipart/form-data", ResponseFormat = "json", Auth = this.Auth, CancellationToken = cancellationToken }).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<UserAvatar>(response.Data);
        }

        /// <summary>
        /// Removes an existing user avatar.
        /// You cannot reverse this operation.
        /// </summary>
        /// <param name="userId">
        /// The ID of the user.
        /// Example: "12345"
        /// </param>
        /// <param name="headers">
        /// Headers of deleteUserAvatar method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task DeleteUserAvatarAsync(string userId, DeleteUserAvatarHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new DeleteUserAvatarHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/2.0/users/", StringUtils.ToStringRepresentation(userId), "/avatar"), new FetchOptions(networkSession: this.NetworkSession) { Method = "DELETE", Headers = headersMap, ResponseFormat = null, Auth = this.Auth, CancellationToken = cancellationToken }).ConfigureAwait(false);
        }

    }
}