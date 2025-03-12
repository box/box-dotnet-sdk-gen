# ISharedLinksAppItemsManager


- [Find app item for shared link](#find-app-item-for-shared-link)

## Find app item for shared link

Returns the app item represented by a shared link.

The link can originate from the current enterprise or another.

This operation is performed by calling function `GetSharedItemAppItems`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-shared-items--app-items/).

*Currently we don't have an example for calling `GetSharedItemAppItems` in integration tests*

### Arguments

- headers `GetSharedItemAppItemsHeaders`
  - Headers of getSharedItemAppItems method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `AppItem`.

Returns a full app item resource if the shared link is valid and
the user has access to it.


