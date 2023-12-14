using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface ITrashedFilesManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession NetworkSession { get; set; }

        public System.Threading.Tasks.Task<TrashFileRestored> RestoreFileFromTrashAsync(string fileId, RestoreFileFromTrashRequestBody? requestBody = default, RestoreFileFromTrashQueryParams? queryParams = default, RestoreFileFromTrashHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<TrashFile> GetFileTrashAsync(string fileId, GetFileTrashQueryParams? queryParams = default, GetFileTrashHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteFileTrashAsync(string fileId, DeleteFileTrashHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}