using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public interface ICollectionsManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession NetworkSession { get; set; }

        public System.Threading.Tasks.Task<Collections> GetCollectionsAsync(GetCollectionsQueryParams? queryParams = default, GetCollectionsHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<Items> GetCollectionItemsAsync(string collectionId, GetCollectionItemsQueryParams? queryParams = default, GetCollectionItemsHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}