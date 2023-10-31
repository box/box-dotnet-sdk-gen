# LegalHoldPoliciesManager


- [List all legal hold policies](#list-all-legal-hold-policies)
- [Create legal hold policy](#create-legal-hold-policy)
- [Get legal hold policy](#get-legal-hold-policy)
- [Update legal hold policy](#update-legal-hold-policy)
- [Remove legal hold policy](#remove-legal-hold-policy)

## List all legal hold policies

Retrieves a list of legal hold policies that belong to
an enterprise.

This operation is performed by calling function `GetLegalHoldPolicies`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-legal-hold-policies/).

*Currently we don't have an example for calling `GetLegalHoldPolicies` in integration tests*

### Arguments

- queryParams `GetLegalHoldPoliciesQueryParamsArg`
  - Query parameters of getLegalHoldPolicies method
- headers `GetLegalHoldPoliciesHeadersArg`
  - Headers of getLegalHoldPolicies method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `LegalHoldPolicies`.

Returns a list of legal hold policies.


## Create legal hold policy

Create a new legal hold policy.

This operation is performed by calling function `CreateLegalHoldPolicy`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/post-legal-hold-policies/).

*Currently we don't have an example for calling `CreateLegalHoldPolicy` in integration tests*

### Arguments

- requestBody `CreateLegalHoldPolicyRequestBodyArg`
  - Request body of createLegalHoldPolicy method
- headers `CreateLegalHoldPolicyHeadersArg`
  - Headers of createLegalHoldPolicy method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `LegalHoldPolicy`.

Returns a new legal hold policy object.


## Get legal hold policy

Retrieve a legal hold policy.

This operation is performed by calling function `GetLegalHoldPolicyById`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-legal-hold-policies-id/).

*Currently we don't have an example for calling `GetLegalHoldPolicyById` in integration tests*

### Arguments

- legalHoldPolicyId `string`
  - The ID of the legal hold policy Example: "324432"
- headers `GetLegalHoldPolicyByIdHeadersArg`
  - Headers of getLegalHoldPolicyById method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `LegalHoldPolicy`.

Returns a legal hold policy object.


## Update legal hold policy

Update legal hold policy.

This operation is performed by calling function `UpdateLegalHoldPolicyById`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/put-legal-hold-policies-id/).

*Currently we don't have an example for calling `UpdateLegalHoldPolicyById` in integration tests*

### Arguments

- legalHoldPolicyId `string`
  - The ID of the legal hold policy Example: "324432"
- requestBody `UpdateLegalHoldPolicyByIdRequestBodyArg`
  - Request body of updateLegalHoldPolicyById method
- headers `UpdateLegalHoldPolicyByIdHeadersArg`
  - Headers of updateLegalHoldPolicyById method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `LegalHoldPolicy`.

Returns a new legal hold policy object.


## Remove legal hold policy

Delete an existing legal hold policy.

This is an asynchronous process. The policy will not be
fully deleted yet when the response returns.

This operation is performed by calling function `DeleteLegalHoldPolicyById`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/delete-legal-hold-policies-id/).

*Currently we don't have an example for calling `DeleteLegalHoldPolicyById` in integration tests*

### Arguments

- legalHoldPolicyId `string`
  - The ID of the legal hold policy Example: "324432"
- headers `DeleteLegalHoldPolicyByIdHeadersArg`
  - Headers of deleteLegalHoldPolicyById method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `null`.

A blank response is returned if the policy was
successfully deleted.


