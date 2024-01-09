using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using StringExtensions;
using DictionaryExtensions;
using Fetch;
using Serializer;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class MembershipsManager : IMembershipsManager {
        public IAuthentication? Auth { get; set; } = default;

        public NetworkSession NetworkSession { get; set; }

        public MembershipsManager(NetworkSession networkSession = default) {
            NetworkSession = networkSession ?? new NetworkSession();
        }
        /// <summary>
        /// Retrieves all the groups for a user. Only members of this
        /// group or users with admin-level permissions will be able to
        /// use this API.
        /// </summary>
        /// <param name="userId">
        /// The ID of the user.
        /// Example: "12345"
        /// </param>
        /// <param name="queryParams">
        /// Query parameters of getUserMemberships method
        /// </param>
        /// <param name="headers">
        /// Headers of getUserMemberships method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<GroupMemberships> GetUserMembershipsAsync(string userId, GetUserMembershipsQueryParams? queryParams = default, GetUserMembershipsHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            queryParams = queryParams ?? new GetUserMembershipsQueryParams();
            headers = headers ?? new GetUserMembershipsHeaders();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(map: new Dictionary<string, string?>() { { "limit", StringUtils.ToStringRepresentation(queryParams.Limit) }, { "offset", StringUtils.ToStringRepresentation(queryParams.Offset) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/users/", StringUtils.ToStringRepresentation(userId), "/memberships"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<GroupMemberships>(response.Data);
        }

        /// <summary>
        /// Retrieves all the members for a group. Only members of this
        /// group or users with admin-level permissions will be able to
        /// use this API.
        /// </summary>
        /// <param name="groupId">
        /// The ID of the group.
        /// Example: "57645"
        /// </param>
        /// <param name="queryParams">
        /// Query parameters of getGroupMemberships method
        /// </param>
        /// <param name="headers">
        /// Headers of getGroupMemberships method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<GroupMemberships> GetGroupMembershipsAsync(string groupId, GetGroupMembershipsQueryParams? queryParams = default, GetGroupMembershipsHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            queryParams = queryParams ?? new GetGroupMembershipsQueryParams();
            headers = headers ?? new GetGroupMembershipsHeaders();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(map: new Dictionary<string, string?>() { { "limit", StringUtils.ToStringRepresentation(queryParams.Limit) }, { "offset", StringUtils.ToStringRepresentation(queryParams.Offset) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/groups/", StringUtils.ToStringRepresentation(groupId), "/memberships"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<GroupMemberships>(response.Data);
        }

        /// <summary>
        /// Creates a group membership. Only users with
        /// admin-level permissions will be able to use this API.
        /// </summary>
        /// <param name="requestBody">
        /// Request body of createGroupMembership method
        /// </param>
        /// <param name="queryParams">
        /// Query parameters of createGroupMembership method
        /// </param>
        /// <param name="headers">
        /// Headers of createGroupMembership method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<GroupMembership> CreateGroupMembershipAsync(CreateGroupMembershipRequestBody requestBody, CreateGroupMembershipQueryParams? queryParams = default, CreateGroupMembershipHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            queryParams = queryParams ?? new CreateGroupMembershipQueryParams();
            headers = headers ?? new CreateGroupMembershipHeaders();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(map: new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/group_memberships"), new FetchOptions(method: "POST", parameters: queryParamsMap, headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<GroupMembership>(response.Data);
        }

        /// <summary>
        /// Retrieves a specific group membership. Only admins of this
        /// group or users with admin-level permissions will be able to
        /// use this API.
        /// </summary>
        /// <param name="groupMembershipId">
        /// The ID of the group membership.
        /// Example: "434534"
        /// </param>
        /// <param name="queryParams">
        /// Query parameters of getGroupMembershipById method
        /// </param>
        /// <param name="headers">
        /// Headers of getGroupMembershipById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<GroupMembership> GetGroupMembershipByIdAsync(string groupMembershipId, GetGroupMembershipByIdQueryParams? queryParams = default, GetGroupMembershipByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            queryParams = queryParams ?? new GetGroupMembershipByIdQueryParams();
            headers = headers ?? new GetGroupMembershipByIdHeaders();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(map: new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/group_memberships/", StringUtils.ToStringRepresentation(groupMembershipId)), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<GroupMembership>(response.Data);
        }

        /// <summary>
        /// Updates a user's group membership. Only admins of this
        /// group or users with admin-level permissions will be able to
        /// use this API.
        /// </summary>
        /// <param name="groupMembershipId">
        /// The ID of the group membership.
        /// Example: "434534"
        /// </param>
        /// <param name="requestBody">
        /// Request body of updateGroupMembershipById method
        /// </param>
        /// <param name="queryParams">
        /// Query parameters of updateGroupMembershipById method
        /// </param>
        /// <param name="headers">
        /// Headers of updateGroupMembershipById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<GroupMembership> UpdateGroupMembershipByIdAsync(string groupMembershipId, UpdateGroupMembershipByIdRequestBody? requestBody = default, UpdateGroupMembershipByIdQueryParams? queryParams = default, UpdateGroupMembershipByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            requestBody = requestBody ?? new UpdateGroupMembershipByIdRequestBody();
            queryParams = queryParams ?? new UpdateGroupMembershipByIdQueryParams();
            headers = headers ?? new UpdateGroupMembershipByIdHeaders();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(map: new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/group_memberships/", StringUtils.ToStringRepresentation(groupMembershipId)), new FetchOptions(method: "PUT", parameters: queryParamsMap, headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<GroupMembership>(response.Data);
        }

        /// <summary>
        /// Deletes a specific group membership. Only admins of this
        /// group or users with admin-level permissions will be able to
        /// use this API.
        /// </summary>
        /// <param name="groupMembershipId">
        /// The ID of the group membership.
        /// Example: "434534"
        /// </param>
        /// <param name="headers">
        /// Headers of deleteGroupMembershipById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task DeleteGroupMembershipByIdAsync(string groupMembershipId, DeleteGroupMembershipByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new DeleteGroupMembershipByIdHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/group_memberships/", StringUtils.ToStringRepresentation(groupMembershipId)), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
        }

    }
}