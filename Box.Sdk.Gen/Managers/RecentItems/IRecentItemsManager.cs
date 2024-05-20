using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public interface IRecentItemsManager {
        public IAuthentication? Auth { get; init; }

        public NetworkSession NetworkSession { get; }

        public System.Threading.Tasks.Task<RecentItems> GetRecentItemsAsync(GetRecentItemsQueryParams? queryParams = default, GetRecentItemsHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}