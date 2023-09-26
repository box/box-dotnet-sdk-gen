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
    public class GroupsManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public GroupsManager() {
            
        }
        public async System.Threading.Tasks.Task<Groups> GetGroups(GetGroupsQueryParamsArg? queryParams = default, GetGroupsHeadersArg? headers = default) {
            queryParams = queryParams ?? new GetGroupsQueryParamsArg();
            headers = headers ?? new GetGroupsHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "filter_term", StringUtils.ToStringRepresentation(queryParams.FilterTerm) }, { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) }, { "limit", StringUtils.ToStringRepresentation(queryParams.Limit) }, { "offset", StringUtils.ToStringRepresentation(queryParams.Offset) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/groups"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<Groups>(response.Text);
        }

        public async System.Threading.Tasks.Task<Group> CreateGroup(CreateGroupRequestBodyArg requestBody, CreateGroupQueryParamsArg? queryParams = default, CreateGroupHeadersArg? headers = default) {
            queryParams = queryParams ?? new CreateGroupQueryParamsArg();
            headers = headers ?? new CreateGroupHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/groups"), new FetchOptions(method: "POST", parameters: queryParamsMap, headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<Group>(response.Text);
        }

        public async System.Threading.Tasks.Task<GroupFull> GetGroupById(string groupId, GetGroupByIdQueryParamsArg? queryParams = default, GetGroupByIdHeadersArg? headers = default) {
            queryParams = queryParams ?? new GetGroupByIdQueryParamsArg();
            headers = headers ?? new GetGroupByIdHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/groups/", StringUtils.ToStringRepresentation(groupId)), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<GroupFull>(response.Text);
        }

        public async System.Threading.Tasks.Task<GroupFull> UpdateGroupById(string groupId, UpdateGroupByIdRequestBodyArg? requestBody = default, UpdateGroupByIdQueryParamsArg? queryParams = default, UpdateGroupByIdHeadersArg? headers = default) {
            requestBody = requestBody ?? new UpdateGroupByIdRequestBodyArg();
            queryParams = queryParams ?? new UpdateGroupByIdQueryParamsArg();
            headers = headers ?? new UpdateGroupByIdHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/groups/", StringUtils.ToStringRepresentation(groupId)), new FetchOptions(method: "PUT", parameters: queryParamsMap, headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<GroupFull>(response.Text);
        }

        public async System.Threading.Tasks.Task DeleteGroupById(string groupId, DeleteGroupByIdHeadersArg? headers = default) {
            headers = headers ?? new DeleteGroupByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/groups/", StringUtils.ToStringRepresentation(groupId)), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession));
        }

    }
}