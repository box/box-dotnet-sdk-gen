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
    public class ShieldInformationBarrierSegmentRestrictionsManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public ShieldInformationBarrierSegmentRestrictionsManager() {
            
        }
        /// <summary>
        /// Retrieves a shield information barrier segment
        /// restriction based on provided ID.
        /// </summary>
        /// <param name="shieldInformationBarrierSegmentRestrictionId">
        /// The ID of the shield information barrier segment Restriction.
        /// Example: "4563"
        /// </param>
        /// <param name="headers">
        /// Headers of getShieldInformationBarrierSegmentRestrictionById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<ShieldInformationBarrierSegmentRestriction> GetShieldInformationBarrierSegmentRestrictionByIdAsync(string shieldInformationBarrierSegmentRestrictionId, GetShieldInformationBarrierSegmentRestrictionByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new GetShieldInformationBarrierSegmentRestrictionByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/shield_information_barrier_segment_restrictions/", StringUtils.ToStringRepresentation(shieldInformationBarrierSegmentRestrictionId)), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<ShieldInformationBarrierSegmentRestriction>(response.Data);
        }

        /// <summary>
        /// Delete shield information barrier segment restriction
        /// based on provided ID.
        /// </summary>
        /// <param name="shieldInformationBarrierSegmentRestrictionId">
        /// The ID of the shield information barrier segment Restriction.
        /// Example: "4563"
        /// </param>
        /// <param name="headers">
        /// Headers of deleteShieldInformationBarrierSegmentRestrictionById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task DeleteShieldInformationBarrierSegmentRestrictionByIdAsync(string shieldInformationBarrierSegmentRestrictionId, DeleteShieldInformationBarrierSegmentRestrictionByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new DeleteShieldInformationBarrierSegmentRestrictionByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/shield_information_barrier_segment_restrictions/", StringUtils.ToStringRepresentation(shieldInformationBarrierSegmentRestrictionId)), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
        }

        /// <summary>
        /// Lists shield information barrier segment restrictions
        /// based on provided segment ID.
        /// </summary>
        /// <param name="queryParams">
        /// Query parameters of getShieldInformationBarrierSegmentRestrictions method
        /// </param>
        /// <param name="headers">
        /// Headers of getShieldInformationBarrierSegmentRestrictions method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<ShieldInformationBarrierSegmentRestrictions> GetShieldInformationBarrierSegmentRestrictionsAsync(GetShieldInformationBarrierSegmentRestrictionsQueryParamsArg queryParams, GetShieldInformationBarrierSegmentRestrictionsHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new GetShieldInformationBarrierSegmentRestrictionsHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(map: new Dictionary<string, string?>() { { "shield_information_barrier_segment_id", StringUtils.ToStringRepresentation(queryParams.ShieldInformationBarrierSegmentId) }, { "marker", StringUtils.ToStringRepresentation(queryParams.Marker) }, { "limit", StringUtils.ToStringRepresentation(queryParams.Limit) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/shield_information_barrier_segment_restrictions"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<ShieldInformationBarrierSegmentRestrictions>(response.Data);
        }

        /// <summary>
        /// Creates a shield information barrier
        /// segment restriction object.
        /// </summary>
        /// <param name="requestBody">
        /// Request body of createShieldInformationBarrierSegmentRestriction method
        /// </param>
        /// <param name="headers">
        /// Headers of createShieldInformationBarrierSegmentRestriction method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<ShieldInformationBarrierSegmentRestriction> CreateShieldInformationBarrierSegmentRestrictionAsync(CreateShieldInformationBarrierSegmentRestrictionRequestBodyArg requestBody, CreateShieldInformationBarrierSegmentRestrictionHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new CreateShieldInformationBarrierSegmentRestrictionHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/shield_information_barrier_segment_restrictions"), new FetchOptions(method: "POST", headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<ShieldInformationBarrierSegmentRestriction>(response.Data);
        }

    }
}