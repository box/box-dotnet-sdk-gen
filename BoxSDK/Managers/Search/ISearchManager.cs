using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface ISearchManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession NetworkSession { get; set; }

        public System.Threading.Tasks.Task<MetadataQueryResults> CreateMetadataQueryExecuteReadAsync(MetadataQuery requestBody, CreateMetadataQueryExecuteReadHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<MetadataQueryIndices> GetMetadataQueryIndicesAsync(GetMetadataQueryIndicesQueryParams queryParams, GetMetadataQueryIndicesHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<SearchResultsOrSearchResultsWithSharedLinks> GetSearchAsync(GetSearchQueryParams? queryParams = default, GetSearchHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}