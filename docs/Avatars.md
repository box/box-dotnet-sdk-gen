# AvatarsManager


- [Get user avatar](#get-user-avatar)
- [Add or update user avatar](#add-or-update-user-avatar)
- [Delete user avatar](#delete-user-avatar)

## Get user avatar

Retrieves an image of a the user's avatar.

This operation is performed by calling function `GetUserAvatar`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-users-id-avatar/).

*Currently we don't have an example for calling `GetUserAvatar` in integration tests*

### Arguments

- userId `string`
  - The ID of the user. Example: "12345"
- headers `GetUserAvatarHeadersArg`
  - Headers of getUserAvatar method


### Returns

This function returns a value of type `Stream`.

When an avatar can be found for the user the
image data will be returned in the body of the
response.


## Add or update user avatar

Adds or updates a user avatar.

This operation is performed by calling function `CreateUserAvatar`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/post-users-id-avatar/).

*Currently we don't have an example for calling `CreateUserAvatar` in integration tests*

### Arguments

- userId `string`
  - The ID of the user. Example: "12345"
- requestBody `CreateUserAvatarRequestBodyArg`
  - Request body of createUserAvatar method
- headers `CreateUserAvatarHeadersArg`
  - Headers of createUserAvatar method


### Returns

This function returns a value of type `UserAvatar`.

* `ok`: Returns the `pic_urls` object with URLs to existing
user avatars that were updated.* `created`: Returns the `pic_urls` object with URLS to user avatars
uploaded to Box with the request.


## Delete user avatar

Removes an existing user avatar.
You cannot reverse this operation.

This operation is performed by calling function `DeleteUserAvatar`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/delete-users-id-avatar/).

*Currently we don't have an example for calling `DeleteUserAvatar` in integration tests*

### Arguments

- userId `string`
  - The ID of the user. Example: "12345"
- headers `DeleteUserAvatarHeadersArg`
  - Headers of deleteUserAvatar method


### Returns

This function returns a value of type `null`.

* `no_content`: Removes the avatar and returns an empty response.


