using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DictionaryExtensions;
using Fetch;
using Serializer;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class RecentItemsManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public RecentItemsManager() {
            
        }
        public async System.Threading.Tasks.Task<RecentItems> GetRecentItems(GetRecentItemsQueryParamsArg? queryParams = default, GetRecentItemsHeadersArg? headers = default) {
            queryParams = queryParams ?? new GetRecentItemsQueryParamsArg();
            headers = headers ?? new GetRecentItemsHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", Utils.ToString(queryParams.Fields) }, { "limit", Utils.ToString(queryParams.Limit) }, { "marker", Utils.ToString(queryParams.Marker) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/recent_items"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<RecentItems>(response.Text);
        }

    }
}