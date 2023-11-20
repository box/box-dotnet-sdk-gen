# WebLinksManager


- [Create web link](#create-web-link)
- [Get web link](#get-web-link)
- [Update web link](#update-web-link)
- [Remove web link](#remove-web-link)

## Create web link

Creates a web link object within a folder.

This operation is performed by calling function `CreateWebLink`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/post-web-links/).

<!-- sample post_web_links -->
```
await client.WebLinks.CreateWebLinkAsync(requestBody: new CreateWebLinkRequestBodyArg(url: url, parent: new CreateWebLinkRequestBodyArgParentField(id: parent.Id), name: name, description: description)).ConfigureAwait(false)
```

### Arguments

- requestBody `CreateWebLinkRequestBodyArg`
  - Request body of createWebLink method
- headers `CreateWebLinkHeadersArg`
  - Headers of createWebLink method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `WebLink`.

Returns the newly created web link object.


## Get web link

Retrieve information about a web link.

This operation is performed by calling function `GetWebLinkById`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-web-links-id/).

<!-- sample get_web_links_id -->
```
await client.WebLinks.GetWebLinkByIdAsync(webLinkId: weblink.Id).ConfigureAwait(false)
```

### Arguments

- webLinkId `string`
  - The ID of the web link. Example: "12345"
- headers `GetWebLinkByIdHeadersArg`
  - Headers of getWebLinkById method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `WebLink`.

Returns the web link object.


## Update web link

Updates a web link object.

This operation is performed by calling function `UpdateWebLinkById`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/put-web-links-id/).

*Currently we don't have an example for calling `UpdateWebLinkById` in integration tests*

### Arguments

- webLinkId `string`
  - The ID of the web link. Example: "12345"
- requestBody `UpdateWebLinkByIdRequestBodyArg`
  - Request body of updateWebLinkById method
- headers `UpdateWebLinkByIdHeadersArg`
  - Headers of updateWebLinkById method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `WebLink`.

Returns the updated web link object.


## Remove web link

Deletes a web link.

This operation is performed by calling function `DeleteWebLinkById`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/delete-web-links-id/).

<!-- sample delete_web_links_id -->
```
await client.WebLinks.DeleteWebLinkByIdAsync(webLinkId: weblink.Id).ConfigureAwait(false)
```

### Arguments

- webLinkId `string`
  - The ID of the web link. Example: "12345"
- headers `DeleteWebLinkByIdHeadersArg`
  - Headers of deleteWebLinkById method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `null`.

An empty response will be returned when the web link
was successfully deleted.


