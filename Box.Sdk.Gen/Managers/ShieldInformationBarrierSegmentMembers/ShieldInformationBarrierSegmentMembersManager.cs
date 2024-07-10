using Box.Sdk.Gen;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public class ShieldInformationBarrierSegmentMembersManager : IShieldInformationBarrierSegmentMembersManager {
        public IAuthentication? Auth { get; init; }

        public NetworkSession NetworkSession { get; }

        public ShieldInformationBarrierSegmentMembersManager(NetworkSession networkSession = default) {
            NetworkSession = networkSession ?? new NetworkSession();
        }
        /// <summary>
        /// Retrieves a shield information barrier
        /// segment member by its ID.
        /// </summary>
        /// <param name="shieldInformationBarrierSegmentMemberId">
        /// The ID of the shield information barrier segment Member.
        /// Example: "7815"
        /// </param>
        /// <param name="headers">
        /// Headers of getShieldInformationBarrierSegmentMemberById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<ShieldInformationBarrierSegmentMember> GetShieldInformationBarrierSegmentMemberByIdAsync(string shieldInformationBarrierSegmentMemberId, GetShieldInformationBarrierSegmentMemberByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new GetShieldInformationBarrierSegmentMemberByIdHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/2.0/shield_information_barrier_segment_members/", StringUtils.ToStringRepresentation(shieldInformationBarrierSegmentMemberId)), new FetchOptions(networkSession: this.NetworkSession) { Method = "GET", Headers = headersMap, ResponseFormat = "json", Auth = this.Auth, CancellationToken = cancellationToken }).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<ShieldInformationBarrierSegmentMember>(response.Data);
        }

        /// <summary>
        /// Deletes a shield information barrier
        /// segment member based on provided ID.
        /// </summary>
        /// <param name="shieldInformationBarrierSegmentMemberId">
        /// The ID of the shield information barrier segment Member.
        /// Example: "7815"
        /// </param>
        /// <param name="headers">
        /// Headers of deleteShieldInformationBarrierSegmentMemberById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task DeleteShieldInformationBarrierSegmentMemberByIdAsync(string shieldInformationBarrierSegmentMemberId, DeleteShieldInformationBarrierSegmentMemberByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new DeleteShieldInformationBarrierSegmentMemberByIdHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/2.0/shield_information_barrier_segment_members/", StringUtils.ToStringRepresentation(shieldInformationBarrierSegmentMemberId)), new FetchOptions(networkSession: this.NetworkSession) { Method = "DELETE", Headers = headersMap, ResponseFormat = null, Auth = this.Auth, CancellationToken = cancellationToken }).ConfigureAwait(false);
        }

        /// <summary>
        /// Lists shield information barrier segment members
        /// based on provided segment IDs.
        /// </summary>
        /// <param name="queryParams">
        /// Query parameters of getShieldInformationBarrierSegmentMembers method
        /// </param>
        /// <param name="headers">
        /// Headers of getShieldInformationBarrierSegmentMembers method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<ShieldInformationBarrierSegmentMembers> GetShieldInformationBarrierSegmentMembersAsync(GetShieldInformationBarrierSegmentMembersQueryParams queryParams, GetShieldInformationBarrierSegmentMembersHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new GetShieldInformationBarrierSegmentMembersHeaders();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(map: new Dictionary<string, string?>() { { "shield_information_barrier_segment_id", StringUtils.ToStringRepresentation(queryParams.ShieldInformationBarrierSegmentId) }, { "marker", StringUtils.ToStringRepresentation(queryParams.Marker) }, { "limit", StringUtils.ToStringRepresentation(queryParams.Limit) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/2.0/shield_information_barrier_segment_members"), new FetchOptions(networkSession: this.NetworkSession) { Method = "GET", Parameters = queryParamsMap, Headers = headersMap, ResponseFormat = "json", Auth = this.Auth, CancellationToken = cancellationToken }).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<ShieldInformationBarrierSegmentMembers>(response.Data);
        }

        /// <summary>
        /// Creates a new shield information barrier segment member.
        /// </summary>
        /// <param name="requestBody">
        /// Request body of createShieldInformationBarrierSegmentMember method
        /// </param>
        /// <param name="headers">
        /// Headers of createShieldInformationBarrierSegmentMember method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<ShieldInformationBarrierSegmentMember> CreateShieldInformationBarrierSegmentMemberAsync(CreateShieldInformationBarrierSegmentMemberRequestBody requestBody, CreateShieldInformationBarrierSegmentMemberHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new CreateShieldInformationBarrierSegmentMemberHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/2.0/shield_information_barrier_segment_members"), new FetchOptions(networkSession: this.NetworkSession) { Method = "POST", Headers = headersMap, Data = SimpleJsonSerializer.Serialize(requestBody), ContentType = "application/json", ResponseFormat = "json", Auth = this.Auth, CancellationToken = cancellationToken }).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<ShieldInformationBarrierSegmentMember>(response.Data);
        }

    }
}