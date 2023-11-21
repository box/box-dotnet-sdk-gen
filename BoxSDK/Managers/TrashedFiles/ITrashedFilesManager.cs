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

        public NetworkSession? NetworkSession { get; set; }

        public System.Threading.Tasks.Task<TrashFileRestored> RestoreFileFromTrashAsync(string fileId, RestoreFileFromTrashRequestBodyArg? requestBody = default, RestoreFileFromTrashQueryParamsArg? queryParams = default, RestoreFileFromTrashHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<TrashFile> GetFileTrashAsync(string fileId, GetFileTrashQueryParamsArg? queryParams = default, GetFileTrashHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteFileTrashAsync(string fileId, DeleteFileTrashHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}