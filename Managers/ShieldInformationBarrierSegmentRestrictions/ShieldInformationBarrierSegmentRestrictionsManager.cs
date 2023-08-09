using System.IO;
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
    public class ShieldInformationBarrierSegmentRestrictionsManager {
        public IAuth Auth { get; }

        public NetworkSession NetworkSession { get; }

        public ShieldInformationBarrierSegmentRestrictionsManager(IAuth auth, NetworkSession networkSession) {
            Auth = auth;
            NetworkSession = networkSession;
        }
        public async System.Threading.Tasks.Task<ShieldInformationBarrierSegmentRestriction> GetShieldInformationBarrierSegmentRestrictionById(string shieldInformationBarrierSegmentRestrictionId, GetShieldInformationBarrierSegmentRestrictionByIdHeadersArg headers) {
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/shield_information_barrier_segment_restrictions/", shieldInformationBarrierSegmentRestrictionId), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<ShieldInformationBarrierSegmentRestriction>(response.Text);
        }

        public async System.Threading.Tasks.Task DeleteShieldInformationBarrierSegmentRestrictionById(string shieldInformationBarrierSegmentRestrictionId, DeleteShieldInformationBarrierSegmentRestrictionByIdHeadersArg headers) {
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/shield_information_barrier_segment_restrictions/", shieldInformationBarrierSegmentRestrictionId), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession));
        }

        public async System.Threading.Tasks.Task GetShieldInformationBarrierSegmentRestrictions(GetShieldInformationBarrierSegmentRestrictionsQueryParamsArg queryParams, GetShieldInformationBarrierSegmentRestrictionsHeadersArg headers) {
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string>() { { "shield_information_barrier_segment_id", Utils.ToString(queryParams.ShieldInformationBarrierSegmentId) }, { "marker", Utils.ToString(queryParams.Marker) }, { "limit", Utils.ToString(queryParams.Limit) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/shield_information_barrier_segment_restrictions"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
        }

        public async System.Threading.Tasks.Task<ShieldInformationBarrierSegmentRestriction> CreateShieldInformationBarrierSegmentRestriction(CreateShieldInformationBarrierSegmentRestrictionRequestBodyArg requestBody, CreateShieldInformationBarrierSegmentRestrictionHeadersArg headers) {
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/shield_information_barrier_segment_restrictions"), new FetchOptions(method: "POST", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<ShieldInformationBarrierSegmentRestriction>(response.Text);
        }

    }
}