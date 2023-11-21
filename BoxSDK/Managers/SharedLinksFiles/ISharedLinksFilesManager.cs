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

        public NetworkSession? NetworkSession { get; set; }

        public System.Threading.Tasks.Task<FileFull> GetSharedItemsAsync(GetSharedItemsHeadersArg headers, GetSharedItemsQueryParamsArg? queryParams = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<FileFull> GetFileGetSharedLinkAsync(string fileId, GetFileGetSharedLinkQueryParamsArg queryParams, GetFileGetSharedLinkHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<FileFull> UpdateFileAddSharedLinkAsync(string fileId, UpdateFileAddSharedLinkQueryParamsArg queryParams, UpdateFileAddSharedLinkRequestBodyArg? requestBody = default, UpdateFileAddSharedLinkHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<FileFull> UpdateFileUpdateSharedLinkAsync(string fileId, UpdateFileUpdateSharedLinkQueryParamsArg queryParams, UpdateFileUpdateSharedLinkRequestBodyArg? requestBody = default, UpdateFileUpdateSharedLinkHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<FileFull> UpdateFileRemoveSharedLinkAsync(string fileId, UpdateFileRemoveSharedLinkQueryParamsArg queryParams, UpdateFileRemoveSharedLinkRequestBodyArg? requestBody = default, UpdateFileRemoveSharedLinkHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}