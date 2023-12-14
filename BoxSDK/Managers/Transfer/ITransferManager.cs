using System.Text.Json.Serialization;
using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface ITransferManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession NetworkSession { get; set; }

        public System.Threading.Tasks.Task<FolderFull> TransferOwnedFolderAsync(string userId, TransferOwnedFolderRequestBody requestBody, TransferOwnedFolderQueryParams? queryParams = default, TransferOwnedFolderHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}