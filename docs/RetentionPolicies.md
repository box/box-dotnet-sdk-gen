# RetentionPoliciesManager


- [List retention policies](#list-retention-policies)
- [Create retention policy](#create-retention-policy)
- [Get retention policy](#get-retention-policy)
- [Update retention policy](#update-retention-policy)
- [Delete retention policy](#delete-retention-policy)

## List retention policies

Retrieves all of the retention policies for an enterprise.

This operation is performed by calling function `GetRetentionPolicies`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-retention-policies/).

*Currently we don't have an example for calling `GetRetentionPolicies` in integration tests*

### Arguments

- queryParams `GetRetentionPoliciesQueryParamsArg`
  - Query parameters of getRetentionPolicies method
- headers `GetRetentionPoliciesHeadersArg`
  - Headers of getRetentionPolicies method


### Returns

This function returns a value of type `RetentionPolicies`.

Returns a list retention policies in the enterprise.


## Create retention policy

Creates a retention policy.

This operation is performed by calling function `CreateRetentionPolicy`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/post-retention-policies/).

*Currently we don't have an example for calling `CreateRetentionPolicy` in integration tests*

### Arguments

- requestBody `CreateRetentionPolicyRequestBodyArg`
  - Request body of createRetentionPolicy method
- headers `CreateRetentionPolicyHeadersArg`
  - Headers of createRetentionPolicy method


### Returns

This function returns a value of type `RetentionPolicy`.

Returns a new retention policy object.


## Get retention policy

Retrieves a retention policy.

This operation is performed by calling function `GetRetentionPolicyById`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-retention-policies-id/).

*Currently we don't have an example for calling `GetRetentionPolicyById` in integration tests*

### Arguments

- retentionPolicyId `string`
  - The ID of the retention policy. Example: "982312"
- queryParams `GetRetentionPolicyByIdQueryParamsArg`
  - Query parameters of getRetentionPolicyById method
- headers `GetRetentionPolicyByIdHeadersArg`
  - Headers of getRetentionPolicyById method


### Returns

This function returns a value of type `RetentionPolicy`.

Returns the retention policy object.


## Update retention policy

Updates a retention policy.

This operation is performed by calling function `UpdateRetentionPolicyById`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/put-retention-policies-id/).

*Currently we don't have an example for calling `UpdateRetentionPolicyById` in integration tests*

### Arguments

- retentionPolicyId `string`
  - The ID of the retention policy. Example: "982312"
- requestBody `UpdateRetentionPolicyByIdRequestBodyArg`
  - Request body of updateRetentionPolicyById method
- headers `UpdateRetentionPolicyByIdHeadersArg`
  - Headers of updateRetentionPolicyById method


### Returns

This function returns a value of type `RetentionPolicy`.

Returns the updated retention policy object.


## Delete retention policy

Permanently deletes a retention policy.

This operation is performed by calling function `DeleteRetentionPolicyById`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/delete-retention-policies-id/).

*Currently we don't have an example for calling `DeleteRetentionPolicyById` in integration tests*

### Arguments

- retentionPolicyId `string`
  - The ID of the retention policy. Example: "982312"
- headers `DeleteRetentionPolicyByIdHeadersArg`
  - Headers of deleteRetentionPolicyById method


### Returns

This function returns a value of type `null`.

Returns an empty response when the policy has been deleted.


