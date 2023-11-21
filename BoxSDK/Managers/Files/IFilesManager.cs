using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface IFilesManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession? NetworkSession { get; set; }

        public System.Threading.Tasks.Task<FileFull> GetFileByIdAsync(string fileId, GetFileByIdQueryParamsArg? queryParams = default, GetFileByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<FileFull> UpdateFileByIdAsync(string fileId, UpdateFileByIdRequestBodyArg? requestBody = default, UpdateFileByIdQueryParamsArg? queryParams = default, UpdateFileByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteFileByIdAsync(string fileId, DeleteFileByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<FileFull> CopyFileAsync(string fileId, CopyFileRequestBodyArg requestBody, CopyFileQueryParamsArg? queryParams = default, CopyFileHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<System.IO.Stream> GetFileThumbnailByIdAsync(string fileId, GetFileThumbnailByIdExtensionArg extension, GetFileThumbnailByIdQueryParamsArg? queryParams = default, GetFileThumbnailByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}