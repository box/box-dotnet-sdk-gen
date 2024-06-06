using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public interface ITrashedFoldersManager {
        public IAuthentication? Auth { get; init; }

        public NetworkSession NetworkSession { get; }

        public System.Threading.Tasks.Task<TrashFolderRestored> RestoreFolderFromTrashAsync(string folderId, RestoreFolderFromTrashRequestBody? requestBody = default, RestoreFolderFromTrashQueryParams? queryParams = default, RestoreFolderFromTrashHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        public System.Threading.Tasks.Task<TrashFolder> GetTrashedFolderByIdAsync(string folderId, GetTrashedFolderByIdQueryParams? queryParams = default, GetTrashedFolderByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        public System.Threading.Tasks.Task DeleteTrashedFolderByIdAsync(string folderId, DeleteTrashedFolderByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

    }
}