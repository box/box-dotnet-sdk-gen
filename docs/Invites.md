# IInvitesManager


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
await client.Invites.CreateInviteAsync(requestBody: new CreateInviteRequestBodyArg(enterprise: new CreateInviteRequestBodyArgEnterpriseField(id: currentUser.Enterprise!.Id!), actionableBy: new CreateInviteRequestBodyArgActionableByField(login: email))).ConfigureAwait(false)
```

### Arguments

- requestBody `CreateInviteRequestBodyArg`
  - Request body of createInvite method
- queryParams `CreateInviteQueryParamsArg`
  - Query parameters of createInvite method
- headers `CreateInviteHeadersArg`
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
await client.Invites.GetInviteByIdAsync(inviteId: invitation.Id).ConfigureAwait(false)
```

### Arguments

- inviteId `string`
  - The ID of an invite. Example: "213723"
- queryParams `GetInviteByIdQueryParamsArg`
  - Query parameters of getInviteById method
- headers `GetInviteByIdHeadersArg`
  - Headers of getInviteById method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `Invite`.

Returns an invite object


