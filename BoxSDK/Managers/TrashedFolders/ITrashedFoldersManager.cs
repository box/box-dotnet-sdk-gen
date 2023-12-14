using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface ITrashedFoldersManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession NetworkSession { get; set; }

        public System.Threading.Tasks.Task<TrashFolderRestored> RestoreFolderFromTrashAsync(string folderId, RestoreFolderFromTrashRequestBody? requestBody = default, RestoreFolderFromTrashQueryParams? queryParams = default, RestoreFolderFromTrashHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<TrashFolder> GetFolderTrashAsync(string folderId, GetFolderTrashQueryParams? queryParams = default, GetFolderTrashHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteFolderTrashAsync(string folderId, DeleteFolderTrashHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}