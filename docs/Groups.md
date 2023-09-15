# GroupsManager


- [List groups for enterprise](#list-groups-for-enterprise)
- [Create group](#create-group)
- [Get group](#get-group)
- [Update group](#update-group)
- [Remove group](#remove-group)

## List groups for enterprise

Retrieves all of the groups for a given enterprise. The user
must have admin permissions to inspect enterprise's groups.

This operation is performed by calling function `GetGroups`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-groups/).

<!-- sample get_groups -->
```
await client.Groups.GetGroups()
```

### Arguments

- queryParams `GetGroupsQueryParamsArg`
  - Query parameters of getGroups method
- headers `GetGroupsHeadersArg`
  - Headers of getGroups method


### Returns

This function returns a value of type `Groups`.

Returns a collection of group objects. If there are no groups, an
empty collection will be returned.


## Create group

Creates a new group of users in an enterprise. Only users with admin
permissions can create new groups.

This operation is performed by calling function `CreateGroup`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/post-groups/).

<!-- sample post_groups -->
```
await client.Groups.CreateGroup(new CreateGroupRequestBodyArg(name: groupName, description: groupDescription))
```

### Arguments

- requestBody `CreateGroupRequestBodyArg`
  - Request body of createGroup method
- queryParams `CreateGroupQueryParamsArg`
  - Query parameters of createGroup method
- headers `CreateGroupHeadersArg`
  - Headers of createGroup method


### Returns

This function returns a value of type `Group`.

Returns the new group object.


## Get group

Retrieves information about a group. Only members of this
group or users with admin-level permissions will be able to
use this API.

This operation is performed by calling function `GetGroupById`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-groups-id/).

<!-- sample get_groups_id -->
```
await client.Groups.GetGroupById(group.Id)
```

### Arguments

- groupId `string`
  - The ID of the group. Example: "57645"
- queryParams `GetGroupByIdQueryParamsArg`
  - Query parameters of getGroupById method
- headers `GetGroupByIdHeadersArg`
  - Headers of getGroupById method


### Returns

This function returns a value of type `GroupFull`.

Returns the group object


## Update group

Updates a specific group. Only admins of this
group or users with admin-level permissions will be able to
use this API.

This operation is performed by calling function `UpdateGroupById`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/put-groups-id/).

<!-- sample put_groups_id -->
```
await client.Groups.UpdateGroupById(group.Id, new UpdateGroupByIdRequestBodyArg(name: updatedGroupName))
```

### Arguments

- groupId `string`
  - The ID of the group. Example: "57645"
- requestBody `UpdateGroupByIdRequestBodyArg`
  - Request body of updateGroupById method
- queryParams `UpdateGroupByIdQueryParamsArg`
  - Query parameters of updateGroupById method
- headers `UpdateGroupByIdHeadersArg`
  - Headers of updateGroupById method


### Returns

This function returns a value of type `GroupFull`.

Returns the updated group object.


## Remove group

Permanently deletes a group. Only users with
admin-level permissions will be able to use this API.

This operation is performed by calling function `DeleteGroupById`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/delete-groups-id/).

<!-- sample delete_groups_id -->
```
await client.Groups.DeleteGroupById(group.Id)
```

### Arguments

- groupId `string`
  - The ID of the group. Example: "57645"
- headers `DeleteGroupByIdHeadersArg`
  - Headers of deleteGroupById method


### Returns

This function returns a value of type `null`.

A blank response is returned if the group was
successfully deleted.


