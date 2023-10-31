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
        /// <summary>
        /// Retrieves information about an individual device pin.
        /// </summary>
        /// <param name="devicePinnerId">
        /// The ID of the device pin
        /// Example: "2324234"
        /// </param>
        /// <param name="headers">
        /// Headers of getDevicePinnerById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<DevicePinner> GetDevicePinnerByIdAsync(string devicePinnerId, GetDevicePinnerByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new GetDevicePinnerByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/device_pinners/", StringUtils.ToStringRepresentation(devicePinnerId)), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<DevicePinner>(response.Text);
        }

        /// <summary>
        /// Deletes an individual device pin.
        /// </summary>
        /// <param name="devicePinnerId">
        /// The ID of the device pin
        /// Example: "2324234"
        /// </param>
        /// <param name="headers">
        /// Headers of deleteDevicePinnerById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task DeleteDevicePinnerByIdAsync(string devicePinnerId, DeleteDevicePinnerByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new DeleteDevicePinnerByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/device_pinners/", StringUtils.ToStringRepresentation(devicePinnerId)), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
        }

        /// <summary>
        /// Retrieves all the device pins within an enterprise.
        /// 
        /// The user must have admin privileges, and the application
        /// needs the "manage enterprise" scope to make this call.
        /// </summary>
        /// <param name="enterpriseId">
        /// The ID of the enterprise
        /// Example: "3442311"
        /// </param>
        /// <param name="queryParams">
        /// Query parameters of getEnterpriseDevicePinners method
        /// </param>
        /// <param name="headers">
        /// Headers of getEnterpriseDevicePinners method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<DevicePinners> GetEnterpriseDevicePinnersAsync(string enterpriseId, GetEnterpriseDevicePinnersQueryParamsArg? queryParams = default, GetEnterpriseDevicePinnersHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            queryParams = queryParams ?? new GetEnterpriseDevicePinnersQueryParamsArg();
            headers = headers ?? new GetEnterpriseDevicePinnersHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "marker", StringUtils.ToStringRepresentation(queryParams.Marker) }, { "limit", StringUtils.ToStringRepresentation(queryParams.Limit) }, { "direction", StringUtils.ToStringRepresentation(queryParams.Direction) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/enterprises/", StringUtils.ToStringRepresentation(enterpriseId), "/device_pinners"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<DevicePinners>(response.Text);
        }

    }
}