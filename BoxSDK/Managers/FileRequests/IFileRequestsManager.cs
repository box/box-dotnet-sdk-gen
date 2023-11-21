using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface IFileRequestsManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession? NetworkSession { get; set; }

        public System.Threading.Tasks.Task<FileRequest> GetFileRequestByIdAsync(string fileRequestId, GetFileRequestByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<FileRequest> UpdateFileRequestByIdAsync(string fileRequestId, FileRequestUpdateRequest requestBody, UpdateFileRequestByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteFileRequestByIdAsync(string fileRequestId, DeleteFileRequestByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<FileRequest> CreateFileRequestCopyAsync(string fileRequestId, FileRequestCopyRequest requestBody, CreateFileRequestCopyHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}