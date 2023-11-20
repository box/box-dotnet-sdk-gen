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
        /// <summary>
        /// Returns a list of all users for the Enterprise along with their `user_id`,
        /// `public_name`, and `login`.
        /// 
        /// The application and the authenticated user need to
        /// have the permission to look up users in the entire
        /// enterprise.
        /// </summary>
        /// <param name="queryParams">
        /// Query parameters of getUsers method
        /// </param>
        /// <param name="headers">
        /// Headers of getUsers method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<Users> GetUsersAsync(GetUsersQueryParamsArg? queryParams = default, GetUsersHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            queryParams = queryParams ?? new GetUsersQueryParamsArg();
            headers = headers ?? new GetUsersHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(map: new Dictionary<string, string?>() { { "filter_term", StringUtils.ToStringRepresentation(queryParams.FilterTerm) }, { "user_type", StringUtils.ToStringRepresentation(queryParams.UserType) }, { "external_app_user_id", StringUtils.ToStringRepresentation(queryParams.ExternalAppUserId) }, { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) }, { "offset", StringUtils.ToStringRepresentation(queryParams.Offset) }, { "limit", StringUtils.ToStringRepresentation(queryParams.Limit) }, { "usemarker", StringUtils.ToStringRepresentation(queryParams.Usemarker) }, { "marker", StringUtils.ToStringRepresentation(queryParams.Marker) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/users"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<Users>(response.Data);
        }

        /// <summary>
        /// Creates a new managed user in an enterprise. This endpoint
        /// is only available to users and applications with the right
        /// admin permissions.
        /// </summary>
        /// <param name="requestBody">
        /// Request body of createUser method
        /// </param>
        /// <param name="queryParams">
        /// Query parameters of createUser method
        /// </param>
        /// <param name="headers">
        /// Headers of createUser method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<UserFull> CreateUserAsync(CreateUserRequestBodyArg requestBody, CreateUserQueryParamsArg? queryParams = default, CreateUserHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            queryParams = queryParams ?? new CreateUserQueryParamsArg();
            headers = headers ?? new CreateUserHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(map: new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/users"), new FetchOptions(method: "POST", parameters: queryParamsMap, headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<UserFull>(response.Data);
        }

        /// <summary>
        /// Retrieves information about the user who is currently authenticated.
        /// 
        /// In the case of a client-side authenticated OAuth 2.0 application
        /// this will be the user who authorized the app.
        /// 
        /// In the case of a JWT, server-side authenticated application
        /// this will be the service account that belongs to the application
        /// by default.
        /// 
        /// Use the `As-User` header to change who this API call is made on behalf of.
        /// </summary>
        /// <param name="queryParams">
        /// Query parameters of getUserMe method
        /// </param>
        /// <param name="headers">
        /// Headers of getUserMe method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<UserFull> GetUserMeAsync(GetUserMeQueryParamsArg? queryParams = default, GetUserMeHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            queryParams = queryParams ?? new GetUserMeQueryParamsArg();
            headers = headers ?? new GetUserMeHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(map: new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/users/me"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<UserFull>(response.Data);
        }

        /// <summary>
        /// Retrieves information about a user in the enterprise.
        /// 
        /// The application and the authenticated user need to
        /// have the permission to look up users in the entire
        /// enterprise.
        /// 
        /// This endpoint also returns a limited set of information
        /// for external users who are collaborated on content
        /// owned by the enterprise for authenticated users with the
        /// right scopes. In this case, disallowed fields will return
        /// null instead.
        /// </summary>
        /// <param name="userId">
        /// The ID of the user.
        /// Example: "12345"
        /// </param>
        /// <param name="queryParams">
        /// Query parameters of getUserById method
        /// </param>
        /// <param name="headers">
        /// Headers of getUserById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<UserFull> GetUserByIdAsync(string userId, GetUserByIdQueryParamsArg? queryParams = default, GetUserByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            queryParams = queryParams ?? new GetUserByIdQueryParamsArg();
            headers = headers ?? new GetUserByIdHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(map: new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/users/", StringUtils.ToStringRepresentation(userId)), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<UserFull>(response.Data);
        }

        /// <summary>
        /// Updates a managed or app user in an enterprise. This endpoint
        /// is only available to users and applications with the right
        /// admin permissions.
        /// </summary>
        /// <param name="userId">
        /// The ID of the user.
        /// Example: "12345"
        /// </param>
        /// <param name="requestBody">
        /// Request body of updateUserById method
        /// </param>
        /// <param name="queryParams">
        /// Query parameters of updateUserById method
        /// </param>
        /// <param name="headers">
        /// Headers of updateUserById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<UserFull> UpdateUserByIdAsync(string userId, UpdateUserByIdRequestBodyArg? requestBody = default, UpdateUserByIdQueryParamsArg? queryParams = default, UpdateUserByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            requestBody = requestBody ?? new UpdateUserByIdRequestBodyArg();
            queryParams = queryParams ?? new UpdateUserByIdQueryParamsArg();
            headers = headers ?? new UpdateUserByIdHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(map: new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/users/", StringUtils.ToStringRepresentation(userId)), new FetchOptions(method: "PUT", parameters: queryParamsMap, headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<UserFull>(response.Data);
        }

        /// <summary>
        /// Deletes a user. By default this will fail if the user
        /// still owns any content. Move their owned content first
        /// before proceeding, or use the `force` field to delete
        /// the user and their files.
        /// </summary>
        /// <param name="userId">
        /// The ID of the user.
        /// Example: "12345"
        /// </param>
        /// <param name="queryParams">
        /// Query parameters of deleteUserById method
        /// </param>
        /// <param name="headers">
        /// Headers of deleteUserById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task DeleteUserByIdAsync(string userId, DeleteUserByIdQueryParamsArg? queryParams = default, DeleteUserByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            queryParams = queryParams ?? new DeleteUserByIdQueryParamsArg();
            headers = headers ?? new DeleteUserByIdHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(map: new Dictionary<string, string?>() { { "notify", StringUtils.ToStringRepresentation(queryParams.Notify) }, { "force", StringUtils.ToStringRepresentation(queryParams.Force) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/users/", StringUtils.ToStringRepresentation(userId)), new FetchOptions(method: "DELETE", parameters: queryParamsMap, headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
        }

    }
}