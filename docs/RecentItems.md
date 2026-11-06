# IRecentItemsManager

<!-- box-dotnet-sdk-gen deprecation banner -->
> [!CAUTION]
> **`box-dotnet-sdk-gen` is deprecated and no longer maintained.** As of September 17, 2025, it receives no new features, bug fixes, or security patches. Do not use it for new projects.
>
> Use [`box-windows-sdk-v2`](https://github.com/box/box-windows-sdk-v2) v10+ instead: `Install-Package Box.V2.Core`.
> The equivalent of this page is [box-windows-sdk-v2/docs/RecentItems.md](https://github.com/box/box-windows-sdk-v2/blob/main/docs/RecentItems.md). To migrate existing code, see the [migration guide](https://github.com/box/box-windows-sdk-v2/blob/main/migration-guides/from-dotnet-sdk-gen-v1-to-box-windows-sdk.md).


- [List recently accessed items](#list-recently-accessed-items)

## List recently accessed items

Returns information about the recent items accessed
by a user, either in the last 90 days or up to the last
1000 items accessed.

This operation is performed by calling function `GetRecentItems`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-recent-items/).

<!-- sample get_recent_items -->
```
await client.RecentItems.GetRecentItemsAsync();
```

### Arguments

- queryParams `GetRecentItemsQueryParams`
  - Query parameters of getRecentItems method
- headers `GetRecentItemsHeaders`
  - Headers of getRecentItems method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `RecentItems`.

Returns a list recent items access by a user.


