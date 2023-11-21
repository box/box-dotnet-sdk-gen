using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface IFileVersionsManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession? NetworkSession { get; set; }

        public System.Threading.Tasks.Task<FileVersions> GetFileVersionsAsync(string fileId, GetFileVersionsQueryParamsArg? queryParams = default, GetFileVersionsHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<FileVersionFull> GetFileVersionByIdAsync(string fileId, string fileVersionId, GetFileVersionByIdQueryParamsArg? queryParams = default, GetFileVersionByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<FileVersionFull> UpdateFileVersionByIdAsync(string fileId, string fileVersionId, UpdateFileVersionByIdRequestBodyArg? requestBody = default, UpdateFileVersionByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteFileVersionByIdAsync(string fileId, string fileVersionId, DeleteFileVersionByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<FileVersionFull> PromoteFileVersionAsync(string fileId, PromoteFileVersionRequestBodyArg? requestBody = default, PromoteFileVersionQueryParamsArg? queryParams = default, PromoteFileVersionHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}