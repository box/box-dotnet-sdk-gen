using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using StringExtensions;
using DictionaryExtensions;
using Fetch;
using Serializer;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class ListCollaborationsManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public ListCollaborationsManager() {
            
        }
        public async System.Threading.Tasks.Task<Collaborations> GetFileCollaborations(string fileId, GetFileCollaborationsQueryParamsArg? queryParams = default, GetFileCollaborationsHeadersArg? headers = default) {
            queryParams = queryParams ?? new GetFileCollaborationsQueryParamsArg();
            headers = headers ?? new GetFileCollaborationsHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) }, { "limit", StringUtils.ToStringRepresentation(queryParams.Limit) }, { "marker", StringUtils.ToStringRepresentation(queryParams.Marker) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/files/", StringUtils.ToStringRepresentation(fileId), "/collaborations"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<Collaborations>(response.Text);
        }

        public async System.Threading.Tasks.Task<Collaborations> GetFolderCollaborations(string folderId, GetFolderCollaborationsQueryParamsArg? queryParams = default, GetFolderCollaborationsHeadersArg? headers = default) {
            queryParams = queryParams ?? new GetFolderCollaborationsQueryParamsArg();
            headers = headers ?? new GetFolderCollaborationsHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/folders/", StringUtils.ToStringRepresentation(folderId), "/collaborations"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<Collaborations>(response.Text);
        }

        public async System.Threading.Tasks.Task<Collaborations> GetCollaborations(GetCollaborationsQueryParamsArg queryParams, GetCollaborationsHeadersArg? headers = default) {
            headers = headers ?? new GetCollaborationsHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "status", StringUtils.ToStringRepresentation(queryParams.Status) }, { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) }, { "offset", StringUtils.ToStringRepresentation(queryParams.Offset) }, { "limit", StringUtils.ToStringRepresentation(queryParams.Limit) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/collaborations"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<Collaborations>(response.Text);
        }

        public async System.Threading.Tasks.Task<Collaborations> GetGroupCollaborations(string groupId, GetGroupCollaborationsQueryParamsArg? queryParams = default, GetGroupCollaborationsHeadersArg? headers = default) {
            queryParams = queryParams ?? new GetGroupCollaborationsQueryParamsArg();
            headers = headers ?? new GetGroupCollaborationsHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "limit", StringUtils.ToStringRepresentation(queryParams.Limit) }, { "offset", StringUtils.ToStringRepresentation(queryParams.Offset) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/groups/", StringUtils.ToStringRepresentation(groupId), "/collaborations"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<Collaborations>(response.Text);
        }

    }
}