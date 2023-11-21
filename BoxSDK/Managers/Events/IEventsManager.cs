using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface IEventsManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession? NetworkSession { get; set; }

        public System.Threading.Tasks.Task<Events> GetEventsAsync(GetEventsQueryParamsArg? queryParams = default, GetEventsHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<RealtimeServers> GetEventsWithLongPollingAsync(GetEventsWithLongPollingHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}