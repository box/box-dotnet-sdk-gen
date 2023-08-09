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
    public class ShieldInformationBarrierSegmentsManager {
        public IAuth Auth { get; }

        public NetworkSession NetworkSession { get; }

        public ShieldInformationBarrierSegmentsManager(IAuth auth, NetworkSession networkSession) {
            Auth = auth;
            NetworkSession = networkSession;
        }
        public async System.Threading.Tasks.Task<ShieldInformationBarrierSegment> GetShieldInformationBarrierSegmentById(string shieldInformationBarrierSegmentId, GetShieldInformationBarrierSegmentByIdHeadersArg headers) {
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/shield_information_barrier_segments/", shieldInformationBarrierSegmentId), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<ShieldInformationBarrierSegment>(response.Text);
        }

        public async System.Threading.Tasks.Task<ShieldInformationBarrierSegment> UpdateShieldInformationBarrierSegmentById(string shieldInformationBarrierSegmentId, UpdateShieldInformationBarrierSegmentByIdRequestBodyArg requestBody, UpdateShieldInformationBarrierSegmentByIdHeadersArg headers) {
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/shield_information_barrier_segments/", shieldInformationBarrierSegmentId), new FetchOptions(method: "PUT", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<ShieldInformationBarrierSegment>(response.Text);
        }

        public async System.Threading.Tasks.Task DeleteShieldInformationBarrierSegmentById(string shieldInformationBarrierSegmentId, DeleteShieldInformationBarrierSegmentByIdHeadersArg headers) {
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/shield_information_barrier_segments/", shieldInformationBarrierSegmentId), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession));
        }

        public async System.Threading.Tasks.Task GetShieldInformationBarrierSegments(GetShieldInformationBarrierSegmentsQueryParamsArg queryParams, GetShieldInformationBarrierSegmentsHeadersArg headers) {
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string>() { { "shield_information_barrier_id", Utils.ToString(queryParams.ShieldInformationBarrierId) }, { "marker", Utils.ToString(queryParams.Marker) }, { "limit", Utils.ToString(queryParams.Limit) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/shield_information_barrier_segments"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
        }

        public async System.Threading.Tasks.Task<ShieldInformationBarrierSegment> CreateShieldInformationBarrierSegment(CreateShieldInformationBarrierSegmentRequestBodyArg requestBody, CreateShieldInformationBarrierSegmentHeadersArg headers) {
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/shield_information_barrier_segments"), new FetchOptions(method: "POST", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<ShieldInformationBarrierSegment>(response.Text);
        }

    }
}