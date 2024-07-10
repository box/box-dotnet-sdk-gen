using Box.Sdk.Gen;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen.Managers {
    public interface IUploadsManager {
        public IAuthentication? Auth { get; init; }

        public NetworkSession NetworkSession { get; }

        public System.Threading.Tasks.Task<Files> UploadFileVersionAsync(string fileId, UploadFileVersionRequestBody requestBody, UploadFileVersionQueryParams? queryParams = default, UploadFileVersionHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        public System.Threading.Tasks.Task<Files> UploadFileAsync(UploadFileRequestBody requestBody, UploadFileQueryParams? queryParams = default, UploadFileHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        public System.Threading.Tasks.Task<UploadUrl> PreflightFileUploadCheckAsync(PreflightFileUploadCheckRequestBody? requestBody = default, PreflightFileUploadCheckHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

    }
}