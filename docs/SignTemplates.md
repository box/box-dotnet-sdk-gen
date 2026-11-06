# ISignTemplatesManager

<!-- box-dotnet-sdk-gen deprecation banner -->
> [!CAUTION]
> **`box-dotnet-sdk-gen` is deprecated and no longer maintained.** As of September 17, 2025, it receives no new features, bug fixes, or security patches. Do not use it for new projects.
>
> Use [`box-windows-sdk-v2`](https://github.com/box/box-windows-sdk-v2) v10+ instead: `Install-Package Box.V2.Core`.
> The equivalent of this page is [box-windows-sdk-v2/docs/SignTemplates.md](https://github.com/box/box-windows-sdk-v2/blob/main/docs/SignTemplates.md). To migrate existing code, see the [migration guide](https://github.com/box/box-windows-sdk-v2/blob/main/migration-guides/from-dotnet-sdk-gen-v1-to-box-windows-sdk.md).


- [List Box Sign templates](#list-box-sign-templates)
- [Get Box Sign template by ID](#get-box-sign-template-by-id)

## List Box Sign templates

Gets Box Sign templates created by a user.

This operation is performed by calling function `GetSignTemplates`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-sign-templates/).

<!-- sample get_sign_templates -->
```
await client.SignTemplates.GetSignTemplatesAsync(queryParams: new GetSignTemplatesQueryParams() { Limit = 2 });
```

### Arguments

- queryParams `GetSignTemplatesQueryParams`
  - Query parameters of getSignTemplates method
- headers `GetSignTemplatesHeaders`
  - Headers of getSignTemplates method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `SignTemplates`.

Returns a collection of templates.


## Get Box Sign template by ID

Fetches details of a specific Box Sign template.

This operation is performed by calling function `GetSignTemplateById`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-sign-templates-id/).

<!-- sample get_sign_templates_id -->
```
await client.SignTemplates.GetSignTemplateByIdAsync(templateId: NullableUtils.Unwrap(NullableUtils.Unwrap(signTemplates.Entries)[0].Id));
```

### Arguments

- templateId `string`
  - The ID of a Box Sign template. Example: "123075213-7d117509-8f05-42e4-a5ef-5190a319d41d"
- headers `GetSignTemplateByIdHeaders`
  - Headers of getSignTemplateById method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `SignTemplate`.

Returns details of a template.


