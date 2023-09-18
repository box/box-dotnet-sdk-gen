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
    public class ShieldInformationBarrierSegmentMembersManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public ShieldInformationBarrierSegmentMembersManager() {
            
        }
        public async System.Threading.Tasks.Task<ShieldInformationBarrierSegmentMember> GetShieldInformationBarrierSegmentMemberById(string shieldInformationBarrierSegmentMemberId, GetShieldInformationBarrierSegmentMemberByIdHeadersArg? headers = default) {
            headers = headers ?? new GetShieldInformationBarrierSegmentMemberByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/shield_information_barrier_segment_members/", shieldInformationBarrierSegmentMemberId), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<ShieldInformationBarrierSegmentMember>(response.Text);
        }

        public async System.Threading.Tasks.Task DeleteShieldInformationBarrierSegmentMemberById(string shieldInformationBarrierSegmentMemberId, DeleteShieldInformationBarrierSegmentMemberByIdHeadersArg? headers = default) {
            headers = headers ?? new DeleteShieldInformationBarrierSegmentMemberByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/shield_information_barrier_segment_members/", shieldInformationBarrierSegmentMemberId), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession));
        }

        public async System.Threading.Tasks.Task GetShieldInformationBarrierSegmentMembers(GetShieldInformationBarrierSegmentMembersQueryParamsArg queryParams, GetShieldInformationBarrierSegmentMembersHeadersArg? headers = default) {
            headers = headers ?? new GetShieldInformationBarrierSegmentMembersHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "shield_information_barrier_segment_id", Utils.ToString(queryParams.ShieldInformationBarrierSegmentId) }, { "marker", Utils.ToString(queryParams.Marker) }, { "limit", Utils.ToString(queryParams.Limit) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/shield_information_barrier_segment_members"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
        }

        public async System.Threading.Tasks.Task<ShieldInformationBarrierSegmentMember> CreateShieldInformationBarrierSegmentMember(CreateShieldInformationBarrierSegmentMemberRequestBodyArg requestBody, CreateShieldInformationBarrierSegmentMemberHeadersArg? headers = default) {
            headers = headers ?? new CreateShieldInformationBarrierSegmentMemberHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/shield_information_barrier_segment_members"), new FetchOptions(method: "POST", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<ShieldInformationBarrierSegmentMember>(response.Text);
        }

    }
}