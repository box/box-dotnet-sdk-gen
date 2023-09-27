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
        /// <summary>
        /// Create a search using SQL-like syntax to return items that match specific
        /// metadata.
        /// 
        /// By default, this endpoint returns only the most basic info about the items for
        /// which the query matches. To get additional fields for each item, including any
        /// of the metadata, use the `fields` attribute in the query.
        /// </summary>
        /// <param name="requestBody">
        /// Request body of createMetadataQueryExecuteRead method
        /// </param>
        /// <param name="headers">
        /// Headers of createMetadataQueryExecuteRead method
        /// </param>
        public async System.Threading.Tasks.Task<MetadataQueryResults> CreateMetadataQueryExecuteReadAsync(MetadataQuery requestBody, CreateMetadataQueryExecuteReadHeadersArg? headers = default) {
            headers = headers ?? new CreateMetadataQueryExecuteReadHeadersArg();
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/metadata_queries/execute_read"), new FetchOptions(method: "POST", headers: headersMap, body: SimpleJsonSerializer.Serialize(requestBody), contentType: "application/json", responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<MetadataQueryResults>(response.Text);
        }

        /// <summary>
        /// Retrieves the metadata query indices for a given scope and template key.
        /// </summary>
        /// <param name="queryParams">
        /// Query parameters of getMetadataQueryIndices method
        /// </param>
        /// <param name="headers">
        /// Headers of getMetadataQueryIndices method
        /// </param>
        public async System.Threading.Tasks.Task<MetadataQueryIndices> GetMetadataQueryIndicesAsync(GetMetadataQueryIndicesQueryParamsArg queryParams, GetMetadataQueryIndicesHeadersArg? headers = default) {
            headers = headers ?? new GetMetadataQueryIndicesHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "scope", StringUtils.ToStringRepresentation(queryParams.Scope) }, { "template_key", StringUtils.ToStringRepresentation(queryParams.TemplateKey) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/metadata_query_indices"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<MetadataQueryIndices>(response.Text);
        }

        /// <summary>
        /// Searches for files, folders, web links, and shared files across the
        /// users content or across the entire enterprise.
        /// </summary>
        /// <param name="queryParams">
        /// Query parameters of getSearch method
        /// </param>
        /// <param name="headers">
        /// Headers of getSearch method
        /// </param>
        public async System.Threading.Tasks.Task<SearchResultsOrSearchResultsWithSharedLinks> GetSearchAsync(GetSearchQueryParamsArg? queryParams = default, GetSearchHeadersArg? headers = default) {
            queryParams = queryParams ?? new GetSearchQueryParamsArg();
            headers = headers ?? new GetSearchHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(new Dictionary<string, string?>() { { "query", StringUtils.ToStringRepresentation(queryParams.Query) }, { "scope", StringUtils.ToStringRepresentation(queryParams.Scope) }, { "file_extensions", StringUtils.ToStringRepresentation(queryParams.FileExtensions) }, { "created_at_range", StringUtils.ToStringRepresentation(queryParams.CreatedAtRange) }, { "updated_at_range", StringUtils.ToStringRepresentation(queryParams.UpdatedAtRange) }, { "size_range", StringUtils.ToStringRepresentation(queryParams.SizeRange) }, { "owner_user_ids", StringUtils.ToStringRepresentation(queryParams.OwnerUserIds) }, { "recent_updater_user_ids", StringUtils.ToStringRepresentation(queryParams.RecentUpdaterUserIds) }, { "ancestor_folder_ids", StringUtils.ToStringRepresentation(queryParams.AncestorFolderIds) }, { "content_types", StringUtils.ToStringRepresentation(queryParams.ContentTypes) }, { "type", StringUtils.ToStringRepresentation(queryParams.Type) }, { "trash_content", StringUtils.ToStringRepresentation(queryParams.TrashContent) }, { "mdfilters", StringUtils.ToStringRepresentation(queryParams.Mdfilters) }, { "sort", StringUtils.ToStringRepresentation(queryParams.Sort) }, { "direction", StringUtils.ToStringRepresentation(queryParams.Direction) }, { "limit", StringUtils.ToStringRepresentation(queryParams.Limit) }, { "include_recent_shared_links", StringUtils.ToStringRepresentation(queryParams.IncludeRecentSharedLinks) }, { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) }, { "offset", StringUtils.ToStringRepresentation(queryParams.Offset) }, { "deleted_user_ids", StringUtils.ToStringRepresentation(queryParams.DeletedUserIds) }, { "deleted_at_range", StringUtils.ToStringRepresentation(queryParams.DeletedAtRange) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/search"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<SearchResultsOrSearchResultsWithSharedLinks>(response.Text);
        }

    }
}