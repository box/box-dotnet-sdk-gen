# IEmailAliasesManager

<!-- box-dotnet-sdk-gen deprecation banner -->
> [!CAUTION]
> **`box-dotnet-sdk-gen` is deprecated and no longer maintained.** As of September 17, 2025, it receives no new features, bug fixes, or security patches. Do not use it for new projects.
>
> Use [`box-windows-sdk-v2`](https://github.com/box/box-windows-sdk-v2) v10+ instead: `Install-Package Box.V2.Core`.
> The equivalent of this page is [box-windows-sdk-v2/docs/EmailAliases.md](https://github.com/box/box-windows-sdk-v2/blob/main/docs/EmailAliases.md). To migrate existing code, see the [migration guide](https://github.com/box/box-windows-sdk-v2/blob/main/migration-guides/from-dotnet-sdk-gen-v1-to-box-windows-sdk.md).


- [List user's email aliases](#list-users-email-aliases)
- [Create email alias](#create-email-alias)
- [Remove email alias](#remove-email-alias)

## List user's email aliases

Retrieves all email aliases for a user. The collection
does not include the primary login for the user.

This operation is performed by calling function `GetUserEmailAliases`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-users-id-email-aliases/).

<!-- sample get_users_id_email_aliases -->
```
await client.EmailAliases.GetUserEmailAliasesAsync(userId: newUser.Id);
```

### Arguments

- userId `string`
  - The ID of the user. Example: "12345"
- headers `GetUserEmailAliasesHeaders`
  - Headers of getUserEmailAliases method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `EmailAliases`.

Returns a collection of email aliases.


## Create email alias

Adds a new email alias to a user account..

This operation is performed by calling function `CreateUserEmailAlias`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/post-users-id-email-aliases/).

<!-- sample post_users_id_email_aliases -->
```
await client.EmailAliases.CreateUserEmailAliasAsync(userId: newUser.Id, requestBody: new CreateUserEmailAliasRequestBody(email: newAliasEmail));
```

### Arguments

- userId `string`
  - The ID of the user. Example: "12345"
- requestBody `CreateUserEmailAliasRequestBody`
  - Request body of createUserEmailAlias method
- headers `CreateUserEmailAliasHeaders`
  - Headers of createUserEmailAlias method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `EmailAlias`.

Returns the newly created email alias object.


## Remove email alias

Removes an email alias from a user.

This operation is performed by calling function `DeleteUserEmailAliasById`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/delete-users-id-email-aliases-id/).

<!-- sample delete_users_id_email_aliases_id -->
```
await client.EmailAliases.DeleteUserEmailAliasByIdAsync(userId: newUser.Id, emailAliasId: NullableUtils.Unwrap(newAlias.Id));
```

### Arguments

- userId `string`
  - The ID of the user. Example: "12345"
- emailAliasId `string`
  - The ID of the email alias. Example: "23432"
- headers `DeleteUserEmailAliasByIdHeaders`
  - Headers of deleteUserEmailAliasById method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `null`.

Removes the alias and returns an empty response.


