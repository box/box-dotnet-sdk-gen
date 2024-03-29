using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using StringExtensions;
using DictionaryExtensions;
using Fetch;
using Serializer;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class ShieldInformationBarrierReportsManager : IShieldInformationBarrierReportsManager {
        public IAuthentication? Auth { get; set; } = default;

        public NetworkSession NetworkSession { get; set; }

        public ShieldInformationBarrierReportsManager(NetworkSession networkSession = default) {
            NetworkSession = networkSession ?? new NetworkSession();
        }
        /// <summary>
        /// Lists shield information barrier reports.
        /// </summary>
        /// <param name="queryParams">
        /// Query parameters of getShieldInformationBarrierReports method
        /// </param>
        /// <param name="headers">
        /// Headers of getShieldInformationBarrierReports method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<ShieldInformationBarrierReports> GetShieldInformationBarrierReportsAsync(GetShieldInformationBarrierReportsQueryParams queryParams, GetShieldInformationBarrierReportsHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new GetShieldInformationBarrierReportsHeaders();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(map: new Dictionary<string, string?>() { { "shield_information_barrier_id", StringUtils.ToStringRepresentation(queryParams.ShieldInformationBarrierId) }, { "marker", StringUtils.ToStringRepresentation(queryParams.Marker) }, { "limit", StringUtils.ToStringRepresentation(queryParams.Limit) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/shield_information_barrier_reports"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<ShieldInformationBarrierReports>(response.Data);
        }

        /// <summary>
        /// Creates a shield information barrier report for a given barrier.
        /// </summary>
        /// <param name="requestBody">
        /// Request body of createShieldInformationBarrierReport method
        /// </param>
        /// <param name="headers">
        /// Headers of createShieldInformationBarrierReport method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<ShieldInformationBarrierReport> CreateShieldInformationBarrierReportAsync(ShieldInformationBarrierReference requestBody, CreateShieldInformationBarrierReportHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new CreateShieldInformationBarrierReportHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/shield_information_barrier_reports"), new FetchOptions(method: "POST", headers: headersMap, data: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<ShieldInformationBarrierReport>(response.Data);
        }

        /// <summary>
        /// Retrieves a shield information barrier report by its ID.
        /// </summary>
        /// <param name="shieldInformationBarrierReportId">
        /// The ID of the shield information barrier Report.
        /// Example: "3423"
        /// </param>
        /// <param name="headers">
        /// Headers of getShieldInformationBarrierReportById method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<ShieldInformationBarrierReport> GetShieldInformationBarrierReportByIdAsync(string shieldInformationBarrierReportId, GetShieldInformationBarrierReportByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            headers = headers ?? new GetShieldInformationBarrierReportByIdHeaders();
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/shield_information_barrier_reports/", StringUtils.ToStringRepresentation(shieldInformationBarrierReportId)), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<ShieldInformationBarrierReport>(response.Data);
        }

    }
}