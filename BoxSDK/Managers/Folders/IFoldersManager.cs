using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface IFoldersManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession? NetworkSession { get; set; }

        public System.Threading.Tasks.Task<FolderFull> GetFolderByIdAsync(string folderId, GetFolderByIdQueryParamsArg? queryParams = default, GetFolderByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<FolderFull> UpdateFolderByIdAsync(string folderId, UpdateFolderByIdRequestBodyArg? requestBody = default, UpdateFolderByIdQueryParamsArg? queryParams = default, UpdateFolderByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteFolderByIdAsync(string folderId, DeleteFolderByIdQueryParamsArg? queryParams = default, DeleteFolderByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<Items> GetFolderItemsAsync(string folderId, GetFolderItemsQueryParamsArg? queryParams = default, GetFolderItemsHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<FolderFull> CreateFolderAsync(CreateFolderRequestBodyArg requestBody, CreateFolderQueryParamsArg? queryParams = default, CreateFolderHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<FolderFull> CopyFolderAsync(string folderId, CopyFolderRequestBodyArg requestBody, CopyFolderQueryParamsArg? queryParams = default, CopyFolderHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}