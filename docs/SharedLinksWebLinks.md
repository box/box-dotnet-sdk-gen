# SharedLinksWebLinksManager


- [Find web link for shared link](#find-web-link-for-shared-link)
- [Get shared link for web link](#get-shared-link-for-web-link)
- [Add shared link to web link](#add-shared-link-to-web-link)
- [Update shared link on web link](#update-shared-link-on-web-link)
- [Remove shared link from web link](#remove-shared-link-from-web-link)

## Find web link for shared link

Returns the web link represented by a shared link.

A shared web link can be represented by a shared link,
which can originate within the current enterprise or within another.

This endpoint allows an application to retrieve information about a
shared web link when only given a shared link.

This operation is performed by calling function `GetSharedItemWebLinks`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-shared-items-web-links/).

<!-- sample get_shared_items#web_links -->
```
await userClient.SharedLinksWebLinks.GetSharedItemWebLinksAsync(queryParams: new GetSharedItemWebLinksQueryParamsArg(), headers: new GetSharedItemWebLinksHeadersArg(boxapi: string.Concat("shared_link=", webLinkFromApi.SharedLink!.Url, "&shared_link_password=incorrectPassword"))).ConfigureAwait(false)
```

### Arguments

- queryParams `GetSharedItemWebLinksQueryParamsArg`
  - Query parameters of getSharedItemWebLinks method
- headers `GetSharedItemWebLinksHeadersArg`
  - Headers of getSharedItemWebLinks method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `WebLink`.

Returns a full file resource if the shared link is valid and
the user has access to it.


## Get shared link for web link

Gets the information for a shared link on a web link.

This operation is performed by calling function `GetWebLinkGetSharedLink`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-web-links-id-get-shared-link/).

<!-- sample get_web_links_id#get_shared_link -->
```
await client.SharedLinksWebLinks.GetWebLinkGetSharedLinkAsync(webLinkId: webLinkId, queryParams: new GetWebLinkGetSharedLinkQueryParamsArg(fields: "shared_link")).ConfigureAwait(false)
```

### Arguments

- webLinkId `string`
  - The ID of the web link. Example: "12345"
- queryParams `GetWebLinkGetSharedLinkQueryParamsArg`
  - Query parameters of getWebLinkGetSharedLink method
- headers `GetWebLinkGetSharedLinkHeadersArg`
  - Headers of getWebLinkGetSharedLink method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `WebLink`.

Returns the base representation of a web link with the
additional shared link information.


## Add shared link to web link

Adds a shared link to a web link.

This operation is performed by calling function `UpdateWebLinkAddSharedLink`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/put-web-links-id-add-shared-link/).

<!-- sample put_web_links_id#add_shared_link -->
```
await client.SharedLinksWebLinks.UpdateWebLinkAddSharedLinkAsync(webLinkId: webLinkId, requestBody: new UpdateWebLinkAddSharedLinkRequestBodyArg(sharedLink: new UpdateWebLinkAddSharedLinkRequestBodyArgSharedLinkField(access: UpdateWebLinkAddSharedLinkRequestBodyArgSharedLinkFieldAccessField.Open, password: "Secret123@")), queryParams: new UpdateWebLinkAddSharedLinkQueryParamsArg(fields: "shared_link")).ConfigureAwait(false)
```

### Arguments

- webLinkId `string`
  - The ID of the web link. Example: "12345"
- requestBody `UpdateWebLinkAddSharedLinkRequestBodyArg`
  - Request body of updateWebLinkAddSharedLink method
- queryParams `UpdateWebLinkAddSharedLinkQueryParamsArg`
  - Query parameters of updateWebLinkAddSharedLink method
- headers `UpdateWebLinkAddSharedLinkHeadersArg`
  - Headers of updateWebLinkAddSharedLink method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `WebLink`.

Returns the base representation of a web link with a new shared
link attached.


## Update shared link on web link

Updates a shared link on a web link.

This operation is performed by calling function `UpdateWebLinkUpdateSharedLink`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/put-web-links-id-update-shared-link/).

<!-- sample put_web_links_id#update_shared_link -->
```
await client.SharedLinksWebLinks.UpdateWebLinkUpdateSharedLinkAsync(webLinkId: webLinkId, requestBody: new UpdateWebLinkUpdateSharedLinkRequestBodyArg(sharedLink: new UpdateWebLinkUpdateSharedLinkRequestBodyArgSharedLinkField(access: UpdateWebLinkUpdateSharedLinkRequestBodyArgSharedLinkFieldAccessField.Collaborators)), queryParams: new UpdateWebLinkUpdateSharedLinkQueryParamsArg(fields: "shared_link")).ConfigureAwait(false)
```

### Arguments

- webLinkId `string`
  - The ID of the web link. Example: "12345"
- requestBody `UpdateWebLinkUpdateSharedLinkRequestBodyArg`
  - Request body of updateWebLinkUpdateSharedLink method
- queryParams `UpdateWebLinkUpdateSharedLinkQueryParamsArg`
  - Query parameters of updateWebLinkUpdateSharedLink method
- headers `UpdateWebLinkUpdateSharedLinkHeadersArg`
  - Headers of updateWebLinkUpdateSharedLink method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `WebLink`.

Returns a basic representation of the web link, with the updated shared
link attached.


## Remove shared link from web link

Removes a shared link from a web link.

This operation is performed by calling function `UpdateWebLinkRemoveSharedLink`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/put-web-links-id-remove-shared-link/).

*Currently we don't have an example for calling `UpdateWebLinkRemoveSharedLink` in integration tests*

### Arguments

- webLinkId `string`
  - The ID of the web link. Example: "12345"
- requestBody `UpdateWebLinkRemoveSharedLinkRequestBodyArg`
  - Request body of updateWebLinkRemoveSharedLink method
- queryParams `UpdateWebLinkRemoveSharedLinkQueryParamsArg`
  - Query parameters of updateWebLinkRemoveSharedLink method
- headers `UpdateWebLinkRemoveSharedLinkHeadersArg`
  - Headers of updateWebLinkRemoveSharedLink method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `WebLink`.

Returns a basic representation of a web link, with the
shared link removed.


