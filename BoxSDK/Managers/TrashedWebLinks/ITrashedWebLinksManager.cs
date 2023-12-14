using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface ITrashedWebLinksManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession NetworkSession { get; set; }

        public System.Threading.Tasks.Task<TrashWebLinkRestored> RestoreWeblinkFromTrashAsync(string webLinkId, RestoreWeblinkFromTrashRequestBody? requestBody = default, RestoreWeblinkFromTrashQueryParams? queryParams = default, RestoreWeblinkFromTrashHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<TrashWebLink> GetWebLinkTrashAsync(string webLinkId, GetWebLinkTrashQueryParams? queryParams = default, GetWebLinkTrashHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteWebLinkTrashAsync(string webLinkId, DeleteWebLinkTrashHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}