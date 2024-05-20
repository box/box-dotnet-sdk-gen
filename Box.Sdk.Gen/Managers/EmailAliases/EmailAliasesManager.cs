using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using DictionaryExtensions;
using StringExtensions;
using Fetch;
using Serializer;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class EmailAliasesManager : IEmailAliasesManager {
        public IAuthentication? Auth { get; init; }

        public NetworkSession NetworkSession { get; }

        public EmailAliasesManager(NetworkSession networkSession = default) {
            NetworkSession = networkSession ?? new NetworkSession();
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
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<EmailAliases> GetUserEmailAliasesAsync(string userId, GetUserEmailAliasesHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new GetUserEmailAliasesHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/2.0/users/", StringUtils.ToStringRepresentation(userId), "/email_aliases"), new FetchOptions(networkSession: this.NetworkSession) { Method = "GET", Headers = headersMap, ResponseFormat = "json", Auth = this.Auth, CancellationToken = cancellationToken }).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<EmailAliases>(response.Data);
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
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<EmailAlias> CreateUserEmailAliasAsync(string userId, CreateUserEmailAliasRequestBody requestBody, CreateUserEmailAliasHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new CreateUserEmailAliasHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/2.0/users/", StringUtils.ToStringRepresentation(userId), "/email_aliases"), new FetchOptions(networkSession: this.NetworkSession) { Method = "POST", Headers = headersMap, Data = SimpleJsonSerializer.Serialize(requestBody), ContentType = "application/json", ResponseFormat = "json", Auth = this.Auth, CancellationToken = cancellationToken }).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<EmailAlias>(response.Data);
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
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task DeleteUserEmailAliasByIdAsync(string userId, string emailAliasId, DeleteUserEmailAliasByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new DeleteUserEmailAliasByIdHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/2.0/users/", StringUtils.ToStringRepresentation(userId), "/email_aliases/", StringUtils.ToStringRepresentation(emailAliasId)), new FetchOptions(networkSession: this.NetworkSession) { Method = "DELETE", Headers = headersMap, ResponseFormat = null, Auth = this.Auth, CancellationToken = cancellationToken }).ConfigureAwait(false);
        }

    }
}