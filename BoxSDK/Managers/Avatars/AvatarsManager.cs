using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DictionaryExtensions;
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
        public async System.Threading.Tasks.Task<System.IO.Stream> GetUserAvatar(string userId, GetUserAvatarHeadersArg? headers = default) {
            headers = headers ?? new GetUserAvatarHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/users/", userId, "/avatar"), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "binary", auth: this.Auth, networkSession: this.NetworkSession));
            return response.Content;
        }

        public async System.Threading.Tasks.Task<UserAvatar> CreateUserAvatar(string userId, CreateUserAvatarRequestBodyArg requestBody, CreateUserAvatarHeadersArg? headers = default) {
            headers = headers ?? new CreateUserAvatarHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/users/", userId, "/avatar"), new FetchOptions(method: "POST", headers: headersMap, multipartData: Array.AsReadOnly(new [] {new MultipartItem(partName: "pic", fileStream: requestBody.Pic, fileName: requestBody.PicFileName, contentType: requestBody.PicContentType)}), contentType: "multipart/form-data", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<UserAvatar>(response.Text);
        }

        public async System.Threading.Tasks.Task DeleteUserAvatar(string userId, DeleteUserAvatarHeadersArg? headers = default) {
            headers = headers ?? new DeleteUserAvatarHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/users/", userId, "/avatar"), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession));
        }

    }
}