using Box.Sdk.Gen;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class ShieldInformationBarrierSegmentRestrictionsManager : IShieldInformationBarrierSegmentRestrictionsManager {
        public IAuthentication? Auth { get; init; }

        public NetworkSession NetworkSession { get; }

        public ShieldInformationBarrierSegmentRestrictionsManager(NetworkSession networkSession = default) {
            NetworkSession = networkSession ?? new NetworkSession();
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
        public async System.Threading.Tasks.Task<ShieldInformationBarrierSegmentRestriction> GetShieldInformationBarrierSegmentRestrictionByIdAsync(string shieldInformationBarrierSegmentRestrictionId, GetShieldInformationBarrierSegmentRestrictionByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new GetShieldInformationBarrierSegmentRestrictionByIdHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/2.0/shield_information_barrier_segment_restrictions/", StringUtils.ToStringRepresentation(shieldInformationBarrierSegmentRestrictionId)), new FetchOptions(networkSession: this.NetworkSession) { Method = "GET", Headers = headersMap, ResponseFormat = "json", Auth = this.Auth, CancellationToken = cancellationToken }).ConfigureAwait(false);
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
        public async System.Threading.Tasks.Task DeleteShieldInformationBarrierSegmentRestrictionByIdAsync(string shieldInformationBarrierSegmentRestrictionId, DeleteShieldInformationBarrierSegmentRestrictionByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new DeleteShieldInformationBarrierSegmentRestrictionByIdHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/2.0/shield_information_barrier_segment_restrictions/", StringUtils.ToStringRepresentation(shieldInformationBarrierSegmentRestrictionId)), new FetchOptions(networkSession: this.NetworkSession) { Method = "DELETE", Headers = headersMap, ResponseFormat = null, Auth = this.Auth, CancellationToken = cancellationToken }).ConfigureAwait(false);
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
        public async System.Threading.Tasks.Task<ShieldInformationBarrierSegmentRestrictions> GetShieldInformationBarrierSegmentRestrictionsAsync(GetShieldInformationBarrierSegmentRestrictionsQueryParams queryParams, GetShieldInformationBarrierSegmentRestrictionsHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new GetShieldInformationBarrierSegmentRestrictionsHeaders();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(map: new Dictionary<string, string?>() { { "shield_information_barrier_segment_id", StringUtils.ToStringRepresentation(queryParams.ShieldInformationBarrierSegmentId) }, { "marker", StringUtils.ToStringRepresentation(queryParams.Marker) }, { "limit", StringUtils.ToStringRepresentation(queryParams.Limit) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/2.0/shield_information_barrier_segment_restrictions"), new FetchOptions(networkSession: this.NetworkSession) { Method = "GET", Parameters = queryParamsMap, Headers = headersMap, ResponseFormat = "json", Auth = this.Auth, CancellationToken = cancellationToken }).ConfigureAwait(false);
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
        public async System.Threading.Tasks.Task<ShieldInformationBarrierSegmentRestriction> CreateShieldInformationBarrierSegmentRestrictionAsync(CreateShieldInformationBarrierSegmentRestrictionRequestBody requestBody, CreateShieldInformationBarrierSegmentRestrictionHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new CreateShieldInformationBarrierSegmentRestrictionHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/2.0/shield_information_barrier_segment_restrictions"), new FetchOptions(networkSession: this.NetworkSession) { Method = "POST", Headers = headersMap, Data = SimpleJsonSerializer.Serialize(requestBody), ContentType = "application/json", ResponseFormat = "json", Auth = this.Auth, CancellationToken = cancellationToken }).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<ShieldInformationBarrierSegmentRestriction>(response.Data);
        }

    }
}