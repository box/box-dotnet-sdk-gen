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
    public class TermsOfServicesManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public TermsOfServicesManager() {
            
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
        public async System.Threading.Tasks.Task<TermsOfServices> GetTermOfServicesAsync(GetTermOfServicesQueryParamsArg? queryParams = default, GetTermOfServicesHeadersArg? headers = default) {
            queryParams = queryParams ?? new GetTermOfServicesQueryParamsArg();
            headers = headers ?? new GetTermOfServicesHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "tos_type", StringUtils.ToStringRepresentation(queryParams.TosType) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/terms_of_services"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<TermsOfServices>(response.Text);
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
        public async System.Threading.Tasks.Task<Task> CreateTermOfServiceAsync(CreateTermOfServiceRequestBodyArg requestBody, CreateTermOfServiceHeadersArg? headers = default) {
            headers = headers ?? new CreateTermOfServiceHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/terms_of_services"), new FetchOptions(method: "POST", headers: headersMap, body: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<Task>(response.Text);
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
        public async System.Threading.Tasks.Task<TermsOfService> GetTermOfServiceByIdAsync(string termsOfServiceId, GetTermOfServiceByIdHeadersArg? headers = default) {
            headers = headers ?? new GetTermOfServiceByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/terms_of_services/", StringUtils.ToStringRepresentation(termsOfServiceId)), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<TermsOfService>(response.Text);
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
        public async System.Threading.Tasks.Task<TermsOfService> UpdateTermOfServiceByIdAsync(string termsOfServiceId, UpdateTermOfServiceByIdRequestBodyArg requestBody, UpdateTermOfServiceByIdHeadersArg? headers = default) {
            headers = headers ?? new UpdateTermOfServiceByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/terms_of_services/", StringUtils.ToStringRepresentation(termsOfServiceId)), new FetchOptions(method: "PUT", headers: headersMap, body: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<TermsOfService>(response.Text);
        }

    }
}