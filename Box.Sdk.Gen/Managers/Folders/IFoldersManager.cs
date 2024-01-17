using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public interface IFoldersManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession NetworkSession { get; set; }

        public System.Threading.Tasks.Task<FolderFull> GetFolderByIdAsync(string folderId, GetFolderByIdQueryParams? queryParams = default, GetFolderByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<FolderFull> UpdateFolderByIdAsync(string folderId, UpdateFolderByIdRequestBody? requestBody = default, UpdateFolderByIdQueryParams? queryParams = default, UpdateFolderByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteFolderByIdAsync(string folderId, DeleteFolderByIdQueryParams? queryParams = default, DeleteFolderByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<Items> GetFolderItemsAsync(string folderId, GetFolderItemsQueryParams? queryParams = default, GetFolderItemsHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<FolderFull> CreateFolderAsync(CreateFolderRequestBody requestBody, CreateFolderQueryParams? queryParams = default, CreateFolderHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<FolderFull> CopyFolderAsync(string folderId, CopyFolderRequestBody requestBody, CopyFolderQueryParams? queryParams = default, CopyFolderHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}