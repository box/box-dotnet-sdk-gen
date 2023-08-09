using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DictionaryExtensions;
using Fetch;
using Serializer;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class FileVersionRetentionsManager {
        public IAuth Auth { get; }

        public NetworkSession NetworkSession { get; }

        public FileVersionRetentionsManager(IAuth auth, NetworkSession networkSession) {
            Auth = auth;
            NetworkSession = networkSession;
        }
        public async System.Threading.Tasks.Task<FileVersionRetentions> GetFileVersionRetentions(GetFileVersionRetentionsQueryParamsArg queryParams, GetFileVersionRetentionsHeadersArg headers) {
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string>() { { "file_id", Utils.ToString(queryParams.FileId) }, { "file_version_id", Utils.ToString(queryParams.FileVersionId) }, { "policy_id", Utils.ToString(queryParams.PolicyId) }, { "disposition_action", Utils.ToString(queryParams.DispositionAction) }, { "disposition_before", Utils.ToString(queryParams.DispositionBefore) }, { "disposition_after", Utils.ToString(queryParams.DispositionAfter) }, { "limit", Utils.ToString(queryParams.Limit) }, { "marker", Utils.ToString(queryParams.Marker) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/file_version_retentions"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<FileVersionRetentions>(response.Text);
        }

        public async System.Threading.Tasks.Task<FileVersionRetention> GetFileVersionRetentionById(string fileVersionRetentionId, GetFileVersionRetentionByIdHeadersArg headers) {
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/file_version_retentions/", fileVersionRetentionId), new FetchOptions(method: "GET", headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<FileVersionRetention>(response.Text);
        }

    }
}