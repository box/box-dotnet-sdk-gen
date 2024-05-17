using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public interface IEventsManager {
        public IAuthentication? Auth { get; init; }

        public NetworkSession NetworkSession { get; }

        public System.Threading.Tasks.Task<Events> GetEventsAsync(GetEventsQueryParams? queryParams = default, GetEventsHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<RealtimeServers> GetEventsWithLongPollingAsync(GetEventsWithLongPollingHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}