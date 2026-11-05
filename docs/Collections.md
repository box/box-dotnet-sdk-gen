# ICollectionsManager

<!-- box-dotnet-sdk-gen deprecation banner -->
> [!CAUTION]
> **`box-dotnet-sdk-gen` is deprecated and no longer maintained.** As of September 17, 2025, it receives no new features, bug fixes, or security patches. Do not use it for new projects.
>
> Use [`box-windows-sdk-v2`](https://github.com/box/box-windows-sdk-v2) v10+ instead: `Install-Package Box.V2.Core`.
> The equivalent of this page is [box-windows-sdk-v2/docs/Collections.md](https://github.com/box/box-windows-sdk-v2/blob/main/docs/Collections.md). To migrate existing code, see the [migration guide](https://github.com/box/box-windows-sdk-v2/blob/main/migration-guides/from-dotnet-sdk-gen-v1-to-box-windows-sdk.md).


- [List all collections](#list-all-collections)
- [List collection items](#list-collection-items)
- [Get collection by ID](#get-collection-by-id)

## List all collections

Retrieves all collections for a given user.

Currently, only the `favorites` collection
is supported.

This operation is performed by calling function `GetCollections`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-collections/).

<!-- sample get_collections -->
```
await client.Collections.GetCollectionsAsync();
```

### Arguments

- queryParams `GetCollectionsQueryParams`
  - Query parameters of getCollections method
- headers `GetCollectionsHeaders`
  - Headers of getCollections method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `Collections`.

Returns all collections for the given user.


## List collection items

Retrieves the files and/or folders contained within
this collection.

This operation is performed by calling function `GetCollectionItems`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-collections-id-items/).

<!-- sample get_collections_id_items -->
```
await client.Collections.GetCollectionItemsAsync(collectionId: NullableUtils.Unwrap(favouriteCollection.Id));
```

### Arguments

- collectionId `string`
  - The ID of the collection. Example: "926489"
- queryParams `GetCollectionItemsQueryParams`
  - Query parameters of getCollectionItems method
- headers `GetCollectionItemsHeaders`
  - Headers of getCollectionItems method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `ItemsOffsetPaginated`.

Returns an array of items in the collection.


## Get collection by ID

Retrieves a collection by its ID.

This operation is performed by calling function `GetCollectionById`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-collections-id/).

<!-- sample get_collections_id -->
```
await client.Collections.GetCollectionByIdAsync(collectionId: NullableUtils.Unwrap(NullableUtils.Unwrap(collections.Entries)[0].Id));
```

### Arguments

- collectionId `string`
  - The ID of the collection. Example: "926489"
- headers `GetCollectionByIdHeaders`
  - Headers of getCollectionById method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `Collection`.

Returns an array of items in the collection.


