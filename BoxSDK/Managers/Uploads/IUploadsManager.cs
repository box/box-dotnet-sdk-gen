using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface IUploadsManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession? NetworkSession { get; set; }

        public System.Threading.Tasks.Task<Files> UploadFileVersionAsync(string fileId, UploadFileVersionRequestBodyArg requestBody, UploadFileVersionQueryParamsArg? queryParams = default, UploadFileVersionHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<Files> UploadFileAsync(UploadFileRequestBodyArg requestBody, UploadFileQueryParamsArg? queryParams = default, UploadFileHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<UploadUrl> PreflightFileUploadAsync(PreflightFileUploadRequestBodyArg? requestBody = default, PreflightFileUploadHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}