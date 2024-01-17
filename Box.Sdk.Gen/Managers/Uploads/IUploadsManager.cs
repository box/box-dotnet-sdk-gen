using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public interface IUploadsManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession NetworkSession { get; set; }

        public System.Threading.Tasks.Task<Files> UploadFileVersionAsync(string fileId, UploadFileVersionRequestBody requestBody, UploadFileVersionQueryParams? queryParams = default, UploadFileVersionHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<Files> UploadFileAsync(UploadFileRequestBody requestBody, UploadFileQueryParams? queryParams = default, UploadFileHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<UploadUrl> PreflightFileUploadCheckAsync(PreflightFileUploadCheckRequestBody? requestBody = default, PreflightFileUploadCheckHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}