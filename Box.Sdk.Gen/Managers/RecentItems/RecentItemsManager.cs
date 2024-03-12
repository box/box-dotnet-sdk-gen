using Box.Sdk.Gen.Schemas;
using DictionaryExtensions;
using Fetch;
using Serializer;
using StringExtensions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Box.Sdk.Gen.Managers
{
    public class RecentItemsManager : IRecentItemsManager
    {
        public IAuthentication? Auth { get; set; } = default;

        public NetworkSession NetworkSession { get; set; }

        public RecentItemsManager(NetworkSession networkSession = default)
        {
            NetworkSession = networkSession ?? new NetworkSession();
        }
        /// <summary>
        /// Returns information about the recent items accessed
        /// by a user, either in the last 90 days or up to the last
        /// 1000 items accessed.
        /// </summary>
        /// <param name="queryParams">
        /// Query parameters of getRecentItems method
        /// </param>
        /// <param name="headers">
        /// Headers of getRecentItems method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<RecentItemsPaginator> GetRecentItemsAsync(GetRecentItemsQueryParams? queryParams = default, GetRecentItemsHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null)
        {
            async Task<(IReadOnlyList<RecentItem> items, string nextMarker)> fetchData(string marker)
            {
                queryParams = queryParams ?? new GetRecentItemsQueryParams();
                headers = headers ?? new GetRecentItemsHeaders();
                var currMarker = marker ?? queryParams.Marker;
                Dictionary<string, string> queryParamsMap = Utils.PrepareParams(map: new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) }, { "limit", StringUtils.ToStringRepresentation(queryParams.Limit) }, { "marker", StringUtils.ToStringRepresentation(currMarker) } });
                Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() { }, headers.ExtraHeaders));
                FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat(this.NetworkSession.BaseUrls.BaseUrl, "/recent_items"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
                var items = SimpleJsonSerializer.Deserialize<RecentItems>(response.Data);
                return (items.Entries, items.NextMarker);
            }

            return new RecentItemsPaginator(fetchData);
        }

    }
}