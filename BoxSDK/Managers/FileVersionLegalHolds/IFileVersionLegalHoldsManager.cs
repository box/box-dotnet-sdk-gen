using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface IFileVersionLegalHoldsManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession? NetworkSession { get; set; }

        public System.Threading.Tasks.Task<FileVersionLegalHold> GetFileVersionLegalHoldByIdAsync(string fileVersionLegalHoldId, GetFileVersionLegalHoldByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<FileVersionLegalHolds> GetFileVersionLegalHoldsAsync(GetFileVersionLegalHoldsQueryParamsArg queryParams, GetFileVersionLegalHoldsHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}