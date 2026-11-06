# IShieldInformationBarrierReportsManager

<!-- box-dotnet-sdk-gen deprecation banner -->
> [!CAUTION]
> **`box-dotnet-sdk-gen` is deprecated and no longer maintained.** As of September 17, 2025, it receives no new features, bug fixes, or security patches. Do not use it for new projects.
>
> Use [`box-windows-sdk-v2`](https://github.com/box/box-windows-sdk-v2) v10+ instead: `Install-Package Box.V2.Core`.
> The equivalent of this page is [box-windows-sdk-v2/docs/ShieldInformationBarrierReports.md](https://github.com/box/box-windows-sdk-v2/blob/main/docs/ShieldInformationBarrierReports.md). To migrate existing code, see the [migration guide](https://github.com/box/box-windows-sdk-v2/blob/main/migration-guides/from-dotnet-sdk-gen-v1-to-box-windows-sdk.md).


- [List shield information barrier reports](#list-shield-information-barrier-reports)
- [Create shield information barrier report](#create-shield-information-barrier-report)
- [Get shield information barrier report by ID](#get-shield-information-barrier-report-by-id)

## List shield information barrier reports

Lists shield information barrier reports.

This operation is performed by calling function `GetShieldInformationBarrierReports`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-shield-information-barrier-reports/).

<!-- sample get_shield_information_barrier_reports -->
```
await client.ShieldInformationBarrierReports.GetShieldInformationBarrierReportsAsync(queryParams: new GetShieldInformationBarrierReportsQueryParams(shieldInformationBarrierId: barrierId));
```

### Arguments

- queryParams `GetShieldInformationBarrierReportsQueryParams`
  - Query parameters of getShieldInformationBarrierReports method
- headers `GetShieldInformationBarrierReportsHeaders`
  - Headers of getShieldInformationBarrierReports method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `ShieldInformationBarrierReports`.

Returns a paginated list of shield information barrier report objects.


## Create shield information barrier report

Creates a shield information barrier report for a given barrier.

This operation is performed by calling function `CreateShieldInformationBarrierReport`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/post-shield-information-barrier-reports/).

<!-- sample post_shield_information_barrier_reports -->
```
await client.ShieldInformationBarrierReports.CreateShieldInformationBarrierReportAsync(requestBody: new ShieldInformationBarrierReference() { ShieldInformationBarrier = new ShieldInformationBarrierBase() { Id = barrierId, Type = ShieldInformationBarrierBaseTypeField.ShieldInformationBarrier } });
```

### Arguments

- requestBody `ShieldInformationBarrierReference`
  - Request body of createShieldInformationBarrierReport method
- headers `CreateShieldInformationBarrierReportHeaders`
  - Headers of createShieldInformationBarrierReport method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `ShieldInformationBarrierReport`.

Returns the shield information barrier report information object.


## Get shield information barrier report by ID

Retrieves a shield information barrier report by its ID.

This operation is performed by calling function `GetShieldInformationBarrierReportById`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-shield-information-barrier-reports-id/).

<!-- sample get_shield_information_barrier_reports_id -->
```
await client.ShieldInformationBarrierReports.GetShieldInformationBarrierReportByIdAsync(shieldInformationBarrierReportId: NullableUtils.Unwrap(createdReport.Id));
```

### Arguments

- shieldInformationBarrierReportId `string`
  - The ID of the shield information barrier Report. Example: "3423"
- headers `GetShieldInformationBarrierReportByIdHeaders`
  - Headers of getShieldInformationBarrierReportById method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `ShieldInformationBarrierReport`.

Returns the  shield information barrier report object.


