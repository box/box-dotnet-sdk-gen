using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface ICollectionsManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession? NetworkSession { get; set; }

        public System.Threading.Tasks.Task<Collections> GetCollectionsAsync(GetCollectionsQueryParamsArg? queryParams = default, GetCollectionsHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<Items> GetCollectionItemsAsync(string collectionId, GetCollectionItemsQueryParamsArg? queryParams = default, GetCollectionItemsHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}