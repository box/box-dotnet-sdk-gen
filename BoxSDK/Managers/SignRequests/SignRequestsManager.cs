using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DictionaryExtensions;
using Fetch;
using Serializer;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class SignRequestsManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public SignRequestsManager() {
            
        }
        public async System.Threading.Tasks.Task<SignRequest> CancelSignRequest(string signRequestId, CancelSignRequestHeadersArg? headers = default) {
            headers = headers ?? new CancelSignRequestHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/sign_requests/", signRequestId, "/cancel"), new FetchOptions(method: "POST", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<SignRequest>(response.Text);
        }

        public async System.Threading.Tasks.Task ResendSignRequest(string signRequestId, ResendSignRequestHeadersArg? headers = default) {
            headers = headers ?? new ResendSignRequestHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/sign_requests/", signRequestId, "/resend"), new FetchOptions(method: "POST", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession));
        }

        public async System.Threading.Tasks.Task<SignRequest> GetSignRequestById(string signRequestId, GetSignRequestByIdHeadersArg? headers = default) {
            headers = headers ?? new GetSignRequestByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/sign_requests/", signRequestId), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<SignRequest>(response.Text);
        }

        public async System.Threading.Tasks.Task<SignRequests> GetSignRequests(GetSignRequestsQueryParamsArg? queryParams = default, GetSignRequestsHeadersArg? headers = default) {
            queryParams = queryParams ?? new GetSignRequestsQueryParamsArg();
            headers = headers ?? new GetSignRequestsHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "marker", Utils.ToString(queryParams.Marker) }, { "limit", Utils.ToString(queryParams.Limit) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/sign_requests"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<SignRequests>(response.Text);
        }

        public async System.Threading.Tasks.Task<SignRequest> CreateSignRequest(SignRequestCreateRequest requestBody, CreateSignRequestHeadersArg? headers = default) {
            headers = headers ?? new CreateSignRequestHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/sign_requests"), new FetchOptions(method: "POST", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<SignRequest>(response.Text);
        }

    }
}