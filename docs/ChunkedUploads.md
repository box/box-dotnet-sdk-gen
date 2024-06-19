# IChunkedUploadsManager


- [Create upload session](#create-upload-session)
- [Create upload session for existing file](#create-upload-session-for-existing-file)
- [Get upload session](#get-upload-session)
- [Upload part of file](#upload-part-of-file)
- [Remove upload session](#remove-upload-session)
- [List parts](#list-parts)
- [Commit upload session](#commit-upload-session)
- [Upload big file](#upload-big-file)

## Create upload session

Creates an upload session for a new file.

This operation is performed by calling function `CreateFileUploadSession`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/post-files-upload-sessions/).

*Currently we don't have an example for calling `CreateFileUploadSession` in integration tests*

### Arguments

- requestBody `CreateFileUploadSessionRequestBody`
  - Request body of createFileUploadSession method
- headers `CreateFileUploadSessionHeaders`
  - Headers of createFileUploadSession method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `UploadSession`.

Returns a new upload session.


## Create upload session for existing file

Creates an upload session for an existing file.

This operation is performed by calling function `CreateFileUploadSessionForExistingFile`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/post-files-id-upload-sessions/).

*Currently we don't have an example for calling `CreateFileUploadSessionForExistingFile` in integration tests*

### Arguments

- fileId `string`
  - The unique identifier that represents a file.  The ID for any file can be determined by visiting a file in the web application and copying the ID from the URL. For example, for the URL `https://*.app.box.com/files/123` the `file_id` is `123`. Example: "12345"
- requestBody `CreateFileUploadSessionForExistingFileRequestBody`
  - Request body of createFileUploadSessionForExistingFile method
- headers `CreateFileUploadSessionForExistingFileHeaders`
  - Headers of createFileUploadSessionForExistingFile method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `UploadSession`.

Returns a new upload session.


## Get upload session

Return information about an upload session.

This operation is performed by calling function `GetFileUploadSessionById`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-files-upload-sessions-id/).

*Currently we don't have an example for calling `GetFileUploadSessionById` in integration tests*

### Arguments

- uploadSessionId `string`
  - The ID of the upload session. Example: "D5E3F7A"
- headers `GetFileUploadSessionByIdHeaders`
  - Headers of getFileUploadSessionById method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `UploadSession`.

Returns an upload session object.


## Upload part of file

Updates a chunk of an upload session for a file.

This operation is performed by calling function `UploadFilePart`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/put-files-upload-sessions-id/).

*Currently we don't have an example for calling `UploadFilePart` in integration tests*

### Arguments

- uploadSessionId `string`
  - The ID of the upload session. Example: "D5E3F7A"
- requestBody `System.IO.Stream`
  - Request body of uploadFilePart method
- headers `UploadFilePartHeaders`
  - Headers of uploadFilePart method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `UploadedPart`.

Chunk has been uploaded successfully.


## Remove upload session

Abort an upload session and discard all data uploaded.

This cannot be reversed.

This operation is performed by calling function `DeleteFileUploadSessionById`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/delete-files-upload-sessions-id/).

*Currently we don't have an example for calling `DeleteFileUploadSessionById` in integration tests*

### Arguments

- uploadSessionId `string`
  - The ID of the upload session. Example: "D5E3F7A"
- headers `DeleteFileUploadSessionByIdHeaders`
  - Headers of deleteFileUploadSessionById method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `null`.

A blank response is returned if the session was
successfully aborted.


## List parts

Return a list of the chunks uploaded to the upload
session so far.

This operation is performed by calling function `GetFileUploadSessionParts`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-files-upload-sessions-id-parts/).

*Currently we don't have an example for calling `GetFileUploadSessionParts` in integration tests*

### Arguments

- uploadSessionId `string`
  - The ID of the upload session. Example: "D5E3F7A"
- queryParams `GetFileUploadSessionPartsQueryParams`
  - Query parameters of getFileUploadSessionParts method
- headers `GetFileUploadSessionPartsHeaders`
  - Headers of getFileUploadSessionParts method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `UploadParts`.

Returns a list of parts that have been uploaded.


## Commit upload session

Close an upload session and create a file from the
uploaded chunks.

This operation is performed by calling function `CreateFileUploadSessionCommit`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/post-files-upload-sessions-id-commit/).

*Currently we don't have an example for calling `CreateFileUploadSessionCommit` in integration tests*

### Arguments

- uploadSessionId `string`
  - The ID of the upload session. Example: "D5E3F7A"
- requestBody `CreateFileUploadSessionCommitRequestBody`
  - Request body of createFileUploadSessionCommit method
- headers `CreateFileUploadSessionCommitHeaders`
  - Headers of createFileUploadSessionCommit method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `Files`.

Returns the file object in a list.Returns when all chunks have been uploaded but not yet processed.

Inspect the upload session to get more information about the
progress of processing the chunks, then retry committing the file
when all chunks have processed.


## Upload big file

Starts the process of chunk uploading a big file. Should return a File object representing uploaded file.

This operation is performed by calling function `UploadBigFile`.



```
await client.ChunkedUploads.UploadBigFileAsync(file: fileByteStream, fileName: fileName, fileSize: fileSize, parentFolderId: parentFolderId);
```

### Arguments

- file `System.IO.Stream`
  - The stream of the file to upload.
- fileName `string`
  - The name of the file, which will be used for storage in Box.
- fileSize `long`
  - The total size of the file for the chunked upload in bytes.
- parentFolderId `string`
  - The ID of the folder where the file should be uploaded.
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `FileFull`.




