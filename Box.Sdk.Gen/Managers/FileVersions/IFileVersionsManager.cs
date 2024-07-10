using Box.Sdk.Gen;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public interface IFileVersionsManager {
        public IAuthentication? Auth { get; init; }

        public NetworkSession NetworkSession { get; }

        public System.Threading.Tasks.Task<FileVersions> GetFileVersionsAsync(string fileId, GetFileVersionsQueryParams? queryParams = default, GetFileVersionsHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        public System.Threading.Tasks.Task<FileVersionFull> GetFileVersionByIdAsync(string fileId, string fileVersionId, GetFileVersionByIdQueryParams? queryParams = default, GetFileVersionByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        public System.Threading.Tasks.Task<FileVersionFull> UpdateFileVersionByIdAsync(string fileId, string fileVersionId, UpdateFileVersionByIdRequestBody? requestBody = default, UpdateFileVersionByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        public System.Threading.Tasks.Task DeleteFileVersionByIdAsync(string fileId, string fileVersionId, DeleteFileVersionByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        public System.Threading.Tasks.Task<FileVersionFull> PromoteFileVersionAsync(string fileId, PromoteFileVersionRequestBody? requestBody = default, PromoteFileVersionQueryParams? queryParams = default, PromoteFileVersionHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

    }
}