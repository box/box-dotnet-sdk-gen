using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public interface ITrashedWebLinksManager {
        public IAuthentication? Auth { get; init; }

        public NetworkSession NetworkSession { get; }

        public System.Threading.Tasks.Task<TrashWebLinkRestored> RestoreWeblinkFromTrashAsync(string webLinkId, RestoreWeblinkFromTrashRequestBody? requestBody = default, RestoreWeblinkFromTrashQueryParams? queryParams = default, RestoreWeblinkFromTrashHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<TrashWebLink> GetTrashedWebLinkByIdAsync(string webLinkId, GetTrashedWebLinkByIdQueryParams? queryParams = default, GetTrashedWebLinkByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteTrashedWebLinkByIdAsync(string webLinkId, DeleteTrashedWebLinkByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}