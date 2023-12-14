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

        public System.Threading.Tasks.Task<FolderFull> GetSharedItemFoldersAsync(GetSharedItemFoldersHeaders headers, GetSharedItemFoldersQueryParams? queryParams = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<FolderFull> GetFolderGetSharedLinkAsync(string folderId, GetFolderGetSharedLinkQueryParams queryParams, GetFolderGetSharedLinkHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<FolderFull> UpdateFolderAddSharedLinkAsync(string folderId, UpdateFolderAddSharedLinkQueryParams queryParams, UpdateFolderAddSharedLinkRequestBody? requestBody = default, UpdateFolderAddSharedLinkHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<FolderFull> UpdateFolderUpdateSharedLinkAsync(string folderId, UpdateFolderUpdateSharedLinkQueryParams queryParams, UpdateFolderUpdateSharedLinkRequestBody? requestBody = default, UpdateFolderUpdateSharedLinkHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<FolderFull> UpdateFolderRemoveSharedLinkAsync(string folderId, UpdateFolderRemoveSharedLinkQueryParams queryParams, UpdateFolderRemoveSharedLinkRequestBody? requestBody = default, UpdateFolderRemoveSharedLinkHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}