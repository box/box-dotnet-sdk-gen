# ShieldInformationBarrierSegmentsManager


- [Get shield information barrier segment with specified ID](#get-shield-information-barrier-segment-with-specified-id)
- [Update shield information barrier segment with specified ID](#update-shield-information-barrier-segment-with-specified-id)
- [Delete shield information barrier segment](#delete-shield-information-barrier-segment)
- [List shield information barrier segments](#list-shield-information-barrier-segments)
- [Create shield information barrier segment](#create-shield-information-barrier-segment)

## Get shield information barrier segment with specified ID

Retrieves shield information barrier segment based on provided ID..

This operation is performed by calling function `GetShieldInformationBarrierSegmentById`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-shield-information-barrier-segments-id/).

*Currently we don't have an example for calling `GetShieldInformationBarrierSegmentById` in integration tests*

### Arguments

- shieldInformationBarrierSegmentId `string`
  - The ID of the shield information barrier segment. Example: "3423"
- headers `GetShieldInformationBarrierSegmentByIdHeadersArg`
  - Headers of getShieldInformationBarrierSegmentById method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `ShieldInformationBarrierSegment`.

Returns the shield information barrier segment object.


## Update shield information barrier segment with specified ID

Updates the shield information barrier segment based on provided ID..

This operation is performed by calling function `UpdateShieldInformationBarrierSegmentById`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/put-shield-information-barrier-segments-id/).

*Currently we don't have an example for calling `UpdateShieldInformationBarrierSegmentById` in integration tests*

### Arguments

- shieldInformationBarrierSegmentId `string`
  - The ID of the shield information barrier segment. Example: "3423"
- requestBody `UpdateShieldInformationBarrierSegmentByIdRequestBodyArg`
  - Request body of updateShieldInformationBarrierSegmentById method
- headers `UpdateShieldInformationBarrierSegmentByIdHeadersArg`
  - Headers of updateShieldInformationBarrierSegmentById method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `ShieldInformationBarrierSegment`.

Returns the updated shield information barrier segment object.


## Delete shield information barrier segment

Deletes the shield information barrier segment
based on provided ID.

This operation is performed by calling function `DeleteShieldInformationBarrierSegmentById`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/delete-shield-information-barrier-segments-id/).

*Currently we don't have an example for calling `DeleteShieldInformationBarrierSegmentById` in integration tests*

### Arguments

- shieldInformationBarrierSegmentId `string`
  - The ID of the shield information barrier segment. Example: "3423"
- headers `DeleteShieldInformationBarrierSegmentByIdHeadersArg`
  - Headers of deleteShieldInformationBarrierSegmentById method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `null`.

Empty body in response


## List shield information barrier segments

Retrieves a list of shield information barrier segment objects
for the specified Information Barrier ID.

This operation is performed by calling function `GetShieldInformationBarrierSegments`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-shield-information-barrier-segments/).

*Currently we don't have an example for calling `GetShieldInformationBarrierSegments` in integration tests*

### Arguments

- queryParams `GetShieldInformationBarrierSegmentsQueryParamsArg`
  - Query parameters of getShieldInformationBarrierSegments method
- headers `GetShieldInformationBarrierSegmentsHeadersArg`
  - Headers of getShieldInformationBarrierSegments method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `ShieldInformationBarrierSegments`.

Returns a paginated list of shield information barrier segment objects.


## Create shield information barrier segment

Creates a shield information barrier segment.

This operation is performed by calling function `CreateShieldInformationBarrierSegment`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/post-shield-information-barrier-segments/).

*Currently we don't have an example for calling `CreateShieldInformationBarrierSegment` in integration tests*

### Arguments

- requestBody `CreateShieldInformationBarrierSegmentRequestBodyArg`
  - Request body of createShieldInformationBarrierSegment method
- headers `CreateShieldInformationBarrierSegmentHeadersArg`
  - Headers of createShieldInformationBarrierSegment method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `ShieldInformationBarrierSegment`.

Returns a new shield information barrier segment object.


