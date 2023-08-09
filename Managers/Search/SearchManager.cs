using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DictionaryExtensions;
using Serializer;
using Fetch;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class SearchManager {
        public IAuth Auth { get; }

        public NetworkSession NetworkSession { get; }

        public SearchManager(IAuth auth, NetworkSession networkSession) {
            Auth = auth;
            NetworkSession = networkSession;
        }
        public async System.Threading.Tasks.Task<MetadataQueryResults> CreateMetadataQueryExecuteRead(MetadataQuery requestBody, CreateMetadataQueryExecuteReadHeadersArg headers) {
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/metadata_queries/execute_read"), new FetchOptions(method: "POST", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<MetadataQueryResults>(response.Text);
        }

        public async System.Threading.Tasks.Task<MetadataQueryIndices> GetMetadataQueryIndices(GetMetadataQueryIndicesQueryParamsArg queryParams, GetMetadataQueryIndicesHeadersArg headers) {
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string>() { { "scope", Utils.ToString(queryParams.Scope) }, { "template_key", Utils.ToString(queryParams.TemplateKey) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/metadata_query_indices"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<MetadataQueryIndices>(response.Text);
        }

        public async System.Threading.Tasks.Task GetSearch(GetSearchQueryParamsArg queryParams, GetSearchHeadersArg headers) {
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string>() { { "query", Utils.ToString(queryParams.Query) }, { "scope", Utils.ToString(queryParams.Scope) }, { "file_extensions", Utils.ToString(queryParams.FileExtensions) }, { "created_at_range", Utils.ToString(queryParams.CreatedAtRange) }, { "updated_at_range", Utils.ToString(queryParams.UpdatedAtRange) }, { "size_range", Utils.ToString(queryParams.SizeRange) }, { "owner_user_ids", Utils.ToString(queryParams.OwnerUserIds) }, { "recent_updater_user_ids", Utils.ToString(queryParams.RecentUpdaterUserIds) }, { "ancestor_folder_ids", Utils.ToString(queryParams.AncestorFolderIds) }, { "content_types", Utils.ToString(queryParams.ContentTypes) }, { "type", Utils.ToString(queryParams.Type) }, { "trash_content", Utils.ToString(queryParams.TrashContent) }, { "mdfilters", Utils.ToString(queryParams.Mdfilters) }, { "sort", Utils.ToString(queryParams.Sort) }, { "direction", Utils.ToString(queryParams.Direction) }, { "limit", Utils.ToString(queryParams.Limit) }, { "include_recent_shared_links", Utils.ToString(queryParams.IncludeRecentSharedLinks) }, { "fields", Utils.ToString(queryParams.Fields) }, { "offset", Utils.ToString(queryParams.Offset) }, { "deleted_user_ids", Utils.ToString(queryParams.DeletedUserIds) }, { "deleted_at_range", Utils.ToString(queryParams.DeletedAtRange) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/search"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
        }

    }
}