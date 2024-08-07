using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen.Managers {
    public interface IChunkedUploadsManager {
        /// <summary>
    /// Creates an upload session for a new file.
    /// </summary>
    /// <param name="requestBody">
    /// Request body of createFileUploadSession method
    /// </param>
    /// <param name="headers">
    /// Headers of createFileUploadSession method
    /// </param>
    /// <param name="cancellationToken">
    /// Token used for request cancellation.
    /// </param>
    public System.Threading.Tasks.Task<UploadSession> CreateFileUploadSessionAsync(CreateFileUploadSessionRequestBody requestBody, CreateFileUploadSessionHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        /// <summary>
    /// Creates an upload session for an existing file.
    /// </summary>
    /// <param name="fileId">
    /// The unique identifier that represents a file.
    /// 
    /// The ID for any file can be determined
    /// by visiting a file in the web application
    /// and copying the ID from the URL. For example,
    /// for the URL `https://*.app.box.com/files/123`
    /// the `file_id` is `123`.
    /// Example: "12345"
    /// </param>
    /// <param name="requestBody">
    /// Request body of createFileUploadSessionForExistingFile method
    /// </param>
    /// <param name="headers">
    /// Headers of createFileUploadSessionForExistingFile method
    /// </param>
    /// <param name="cancellationToken">
    /// Token used for request cancellation.
    /// </param>
    public System.Threading.Tasks.Task<UploadSession> CreateFileUploadSessionForExistingFileAsync(string fileId, CreateFileUploadSessionForExistingFileRequestBody requestBody, CreateFileUploadSessionForExistingFileHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        /// <summary>
    /// Return information about an upload session.
    /// </summary>
    /// <param name="uploadSessionId">
    /// The ID of the upload session.
    /// Example: "D5E3F7A"
    /// </param>
    /// <param name="headers">
    /// Headers of getFileUploadSessionById method
    /// </param>
    /// <param name="cancellationToken">
    /// Token used for request cancellation.
    /// </param>
    public System.Threading.Tasks.Task<UploadSession> GetFileUploadSessionByIdAsync(string uploadSessionId, GetFileUploadSessionByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        /// <summary>
    /// Updates a chunk of an upload session for a file.
    /// </summary>
    /// <param name="uploadSessionId">
    /// The ID of the upload session.
    /// Example: "D5E3F7A"
    /// </param>
    /// <param name="requestBody">
    /// Request body of uploadFilePart method
    /// </param>
    /// <param name="headers">
    /// Headers of uploadFilePart method
    /// </param>
    /// <param name="cancellationToken">
    /// Token used for request cancellation.
    /// </param>
    public System.Threading.Tasks.Task<UploadedPart> UploadFilePartAsync(string uploadSessionId, System.IO.Stream requestBody, UploadFilePartHeaders headers, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        /// <summary>
    /// Abort an upload session and discard all data uploaded.
    /// 
    /// This cannot be reversed.
    /// </summary>
    /// <param name="uploadSessionId">
    /// The ID of the upload session.
    /// Example: "D5E3F7A"
    /// </param>
    /// <param name="headers">
    /// Headers of deleteFileUploadSessionById method
    /// </param>
    /// <param name="cancellationToken">
    /// Token used for request cancellation.
    /// </param>
    public System.Threading.Tasks.Task DeleteFileUploadSessionByIdAsync(string uploadSessionId, DeleteFileUploadSessionByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        /// <summary>
    /// Return a list of the chunks uploaded to the upload
    /// session so far.
    /// </summary>
    /// <param name="uploadSessionId">
    /// The ID of the upload session.
    /// Example: "D5E3F7A"
    /// </param>
    /// <param name="queryParams">
    /// Query parameters of getFileUploadSessionParts method
    /// </param>
    /// <param name="headers">
    /// Headers of getFileUploadSessionParts method
    /// </param>
    /// <param name="cancellationToken">
    /// Token used for request cancellation.
    /// </param>
    public System.Threading.Tasks.Task<UploadParts> GetFileUploadSessionPartsAsync(string uploadSessionId, GetFileUploadSessionPartsQueryParams? queryParams = default, GetFileUploadSessionPartsHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        /// <summary>
    /// Close an upload session and create a file from the
    /// uploaded chunks.
    /// </summary>
    /// <param name="uploadSessionId">
    /// The ID of the upload session.
    /// Example: "D5E3F7A"
    /// </param>
    /// <param name="requestBody">
    /// Request body of createFileUploadSessionCommit method
    /// </param>
    /// <param name="headers">
    /// Headers of createFileUploadSessionCommit method
    /// </param>
    /// <param name="cancellationToken">
    /// Token used for request cancellation.
    /// </param>
    public System.Threading.Tasks.Task<Files> CreateFileUploadSessionCommitAsync(string uploadSessionId, CreateFileUploadSessionCommitRequestBody requestBody, CreateFileUploadSessionCommitHeaders headers, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

        /// <summary>
    /// Starts the process of chunk uploading a big file. Should return a File object representing uploaded file.
    /// </summary>
    /// <param name="file">
    /// The stream of the file to upload.
    /// </param>
    /// <param name="fileName">
    /// The name of the file, which will be used for storage in Box.
    /// </param>
    /// <param name="fileSize">
    /// The total size of the file for the chunked upload in bytes.
    /// </param>
    /// <param name="parentFolderId">
    /// The ID of the folder where the file should be uploaded.
    /// </param>
    /// <param name="cancellationToken">
    /// Token used for request cancellation.
    /// </param>
    public System.Threading.Tasks.Task<FileFull> UploadBigFileAsync(System.IO.Stream file, string fileName, long fileSize, string parentFolderId, System.Threading.CancellationToken? cancellationToken = null) => throw new System.NotImplementedException("This method needs to be implemented by the derived class before calling it.");

    }
}