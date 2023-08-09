# UploadsManager


- [Upload file version](#upload-file-version)
- [Upload file](#upload-file)
- [Preflight check before upload](#preflight-check-before-upload)

## Upload file version

Update a file's content. For file sizes over 50MB we recommend
using the Chunk Upload APIs.

# Request body order

The `attributes` part of the body must come **before** the
`file` part. Requests that do not follow this format when
uploading the file will receive a HTTP `400` error with a
`metadata_after_file_contents` error code.

This operation is performed by calling function `UploadFileVersion`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/post-files-id-content/).

*Currently we don't have an example for calling `UploadFileVersion` in integration tests*

### Arguments

- fileId `string`
  - The unique identifier that represents a file.  The ID for any file can be determined by visiting a file in the web application and copying the ID from the URL. For example, for the URL `https://*.app.box.com/files/123` the `file_id` is `123`. Example: "12345"
- requestBody `UploadFileVersionRequestBodyArg`
  - Request body of uploadFileVersion method
- queryParams `UploadFileVersionQueryParamsArg`
  - Query parameters of uploadFileVersion method
- headers `UploadFileVersionHeadersArg`
  - Headers of uploadFileVersion method


### Returns

This function returns a value of type `Files`.

Returns the new file object in a list.


## Upload file

Uploads a small file to Box. For file sizes over 50MB we recommend
using the Chunk Upload APIs.

# Request body order

The `attributes` part of the body must come **before** the
`file` part. Requests that do not follow this format when
uploading the file will receive a HTTP `400` error with a
`metadata_after_file_contents` error code.

This operation is performed by calling function `UploadFile`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/post-files-content/).

*Currently we don't have an example for calling `UploadFile` in integration tests*

### Arguments

- requestBody `UploadFileRequestBodyArg`
  - Request body of uploadFile method
- queryParams `UploadFileQueryParamsArg`
  - Query parameters of uploadFile method
- headers `UploadFileHeadersArg`
  - Headers of uploadFile method


### Returns

This function returns a value of type `Files`.

Returns the new file object in a list.


## Preflight check before upload

Performs a check to verify that a file will be accepted by Box
before you upload the entire file.

This operation is performed by calling function `PreflightFileUpload`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/options-files-content/).

*Currently we don't have an example for calling `PreflightFileUpload` in integration tests*

### Arguments

- requestBody `PreflightFileUploadRequestBodyArg`
  - Request body of preflightFileUpload method
- headers `PreflightFileUploadHeadersArg`
  - Headers of preflightFileUpload method


### Returns

This function returns a value of type `UploadUrl`.

If the check passed, the response will include a session URL that
can be used to upload the file to.


