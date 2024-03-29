# ISignRequestsManager


- [Cancel sign request](#cancel-sign-request)
- [Resend sign request](#resend-sign-request)
- [Get sign request by ID](#get-sign-request-by-id)
- [List sign requests](#list-sign-requests)
- [Create sign request](#create-sign-request)

## Cancel sign request

Cancels a sign request.

This operation is performed by calling function `CancelSignRequest`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/post-sign-requests-id-cancel/).

<!-- sample post_sign_requests_id_cancel -->
```
await client.SignRequests.CancelSignRequestAsync(signRequestId: NullableUtils.Unwrap(createdSignRequest.Id));
```

### Arguments

- signRequestId `string`
  - The ID of the sign request Example: "33243242"
- headers `CancelSignRequestHeaders`
  - Headers of cancelSignRequest method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `SignRequest`.

Returns a Sign Request object.


## Resend sign request

Resends a sign request email to all outstanding signers.

This operation is performed by calling function `ResendSignRequest`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/post-sign-requests-id-resend/).

*Currently we don't have an example for calling `ResendSignRequest` in integration tests*

### Arguments

- signRequestId `string`
  - The ID of the sign request Example: "33243242"
- headers `ResendSignRequestHeaders`
  - Headers of resendSignRequest method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `null`.

Returns an empty response when the API call was successful.
The email notifications will be sent asynchronously.


## Get sign request by ID

Gets a sign request by ID.

This operation is performed by calling function `GetSignRequestById`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-sign-requests-id/).

<!-- sample get_sign_requests_id -->
```
await client.SignRequests.GetSignRequestByIdAsync(signRequestId: NullableUtils.Unwrap(createdSignRequest.Id));
```

### Arguments

- signRequestId `string`
  - The ID of the sign request Example: "33243242"
- headers `GetSignRequestByIdHeaders`
  - Headers of getSignRequestById method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `SignRequest`.

Returns a sign request


## List sign requests

Gets sign requests created by a user. If the `sign_files` and/or
`parent_folder` are deleted, the sign request will not return in the list.

This operation is performed by calling function `GetSignRequests`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-sign-requests/).

<!-- sample get_sign_requests -->
```
await client.SignRequests.GetSignRequestsAsync();
```

### Arguments

- queryParams `GetSignRequestsQueryParams`
  - Query parameters of getSignRequests method
- headers `GetSignRequestsHeaders`
  - Headers of getSignRequests method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `SignRequests`.

Returns a collection of sign requests


## Create sign request

Creates a sign request. This involves preparing a document for signing and
sending the sign request to signers.

This operation is performed by calling function `CreateSignRequest`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/post-sign-requests/).

<!-- sample post_sign_requests -->
```
await client.SignRequests.CreateSignRequestAsync(requestBody: new SignRequestCreateRequest(signers: Array.AsReadOnly(new [] {new SignRequestCreateSigner(email: signer1Email, signerGroupId: "user"),new SignRequestCreateSigner(email: signer2Email, signerGroupId: "user")}), parentFolder: new FolderMini(id: destinationFolder.Id, type: FolderBaseTypeField.Folder), sourceFiles: Array.AsReadOnly(new [] {new FileBase(id: fileToSign.Id, type: FileBaseTypeField.File)})));
```

### Arguments

- requestBody `SignRequestCreateRequest`
  - Request body of createSignRequest method
- headers `CreateSignRequestHeaders`
  - Headers of createSignRequest method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `SignRequest`.

Returns a Sign Request object.


