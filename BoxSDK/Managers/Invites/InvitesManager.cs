using System.Text.Json.Serialization;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DictionaryExtensions;
using Serializer;
using Fetch;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class InvitesManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public InvitesManager() {
            
        }
        public async System.Threading.Tasks.Task<Invite> CreateInvite(CreateInviteRequestBodyArg requestBody, CreateInviteQueryParamsArg? queryParams = default, CreateInviteHeadersArg? headers = default) {
            queryParams = queryParams ?? new CreateInviteQueryParamsArg();
            headers = headers ?? new CreateInviteHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", Utils.ToString(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/invites"), new FetchOptions(method: "POST", parameters: queryParamsMap, headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<Invite>(response.Text);
        }

        public async System.Threading.Tasks.Task<Invite> GetInviteById(string inviteId, GetInviteByIdQueryParamsArg? queryParams = default, GetInviteByIdHeadersArg? headers = default) {
            queryParams = queryParams ?? new GetInviteByIdQueryParamsArg();
            headers = headers ?? new GetInviteByIdHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", Utils.ToString(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/invites/", inviteId), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<Invite>(response.Text);
        }

    }
}