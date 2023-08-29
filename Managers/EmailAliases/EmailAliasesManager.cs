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
    public class EmailAliasesManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public EmailAliasesManager() {
            
        }
        public async System.Threading.Tasks.Task<EmailAliases> GetUserEmailAliases(string userId, GetUserEmailAliasesHeadersArg? headers = default) {
            headers = headers ?? new GetUserEmailAliasesHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/users/", userId, "/email_aliases"), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<EmailAliases>(response.Text);
        }

        public async System.Threading.Tasks.Task<EmailAlias> CreateUserEmailAlias(string userId, CreateUserEmailAliasRequestBodyArg requestBody, CreateUserEmailAliasHeadersArg? headers = default) {
            headers = headers ?? new CreateUserEmailAliasHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/users/", userId, "/email_aliases"), new FetchOptions(method: "POST", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<EmailAlias>(response.Text);
        }

        public async System.Threading.Tasks.Task DeleteUserEmailAliasById(string userId, string emailAliasId, DeleteUserEmailAliasByIdHeadersArg? headers = default) {
            headers = headers ?? new DeleteUserEmailAliasByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/users/", userId, "/email_aliases/", emailAliasId), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession));
        }

    }
}