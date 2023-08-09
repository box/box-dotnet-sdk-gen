using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using DictionaryExtensions;
using Fetch;
using System;
using Serializer;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class AvatarsManager {
        public IAuth Auth { get; }

        public NetworkSession NetworkSession { get; }

        public AvatarsManager(IAuth auth, NetworkSession networkSession) {
            Auth = auth;
            NetworkSession = networkSession;
        }
        public async System.Threading.Tasks.Task<Stream> GetUserAvatar(string userId, GetUserAvatarHeadersArg headers) {
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/users/", userId, "/avatar"), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "binary", auth: this.Auth, networkSession: this.NetworkSession));
            return response.Content;
        }

        public async System.Threading.Tasks.Task<UserAvatar> CreateUserAvatar(string userId, CreateUserAvatarRequestBodyArg requestBody, CreateUserAvatarHeadersArg headers) {
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/users/", userId, "/avatar"), new FetchOptions(method: "POST", headers: headersMap, multipartData: Array.AsReadOnly(new [] {new MultipartItem(partName: "pic", fileStream: requestBody.Pic, contentType: requestBody.PicContentType, fileName: requestBody.PicFileName)}), contentType: "multipart/form-data", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<UserAvatar>(response.Text);
        }

        public async System.Threading.Tasks.Task DeleteUserAvatar(string userId, DeleteUserAvatarHeadersArg headers) {
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/users/", userId, "/avatar"), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession));
        }

    }
}