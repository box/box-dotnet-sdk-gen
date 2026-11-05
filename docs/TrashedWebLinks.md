# ITrashedWebLinksManager

<!-- box-dotnet-sdk-gen deprecation banner -->
> [!CAUTION]
> **`box-dotnet-sdk-gen` is deprecated and no longer maintained.** As of September 17, 2025, it receives no new features, bug fixes, or security patches. Do not use it for new projects.
>
> Use [`box-windows-sdk-v2`](https://github.com/box/box-windows-sdk-v2) v10+ instead: `Install-Package Box.V2.Core`.
> The equivalent of this page is [box-windows-sdk-v2/docs/TrashedWebLinks.md](https://github.com/box/box-windows-sdk-v2/blob/main/docs/TrashedWebLinks.md). To migrate existing code, see the [migration guide](https://github.com/box/box-windows-sdk-v2/blob/main/migration-guides/from-dotnet-sdk-gen-v1-to-box-windows-sdk.md).


- [Restore web link](#restore-web-link)
- [Get trashed web link](#get-trashed-web-link)
- [Permanently remove web link](#permanently-remove-web-link)

## Restore web link

Restores a web link that has been moved to the trash.

An optional new parent ID can be provided to restore the  web link to in case
the original folder has been deleted.

This operation is performed by calling function `RestoreWeblinkFromTrash`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/post-web-links-id/).

<!-- sample post_web_links_id -->
```
await client.TrashedWebLinks.RestoreWeblinkFromTrashAsync(webLinkId: weblink.Id);
```

### Arguments

- webLinkId `string`
  - The ID of the web link. Example: "12345"
- requestBody `RestoreWeblinkFromTrashRequestBody`
  - Request body of restoreWeblinkFromTrash method
- queryParams `RestoreWeblinkFromTrashQueryParams`
  - Query parameters of restoreWeblinkFromTrash method
- headers `RestoreWeblinkFromTrashHeaders`
  - Headers of restoreWeblinkFromTrash method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `TrashWebLinkRestored`.

Returns a web link object when it has been restored.


## Get trashed web link

Retrieves a web link that has been moved to the trash.

This operation is performed by calling function `GetTrashedWebLinkById`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-web-links-id-trash/).

<!-- sample get_web_links_id_trash -->
```
await client.TrashedWebLinks.GetTrashedWebLinkByIdAsync(webLinkId: weblink.Id);
```

### Arguments

- webLinkId `string`
  - The ID of the web link. Example: "12345"
- queryParams `GetTrashedWebLinkByIdQueryParams`
  - Query parameters of getTrashedWebLinkById method
- headers `GetTrashedWebLinkByIdHeaders`
  - Headers of getTrashedWebLinkById method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `TrashWebLink`.

Returns the web link that was trashed,
including information about when the it
was moved to the trash.


## Permanently remove web link

Permanently deletes a web link that is in the trash.
This action cannot be undone.

This operation is performed by calling function `DeleteTrashedWebLinkById`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/delete-web-links-id-trash/).

<!-- sample delete_web_links_id_trash -->
```
await client.TrashedWebLinks.DeleteTrashedWebLinkByIdAsync(webLinkId: weblink.Id);
```

### Arguments

- webLinkId `string`
  - The ID of the web link. Example: "12345"
- headers `DeleteTrashedWebLinkByIdHeaders`
  - Headers of deleteTrashedWebLinkById method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `null`.

Returns an empty response when the web link was
permanently deleted.


