using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DictionaryExtensions;
using Fetch;
using Serializer;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class FileVersionLegalHoldsManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public FileVersionLegalHoldsManager() {
            
        }
        public async System.Threading.Tasks.Task<FileVersionLegalHold> GetFileVersionLegalHoldById(string fileVersionLegalHoldId, GetFileVersionLegalHoldByIdHeadersArg? headers = default) {
            headers = headers ?? new GetFileVersionLegalHoldByIdHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/file_version_legal_holds/", fileVersionLegalHoldId), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<FileVersionLegalHold>(response.Text);
        }

        public async System.Threading.Tasks.Task<FileVersionLegalHolds> GetFileVersionLegalHolds(GetFileVersionLegalHoldsQueryParamsArg queryParams, GetFileVersionLegalHoldsHeadersArg? headers = default) {
            headers = headers ?? new GetFileVersionLegalHoldsHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "policy_id", Utils.ToString(queryParams.PolicyId) }, { "marker", Utils.ToString(queryParams.Marker) }, { "limit", Utils.ToString(queryParams.Limit) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/file_version_legal_holds"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<FileVersionLegalHolds>(response.Text);
        }

    }
}