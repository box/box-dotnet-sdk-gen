using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public interface IFileVersionLegalHoldsManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession NetworkSession { get; set; }

        public System.Threading.Tasks.Task<FileVersionLegalHold> GetFileVersionLegalHoldByIdAsync(string fileVersionLegalHoldId, GetFileVersionLegalHoldByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<FileVersionLegalHolds> GetFileVersionLegalHoldsAsync(GetFileVersionLegalHoldsQueryParams queryParams, GetFileVersionLegalHoldsHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}