# IFileVersionRetentionsManager


- [List file version retentions](#list-file-version-retentions)
- [Get retention on file](#get-retention-on-file)

## List file version retentions

Retrieves all file version retentions for the given enterprise.

This operation is performed by calling function `GetFileVersionRetentions`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-file-version-retentions/).

<!-- sample get_file_version_retentions -->
```
await client.FileVersionRetentions.GetFileVersionRetentionsAsync();
```

### Arguments

- queryParams `GetFileVersionRetentionsQueryParams`
  - Query parameters of getFileVersionRetentions method
- headers `GetFileVersionRetentionsHeaders`
  - Headers of getFileVersionRetentions method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `FileVersionRetentions`.

Returns a list of all file version retentions for the enterprise.


## Get retention on file

Returns information about a file version retention.

This operation is performed by calling function `GetFileVersionRetentionById`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-file-version-retentions-id/).

<!-- sample get_file_version_retentions_id -->
```
await client.FileVersionRetentions.GetFileVersionRetentionByIdAsync(fileVersionRetentionId: NullableUtils.Unwrap(fileVersionRetention.Id));
```

### Arguments

- fileVersionRetentionId `string`
  - The ID of the file version retention Example: "3424234"
- headers `GetFileVersionRetentionByIdHeaders`
  - Headers of getFileVersionRetentionById method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `FileVersionRetention`.

Returns a file version retention object.


