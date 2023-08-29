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
    public class ShieldInformationBarriersManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public ShieldInformationBarriersManager() {
            
        }
        public async System.Threading.Tasks.Task<ShieldInformationBarrier> GetShieldInformationBarrierById(string shieldInformationBarrierId, GetShieldInformationBarrierByIdHeadersArg? headers = default) {
            headers = headers ?? new GetShieldInformationBarrierByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/shield_information_barriers/", shieldInformationBarrierId), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<ShieldInformationBarrier>(response.Text);
        }

        public async System.Threading.Tasks.Task<ShieldInformationBarrier> CreateShieldInformationBarrierChangeStatus(CreateShieldInformationBarrierChangeStatusRequestBodyArg requestBody, CreateShieldInformationBarrierChangeStatusHeadersArg? headers = default) {
            headers = headers ?? new CreateShieldInformationBarrierChangeStatusHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/shield_information_barriers/change_status"), new FetchOptions(method: "POST", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<ShieldInformationBarrier>(response.Text);
        }

        public async System.Threading.Tasks.Task GetShieldInformationBarriers(GetShieldInformationBarriersQueryParamsArg? queryParams = default, GetShieldInformationBarriersHeadersArg? headers = default) {
            queryParams = queryParams ?? new GetShieldInformationBarriersQueryParamsArg();
            headers = headers ?? new GetShieldInformationBarriersHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "marker", Utils.ToString(queryParams.Marker) }, { "limit", Utils.ToString(queryParams.Limit) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/shield_information_barriers"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
        }

        public async System.Threading.Tasks.Task<ShieldInformationBarrier> CreateShieldInformationBarrier(ShieldInformationBarrier requestBody, CreateShieldInformationBarrierHeadersArg? headers = default) {
            headers = headers ?? new CreateShieldInformationBarrierHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/shield_information_barriers"), new FetchOptions(method: "POST", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<ShieldInformationBarrier>(response.Text);
        }

    }
}