# IUploadsManager


- [Upload file version](#upload-file-version)
- [Upload file](#upload-file)
- [Preflight check before upload](#preflight-check-before-upload)

## Upload file version

Update a file's content. For file sizes over 50MB we recommend
using the Chunk Upload APIs.

The `attributes` part of the body must come **before** the
`file` part. Requests that do not follow this format when
uploading the file will receive a HTTP `400` error with a
`metadata_after_file_contents` error code.

This operation is performed by calling function `UploadFileVersion`.



```
await client.Uploads.UploadFileVersionAsync(fileId: file.Id, requestBody: new UploadFileVersionRequestBody(attributes: new UploadFileVersionRequestBodyAttributesField(name: NullableUtils.Unwrap(file.Name)), file: Utils.GenerateByteStream(size: 20)));
```

### Arguments

- fileId `string`
  - The unique identifier that represents a file.  The ID for any file can be determined by visiting a file in the web application and copying the ID from the URL. For example, for the URL `https://*.app.box.com/files/123` the `file_id` is `123`. Example: "12345"
- requestBody `UploadFileVersionRequestBody`
  - Request body of uploadFileVersion method
- queryParams `UploadFileVersionQueryParams`
  - Query parameters of uploadFileVersion method
- headers `UploadFileVersionHeaders`
  - Headers of uploadFileVersion method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `Files`.

Returns the new file object in a list.


## Upload file

Uploads a small file to Box. For file sizes over 50MB we recommend
using the Chunk Upload APIs.

The `attributes` part of the body must come **before** the
`file` part. Requests that do not follow this format when
uploading the file will receive a HTTP `400` error with a
`metadata_after_file_contents` error code.

This operation is performed by calling function `UploadFile`.



```
await parentClient.Uploads.UploadFileAsync(requestBody: new UploadFileRequestBody(attributes: new UploadFileRequestBodyAttributesField(name: Utils.GetUUID(), parent: new UploadFileRequestBodyAttributesParentField(id: "0")), file: Utils.GenerateByteStream(size: 1024 * 1024)));
```

### Arguments

- requestBody `UploadFileRequestBody`
  - Request body of uploadFile method
- queryParams `UploadFileQueryParams`
  - Query parameters of uploadFile method
- headers `UploadFileHeaders`
  - Headers of uploadFile method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `Files`.

Returns the new file object in a list.


## Preflight check before upload

Performs a check to verify that a file will be accepted by Box
before you upload the entire file.

This operation is performed by calling function `PreflightFileUploadCheck`.


*Currently we don't have an example for calling `PreflightFileUploadCheck` in integration tests*

### Arguments

- requestBody `PreflightFileUploadCheckRequestBody`
  - Request body of preflightFileUploadCheck method
- headers `PreflightFileUploadCheckHeaders`
  - Headers of preflightFileUploadCheck method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `UploadUrl`.

If the check passed, the response will include a session URL that
can be used to upload the file to.


