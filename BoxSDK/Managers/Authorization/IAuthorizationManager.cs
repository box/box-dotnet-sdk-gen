using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface IAuthorizationManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession? NetworkSession { get; set; }

        public System.Threading.Tasks.Task GetAuthorizeAsync(GetAuthorizeQueryParamsArg queryParams, GetAuthorizeHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}