# ShieldInformationBarrierSegmentMembersManager


- [Get shield information barrier segment member by ID](#get-shield-information-barrier-segment-member-by-id)
- [Delete shield information barrier segment member by ID](#delete-shield-information-barrier-segment-member-by-id)
- [List shield information barrier segment members](#list-shield-information-barrier-segment-members)
- [Create shield information barrier segment member](#create-shield-information-barrier-segment-member)

## Get shield information barrier segment member by ID

Retrieves a shield information barrier
segment member by its ID.

This operation is performed by calling function `GetShieldInformationBarrierSegmentMemberById`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-shield-information-barrier-segment-members-id/).

*Currently we don't have an example for calling `GetShieldInformationBarrierSegmentMemberById` in integration tests*

### Arguments

- shieldInformationBarrierSegmentMemberId `string`
  - The ID of the shield information barrier segment Member. Example: "7815"
- headers `GetShieldInformationBarrierSegmentMemberByIdHeadersArg`
  - Headers of getShieldInformationBarrierSegmentMemberById method


### Returns

This function returns a value of type `ShieldInformationBarrierSegmentMember`.

Returns the shield information barrier segment member object.


## Delete shield information barrier segment member by ID

Deletes a shield information barrier
segment member based on provided ID.

This operation is performed by calling function `DeleteShieldInformationBarrierSegmentMemberById`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/delete-shield-information-barrier-segment-members-id/).

*Currently we don't have an example for calling `DeleteShieldInformationBarrierSegmentMemberById` in integration tests*

### Arguments

- shieldInformationBarrierSegmentMemberId `string`
  - The ID of the shield information barrier segment Member. Example: "7815"
- headers `DeleteShieldInformationBarrierSegmentMemberByIdHeadersArg`
  - Headers of deleteShieldInformationBarrierSegmentMemberById method


### Returns

This function returns a value of type `null`.

Returns an empty response if the
segment member was deleted successfully.


## List shield information barrier segment members

Lists shield information barrier segment members
based on provided segment IDs.

This operation is performed by calling function `GetShieldInformationBarrierSegmentMembers`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-shield-information-barrier-segment-members/).

*Currently we don't have an example for calling `GetShieldInformationBarrierSegmentMembers` in integration tests*

### Arguments

- queryParams `GetShieldInformationBarrierSegmentMembersQueryParamsArg`
  - Query parameters of getShieldInformationBarrierSegmentMembers method
- headers `GetShieldInformationBarrierSegmentMembersHeadersArg`
  - Headers of getShieldInformationBarrierSegmentMembers method


### Returns

This function returns a value of type `ShieldInformationBarrierSegmentMembers`.

Returns a paginated list of
shield information barrier segment member objects.


## Create shield information barrier segment member

Creates a new shield information barrier segment member.

This operation is performed by calling function `CreateShieldInformationBarrierSegmentMember`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/post-shield-information-barrier-segment-members/).

*Currently we don't have an example for calling `CreateShieldInformationBarrierSegmentMember` in integration tests*

### Arguments

- requestBody `CreateShieldInformationBarrierSegmentMemberRequestBodyArg`
  - Request body of createShieldInformationBarrierSegmentMember method
- headers `CreateShieldInformationBarrierSegmentMemberHeadersArg`
  - Headers of createShieldInformationBarrierSegmentMember method


### Returns

This function returns a value of type `ShieldInformationBarrierSegmentMember`.

Returns a new shield information barrier segment member object.


