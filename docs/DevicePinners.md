# IDevicePinnersManager

<!-- box-dotnet-sdk-gen deprecation banner -->
> [!CAUTION]
> **`box-dotnet-sdk-gen` is deprecated and no longer maintained.** As of September 17, 2025, it receives no new features, bug fixes, or security patches. Do not use it for new projects.
>
> Use [`box-windows-sdk-v2`](https://github.com/box/box-windows-sdk-v2) v10+ instead: `Install-Package Box.V2.Core`.
> The equivalent of this page is [box-windows-sdk-v2/docs/DevicePinners.md](https://github.com/box/box-windows-sdk-v2/blob/main/docs/DevicePinners.md). To migrate existing code, see the [migration guide](https://github.com/box/box-windows-sdk-v2/blob/main/migration-guides/from-dotnet-sdk-gen-v1-to-box-windows-sdk.md).


- [Get device pin](#get-device-pin)
- [Remove device pin](#remove-device-pin)
- [List enterprise device pins](#list-enterprise-device-pins)

## Get device pin

Retrieves information about an individual device pin.

This operation is performed by calling function `GetDevicePinnerById`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-device-pinners-id/).

<!-- sample get_device_pinners_id -->
```
await client.DevicePinners.GetDevicePinnerByIdAsync(devicePinnerId: devicePinnerId);
```

### Arguments

- devicePinnerId `string`
  - The ID of the device pin. Example: "2324234"
- headers `GetDevicePinnerByIdHeaders`
  - Headers of getDevicePinnerById method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `DevicePinner`.

Returns information about a single device pin.


## Remove device pin

Deletes an individual device pin.

This operation is performed by calling function `DeleteDevicePinnerById`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/delete-device-pinners-id/).

<!-- sample delete_device_pinners_id -->
```
await client.DevicePinners.DeleteDevicePinnerByIdAsync(devicePinnerId: devicePinnerId);
```

### Arguments

- devicePinnerId `string`
  - The ID of the device pin. Example: "2324234"
- headers `DeleteDevicePinnerByIdHeaders`
  - Headers of deleteDevicePinnerById method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `null`.

Returns an empty response when the pin has been deleted.


## List enterprise device pins

Retrieves all the device pins within an enterprise.

The user must have admin privileges, and the application
needs the "manage enterprise" scope to make this call.

This operation is performed by calling function `GetEnterpriseDevicePinners`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-enterprises-id-device-pinners/).

<!-- sample get_enterprises_id_device_pinners -->
```
await client.DevicePinners.GetEnterpriseDevicePinnersAsync(enterpriseId: enterpriseId);
```

### Arguments

- enterpriseId `string`
  - The ID of the enterprise. Example: "3442311"
- queryParams `GetEnterpriseDevicePinnersQueryParams`
  - Query parameters of getEnterpriseDevicePinners method
- headers `GetEnterpriseDevicePinnersHeaders`
  - Headers of getEnterpriseDevicePinners method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `DevicePinners`.

Returns a list of device pins for a given enterprise.


