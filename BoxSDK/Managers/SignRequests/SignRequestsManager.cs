using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DictionaryExtensions;
using StringExtensions;
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
        /// <summary>
        /// Cancels a sign request.
        /// </summary>
        /// <param name="signRequestId">
        /// The ID of the sign request
        /// Example: "33243242"
        /// </param>
        /// <param name="headers">
        /// Headers of cancelSignRequest method
        /// </param>
        public async System.Threading.Tasks.Task<SignRequest> CancelSignRequestAsync(string signRequestId, CancelSignRequestHeadersArg? headers = default) {
            headers = headers ?? new CancelSignRequestHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/sign_requests/", StringUtils.ToStringRepresentation(signRequestId), "/cancel"), new FetchOptions(method: "POST", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<SignRequest>(response.Text);
        }

        /// <summary>
        /// Resends a sign request email to all outstanding signers.
        /// </summary>
        /// <param name="signRequestId">
        /// The ID of the sign request
        /// Example: "33243242"
        /// </param>
        /// <param name="headers">
        /// Headers of resendSignRequest method
        /// </param>
        public async System.Threading.Tasks.Task ResendSignRequestAsync(string signRequestId, ResendSignRequestHeadersArg? headers = default) {
            headers = headers ?? new ResendSignRequestHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/sign_requests/", StringUtils.ToStringRepresentation(signRequestId), "/resend"), new FetchOptions(method: "POST", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession)).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a sign request by ID.
        /// </summary>
        /// <param name="signRequestId">
        /// The ID of the sign request
        /// Example: "33243242"
        /// </param>
        /// <param name="headers">
        /// Headers of getSignRequestById method
        /// </param>
        public async System.Threading.Tasks.Task<SignRequest> GetSignRequestByIdAsync(string signRequestId, GetSignRequestByIdHeadersArg? headers = default) {
            headers = headers ?? new GetSignRequestByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/sign_requests/", StringUtils.ToStringRepresentation(signRequestId)), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<SignRequest>(response.Text);
        }

        /// <summary>
        /// Gets sign requests created by a user. If the `sign_files` and/or
        /// `parent_folder` are deleted, the sign request will not return in the list.
        /// </summary>
        /// <param name="queryParams">
        /// Query parameters of getSignRequests method
        /// </param>
        /// <param name="headers">
        /// Headers of getSignRequests method
        /// </param>
        public async System.Threading.Tasks.Task<SignRequests> GetSignRequestsAsync(GetSignRequestsQueryParamsArg? queryParams = default, GetSignRequestsHeadersArg? headers = default) {
            queryParams = queryParams ?? new GetSignRequestsQueryParamsArg();
            headers = headers ?? new GetSignRequestsHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "marker", StringUtils.ToStringRepresentation(queryParams.Marker) }, { "limit", StringUtils.ToStringRepresentation(queryParams.Limit) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/sign_requests"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<SignRequests>(response.Text);
        }

        /// <summary>
        /// Creates a sign request. This involves preparing a document for signing and
        /// sending the sign request to signers.
        /// </summary>
        /// <param name="requestBody">
        /// Request body of createSignRequest method
        /// </param>
        /// <param name="headers">
        /// Headers of createSignRequest method
        /// </param>
        public async System.Threading.Tasks.Task<SignRequest> CreateSignRequestAsync(SignRequestCreateRequest requestBody, CreateSignRequestHeadersArg? headers = default) {
            headers = headers ?? new CreateSignRequestHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/sign_requests"), new FetchOptions(method: "POST", headers: headersMap, body: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<SignRequest>(response.Text);
        }

    }
}