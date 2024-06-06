using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public interface ITrashedFilesManager {
        public IAuthentication? Auth { get; init; }

        public NetworkSession NetworkSession { get; }

        public System.Threading.Tasks.Task<TrashFileRestored> RestoreFileFromTrashAsync(string fileId, RestoreFileFromTrashRequestBody? requestBody = default, RestoreFileFromTrashQueryParams? queryParams = default, RestoreFileFromTrashHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        public System.Threading.Tasks.Task<TrashFile> GetTrashedFileByIdAsync(string fileId, GetTrashedFileByIdQueryParams? queryParams = default, GetTrashedFileByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        public System.Threading.Tasks.Task DeleteTrashedFileByIdAsync(string fileId, DeleteTrashedFileByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

    }
}