# FileWatermarksManager


- [Get watermark on file](#get-watermark-on-file)
- [Apply watermark to file](#apply-watermark-to-file)
- [Remove watermark from file](#remove-watermark-from-file)

## Get watermark on file

Retrieve the watermark for a file.

This operation is performed by calling function `GetFileWatermark`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-files-id-watermark/).

*Currently we don't have an example for calling `GetFileWatermark` in integration tests*

### Arguments

- fileId `string`
  - The unique identifier that represents a file.  The ID for any file can be determined by visiting a file in the web application and copying the ID from the URL. For example, for the URL `https://*.app.box.com/files/123` the `file_id` is `123`. Example: "12345"
- headers `GetFileWatermarkHeadersArg`
  - Headers of getFileWatermark method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `Watermark`.

Returns an object containing information about the
watermark associated for to this file.


## Apply watermark to file

Applies or update a watermark on a file.

This operation is performed by calling function `UpdateFileWatermark`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/put-files-id-watermark/).

*Currently we don't have an example for calling `UpdateFileWatermark` in integration tests*

### Arguments

- fileId `string`
  - The unique identifier that represents a file.  The ID for any file can be determined by visiting a file in the web application and copying the ID from the URL. For example, for the URL `https://*.app.box.com/files/123` the `file_id` is `123`. Example: "12345"
- requestBody `UpdateFileWatermarkRequestBodyArg`
  - Request body of updateFileWatermark method
- headers `UpdateFileWatermarkHeadersArg`
  - Headers of updateFileWatermark method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `Watermark`.

Returns an updated watermark if a watermark already
existed on this file.Returns a new watermark if no watermark existed on
this file yet.


## Remove watermark from file

Removes the watermark from a file.

This operation is performed by calling function `DeleteFileWatermark`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/delete-files-id-watermark/).

*Currently we don't have an example for calling `DeleteFileWatermark` in integration tests*

### Arguments

- fileId `string`
  - The unique identifier that represents a file.  The ID for any file can be determined by visiting a file in the web application and copying the ID from the URL. For example, for the URL `https://*.app.box.com/files/123` the `file_id` is `123`. Example: "12345"
- headers `DeleteFileWatermarkHeadersArg`
  - Headers of deleteFileWatermark method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `null`.

Removes the watermark and returns an empty response.


