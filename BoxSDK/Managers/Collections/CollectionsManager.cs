using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using StringExtensions;
using DictionaryExtensions;
using Fetch;
using Serializer;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CollectionsManager {
        public IAuth? Auth { get; set; } = default;

        public NetworkSession? NetworkSession { get; set; } = default;

        public CollectionsManager() {
            
        }
        /// <summary>
        /// Retrieves all collections for a given user.
        /// 
        /// Currently, only the `favorites` collection
        /// is supported.
        /// </summary>
        /// <param name="queryParams">
        /// Query parameters of getCollections method
        /// </param>
        /// <param name="headers">
        /// Headers of getCollections method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<Collections> GetCollectionsAsync(GetCollectionsQueryParamsArg? queryParams = default, GetCollectionsHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            queryParams = queryParams ?? new GetCollectionsQueryParamsArg();
            headers = headers ?? new GetCollectionsHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(map: new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) }, { "offset", StringUtils.ToStringRepresentation(queryParams.Offset) }, { "limit", StringUtils.ToStringRepresentation(queryParams.Limit) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/collections"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<Collections>(response.Data);
        }

        /// <summary>
        /// Retrieves the files and/or folders contained within
        /// this collection.
        /// </summary>
        /// <param name="collectionId">
        /// The ID of the collection.
        /// Example: "926489"
        /// </param>
        /// <param name="queryParams">
        /// Query parameters of getCollectionItems method
        /// </param>
        /// <param name="headers">
        /// Headers of getCollectionItems method
        /// </param>
        /// <param name="cancellationToken">
        /// Token used for request cancellation.
        /// </param>
        public async System.Threading.Tasks.Task<Items> GetCollectionItemsAsync(string collectionId, GetCollectionItemsQueryParamsArg? queryParams = default, GetCollectionItemsHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null) {
            queryParams = queryParams ?? new GetCollectionItemsQueryParamsArg();
            headers = headers ?? new GetCollectionItemsHeadersArg();
            Dictionary<string, string> queryParamsMap = Utils.PrepareParams(map: new Dictionary<string, string?>() { { "fields", StringUtils.ToStringRepresentation(queryParams.Fields) }, { "offset", StringUtils.ToStringRepresentation(queryParams.Offset) }, { "limit", StringUtils.ToStringRepresentation(queryParams.Limit) } });
            Dictionary<string, string> headersMap = Utils.PrepareParams(map: DictionaryUtils.MergeDictionaries(new Dictionary<string, string?>() {  }, headers.ExtraHeaders));
            FetchResponse response = await HttpClientAdapter.FetchAsync(string.Concat("https://api.box.com/2.0/collections/", StringUtils.ToStringRepresentation(collectionId), "/items"), new FetchOptions(method: "GET", parameters: queryParamsMap, headers: headersMap, responseFormat: "json", auth: this.Auth, networkSession: this.NetworkSession, cancellationToken: cancellationToken)).ConfigureAwait(false);
            return SimpleJsonSerializer.Deserialize<Items>(response.Data);
        }

    }
}