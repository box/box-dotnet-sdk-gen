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
    public class UserCollaborationsManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public UserCollaborationsManager() {
            
        }
        public async System.Threading.Tasks.Task<Collaboration> GetCollaborationById(string collaborationId, GetCollaborationByIdQueryParamsArg? queryParams = default, GetCollaborationByIdHeadersArg? headers = default) {
            queryParams = queryParams ?? new GetCollaborationByIdQueryParamsArg();
            headers = headers ?? new GetCollaborationByIdHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", Utils.ToString(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/collaborations/", collaborationId), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<Collaboration>(response.Text);
        }

        public async System.Threading.Tasks.Task<Collaboration> UpdateCollaborationById(string collaborationId, UpdateCollaborationByIdRequestBodyArg requestBody, UpdateCollaborationByIdHeadersArg? headers = default) {
            headers = headers ?? new UpdateCollaborationByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/collaborations/", collaborationId), new FetchOptions(method: "PUT", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<Collaboration>(response.Text);
        }

        public async System.Threading.Tasks.Task DeleteCollaborationById(string collaborationId, DeleteCollaborationByIdHeadersArg? headers = default) {
            headers = headers ?? new DeleteCollaborationByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/collaborations/", collaborationId), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession));
        }

        public async System.Threading.Tasks.Task<Collaboration> CreateCollaboration(CreateCollaborationRequestBodyArg requestBody, CreateCollaborationQueryParamsArg? queryParams = default, CreateCollaborationHeadersArg? headers = default) {
            queryParams = queryParams ?? new CreateCollaborationQueryParamsArg();
            headers = headers ?? new CreateCollaborationHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", Utils.ToString(queryParams.Fields) }, { "notify", Utils.ToString(queryParams.Notify) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/collaborations"), new FetchOptions(method: "POST", parameters: queryParamsMap, headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<Collaboration>(response.Text);
        }

    }
}