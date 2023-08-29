using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DictionaryExtensions;
using Serializer;
using Fetch;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class TrashedFoldersManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public TrashedFoldersManager() {
            
        }
        public async System.Threading.Tasks.Task<TrashFolderRestored> RestoreFolderFromTrash(string folderId, RestoreFolderFromTrashRequestBodyArg? requestBody = default, RestoreFolderFromTrashQueryParamsArg? queryParams = default, RestoreFolderFromTrashHeadersArg? headers = default) {
            requestBody = requestBody ?? new RestoreFolderFromTrashRequestBodyArg();
            queryParams = queryParams ?? new RestoreFolderFromTrashQueryParamsArg();
            headers = headers ?? new RestoreFolderFromTrashHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", Utils.ToString(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/folders/", folderId), new FetchOptions(method: "POST", parameters: queryParamsMap, headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<TrashFolderRestored>(response.Text);
        }

        public async System.Threading.Tasks.Task<TrashFolder> GetFolderTrash(string folderId, GetFolderTrashQueryParamsArg? queryParams = default, GetFolderTrashHeadersArg? headers = default) {
            queryParams = queryParams ?? new GetFolderTrashQueryParamsArg();
            headers = headers ?? new GetFolderTrashHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "fields", Utils.ToString(queryParams.Fields) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/folders/", folderId, "/trash"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<TrashFolder>(response.Text);
        }

        public async System.Threading.Tasks.Task DeleteFolderTrash(string folderId, DeleteFolderTrashHeadersArg? headers = default) {
            headers = headers ?? new DeleteFolderTrashHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/folders/", folderId, "/trash"), new FetchOptions(method: "DELETE", headers: headersMap, responseFormat: null, auth: this.Auth, networkSession: this.NetworkSession));
        }

    }
}