using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public interface ISharedLinksFilesManager {
        public IAuthentication? Auth { get; init; }

        public NetworkSession NetworkSession { get; }

        public System.Threading.Tasks.Task<FileFull> FindFileForSharedLinkAsync(FindFileForSharedLinkHeaders headers, FindFileForSharedLinkQueryParams? queryParams = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        public System.Threading.Tasks.Task<FileFull> GetSharedLinkForFileAsync(string fileId, GetSharedLinkForFileQueryParams queryParams, GetSharedLinkForFileHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        public System.Threading.Tasks.Task<FileFull> AddShareLinkToFileAsync(string fileId, AddShareLinkToFileQueryParams queryParams, AddShareLinkToFileRequestBody? requestBody = default, AddShareLinkToFileHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        public System.Threading.Tasks.Task<FileFull> UpdateSharedLinkOnFileAsync(string fileId, UpdateSharedLinkOnFileQueryParams queryParams, UpdateSharedLinkOnFileRequestBody? requestBody = default, UpdateSharedLinkOnFileHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        public System.Threading.Tasks.Task<FileFull> RemoveSharedLinkFromFileAsync(string fileId, RemoveSharedLinkFromFileQueryParams queryParams, RemoveSharedLinkFromFileRequestBody? requestBody = default, RemoveSharedLinkFromFileHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

    }
}