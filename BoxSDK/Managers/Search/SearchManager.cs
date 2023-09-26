using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using DictionaryExtensions;
using Serializer;
using Fetch;
using StringExtensions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class SearchManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public SearchManager() {
            
        }
        public async System.Threading.Tasks.Task<MetadataQueryResults> CreateMetadataQueryExecuteRead(MetadataQuery requestBody, CreateMetadataQueryExecuteReadHeadersArg? headers = default) {
            headers = headers ?? new CreateMetadataQueryExecuteReadHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/metadata_queries/execute_read"), new FetchOptions(method: "POST", headers: headersMap, body: SimpleJsonConverter.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<MetadataQueryResults>(response.Text);
        }

        public async System.Threading.Tasks.Task<MetadataQueryIndices> GetMetadataQueryIndices(GetMetadataQueryIndicesQueryParamsArg queryParams, GetMetadataQueryIndicesHeadersArg? headers = default) {
            headers = headers ?? new GetMetadataQueryIndicesHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "scope", StringUtils.ToStringRepresentation(queryParams.Scope) }, { "template_key", StringUtils.ToStringRepresentation(queryParams.TemplateKey) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/metadata_query_indices"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<MetadataQueryIndices>(response.Text);
        }

        public async System.Threading.Tasks.Task<SearchResultsOrSearchResultsWithSharedLinks> GetSearch(GetSearchQueryParamsArg? queryParams = default, GetSearchHeadersArg? headers = default) {
            queryParams = queryParams ?? new GetSearchQueryParamsArg();
            headers = headers ?? new GetSearchHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "query", StringUtils.ToStringRepresentation(queryParams.Query) }, { "scope", StringUtils.ToStringRepresentation(queryParams.Scope) }, { "file_extensions", StringUtils.ToStringRepresentation(queryParams.FileExtensions) }, { "created_at_range", StringUtils.ToStringRepresentation(queryParams.CreatedAtRange) }, { "updated_at_range", StringUtils.ToStringRepresentation(queryParams.UpdatedAtRange) }, { "size_range", StringUtils.ToStringRepresentation(queryParams.SizeRange) }, { "owner_user_ids", StringUtils.ToStringRepresentation(queryParams.OwnerUserIds) }, { "recent_updater_user_ids", StringUtils.ToStringRepresentation(queryParams.RecentUpdaterUserIds) }, { "ancestor_folder_ids", StringUtils.ToStringRepresentation(queryParams.AncestorFolderIds) }, { "content_types", StringUtils.ToStringRepresentation(queryParams.ContentTypes) }, { "type", StringUtils.ToStringRepresentation(queryParams.Type) }, { "trash_content", StringUtils.ToStringRepresentation(queryParams.TrashContent) }, { "mdfilters", StringUtils.ToStringRepresentation(queryParams.Mdfilters) }, { "sort", StringUtils.ToStringRepresentation(queryParams.Sort) }, { "direction", StringUtils.ToStringRepresentation(queryParams.Direction) }, { "limit", StringUtils.ToStringRepresentation(queryParams.Limit) }, { "include_recent_shared_links", StringUtils.ToStringRepresentation(queryParams.IncludeRecentSharedLinks) }, { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) }, { "offset", StringUtils.ToStringRepresentation(queryParams.Offset) }, { "deleted_user_ids", StringUtils.ToStringRepresentation(queryParams.DeletedUserIds) }, { "deleted_at_range", StringUtils.ToStringRepresentation(queryParams.DeletedAtRange) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await SimpleHttpClient.Fetch(string.Concat("https://api.box.com/2.0/search"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession));
            return SimpleJsonConverter.Deserialize<SearchResultsOrSearchResultsWithSharedLinks>(response.Text);
        }

    }
}