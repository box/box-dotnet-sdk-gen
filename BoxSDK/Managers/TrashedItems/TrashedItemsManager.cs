using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DictionaryExtensions;
using Fetch;
using Serializer;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class TrashedItemsManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public TrashedItemsManager() {
            
        }
        public async System.Threading.Tasks.Task<Items> GetFolderTrashItems(GetFolderTrashItemsQueryParamsArg? queryParams = default, GetFolderTrashItemsHeadersArg? headers = default) {
            queryParams = queryParams ?? new GetFolderTrashItemsQueryParamsArg();
            headers = headers ?? new GetFolderTrashItemsHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", Utils.ToString(queryParams.Fields) }, { "limit", Utils.ToString(queryParams.Limit) }, { "offset", Utils.ToString(queryParams.Offset) }, { "usemarker", Utils.ToString(queryParams.Usemarker) }, { "marker", Utils.ToString(queryParams.Marker) }, { "direction", Utils.ToString(queryParams.Direction) }, { "sort", Utils.ToString(queryParams.Sort) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/folders/trash/items"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<Items>(response.Text);
        }

    }
}