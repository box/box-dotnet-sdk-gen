# IFileVersionRetentionsManager

<!-- box-dotnet-sdk-gen deprecation banner -->
> [!CAUTION]
> **`box-dotnet-sdk-gen` is deprecated and no longer maintained.** As of September 17, 2025, it receives no new features, bug fixes, or security patches. Do not use it for new projects.
>
> Use [`box-windows-sdk-v2`](https://github.com/box/box-windows-sdk-v2) v10+ instead: `Install-Package Box.V2.Core`.
> The equivalent of this page is [box-windows-sdk-v2/docs/FileVersionRetentions.md](https://github.com/box/box-windows-sdk-v2/blob/main/docs/FileVersionRetentions.md). To migrate existing code, see the [migration guide](https://github.com/box/box-windows-sdk-v2/blob/main/migration-guides/from-dotnet-sdk-gen-v1-to-box-windows-sdk.md).


- [List file version retentions](#list-file-version-retentions)
- [Get retention on file](#get-retention-on-file)

## List file version retentions

Retrieves all file version retentions for the given enterprise.

**Note**:
File retention API is now **deprecated**. 
To get information about files and file versions under retention,
see [files under retention](e://get-retention-policy-assignments-id-files-under-retention) or [file versions under retention](e://get-retention-policy-assignments-id-file-versions-under-retention) endpoints.

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

**Note**:
File retention API is now **deprecated**. 
To get information about files and file versions under retention,
see [files under retention](e://get-retention-policy-assignments-id-files-under-retention) or [file versions under retention](e://get-retention-policy-assignments-id-file-versions-under-retention) endpoints.

This operation is performed by calling function `GetFileVersionRetentionById`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-file-version-retentions-id/).

<!-- sample get_file_version_retentions_id -->
```
await client.FileVersionRetentions.GetFileVersionRetentionByIdAsync(fileVersionRetentionId: NullableUtils.Unwrap(fileVersionRetention.Id));
```

### Arguments

- fileVersionRetentionId `string`
  - The ID of the file version retention. Example: "3424234"
- headers `GetFileVersionRetentionByIdHeaders`
  - Headers of getFileVersionRetentionById method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `FileVersionRetention`.

Returns a file version retention object.


