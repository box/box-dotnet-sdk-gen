# IStoragePoliciesManager

<!-- box-dotnet-sdk-gen deprecation banner -->
> [!CAUTION]
> **`box-dotnet-sdk-gen` is deprecated and no longer maintained.** As of September 17, 2025, it receives no new features, bug fixes, or security patches. Do not use it for new projects.
>
> Use [`box-windows-sdk-v2`](https://github.com/box/box-windows-sdk-v2) v10+ instead: `Install-Package Box.V2.Core`.
> The equivalent of this page is [box-windows-sdk-v2/docs/StoragePolicies.md](https://github.com/box/box-windows-sdk-v2/blob/main/docs/StoragePolicies.md). To migrate existing code, see the [migration guide](https://github.com/box/box-windows-sdk-v2/blob/main/migration-guides/from-dotnet-sdk-gen-v1-to-box-windows-sdk.md).


- [List storage policies](#list-storage-policies)
- [Get storage policy](#get-storage-policy)

## List storage policies

Fetches all the storage policies in the enterprise.

This operation is performed by calling function `GetStoragePolicies`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-storage-policies/).

<!-- sample get_storage_policies -->
```
await client.StoragePolicies.GetStoragePoliciesAsync();
```

### Arguments

- queryParams `GetStoragePoliciesQueryParams`
  - Query parameters of getStoragePolicies method
- headers `GetStoragePoliciesHeaders`
  - Headers of getStoragePolicies method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `StoragePolicies`.

Returns a collection of storage policies.


## Get storage policy

Fetches a specific storage policy.

This operation is performed by calling function `GetStoragePolicyById`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-storage-policies-id/).

<!-- sample get_storage_policies_id -->
```
await client.StoragePolicies.GetStoragePolicyByIdAsync(storagePolicyId: storagePolicy.Id);
```

### Arguments

- storagePolicyId `string`
  - The ID of the storage policy. Example: "34342"
- headers `GetStoragePolicyByIdHeaders`
  - Headers of getStoragePolicyById method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `StoragePolicy`.

Returns a storage policy object.


