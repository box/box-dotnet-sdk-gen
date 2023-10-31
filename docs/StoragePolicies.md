# StoragePoliciesManager


- [List storage policies](#list-storage-policies)
- [Get storage policy](#get-storage-policy)

## List storage policies

Fetches all the storage policies in the enterprise.

This operation is performed by calling function `GetStoragePolicies`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-storage-policies/).

*Currently we don't have an example for calling `GetStoragePolicies` in integration tests*

### Arguments

- queryParams `GetStoragePoliciesQueryParamsArg`
  - Query parameters of getStoragePolicies method
- headers `GetStoragePoliciesHeadersArg`
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

*Currently we don't have an example for calling `GetStoragePolicyById` in integration tests*

### Arguments

- storagePolicyId `string`
  - The ID of the storage policy. Example: "34342"
- headers `GetStoragePolicyByIdHeadersArg`
  - Headers of getStoragePolicyById method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `StoragePolicy`.

Returns a storage policy object.


