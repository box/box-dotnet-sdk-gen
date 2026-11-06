# IFileVersionLegalHoldsManager

<!-- box-dotnet-sdk-gen deprecation banner -->
> [!CAUTION]
> **`box-dotnet-sdk-gen` is deprecated and no longer maintained.** As of September 17, 2025, it receives no new features, bug fixes, or security patches. Do not use it for new projects.
>
> Use [`box-windows-sdk-v2`](https://github.com/box/box-windows-sdk-v2) v10+ instead: `Install-Package Box.V2.Core`.
> The equivalent of this page is [box-windows-sdk-v2/docs/FileVersionLegalHolds.md](https://github.com/box/box-windows-sdk-v2/blob/main/docs/FileVersionLegalHolds.md). To migrate existing code, see the [migration guide](https://github.com/box/box-windows-sdk-v2/blob/main/migration-guides/from-dotnet-sdk-gen-v1-to-box-windows-sdk.md).


- [Get file version legal hold](#get-file-version-legal-hold)
- [List file version legal holds](#list-file-version-legal-holds)

## Get file version legal hold

Retrieves information about the legal hold policies
assigned to a file version.

This operation is performed by calling function `GetFileVersionLegalHoldById`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-file-version-legal-holds-id/).

<!-- sample get_file_version_legal_holds_id -->
```
await client.FileVersionLegalHolds.GetFileVersionLegalHoldByIdAsync(fileVersionLegalHoldId: fileVersionLegalHoldId);
```

### Arguments

- fileVersionLegalHoldId `string`
  - The ID of the file version legal hold. Example: "2348213"
- headers `GetFileVersionLegalHoldByIdHeaders`
  - Headers of getFileVersionLegalHoldById method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `FileVersionLegalHold`.

Returns the legal hold policy assignments for the file version.


## List file version legal holds

Get a list of file versions on legal hold for a legal hold
assignment.

Due to ongoing re-architecture efforts this API might not return all file
versions for this policy ID.

Instead, this API will only return file versions held in the legacy
architecture. Two new endpoints will available to request any file versions
held in the new architecture.

For file versions held in the new architecture, the `GET
/legal_hold_policy_assignments/:id/file_versions_on_hold` API can be used to
return all past file versions available for this policy assignment, and the
`GET /legal_hold_policy_assignments/:id/files_on_hold` API can be used to
return any current (latest) versions of a file under legal hold.

The `GET /legal_hold_policy_assignments?policy_id={id}` API can be used to
find a list of policy assignments for a given policy ID.

Once the re-architecture is completed this API will be deprecated.

This operation is performed by calling function `GetFileVersionLegalHolds`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-file-version-legal-holds/).

<!-- sample get_file_version_legal_holds -->
```
await client.FileVersionLegalHolds.GetFileVersionLegalHoldsAsync(queryParams: new GetFileVersionLegalHoldsQueryParams(policyId: policyId));
```

### Arguments

- queryParams `GetFileVersionLegalHoldsQueryParams`
  - Query parameters of getFileVersionLegalHolds method
- headers `GetFileVersionLegalHoldsHeaders`
  - Headers of getFileVersionLegalHolds method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `FileVersionLegalHolds`.

Returns the list of file version legal holds for a specific legal
hold policy.


