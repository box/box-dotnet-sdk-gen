using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface ISharedLinksFoldersManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession NetworkSession { get; set; }

        public System.Threading.Tasks.Task<FolderFull> FindFolderForSharedLinkAsync(FindFolderForSharedLinkHeaders headers, FindFolderForSharedLinkQueryParams? queryParams = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<FolderFull> GetSharedLinkForFolderAsync(string folderId, GetSharedLinkForFolderQueryParams queryParams, GetSharedLinkForFolderHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<FolderFull> AddShareLinkToFolderAsync(string folderId, AddShareLinkToFolderQueryParams queryParams, AddShareLinkToFolderRequestBody? requestBody = default, AddShareLinkToFolderHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<FolderFull> UpdateSharedLinkOnFolderAsync(string folderId, UpdateSharedLinkOnFolderQueryParams queryParams, UpdateSharedLinkOnFolderRequestBody? requestBody = default, UpdateSharedLinkOnFolderHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<FolderFull> RemoveSharedLinkFromFolderAsync(string folderId, RemoveSharedLinkFromFolderQueryParams queryParams, RemoveSharedLinkFromFolderRequestBody? requestBody = default, RemoveSharedLinkFromFolderHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}