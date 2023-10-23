# FolderLocksManager


- [List folder locks](#list-folder-locks)
- [Create folder lock](#create-folder-lock)
- [Delete folder lock](#delete-folder-lock)

## List folder locks

Retrieves folder lock details for a given folder.

You must be authenticated as the owner or co-owner of the folder to
use this endpoint.

This operation is performed by calling function `GetFolderLocks`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-folder-locks/).

<!-- sample get_folder_locks -->
```
await client.FolderLocks.GetFolderLocksAsync(new GetFolderLocksQueryParamsArg(folderId: folder.Id)).ConfigureAwait(false)
```

### Arguments

- queryParams `GetFolderLocksQueryParamsArg`
  - Query parameters of getFolderLocks method
- headers `GetFolderLocksHeadersArg`
  - Headers of getFolderLocks method


### Returns

This function returns a value of type `FolderLocks`.

Returns details for all folder locks applied to the folder, including the
lock type and user that applied the lock.


## Create folder lock

Creates a folder lock on a folder, preventing it from being moved and/or
deleted.

You must be authenticated as the owner or co-owner of the folder to
use this endpoint.

This operation is performed by calling function `CreateFolderLock`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/post-folder-locks/).

<!-- sample post_folder_locks -->
```
await client.FolderLocks.CreateFolderLockAsync(new CreateFolderLockRequestBodyArg(folder: new CreateFolderLockRequestBodyArgFolderField(id: folder.Id, type: "folder"), lockedOperations: new CreateFolderLockRequestBodyArgLockedOperationsField(move: true, delete: true))).ConfigureAwait(false)
```

### Arguments

- requestBody `CreateFolderLockRequestBodyArg`
  - Request body of createFolderLock method
- headers `CreateFolderLockHeadersArg`
  - Headers of createFolderLock method


### Returns

This function returns a value of type `FolderLock`.

Returns the instance of the folder lock that was applied to the folder,
including the user that applied the lock and the operations set.


## Delete folder lock

Deletes a folder lock on a given folder.

You must be authenticated as the owner or co-owner of the folder to
use this endpoint.

This operation is performed by calling function `DeleteFolderLockById`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/delete-folder-locks-id/).

<!-- sample delete_folder_locks_id -->
```
await client.FolderLocks.DeleteFolderLockByIdAsync(folderLock.Id!).ConfigureAwait(false)
```

### Arguments

- folderLockId `string`
  - The ID of the folder lock. Example: "12345"
- headers `DeleteFolderLockByIdHeadersArg`
  - Headers of deleteFolderLockById method


### Returns

This function returns a value of type `null`.

Returns an empty response when the folder lock is successfully deleted.


