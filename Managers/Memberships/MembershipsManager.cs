using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using DictionaryExtensions;
using Fetch;
using Serializer;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class MembershipsManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public MembershipsManager() {
            
        }
        public async System.Threading.Tasks.Task<GroupMemberships> GetUserMemberships(string userId, GetUserMembershipsQueryParamsArg? queryParams = default, GetUserMembershipsHeadersArg? headers = default) {
            queryParams = queryParams ?? new GetUserMembershipsQueryParamsArg();
            headers = headers ?? new GetUserMembershipsHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "limit", Utils.ToString(queryParams.Limit) }, { "offset", Utils.ToString(queryParams.Offset) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/users/", userId, "/memberships"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<GroupMemberships>(response.Text);
        }

        public async System.Threading.Tasks.Task<GroupMemberships> GetGroupMemberships(string groupId, GetGroupMembershipsQueryParamsArg? queryParams = default, GetGroupMembershipsHeadersArg? headers = default) {
            queryParams = queryParams ?? new GetGroupMembershipsQueryParamsArg();
            headers = headers ?? new GetGroupMembershipsHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "limit", Utils.ToString(queryParams.Limit) }, { "offset", Utils.ToString(queryParams.Offset) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/groups/", groupId, "/memberships"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<GroupMemberships>(response.Text);
        }

        public async System.Threading.Tasks.Task<GroupMembership> CreateGroupMembership(CreateGroupMembershipRequestBodyArg requestBody, CreateGroupMembershipQueryParamsArg? queryParams = default, CreateGroupMembershipHeadersArg? headers = default) {
            queryParams = queryParams ?? new CreateGroupMembershipQueryParamsArg();
            headers = headers ?? new CreateGroupMembershipHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", Utils.ToString(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/group_memberships"), new FetchOptions(method: "POST", parameters: queryParamsMap, headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<GroupMembership>(response.Text);
        }

        public async System.Threading.Tasks.Task<GroupMembership> GetGroupMembershipById(string groupMembershipId, GetGroupMembershipByIdQueryParamsArg? queryParams = default, GetGroupMembershipByIdHeadersArg? headers = default) {
            queryParams = queryParams ?? new GetGroupMembershipByIdQueryParamsArg();
            headers = headers ?? new GetGroupMembershipByIdHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", Utils.ToString(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/group_memberships/", groupMembershipId), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<GroupMembership>(response.Text);
        }

        public async System.Threading.Tasks.Task<GroupMembership> UpdateGroupMembershipById(string groupMembershipId, UpdateGroupMembershipByIdRequestBodyArg? requestBody = default, UpdateGroupMembershipByIdQueryParamsArg? queryParams = default, UpdateGroupMembershipByIdHeadersArg? headers = default) {
            requestBody = requestBody ?? new UpdateGroupMembershipByIdRequestBodyArg();
            queryParams = queryParams ?? new UpdateGroupMembershipByIdQueryParamsArg();
            headers = headers ?? new UpdateGroupMembershipByIdHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", Utils.ToString(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/group_memberships/", groupMembershipId), new FetchOptions(method: "PUT", parameters: queryParamsMap, headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<GroupMembership>(response.Text);
        }

        public async System.Threading.Tasks.Task DeleteGroupMembershipById(string groupMembershipId, DeleteGroupMembershipByIdHeadersArg? headers = default) {
            headers = headers ?? new DeleteGroupMembershipByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/group_memberships/", groupMembershipId), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession));
        }

    }
}