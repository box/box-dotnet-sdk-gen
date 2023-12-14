using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface ISharedLinksFilesManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession NetworkSession { get; set; }

        public System.Threading.Tasks.Task<FileFull> GetSharedItemsAsync(GetSharedItemsHeaders headers, GetSharedItemsQueryParams? queryParams = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<FileFull> GetFileGetSharedLinkAsync(string fileId, GetFileGetSharedLinkQueryParams queryParams, GetFileGetSharedLinkHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<FileFull> UpdateFileAddSharedLinkAsync(string fileId, UpdateFileAddSharedLinkQueryParams queryParams, UpdateFileAddSharedLinkRequestBody? requestBody = default, UpdateFileAddSharedLinkHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<FileFull> UpdateFileUpdateSharedLinkAsync(string fileId, UpdateFileUpdateSharedLinkQueryParams queryParams, UpdateFileUpdateSharedLinkRequestBody? requestBody = default, UpdateFileUpdateSharedLinkHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<FileFull> UpdateFileRemoveSharedLinkAsync(string fileId, UpdateFileRemoveSharedLinkQueryParams queryParams, UpdateFileRemoveSharedLinkRequestBody? requestBody = default, UpdateFileRemoveSharedLinkHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}