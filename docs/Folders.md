# FoldersManager


- [Get folder information](#get-folder-information)
- [Update folder](#update-folder)
- [Delete folder](#delete-folder)
- [List items in folder](#list-items-in-folder)
- [Create folder](#create-folder)
- [Copy folder](#copy-folder)

## Get folder information

Retrieves details for a folder, including the first 100 entries
in the folder.

Passing `sort`, `direction`, `offset`, and `limit`
parameters in query allows you to manage the
list of returned
[folder items](r://folder--full#param-item-collection).

To fetch more items within the folder, use the
[Get items in a folder](#get-folders-id-items) endpoint.

This operation is performed by calling function `GetFolderById`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-folders-id/).

*Currently we don't have an example for calling `GetFolderById` in integration tests*

### Arguments

- folderId `string`
  - The unique identifier that represent a folder.  The ID for any folder can be determined by visiting this folder in the web application and copying the ID from the URL. For example, for the URL `https://*.app.box.com/folder/123` the `folder_id` is `123`.  The root folder of a Box account is always represented by the ID `0`. Example: "12345"
- queryParams `GetFolderByIdQueryParamsArg`
  - Query parameters of getFolderById method
- headers `GetFolderByIdHeadersArg`
  - Headers of getFolderById method


### Returns

This function returns a value of type `FolderFull`.

Returns a folder, including the first 100 entries in the folder.
If you used query parameters like
`sort`, `direction`, `offset`, or `limit`
the *folder items list* will be affected accordingly.

To fetch more items within the folder, use the
[Get items in a folder](#get-folders-id-items) endpoint.

Not all available fields are returned by default. Use the
[fields](#param-fields) query parameter to explicitly request
any specific fields.


## Update folder

Updates a folder. This can be also be used to move the folder,
create shared links, update collaborations, and more.

This operation is performed by calling function `UpdateFolderById`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/put-folders-id/).

*Currently we don't have an example for calling `UpdateFolderById` in integration tests*

### Arguments

- folderId `string`
  - The unique identifier that represent a folder.  The ID for any folder can be determined by visiting this folder in the web application and copying the ID from the URL. For example, for the URL `https://*.app.box.com/folder/123` the `folder_id` is `123`.  The root folder of a Box account is always represented by the ID `0`. Example: "12345"
- requestBody `UpdateFolderByIdRequestBodyArg`
  - Request body of updateFolderById method
- queryParams `UpdateFolderByIdQueryParamsArg`
  - Query parameters of updateFolderById method
- headers `UpdateFolderByIdHeadersArg`
  - Headers of updateFolderById method


### Returns

This function returns a value of type `FolderFull`.

Returns a folder object for the updated folder

Not all available fields are returned by default. Use the
[fields](#param-fields) query parameter to explicitly request
any specific fields.

This call will return synchronously. This holds true even when
moving folders with a large a large number of items in all of its
descendants. For very large folders, this means the call could
take minutes or hours to return.


## Delete folder

Deletes a folder, either permanently or by moving it to
the trash.

This operation is performed by calling function `DeleteFolderById`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/delete-folders-id/).

*Currently we don't have an example for calling `DeleteFolderById` in integration tests*

### Arguments

- folderId `string`
  - The unique identifier that represent a folder.  The ID for any folder can be determined by visiting this folder in the web application and copying the ID from the URL. For example, for the URL `https://*.app.box.com/folder/123` the `folder_id` is `123`.  The root folder of a Box account is always represented by the ID `0`. Example: "12345"
- queryParams `DeleteFolderByIdQueryParamsArg`
  - Query parameters of deleteFolderById method
- headers `DeleteFolderByIdHeadersArg`
  - Headers of deleteFolderById method


### Returns

This function returns a value of type `null`.

Returns an empty response when the folder is successfully deleted
or moved to the trash.


## List items in folder

Retrieves a page of items in a folder. These items can be files,
folders, and web links.

To request more information about the folder itself, like its size,
use the [Get a folder](#get-folders-id) endpoint instead.

This operation is performed by calling function `GetFolderItems`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-folders-id-items/).

*Currently we don't have an example for calling `GetFolderItems` in integration tests*

### Arguments

- folderId `string`
  - The unique identifier that represent a folder.  The ID for any folder can be determined by visiting this folder in the web application and copying the ID from the URL. For example, for the URL `https://*.app.box.com/folder/123` the `folder_id` is `123`.  The root folder of a Box account is always represented by the ID `0`. Example: "12345"
- queryParams `GetFolderItemsQueryParamsArg`
  - Query parameters of getFolderItems method
- headers `GetFolderItemsHeadersArg`
  - Headers of getFolderItems method


### Returns

This function returns a value of type `Items`.

Returns a collection of files, folders, and web links contained in a folder.


## Create folder

Creates a new empty folder within the specified parent folder.

This operation is performed by calling function `CreateFolder`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/post-folders/).

*Currently we don't have an example for calling `CreateFolder` in integration tests*

### Arguments

- requestBody `CreateFolderRequestBodyArg`
  - Request body of createFolder method
- queryParams `CreateFolderQueryParamsArg`
  - Query parameters of createFolder method
- headers `CreateFolderHeadersArg`
  - Headers of createFolder method


### Returns

This function returns a value of type `FolderFull`.

Returns a folder object.

Not all available fields are returned by default. Use the
[fields](#param-fields) query parameter to explicitly request
any specific fields.


## Copy folder

Creates a copy of a folder within a destination folder.

The original folder will not be changed.

This operation is performed by calling function `CopyFolder`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/post-folders-id-copy/).

*Currently we don't have an example for calling `CopyFolder` in integration tests*

### Arguments

- folderId `string`
  - The unique identifier of the folder to copy.  The ID for any folder can be determined by visiting this folder in the web application and copying the ID from the URL. For example, for the URL `https://*.app.box.com/folder/123` the `folder_id` is `123`.  The root folder with the ID `0` can not be copied. Example: "0"
- requestBody `CopyFolderRequestBodyArg`
  - Request body of copyFolder method
- queryParams `CopyFolderQueryParamsArg`
  - Query parameters of copyFolder method
- headers `CopyFolderHeadersArg`
  - Headers of copyFolder method


### Returns

This function returns a value of type `FolderFull`.

Returns a new folder object representing the copied folder.

Not all available fields are returned by default. Use the
[fields](#param-fields) query parameter to explicitly request
any specific fields.


