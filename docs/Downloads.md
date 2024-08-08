# IDownloadsManager


- [Download file](#download-file)

## Download file

Returns the contents of a file in binary format.

This operation is performed by calling function `DownloadFile`.



```
await client.Downloads.DownloadFileAsync(fileId: uploadedFile.Id);
```

### Arguments

- fileId `string`
  - The unique identifier that represents a file.  The ID for any file can be determined by visiting a file in the web application and copying the ID from the URL. For example, for the URL `https://*.app.box.com/files/123` the `file_id` is `123`. Example: "12345"
- queryParams `DownloadFileQueryParams`
  - Query parameters of downloadFile method
- headers `DownloadFileHeaders`
  - Headers of downloadFile method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `System.IO.Stream`.

Returns the requested file if the client has the **follow
redirects** setting enabled to automatically
follow HTTP `3xx` responses as redirects. If not, the request
will return `302` instead.
For details, see
the [download file guide](g://downloads/file#download-url).If the file is not ready to be downloaded yet `Retry-After` header will
be returned indicating the time in seconds after which the file will
be available for the client to download.

This response can occur when the file was uploaded immediately before the
download request.


