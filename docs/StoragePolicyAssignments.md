# StoragePolicyAssignmentsManager


- [List storage policy assignments](#list-storage-policy-assignments)
- [Assign storage policy](#assign-storage-policy)
- [Get storage policy assignment](#get-storage-policy-assignment)
- [Update storage policy assignment](#update-storage-policy-assignment)
- [Unassign storage policy](#unassign-storage-policy)

## List storage policy assignments

Fetches all the storage policy assignment for an enterprise or user.

This operation is performed by calling function `GetStoragePolicyAssignments`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-storage-policy-assignments/).

*Currently we don't have an example for calling `GetStoragePolicyAssignments` in integration tests*

### Arguments

- queryParams `GetStoragePolicyAssignmentsQueryParamsArg`
  - Query parameters of getStoragePolicyAssignments method
- headers `GetStoragePolicyAssignmentsHeadersArg`
  - Headers of getStoragePolicyAssignments method


### Returns

This function returns a value of type `StoragePolicyAssignments`.

Returns a collection of storage policies for
the enterprise or user.


## Assign storage policy

Creates a storage policy assignment for an enterprise or user.

This operation is performed by calling function `CreateStoragePolicyAssignment`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/post-storage-policy-assignments/).

*Currently we don't have an example for calling `CreateStoragePolicyAssignment` in integration tests*

### Arguments

- requestBody `CreateStoragePolicyAssignmentRequestBodyArg`
  - Request body of createStoragePolicyAssignment method
- headers `CreateStoragePolicyAssignmentHeadersArg`
  - Headers of createStoragePolicyAssignment method


### Returns

This function returns a value of type `StoragePolicyAssignment`.

Returns the new storage policy assignment created.


## Get storage policy assignment

Fetches a specific storage policy assignment.

This operation is performed by calling function `GetStoragePolicyAssignmentById`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-storage-policy-assignments-id/).

*Currently we don't have an example for calling `GetStoragePolicyAssignmentById` in integration tests*

### Arguments

- storagePolicyAssignmentId `string`
  - The ID of the storage policy assignment. Example: "932483"
- headers `GetStoragePolicyAssignmentByIdHeadersArg`
  - Headers of getStoragePolicyAssignmentById method


### Returns

This function returns a value of type `StoragePolicyAssignment`.

Returns a storage policy assignment object.


## Update storage policy assignment

Updates a specific storage policy assignment.

This operation is performed by calling function `UpdateStoragePolicyAssignmentById`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/put-storage-policy-assignments-id/).

*Currently we don't have an example for calling `UpdateStoragePolicyAssignmentById` in integration tests*

### Arguments

- storagePolicyAssignmentId `string`
  - The ID of the storage policy assignment. Example: "932483"
- requestBody `UpdateStoragePolicyAssignmentByIdRequestBodyArg`
  - Request body of updateStoragePolicyAssignmentById method
- headers `UpdateStoragePolicyAssignmentByIdHeadersArg`
  - Headers of updateStoragePolicyAssignmentById method


### Returns

This function returns a value of type `StoragePolicyAssignment`.

Returns an updated storage policy assignment object.


## Unassign storage policy

Delete a storage policy assignment.

Deleting a storage policy assignment on a user
will have the user inherit the enterprise's default
storage policy.

There is a rate limit for calling this endpoint of only
twice per user in a 24 hour time frame.

This operation is performed by calling function `DeleteStoragePolicyAssignmentById`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/delete-storage-policy-assignments-id/).

*Currently we don't have an example for calling `DeleteStoragePolicyAssignmentById` in integration tests*

### Arguments

- storagePolicyAssignmentId `string`
  - The ID of the storage policy assignment. Example: "932483"
- headers `DeleteStoragePolicyAssignmentByIdHeadersArg`
  - Headers of deleteStoragePolicyAssignmentById method


### Returns

This function returns a value of type `null`.

Returns an empty response when the storage policy
assignment is successfully deleted.

