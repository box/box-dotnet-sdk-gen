# IWebhooksManager


- [List all webhooks](#list-all-webhooks)
- [Create webhook](#create-webhook)
- [Get webhook](#get-webhook)
- [Update webhook](#update-webhook)
- [Remove webhook](#remove-webhook)

## List all webhooks

Returns all defined webhooks for the requesting application.

This API only returns webhooks that are applied to files or folders that are
owned by the authenticated user. This means that an admin can not see webhooks
created by a service account unless the admin has access to those folders, and
vice versa.

This operation is performed by calling function `GetWebhooks`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-webhooks/).

<!-- sample get_webhooks -->
```
await client.Webhooks.GetWebhooksAsync().ConfigureAwait(false)
```

### Arguments

- queryParams `GetWebhooksQueryParamsArg`
  - Query parameters of getWebhooks method
- headers `GetWebhooksHeadersArg`
  - Headers of getWebhooks method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `Webhooks`.

Returns a list of webhooks.


## Create webhook

Creates a webhook.

This operation is performed by calling function `CreateWebhook`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/post-webhooks/).

<!-- sample post_webhooks -->
```
await client.Webhooks.CreateWebhookAsync(requestBody: new CreateWebhookRequestBodyArg(target: new CreateWebhookRequestBodyArgTargetField(id: folder.Id, type: CreateWebhookRequestBodyArgTargetFieldTypeField.Folder), address: "https://example.com/new-webhook", triggers: Array.AsReadOnly(new [] {CreateWebhookRequestBodyArgTriggersField.FileUploaded}))).ConfigureAwait(false)
```

### Arguments

- requestBody `CreateWebhookRequestBodyArg`
  - Request body of createWebhook method
- headers `CreateWebhookHeadersArg`
  - Headers of createWebhook method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `Webhook`.

Returns the new webhook object.


## Get webhook

Retrieves a specific webhook

This operation is performed by calling function `GetWebhookById`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-webhooks-id/).

<!-- sample get_webhooks_id -->
```
await client.Webhooks.GetWebhookByIdAsync(webhookId: webhook.Id!).ConfigureAwait(false)
```

### Arguments

- webhookId `string`
  - The ID of the webhook. Example: "3321123"
- headers `GetWebhookByIdHeadersArg`
  - Headers of getWebhookById method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `Webhook`.

Returns a webhook object


## Update webhook

Updates a webhook.

This operation is performed by calling function `UpdateWebhookById`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/put-webhooks-id/).

<!-- sample put_webhooks_id -->
```
await client.Webhooks.UpdateWebhookByIdAsync(webhookId: webhook.Id!, requestBody: new UpdateWebhookByIdRequestBodyArg(address: "https://example.com/updated-webhook")).ConfigureAwait(false)
```

### Arguments

- webhookId `string`
  - The ID of the webhook. Example: "3321123"
- requestBody `UpdateWebhookByIdRequestBodyArg`
  - Request body of updateWebhookById method
- headers `UpdateWebhookByIdHeadersArg`
  - Headers of updateWebhookById method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `Webhook`.

Returns the new webhook object.


## Remove webhook

Deletes a webhook.

This operation is performed by calling function `DeleteWebhookById`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/delete-webhooks-id/).

<!-- sample delete_webhooks_id -->
```
await client.Webhooks.DeleteWebhookByIdAsync(webhookId: webhook.Id!).ConfigureAwait(false)
```

### Arguments

- webhookId `string`
  - The ID of the webhook. Example: "3321123"
- headers `DeleteWebhookByIdHeadersArg`
  - Headers of deleteWebhookById method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `null`.

An empty response will be returned when the webhook
was successfully deleted.


