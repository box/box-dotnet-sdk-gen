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

        public NetworkSession NetworkSession { get; set; }

        public System.Threading.Tasks.Task<FileFull> GetFileByIdAsync(string fileId, GetFileByIdQueryParams? queryParams = default, GetFileByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<FileFull> UpdateFileByIdAsync(string fileId, UpdateFileByIdRequestBody? requestBody = default, UpdateFileByIdQueryParams? queryParams = default, UpdateFileByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteFileByIdAsync(string fileId, DeleteFileByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<FileFull> CopyFileAsync(string fileId, CopyFileRequestBody requestBody, CopyFileQueryParams? queryParams = default, CopyFileHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<System.IO.Stream> GetFileThumbnailByIdAsync(string fileId, GetFileThumbnailByIdExtension extension, GetFileThumbnailByIdQueryParams? queryParams = default, GetFileThumbnailByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}