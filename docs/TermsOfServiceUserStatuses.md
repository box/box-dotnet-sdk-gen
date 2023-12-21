# ITermsOfServiceUserStatusesManager


- [List terms of service user statuses](#list-terms-of-service-user-statuses)
- [Create terms of service status for new user](#create-terms-of-service-status-for-new-user)
- [Update terms of service status for existing user](#update-terms-of-service-status-for-existing-user)

## List terms of service user statuses

Retrieves an overview of users and their status for a
terms of service, including Whether they have accepted
the terms and when.

This operation is performed by calling function `GetTermsOfServiceUserStatuses`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-terms-of-service-user-statuses/).

*Currently we don't have an example for calling `GetTermsOfServiceUserStatuses` in integration tests*

### Arguments

- queryParams `GetTermsOfServiceUserStatusesQueryParams`
  - Query parameters of getTermsOfServiceUserStatuses method
- headers `GetTermsOfServiceUserStatusesHeaders`
  - Headers of getTermsOfServiceUserStatuses method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `TermsOfServiceUserStatuses`.

Returns a list of terms of service statuses.


## Create terms of service status for new user

Sets the status for a terms of service for a user.

This operation is performed by calling function `CreateTermsOfServiceStatusForUser`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/post-terms-of-service-user-statuses/).

*Currently we don't have an example for calling `CreateTermsOfServiceStatusForUser` in integration tests*

### Arguments

- requestBody `CreateTermsOfServiceStatusForUserRequestBody`
  - Request body of createTermsOfServiceStatusForUser method
- headers `CreateTermsOfServiceStatusForUserHeaders`
  - Headers of createTermsOfServiceStatusForUser method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `TermsOfServiceUserStatus`.

Returns a terms of service status object.


## Update terms of service status for existing user

Updates the status for a terms of service for a user.

This operation is performed by calling function `UpdateTermsOfServiceStatusForUserById`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/put-terms-of-service-user-statuses-id/).

*Currently we don't have an example for calling `UpdateTermsOfServiceStatusForUserById` in integration tests*

### Arguments

- termsOfServiceUserStatusId `string`
  - The ID of the terms of service status. Example: "324234"
- requestBody `UpdateTermsOfServiceStatusForUserByIdRequestBody`
  - Request body of updateTermsOfServiceStatusForUserById method
- headers `UpdateTermsOfServiceStatusForUserByIdHeaders`
  - Headers of updateTermsOfServiceStatusForUserById method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `TermsOfServiceUserStatus`.

Returns the updated terms of service status object.


