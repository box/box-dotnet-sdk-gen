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
    public class UsersManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public UsersManager() {
            
        }
        public async System.Threading.Tasks.Task<Users> GetUsers(GetUsersQueryParamsArg? queryParams = default, GetUsersHeadersArg? headers = default) {
            queryParams = queryParams ?? new GetUsersQueryParamsArg();
            headers = headers ?? new GetUsersHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "filter_term", StringUtils.ToStringRepresentation(queryParams.FilterTerm) }, { "user_type", StringUtils.ToStringRepresentation(queryParams.UserType) }, { "external_app_user_id", StringUtils.ToStringRepresentation(queryParams.ExternalAppUserId) }, { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) }, { "offset", StringUtils.ToStringRepresentation(queryParams.Offset) }, { "limit", StringUtils.ToStringRepresentation(queryParams.Limit) }, { "usemarker", StringUtils.ToStringRepresentation(queryParams.Usemarker) }, { "marker", StringUtils.ToStringRepresentation(queryParams.Marker) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/users"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<Users>(response.Text);
        }

        public async System.Threading.Tasks.Task<User> CreateUser(CreateUserRequestBodyArg requestBody, CreateUserQueryParamsArg? queryParams = default, CreateUserHeadersArg? headers = default) {
            queryParams = queryParams ?? new CreateUserQueryParamsArg();
            headers = headers ?? new CreateUserHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/users"), new FetchOptions(method: "POST", parameters: queryParamsMap, headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<User>(response.Text);
        }

        public async System.Threading.Tasks.Task<UserFull> GetUserMe(GetUserMeQueryParamsArg? queryParams = default, GetUserMeHeadersArg? headers = default) {
            queryParams = queryParams ?? new GetUserMeQueryParamsArg();
            headers = headers ?? new GetUserMeHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/users/me"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<UserFull>(response.Text);
        }

        public async System.Threading.Tasks.Task<UserFull> GetUserById(string userId, GetUserByIdQueryParamsArg? queryParams = default, GetUserByIdHeadersArg? headers = default) {
            queryParams = queryParams ?? new GetUserByIdQueryParamsArg();
            headers = headers ?? new GetUserByIdHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/users/", StringUtils.ToStringRepresentation(userId)), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<UserFull>(response.Text);
        }

        public async System.Threading.Tasks.Task<UserFull> UpdateUserById(string userId, UpdateUserByIdRequestBodyArg? requestBody = default, UpdateUserByIdQueryParamsArg? queryParams = default, UpdateUserByIdHeadersArg? headers = default) {
            requestBody = requestBody ?? new UpdateUserByIdRequestBodyArg();
            queryParams = queryParams ?? new UpdateUserByIdQueryParamsArg();
            headers = headers ?? new UpdateUserByIdHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/users/", StringUtils.ToStringRepresentation(userId)), new FetchOptions(method: "PUT", parameters: queryParamsMap, headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<UserFull>(response.Text);
        }

        public async System.Threading.Tasks.Task DeleteUserById(string userId, DeleteUserByIdQueryParamsArg? queryParams = default, DeleteUserByIdHeadersArg? headers = default) {
            queryParams = queryParams ?? new DeleteUserByIdQueryParamsArg();
            headers = headers ?? new DeleteUserByIdHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "notify", StringUtils.ToStringRepresentation(queryParams.Notify) }, { "force", StringUtils.ToStringRepresentation(queryParams.Force) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/users/", StringUtils.ToStringRepresentation(userId)), new FetchOptions(method: "DELETE", parameters: queryParamsMap, headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession));
        }

    }
}