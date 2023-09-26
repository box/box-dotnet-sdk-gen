using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DictionaryExtensions;
using StringExtensions;
using Fetch;
using Serializer;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class DevicePinnersManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public DevicePinnersManager() {
            
        }
        public async System.Threading.Tasks.Task<DevicePinner> GetDevicePinnerById(string devicePinnerId, GetDevicePinnerByIdHeadersArg? headers = default) {
            headers = headers ?? new GetDevicePinnerByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/device_pinners/", StringUtils.ToStringRepresentation(devicePinnerId)), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<DevicePinner>(response.Text);
        }

        public async System.Threading.Tasks.Task DeleteDevicePinnerById(string devicePinnerId, DeleteDevicePinnerByIdHeadersArg? headers = default) {
            headers = headers ?? new DeleteDevicePinnerByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/device_pinners/", StringUtils.ToStringRepresentation(devicePinnerId)), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession));
        }

        public async System.Threading.Tasks.Task<DevicePinners> GetEnterpriseDevicePinners(string enterpriseId, GetEnterpriseDevicePinnersQueryParamsArg? queryParams = default, GetEnterpriseDevicePinnersHeadersArg? headers = default) {
            queryParams = queryParams ?? new GetEnterpriseDevicePinnersQueryParamsArg();
            headers = headers ?? new GetEnterpriseDevicePinnersHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "marker", StringUtils.ToStringRepresentation(queryParams.Marker) }, { "limit", StringUtils.ToStringRepresentation(queryParams.Limit) }, { "direction", StringUtils.ToStringRepresentation(queryParams.Direction) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/enterprises/", StringUtils.ToStringRepresentation(enterpriseId), "/device_pinners"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<DevicePinners>(response.Text);
        }

    }
}