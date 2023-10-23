# FileVersionsManager


- [List all file versions](#list-all-file-versions)
- [Get file version](#get-file-version)
- [Restore file version](#restore-file-version)
- [Remove file version](#remove-file-version)
- [Promote file version](#promote-file-version)

## List all file versions

Retrieve a list of the past versions for a file.

Versions are only tracked by Box users with premium accounts. To fetch the ID
of the current version of a file, use the `GET /file/:id` API.

This operation is performed by calling function `GetFileVersions`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-files-id-versions/).

<!-- sample get_files_id_versions -->
```
await client.FileVersions.GetFileVersionsAsync(file.Id).ConfigureAwait(false)
```

### Arguments

- fileId `string`
  - The unique identifier that represents a file.  The ID for any file can be determined by visiting a file in the web application and copying the ID from the URL. For example, for the URL `https://*.app.box.com/files/123` the `file_id` is `123`. Example: "12345"
- queryParams `GetFileVersionsQueryParamsArg`
  - Query parameters of getFileVersions method
- headers `GetFileVersionsHeadersArg`
  - Headers of getFileVersions method


### Returns

This function returns a value of type `FileVersions`.

Returns an array of past versions for this file.


## Get file version

Retrieve a specific version of a file.

Versions are only tracked for Box users with premium accounts.

This operation is performed by calling function `GetFileVersionById`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-files-id-versions-id/).

<!-- sample get_files_id_versions_id -->
```
await client.FileVersions.GetFileVersionByIdAsync(file.Id, fileVersions.Entries![0].Id).ConfigureAwait(false)
```

### Arguments

- fileId `string`
  - The unique identifier that represents a file.  The ID for any file can be determined by visiting a file in the web application and copying the ID from the URL. For example, for the URL `https://*.app.box.com/files/123` the `file_id` is `123`. Example: "12345"
- fileVersionId `string`
  - The ID of the file version Example: "1234"
- queryParams `GetFileVersionByIdQueryParamsArg`
  - Query parameters of getFileVersionById method
- headers `GetFileVersionByIdHeadersArg`
  - Headers of getFileVersionById method


### Returns

This function returns a value of type `FileVersionFull`.

Returns a specific version of a file.

Not all available fields are returned by default. Use the
[fields](#param-fields) query parameter to explicitly request
any specific fields.


## Restore file version

Restores a specific version of a file after it was deleted.
Don't use this endpoint to restore Box Notes,
as it works with file formats such as PDF, DOC,
PPTX or similar.

This operation is performed by calling function `UpdateFileVersionById`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/put-files-id-versions-id/).

*Currently we don't have an example for calling `UpdateFileVersionById` in integration tests*

### Arguments

- fileId `string`
  - The unique identifier that represents a file.  The ID for any file can be determined by visiting a file in the web application and copying the ID from the URL. For example, for the URL `https://*.app.box.com/files/123` the `file_id` is `123`. Example: "12345"
- fileVersionId `string`
  - The ID of the file version Example: "1234"
- requestBody `UpdateFileVersionByIdRequestBodyArg`
  - Request body of updateFileVersionById method
- headers `UpdateFileVersionByIdHeadersArg`
  - Headers of updateFileVersionById method


### Returns

This function returns a value of type `FileVersionFull`.

Returns a restored file version object.


## Remove file version

Move a file version to the trash.

Versions are only tracked for Box users with premium accounts.

This operation is performed by calling function `DeleteFileVersionById`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/delete-files-id-versions-id/).

<!-- sample delete_files_id_versions_id -->
```
await client.FileVersions.DeleteFileVersionByIdAsync(file.Id, fileVersionsRestored.Entries![0].Id).ConfigureAwait(false)
```

### Arguments

- fileId `string`
  - The unique identifier that represents a file.  The ID for any file can be determined by visiting a file in the web application and copying the ID from the URL. For example, for the URL `https://*.app.box.com/files/123` the `file_id` is `123`. Example: "12345"
- fileVersionId `string`
  - The ID of the file version Example: "1234"
- headers `DeleteFileVersionByIdHeadersArg`
  - Headers of deleteFileVersionById method


### Returns

This function returns a value of type `null`.

Returns an empty response when the file has been successfully
deleted.


## Promote file version

Promote a specific version of a file.

If previous versions exist, this method can be used to
promote one of the older versions to the top of the version history.

This creates a new copy of the old version and puts it at the
top of the versions history. The file will have the exact same contents
as the older version, with the the same hash digest, `etag`, and
name as the original.

Other properties such as comments do not get updated to their
former values.

Don't use this endpoint to restore Box Notes,
as it works with file formats such as PDF, DOC,
PPTX or similar.

This operation is performed by calling function `PromoteFileVersion`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/post-files-id-versions-current/).

<!-- sample post_files_id_versions_current -->
```
await client.FileVersions.PromoteFileVersionAsync(file.Id, new PromoteFileVersionRequestBodyArg(id: fileVersions.Entries![0].Id, type: PromoteFileVersionRequestBodyArgTypeField.FileVersion)).ConfigureAwait(false)
```

### Arguments

- fileId `string`
  - The unique identifier that represents a file.  The ID for any file can be determined by visiting a file in the web application and copying the ID from the URL. For example, for the URL `https://*.app.box.com/files/123` the `file_id` is `123`. Example: "12345"
- requestBody `PromoteFileVersionRequestBodyArg`
  - Request body of promoteFileVersion method
- queryParams `PromoteFileVersionQueryParamsArg`
  - Query parameters of promoteFileVersion method
- headers `PromoteFileVersionHeadersArg`
  - Headers of promoteFileVersion method


### Returns

This function returns a value of type `FileVersionFull`.

Returns a newly created file version object.


