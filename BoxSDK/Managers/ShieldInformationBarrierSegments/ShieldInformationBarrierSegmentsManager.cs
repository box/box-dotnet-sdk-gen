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
    public class ShieldInformationBarrierSegmentsManager : IShieldInformationBarrierSegmentsManager {
        public IAuthentication? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public ShieldInformationBarrierSegmentsManager() {
            
        }
        /// <summary>
        /// Retrieves shield information barrier segment based on provided ID..
        /// </summary>
        /// <param name="shieldInformationBarrierSegmentId">
        /// The ID of the shield information barrier segment.
        /// Example: "3423"
        /// </param>
        /// <param name="headers">
        /// Headers of getShieldInformationBarrierSegmentById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<ShieldInformationBarrierSegment> GetShieldInformationBarrierSegmentByIdAsync(string shieldInformationBarrierSegmentId, GetShieldInformationBarrierSegmentByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new GetShieldInformationBarrierSegmentByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/shield_information_barrier_segments/", StringUtils.ToStringRepresentation(shieldInformationBarrierSegmentId)), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<ShieldInformationBarrierSegment>(response.Data);
        }

        /// <summary>
        /// Updates the shield information barrier segment based on provided ID..
        /// </summary>
        /// <param name="shieldInformationBarrierSegmentId">
        /// The ID of the shield information barrier segment.
        /// Example: "3423"
        /// </param>
        /// <param name="requestBody">
        /// Request body of updateShieldInformationBarrierSegmentById method
        /// </param>
        /// <param name="headers">
        /// Headers of updateShieldInformationBarrierSegmentById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<ShieldInformationBarrierSegment> UpdateShieldInformationBarrierSegmentByIdAsync(string shieldInformationBarrierSegmentId, UpdateShieldInformationBarrierSegmentByIdRequestBodyArg? requestBody = default, UpdateShieldInformationBarrierSegmentByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            requestBody = requestBody ?? new UpdateShieldInformationBarrierSegmentByIdRequestBodyArg();
            headers = headers ?? new UpdateShieldInformationBarrierSegmentByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/shield_information_barrier_segments/", StringUtils.ToStringRepresentation(shieldInformationBarrierSegmentId)), new FetchOptions(method: "PUT", headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<ShieldInformationBarrierSegment>(response.Data);
        }

        /// <summary>
        /// Deletes the shield information barrier segment
        /// based on provided ID.
        /// </summary>
        /// <param name="shieldInformationBarrierSegmentId">
        /// The ID of the shield information barrier segment.
        /// Example: "3423"
        /// </param>
        /// <param name="headers">
        /// Headers of deleteShieldInformationBarrierSegmentById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task DeleteShieldInformationBarrierSegmentByIdAsync(string shieldInformationBarrierSegmentId, DeleteShieldInformationBarrierSegmentByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new DeleteShieldInformationBarrierSegmentByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/shield_information_barrier_segments/", StringUtils.ToStringRepresentation(shieldInformationBarrierSegmentId)), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
        }

        /// <summary>
        /// Retrieves a list of shield information barrier segment objects
        /// for the specified Information Barrier ID.
        /// </summary>
        /// <param name="queryParams">
        /// Query parameters of getShieldInformationBarrierSegments method
        /// </param>
        /// <param name="headers">
        /// Headers of getShieldInformationBarrierSegments method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<ShieldInformationBarrierSegments> GetShieldInformationBarrierSegmentsAsync(GetShieldInformationBarrierSegmentsQueryParamsArg queryParams, GetShieldInformationBarrierSegmentsHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new GetShieldInformationBarrierSegmentsHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(map: new Dictionary<string, string?>() { { "shield_information_barrier_id", StringUtils.ToStringRepresentation(queryParams.ShieldInformationBarrierId) }, { "marker", StringUtils.ToStringRepresentation(queryParams.Marker) }, { "limit", StringUtils.ToStringRepresentation(queryParams.Limit) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/shield_information_barrier_segments"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<ShieldInformationBarrierSegments>(response.Data);
        }

        /// <summary>
        /// Creates a shield information barrier segment.
        /// </summary>
        /// <param name="requestBody">
        /// Request body of createShieldInformationBarrierSegment method
        /// </param>
        /// <param name="headers">
        /// Headers of createShieldInformationBarrierSegment method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<ShieldInformationBarrierSegment> CreateShieldInformationBarrierSegmentAsync(CreateShieldInformationBarrierSegmentRequestBodyArg requestBody, CreateShieldInformationBarrierSegmentHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new CreateShieldInformationBarrierSegmentHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/shield_information_barrier_segments"), new FetchOptions(method: "POST", headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<ShieldInformationBarrierSegment>(response.Data);
        }

    }
}