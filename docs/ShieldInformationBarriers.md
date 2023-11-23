# IShieldInformationBarriersManager


- [Get shield information barrier with specified ID](#get-shield-information-barrier-with-specified-id)
- [Add changed status of shield information barrier with specified ID](#add-changed-status-of-shield-information-barrier-with-specified-id)
- [List shield information barriers](#list-shield-information-barriers)
- [Create shield information barrier](#create-shield-information-barrier)

## Get shield information barrier with specified ID

Get shield information barrier based on provided ID.

This operation is performed by calling function `GetShieldInformationBarrierById`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-shield-information-barriers-id/).

<!-- sample get_shield_information_barriers_id -->
```
await client.ShieldInformationBarriers.GetShieldInformationBarrierByIdAsync(shieldInformationBarrierId: barrierId).ConfigureAwait(false)
```

### Arguments

- shieldInformationBarrierId `string`
  - The ID of the shield information barrier. Example: "1910967"
- headers `GetShieldInformationBarrierByIdHeadersArg`
  - Headers of getShieldInformationBarrierById method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `ShieldInformationBarrier`.

Returns the shield information barrier object.


## Add changed status of shield information barrier with specified ID

Change status of shield information barrier with the specified ID.

This operation is performed by calling function `CreateShieldInformationBarrierChangeStatus`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/post-shield-information-barriers-change-status/).

<!-- sample post_shield_information_barriers_change_status -->
```
await client.ShieldInformationBarriers.CreateShieldInformationBarrierChangeStatusAsync(requestBody: new CreateShieldInformationBarrierChangeStatusRequestBodyArg(id: barrierId, status: CreateShieldInformationBarrierChangeStatusRequestBodyArgStatusField.Disabled)).ConfigureAwait(false)
```

### Arguments

- requestBody `CreateShieldInformationBarrierChangeStatusRequestBodyArg`
  - Request body of createShieldInformationBarrierChangeStatus method
- headers `CreateShieldInformationBarrierChangeStatusHeadersArg`
  - Headers of createShieldInformationBarrierChangeStatus method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `ShieldInformationBarrier`.

Returns the updated shield information barrier object.


## List shield information barriers

Retrieves a list of shield information barrier objects
for the enterprise of JWT.

This operation is performed by calling function `GetShieldInformationBarriers`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-shield-information-barriers/).

<!-- sample get_shield_information_barriers -->
```
await client.ShieldInformationBarriers.GetShieldInformationBarriersAsync().ConfigureAwait(false)
```

### Arguments

- queryParams `GetShieldInformationBarriersQueryParamsArg`
  - Query parameters of getShieldInformationBarriers method
- headers `GetShieldInformationBarriersHeadersArg`
  - Headers of getShieldInformationBarriers method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `ShieldInformationBarriers`.

Returns a paginated list of
shield information barrier objects,
empty list if currently no barrier.


## Create shield information barrier

Creates a shield information barrier to
separate individuals/groups within the same
firm and prevents confidential information passing between them.

This operation is performed by calling function `CreateShieldInformationBarrier`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/post-shield-information-barriers/).

<!-- sample post_shield_information_barriers -->
```
await client.ShieldInformationBarriers.CreateShieldInformationBarrierAsync(requestBody: new CreateShieldInformationBarrierRequestBodyArg(enterprise: new EnterpriseBase(id: enterpriseId, type: EnterpriseBaseTypeField.Enterprise))).ConfigureAwait(false)
```

### Arguments

- requestBody `CreateShieldInformationBarrierRequestBodyArg`
  - Request body of createShieldInformationBarrier method
- headers `CreateShieldInformationBarrierHeadersArg`
  - Headers of createShieldInformationBarrier method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `ShieldInformationBarrier`.

Returns a new shield information barrier object.


