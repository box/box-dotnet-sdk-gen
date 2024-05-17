using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using StringExtensions;
using DictionaryExtensions;
using Fetch;
using Serializer;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class TermsOfServiceUserStatusesManager : ITermsOfServiceUserStatusesManager {
        public IAuthentication? Auth { get; init; }

        public NetworkSession NetworkSession { get; }

        public TermsOfServiceUserStatusesManager(NetworkSession networkSession = default) {
            NetworkSession = networkSession ?? new NetworkSession();
        }
        /// <summary>
        /// Retrieves an overview of users and their status for a
        /// terms of service, including Whether they have accepted
        /// the terms and when.
        /// </summary>
        /// <param name="queryParams">
        /// Query parameters of getTermsOfServiceUserStatuses method
        /// </param>
        /// <param name="headers">
        /// Headers of getTermsOfServiceUserStatuses method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<TermsOfServiceUserStatuses> GetTermsOfServiceUserStatusesAsync(GetTermsOfServiceUserStatusesQueryParams queryParams, GetTermsOfServiceUserStatusesHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new GetTermsOfServiceUserStatusesHeaders();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(map: new Dictionary<string, string?>() { { "tos_id", StringUtils.ToStringRepresentation(queryParams.TosId) }, { "user_id", StringUtils.ToStringRepresentation(queryParams.UserId) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/2.0/terms_of_service_user_statuses"), new FetchOptions(networkSession: this.NetworkSession) { Method = "GET", Parameters = queryParamsMap, Headers = headersMap, ResponseFormat = "json", Auth = this.Auth, CancellationToken = cancellationToken }).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<TermsOfServiceUserStatuses>(response.Data);
        }

        /// <summary>
        /// Sets the status for a terms of service for a user.
        /// </summary>
        /// <param name="requestBody">
        /// Request body of createTermsOfServiceStatusForUser method
        /// </param>
        /// <param name="headers">
        /// Headers of createTermsOfServiceStatusForUser method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<TermsOfServiceUserStatus> CreateTermsOfServiceStatusForUserAsync(CreateTermsOfServiceStatusForUserRequestBody requestBody, CreateTermsOfServiceStatusForUserHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new CreateTermsOfServiceStatusForUserHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/2.0/terms_of_service_user_statuses"), new FetchOptions(networkSession: this.NetworkSession) { Method = "POST", Headers = headersMap, Data = SimpleJsonSerializer.Serialize(requestBody), ContentType = "application/json", ResponseFormat = "json", Auth = this.Auth, CancellationToken = cancellationToken }).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<TermsOfServiceUserStatus>(response.Data);
        }

        /// <summary>
        /// Updates the status for a terms of service for a user.
        /// </summary>
        /// <param name="termsOfServiceUserStatusId">
        /// The ID of the terms of service status.
        /// Example: "324234"
        /// </param>
        /// <param name="requestBody">
        /// Request body of updateTermsOfServiceStatusForUserById method
        /// </param>
        /// <param name="headers">
        /// Headers of updateTermsOfServiceStatusForUserById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<TermsOfServiceUserStatus> UpdateTermsOfServiceStatusForUserByIdAsync(string termsOfServiceUserStatusId, UpdateTermsOfServiceStatusForUserByIdRequestBody requestBody, UpdateTermsOfServiceStatusForUserByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new UpdateTermsOfServiceStatusForUserByIdHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/2.0/terms_of_service_user_statuses/", StringUtils.ToStringRepresentation(termsOfServiceUserStatusId)), new FetchOptions(networkSession: this.NetworkSession) { Method = "PUT", Headers = headersMap, Data = SimpleJsonSerializer.Serialize(requestBody), ContentType = "application/json", ResponseFormat = "json", Auth = this.Auth, CancellationToken = cancellationToken }).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<TermsOfServiceUserStatus>(response.Data);
        }

    }
}