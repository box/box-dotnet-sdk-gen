using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using StringExtensions;
using DictionaryExtensions;
using Fetch;
using Serializer;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class TermsOfServiceUserStatusesManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public TermsOfServiceUserStatusesManager() {
            
        }
        /// <summary>
        /// Retrieves an overview of users and their status for a
        /// terms of service, including Whether they have accepted
        /// the terms and when.
        /// </summary>
        /// <param name="queryParams">
        /// Query parameters of getTermOfServiceUserStatuses method
        /// </param>
        /// <param name="headers">
        /// Headers of getTermOfServiceUserStatuses method
        /// </param>
        public async System.Threading.Tasks.Task<TermsOfServiceUserStatuses> GetTermOfServiceUserStatusesAsync(GetTermOfServiceUserStatusesQueryParamsArg queryParams, GetTermOfServiceUserStatusesHeadersArg? headers = default) {
            headers = headers ?? new GetTermOfServiceUserStatusesHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "tos_id", StringUtils.ToStringRepresentation(queryParams.TosId) }, { "user_id", StringUtils.ToStringRepresentation(queryParams.UserId) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/terms_of_service_user_statuses"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<TermsOfServiceUserStatuses>(response.Text);
        }

        /// <summary>
        /// Sets the status for a terms of service for a user.
        /// </summary>
        /// <param name="requestBody">
        /// Request body of createTermOfServiceUserStatus method
        /// </param>
        /// <param name="headers">
        /// Headers of createTermOfServiceUserStatus method
        /// </param>
        public async System.Threading.Tasks.Task<TermsOfServiceUserStatus> CreateTermOfServiceUserStatusAsync(CreateTermOfServiceUserStatusRequestBodyArg requestBody, CreateTermOfServiceUserStatusHeadersArg? headers = default) {
            headers = headers ?? new CreateTermOfServiceUserStatusHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/terms_of_service_user_statuses"), new FetchOptions(method: "POST", headers: headersMap, body: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<TermsOfServiceUserStatus>(response.Text);
        }

        /// <summary>
        /// Updates the status for a terms of service for a user.
        /// </summary>
        /// <param name="termsOfServiceUserStatusId">
        /// The ID of the terms of service status.
        /// Example: "324234"
        /// </param>
        /// <param name="requestBody">
        /// Request body of updateTermOfServiceUserStatusById method
        /// </param>
        /// <param name="headers">
        /// Headers of updateTermOfServiceUserStatusById method
        /// </param>
        public async System.Threading.Tasks.Task<TermsOfServiceUserStatus> UpdateTermOfServiceUserStatusByIdAsync(string termsOfServiceUserStatusId, UpdateTermOfServiceUserStatusByIdRequestBodyArg requestBody, UpdateTermOfServiceUserStatusByIdHeadersArg? headers = default) {
            headers = headers ?? new UpdateTermOfServiceUserStatusByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/terms_of_service_user_statuses/", StringUtils.ToStringRepresentation(termsOfServiceUserStatusId)), new FetchOptions(method: "PUT", headers: headersMap, body: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<TermsOfServiceUserStatus>(response.Text);
        }

    }
}