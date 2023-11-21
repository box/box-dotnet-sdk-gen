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

        public NetworkSession? NetworkSession { get; set; }

        public System.Threading.Tasks.Task<FolderFull> GetSharedItemFoldersAsync(GetSharedItemFoldersHeadersArg headers, GetSharedItemFoldersQueryParamsArg? queryParams = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<FolderFull> GetFolderGetSharedLinkAsync(string folderId, GetFolderGetSharedLinkQueryParamsArg queryParams, GetFolderGetSharedLinkHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<FolderFull> UpdateFolderAddSharedLinkAsync(string folderId, UpdateFolderAddSharedLinkQueryParamsArg queryParams, UpdateFolderAddSharedLinkRequestBodyArg? requestBody = default, UpdateFolderAddSharedLinkHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<FolderFull> UpdateFolderUpdateSharedLinkAsync(string folderId, UpdateFolderUpdateSharedLinkQueryParamsArg queryParams, UpdateFolderUpdateSharedLinkRequestBodyArg? requestBody = default, UpdateFolderUpdateSharedLinkHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<FolderFull> UpdateFolderRemoveSharedLinkAsync(string folderId, UpdateFolderRemoveSharedLinkQueryParamsArg queryParams, UpdateFolderRemoveSharedLinkRequestBodyArg? requestBody = default, UpdateFolderRemoveSharedLinkHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}