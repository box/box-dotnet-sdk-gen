# ICollaborationAllowlistExemptTargetsManager

<!-- box-dotnet-sdk-gen deprecation banner -->
> [!CAUTION]
> **`box-dotnet-sdk-gen` is deprecated and no longer maintained.** As of September 17, 2025, it receives no new features, bug fixes, or security patches. Do not use it for new projects.
>
> Use [`box-windows-sdk-v2`](https://github.com/box/box-windows-sdk-v2) v10+ instead: `Install-Package Box.V2.Core`.
> The equivalent of this page is [box-windows-sdk-v2/docs/CollaborationAllowlistExemptTargets.md](https://github.com/box/box-windows-sdk-v2/blob/main/docs/CollaborationAllowlistExemptTargets.md). To migrate existing code, see the [migration guide](https://github.com/box/box-windows-sdk-v2/blob/main/migration-guides/from-dotnet-sdk-gen-v1-to-box-windows-sdk.md).


- [List users exempt from collaboration domain restrictions](#list-users-exempt-from-collaboration-domain-restrictions)
- [Create user exemption from collaboration domain restrictions](#create-user-exemption-from-collaboration-domain-restrictions)
- [Get user exempt from collaboration domain restrictions](#get-user-exempt-from-collaboration-domain-restrictions)
- [Remove user from list of users exempt from domain restrictions](#remove-user-from-list-of-users-exempt-from-domain-restrictions)

## List users exempt from collaboration domain restrictions

Returns a list of users who have been exempt from the collaboration
domain restrictions.

This operation is performed by calling function `GetCollaborationWhitelistExemptTargets`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-collaboration-whitelist-exempt-targets/).

<!-- sample get_collaboration_whitelist_exempt_targets -->
```
await client.CollaborationAllowlistExemptTargets.GetCollaborationWhitelistExemptTargetsAsync();
```

### Arguments

- queryParams `GetCollaborationWhitelistExemptTargetsQueryParams`
  - Query parameters of getCollaborationWhitelistExemptTargets method
- headers `GetCollaborationWhitelistExemptTargetsHeaders`
  - Headers of getCollaborationWhitelistExemptTargets method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `CollaborationAllowlistExemptTargets`.

Returns a collection of user exemptions.


## Create user exemption from collaboration domain restrictions

Exempts a user from the restrictions set out by the allowed list of domains
for collaborations.

This operation is performed by calling function `CreateCollaborationWhitelistExemptTarget`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/post-collaboration-whitelist-exempt-targets/).

<!-- sample post_collaboration_whitelist_exempt_targets -->
```
await client.CollaborationAllowlistExemptTargets.CreateCollaborationWhitelistExemptTargetAsync(requestBody: new CreateCollaborationWhitelistExemptTargetRequestBody(user: new CreateCollaborationWhitelistExemptTargetRequestBodyUserField(id: user.Id)));
```

### Arguments

- requestBody `CreateCollaborationWhitelistExemptTargetRequestBody`
  - Request body of createCollaborationWhitelistExemptTarget method
- headers `CreateCollaborationWhitelistExemptTargetHeaders`
  - Headers of createCollaborationWhitelistExemptTarget method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `CollaborationAllowlistExemptTarget`.

Returns a new exemption entry.


## Get user exempt from collaboration domain restrictions

Returns a users who has been exempt from the collaboration
domain restrictions.

This operation is performed by calling function `GetCollaborationWhitelistExemptTargetById`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-collaboration-whitelist-exempt-targets-id/).

<!-- sample get_collaboration_whitelist_exempt_targets_id -->
```
await client.CollaborationAllowlistExemptTargets.GetCollaborationWhitelistExemptTargetByIdAsync(collaborationWhitelistExemptTargetId: NullableUtils.Unwrap(newExemptTarget.Id));
```

### Arguments

- collaborationWhitelistExemptTargetId `string`
  - The ID of the exemption to the list. Example: "984923"
- headers `GetCollaborationWhitelistExemptTargetByIdHeaders`
  - Headers of getCollaborationWhitelistExemptTargetById method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `CollaborationAllowlistExemptTarget`.

Returns the user's exempted from the list of collaboration domains.


## Remove user from list of users exempt from domain restrictions

Removes a user's exemption from the restrictions set out by the allowed list
of domains for collaborations.

This operation is performed by calling function `DeleteCollaborationWhitelistExemptTargetById`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/delete-collaboration-whitelist-exempt-targets-id/).

<!-- sample delete_collaboration_whitelist_exempt_targets_id -->
```
await client.CollaborationAllowlistExemptTargets.DeleteCollaborationWhitelistExemptTargetByIdAsync(collaborationWhitelistExemptTargetId: NullableUtils.Unwrap(exemptTarget.Id));
```

### Arguments

- collaborationWhitelistExemptTargetId `string`
  - The ID of the exemption to the list. Example: "984923"
- headers `DeleteCollaborationWhitelistExemptTargetByIdHeaders`
  - Headers of deleteCollaborationWhitelistExemptTargetById method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `null`.

A blank response is returned if the exemption was
successfully deleted.


