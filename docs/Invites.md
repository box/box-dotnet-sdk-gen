# IInvitesManager

<!-- box-dotnet-sdk-gen deprecation banner -->
> [!CAUTION]
> **`box-dotnet-sdk-gen` is deprecated and no longer maintained.** As of September 17, 2025, it receives no new features, bug fixes, or security patches. Do not use it for new projects.
>
> Use [`box-windows-sdk-v2`](https://github.com/box/box-windows-sdk-v2) v10+ instead: `Install-Package Box.V2.Core`.
> The equivalent of this page is [box-windows-sdk-v2/docs/Invites.md](https://github.com/box/box-windows-sdk-v2/blob/main/docs/Invites.md). To migrate existing code, see the [migration guide](https://github.com/box/box-windows-sdk-v2/blob/main/migration-guides/from-dotnet-sdk-gen-v1-to-box-windows-sdk.md).


- [Create user invite](#create-user-invite)
- [Get user invite status](#get-user-invite-status)

## Create user invite

Invites an existing external user to join an enterprise.

The existing user can not be part of another enterprise and
must already have a Box account. Once invited, the user will receive an
email and are prompted to accept the invitation within the
Box web application.

This method requires the "Manage An Enterprise" scope enabled for
the application, which can be enabled within the developer console.

This operation is performed by calling function `CreateInvite`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/post-invites/).

<!-- sample post_invites -->
```
await client.Invites.CreateInviteAsync(requestBody: new CreateInviteRequestBody(enterprise: new CreateInviteRequestBodyEnterpriseField(id: NullableUtils.Unwrap(NullableUtils.Unwrap(currentUser.Enterprise).Id)), actionableBy: new CreateInviteRequestBodyActionableByField() { Login = email }));
```

### Arguments

- requestBody `CreateInviteRequestBody`
  - Request body of createInvite method
- queryParams `CreateInviteQueryParams`
  - Query parameters of createInvite method
- headers `CreateInviteHeaders`
  - Headers of createInvite method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `Invite`.

Returns a new invite object.


## Get user invite status

Returns the status of a user invite.

This operation is performed by calling function `GetInviteById`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-invites-id/).

<!-- sample get_invites_id -->
```
await client.Invites.GetInviteByIdAsync(inviteId: invitation.Id);
```

### Arguments

- inviteId `string`
  - The ID of an invite. Example: "213723"
- queryParams `GetInviteByIdQueryParams`
  - Query parameters of getInviteById method
- headers `GetInviteByIdHeaders`
  - Headers of getInviteById method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `Invite`.

Returns an invite object.


