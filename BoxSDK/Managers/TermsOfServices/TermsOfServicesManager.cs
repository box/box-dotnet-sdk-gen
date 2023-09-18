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
    public class TermsOfServicesManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public TermsOfServicesManager() {
            
        }
        public async System.Threading.Tasks.Task<TermsOfServices> GetTermOfServices(GetTermOfServicesQueryParamsArg? queryParams = default, GetTermOfServicesHeadersArg? headers = default) {
            queryParams = queryParams ?? new GetTermOfServicesQueryParamsArg();
            headers = headers ?? new GetTermOfServicesHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "tos_type", Utils.ToString(queryParams.TosType) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/terms_of_services"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<TermsOfServices>(response.Text);
        }

        public async System.Threading.Tasks.Task<Task> CreateTermOfService(CreateTermOfServiceRequestBodyArg requestBody, CreateTermOfServiceHeadersArg? headers = default) {
            headers = headers ?? new CreateTermOfServiceHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/terms_of_services"), new FetchOptions(method: "POST", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<Task>(response.Text);
        }

        public async System.Threading.Tasks.Task<TermsOfService> GetTermOfServiceById(string termsOfServiceId, GetTermOfServiceByIdHeadersArg? headers = default) {
            headers = headers ?? new GetTermOfServiceByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/terms_of_services/", termsOfServiceId), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<TermsOfService>(response.Text);
        }

        public async System.Threading.Tasks.Task<TermsOfService> UpdateTermOfServiceById(string termsOfServiceId, UpdateTermOfServiceByIdRequestBodyArg requestBody, UpdateTermOfServiceByIdHeadersArg? headers = default) {
            headers = headers ?? new UpdateTermOfServiceByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/terms_of_services/", termsOfServiceId), new FetchOptions(method: "PUT", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<TermsOfService>(response.Text);
        }

    }
}