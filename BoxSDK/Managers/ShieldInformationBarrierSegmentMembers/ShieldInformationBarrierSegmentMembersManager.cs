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
    public class ShieldInformationBarrierSegmentMembersManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public ShieldInformationBarrierSegmentMembersManager() {
            
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
        public async System.Threading.Tasks.Task<ShieldInformationBarrierSegmentMember> GetShieldInformationBarrierSegmentMemberByIdAsync(string shieldInformationBarrierSegmentMemberId, GetShieldInformationBarrierSegmentMemberByIdHeadersArg? headers = default) {
            headers = headers ?? new GetShieldInformationBarrierSegmentMemberByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/shield_information_barrier_segment_members/", StringUtils.ToStringRepresentation(shieldInformationBarrierSegmentMemberId)), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<ShieldInformationBarrierSegmentMember>(response.Text);
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
        public async System.Threading.Tasks.Task DeleteShieldInformationBarrierSegmentMemberByIdAsync(string shieldInformationBarrierSegmentMemberId, DeleteShieldInformationBarrierSegmentMemberByIdHeadersArg? headers = default) {
            headers = headers ?? new DeleteShieldInformationBarrierSegmentMemberByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/shield_information_barrier_segment_members/", StringUtils.ToStringRepresentation(shieldInformationBarrierSegmentMemberId)), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession)).ConfigureAwait(false);
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
        public async System.Threading.Tasks.Task GetShieldInformationBarrierSegmentMembersAsync(GetShieldInformationBarrierSegmentMembersQueryParamsArg queryParams, GetShieldInformationBarrierSegmentMembersHeadersArg? headers = default) {
            headers = headers ?? new GetShieldInformationBarrierSegmentMembersHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "shield_information_barrier_segment_id", StringUtils.ToStringRepresentation(queryParams.ShieldInformationBarrierSegmentId) }, { "marker", StringUtils.ToStringRepresentation(queryParams.Marker) }, { "limit", StringUtils.ToStringRepresentation(queryParams.Limit) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/shield_information_barrier_segment_members"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession)).ConfigureAwait(false);
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
        public async System.Threading.Tasks.Task<ShieldInformationBarrierSegmentMember> CreateShieldInformationBarrierSegmentMemberAsync(CreateShieldInformationBarrierSegmentMemberRequestBodyArg requestBody, CreateShieldInformationBarrierSegmentMemberHeadersArg? headers = default) {
            headers = headers ?? new CreateShieldInformationBarrierSegmentMemberHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/shield_information_barrier_segment_members"), new FetchOptions(method: "POST", headers: headersMap, body: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<ShieldInformationBarrierSegmentMember>(response.Text);
        }

    }
}