using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen;
using Serializer;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Managers {
    public interface ISharedLinksFoldersManager {
        public IAuthentication? Auth { get; init; }

        public NetworkSession NetworkSession { get; }

        public System.Threading.Tasks.Task<FolderFull> FindFolderForSharedLinkAsync(FindFolderForSharedLinkHeaders headers, FindFolderForSharedLinkQueryParams? queryParams = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        public System.Threading.Tasks.Task<FolderFull> GetSharedLinkForFolderAsync(string folderId, GetSharedLinkForFolderQueryParams queryParams, GetSharedLinkForFolderHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        public System.Threading.Tasks.Task<FolderFull> AddShareLinkToFolderAsync(string folderId, AddShareLinkToFolderQueryParams queryParams, AddShareLinkToFolderRequestBody? requestBody = default, AddShareLinkToFolderHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        public System.Threading.Tasks.Task<FolderFull> UpdateSharedLinkOnFolderAsync(string folderId, UpdateSharedLinkOnFolderQueryParams queryParams, UpdateSharedLinkOnFolderRequestBody? requestBody = default, UpdateSharedLinkOnFolderHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        public System.Threading.Tasks.Task<FolderFull> RemoveSharedLinkFromFolderAsync(string folderId, RemoveSharedLinkFromFolderQueryParams queryParams, RemoveSharedLinkFromFolderRequestBody? requestBody = default, RemoveSharedLinkFromFolderHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

    }
}