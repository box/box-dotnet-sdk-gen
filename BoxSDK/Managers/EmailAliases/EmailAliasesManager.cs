using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using DictionaryExtensions;
using StringExtensions;
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
        /// <summary>
        /// Retrieves all email aliases for a user. The collection
        /// does not include the primary login for the user.
        /// </summary>
        /// <param name="userId">
        /// The ID of the user.
        /// Example: "12345"
        /// </param>
        /// <param name="headers">
        /// Headers of getUserEmailAliases method
        /// </param>
        public async System.Threading.Tasks.Task<EmailAliases> GetUserEmailAliasesAsync(string userId, GetUserEmailAliasesHeadersArg? headers = default) {
            headers = headers ?? new GetUserEmailAliasesHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/users/", StringUtils.ToStringRepresentation(userId), "/email_aliases"), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<EmailAliases>(response.Text);
        }

        /// <summary>
        /// Adds a new email alias to a user account..
        /// </summary>
        /// <param name="userId">
        /// The ID of the user.
        /// Example: "12345"
        /// </param>
        /// <param name="requestBody">
        /// Request body of createUserEmailAlias method
        /// </param>
        /// <param name="headers">
        /// Headers of createUserEmailAlias method
        /// </param>
        public async System.Threading.Tasks.Task<EmailAlias> CreateUserEmailAliasAsync(string userId, CreateUserEmailAliasRequestBodyArg requestBody, CreateUserEmailAliasHeadersArg? headers = default) {
            headers = headers ?? new CreateUserEmailAliasHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/users/", StringUtils.ToStringRepresentation(userId), "/email_aliases"), new FetchOptions(method: "POST", headers: headersMap, body: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<EmailAlias>(response.Text);
        }

        /// <summary>
        /// Removes an email alias from a user.
        /// </summary>
        /// <param name="userId">
        /// The ID of the user.
        /// Example: "12345"
        /// </param>
        /// <param name="emailAliasId">
        /// The ID of the email alias.
        /// Example: "23432"
        /// </param>
        /// <param name="headers">
        /// Headers of deleteUserEmailAliasById method
        /// </param>
        public async System.Threading.Tasks.Task DeleteUserEmailAliasByIdAsync(string userId, string emailAliasId, DeleteUserEmailAliasByIdHeadersArg? headers = default) {
            headers = headers ?? new DeleteUserEmailAliasByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/users/", StringUtils.ToStringRepresentation(userId), "/email_aliases/", StringUtils.ToStringRepresentation(emailAliasId)), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession)).ConfigureAwait(false);
        }

    }
}