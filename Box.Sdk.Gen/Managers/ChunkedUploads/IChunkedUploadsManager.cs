using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Unions;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public interface IChunkedUploadsManager {
        public IAuthentication? Auth { get; init; }

        public NetworkSession NetworkSession { get; }

        public System.Threading.Tasks.Task<UploadSession> CreateFileUploadSessionAsync(CreateFileUploadSessionRequestBody requestBody, CreateFileUploadSessionHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        public System.Threading.Tasks.Task<UploadSession> CreateFileUploadSessionForExistingFileAsync(string fileId, CreateFileUploadSessionForExistingFileRequestBody requestBody, CreateFileUploadSessionForExistingFileHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        public System.Threading.Tasks.Task<UploadSession> GetFileUploadSessionByIdAsync(string uploadSessionId, GetFileUploadSessionByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        public System.Threading.Tasks.Task<UploadedPart> UploadFilePartAsync(string uploadSessionId, System.IO.Stream requestBody, UploadFilePartHeaders headers, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        public System.Threading.Tasks.Task DeleteFileUploadSessionByIdAsync(string uploadSessionId, DeleteFileUploadSessionByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        public System.Threading.Tasks.Task<UploadParts> GetFileUploadSessionPartsAsync(string uploadSessionId, GetFileUploadSessionPartsQueryParams? queryParams = default, GetFileUploadSessionPartsHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        public System.Threading.Tasks.Task<Files> CreateFileUploadSessionCommitAsync(string uploadSessionId, CreateFileUploadSessionCommitRequestBody requestBody, CreateFileUploadSessionCommitHeaders headers, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        public System.Threading.Tasks.Task<FileFull> UploadBigFileAsync(System.IO.Stream file, string fileName, int fileSize, string parentFolderId, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

    }
}