using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DictionaryExtensions;
using StringExtensions;
using Fetch;
using Serializer;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class SignRequestsManager : ISignRequestsManager {
        public IAuthentication? Auth { get; init; }

        public NetworkSession NetworkSession { get; }

        public SignRequestsManager(NetworkSession networkSession = default) {
            NetworkSession = networkSession ?? new NetworkSession();
        }
        /// <summary>
        /// Cancels a sign request.
        /// </summary>
        /// <param name="signRequestId">
        /// The ID of the signature request
        /// Example: "33243242"
        /// </param>
        /// <param name="headers">
        /// Headers of cancelSignRequest method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<SignRequest> CancelSignRequestAsync(string signRequestId, CancelSignRequestHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new CancelSignRequestHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/2.0/sign_requests/", StringUtils.ToStringRepresentation(signRequestId), "/cancel"), new FetchOptions(networkSession: this.NetworkSession) { Method = "POST", Headers = headersMap, ResponseFormat = "json", Auth = this.Auth, CancellationToken = cancellationToken }).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<SignRequest>(response.Data);
        }

        /// <summary>
        /// Resends a signature request email to all outstanding signers.
        /// </summary>
        /// <param name="signRequestId">
        /// The ID of the signature request
        /// Example: "33243242"
        /// </param>
        /// <param name="headers">
        /// Headers of resendSignRequest method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task ResendSignRequestAsync(string signRequestId, ResendSignRequestHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new ResendSignRequestHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/2.0/sign_requests/", StringUtils.ToStringRepresentation(signRequestId), "/resend"), new FetchOptions(networkSession: this.NetworkSession) { Method = "POST", Headers = headersMap, ResponseFormat = null, Auth = this.Auth, CancellationToken = cancellationToken }).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a sign request by ID.
        /// </summary>
        /// <param name="signRequestId">
        /// The ID of the signature request
        /// Example: "33243242"
        /// </param>
        /// <param name="headers">
        /// Headers of getSignRequestById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<SignRequest> GetSignRequestByIdAsync(string signRequestId, GetSignRequestByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new GetSignRequestByIdHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/2.0/sign_requests/", StringUtils.ToStringRepresentation(signRequestId)), new FetchOptions(networkSession: this.NetworkSession) { Method = "GET", Headers = headersMap, ResponseFormat = "json", Auth = this.Auth, CancellationToken = cancellationToken }).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<SignRequest>(response.Data);
        }

        /// <summary>
        /// Gets signature requests created by a user. If the `sign_files` and/or
        /// `parent_folder` are deleted, the signature request will not return in the list.
        /// </summary>
        /// <param name="queryParams">
        /// Query parameters of getSignRequests method
        /// </param>
        /// <param name="headers">
        /// Headers of getSignRequests method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<SignRequests> GetSignRequestsAsync(GetSignRequestsQueryParams? queryParams = default, GetSignRequestsHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            queryParams = queryParams ?? new GetSignRequestsQueryParams();
            headers = headers ?? new GetSignRequestsHeaders();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(map: new Dictionary<string, string?>() { { "marker", StringUtils.ToStringRepresentation(queryParams.Marker) }, { "limit", StringUtils.ToStringRepresentation(queryParams.Limit) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/2.0/sign_requests"), new FetchOptions(networkSession: this.NetworkSession) { Method = "GET", Parameters = queryParamsMap, Headers = headersMap, ResponseFormat = "json", Auth = this.Auth, CancellationToken = cancellationToken }).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<SignRequests>(response.Data);
        }

        /// <summary>
        /// Creates a signature request. This involves preparing a document for signing and
        /// sending the signature request to signers.
        /// </summary>
        /// <param name="requestBody">
        /// Request body of createSignRequest method
        /// </param>
        /// <param name="headers">
        /// Headers of createSignRequest method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<SignRequest> CreateSignRequestAsync(SignRequestCreateRequest requestBody, CreateSignRequestHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new CreateSignRequestHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/2.0/sign_requests"), new FetchOptions(networkSession: this.NetworkSession) { Method = "POST", Headers = headersMap, Data = SimpleJsonSerializer.Serialize(requestBody), ContentType = "application/json", ResponseFormat = "json", Auth = this.Auth, CancellationToken = cancellationToken }).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<SignRequest>(response.Data);
        }

    }
}