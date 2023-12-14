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
    public class TermsOfServicesManager : ITermsOfServicesManager {
        public IAuthentication? Auth { get; set; } = default;

        public NetworkSession NetworkSession { get; set; }

        public TermsOfServicesManager(NetworkSession networkSession = default) {
            NetworkSession = networkSession ?? new NetworkSession();
        }
        /// <summary>
        /// Returns the current terms of service text and settings
        /// for the enterprise.
        /// </summary>
        /// <param name="queryParams">
        /// Query parameters of getTermOfServices method
        /// </param>
        /// <param name="headers">
        /// Headers of getTermOfServices method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<TermsOfServices> GetTermOfServicesAsync(GetTermOfServicesQueryParams? queryParams = default, GetTermOfServicesHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            queryParams = queryParams ?? new GetTermOfServicesQueryParams();
            headers = headers ?? new GetTermOfServicesHeaders();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(map: new Dictionary<string, string?>() { { "tos_type", StringUtils.ToStringRepresentation(queryParams.TosType) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/terms_of_services"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<TermsOfServices>(response.Data);
        }

        /// <summary>
        /// Creates a terms of service for a given enterprise
        /// and type of user.
        /// </summary>
        /// <param name="requestBody">
        /// Request body of createTermOfService method
        /// </param>
        /// <param name="headers">
        /// Headers of createTermOfService method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<Task> CreateTermOfServiceAsync(CreateTermOfServiceRequestBody requestBody, CreateTermOfServiceHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new CreateTermOfServiceHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/terms_of_services"), new FetchOptions(method: "POST", headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<Task>(response.Data);
        }

        /// <summary>
        /// Fetches a specific terms of service.
        /// </summary>
        /// <param name="termsOfServiceId">
        /// The ID of the terms of service.
        /// Example: "324234"
        /// </param>
        /// <param name="headers">
        /// Headers of getTermOfServiceById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<TermsOfService> GetTermOfServiceByIdAsync(string termsOfServiceId, GetTermOfServiceByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new GetTermOfServiceByIdHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/terms_of_services/", StringUtils.ToStringRepresentation(termsOfServiceId)), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<TermsOfService>(response.Data);
        }

        /// <summary>
        /// Updates a specific terms of service.
        /// </summary>
        /// <param name="termsOfServiceId">
        /// The ID of the terms of service.
        /// Example: "324234"
        /// </param>
        /// <param name="requestBody">
        /// Request body of updateTermOfServiceById method
        /// </param>
        /// <param name="headers">
        /// Headers of updateTermOfServiceById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<TermsOfService> UpdateTermOfServiceByIdAsync(string termsOfServiceId, UpdateTermOfServiceByIdRequestBody requestBody, UpdateTermOfServiceByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new UpdateTermOfServiceByIdHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/terms_of_services/", StringUtils.ToStringRepresentation(termsOfServiceId)), new FetchOptions(method: "PUT", headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<TermsOfService>(response.Data);
        }

    }
}