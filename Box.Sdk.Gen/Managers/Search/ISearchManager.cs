using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public interface ISearchManager {
        public IAuthentication? Auth { get; init; }

        public NetworkSession NetworkSession { get; }

        public System.Threading.Tasks.Task<MetadataQueryResults> SearchByMetadataQueryAsync(MetadataQuery requestBody, SearchByMetadataQueryHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<SearchResultsOrSearchResultsWithSharedLinks> SearchForContentAsync(SearchForContentQueryParams? queryParams = default, SearchForContentHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}