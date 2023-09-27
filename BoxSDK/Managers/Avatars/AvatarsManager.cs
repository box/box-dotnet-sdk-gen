using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DictionaryExtensions;
using StringExtensions;
using Fetch;
using System;
using Serializer;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class AvatarsManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public AvatarsManager() {
            
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
        public async System.Threading.Tasks.Task<System.IO.Stream> GetUserAvatarAsync(string userId, GetUserAvatarHeadersArg? headers = default) {
            headers = headers ?? new GetUserAvatarHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/users/", StringUtils.ToStringRepresentation(userId), "/avatar"), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "binary", auth: this.Auth, networkSession: this.NetworkSession)).ConfigureAwait(false);
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
        public async System.Threading.Tasks.Task<UserAvatar> CreateUserAvatarAsync(string userId, CreateUserAvatarRequestBodyArg requestBody, CreateUserAvatarHeadersArg? headers = default) {
            headers = headers ?? new CreateUserAvatarHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/users/", StringUtils.ToStringRepresentation(userId), "/avatar"), new FetchOptions(method: "POST", headers: headersMap, multipartData: Array.AsReadOnly(new [] {new MultipartItem(partName: "pic", fileStream: requestBody.Pic, fileName: requestBody.PicFileName, contentType: requestBody.PicContentType)}), contentType: "multipart/form-data", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<UserAvatar>(response.Text);
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
        public async System.Threading.Tasks.Task DeleteUserAvatarAsync(string userId, DeleteUserAvatarHeadersArg? headers = default) {
            headers = headers ?? new DeleteUserAvatarHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/users/", StringUtils.ToStringRepresentation(userId), "/avatar"), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession)).ConfigureAwait(false);
        }

    }
}