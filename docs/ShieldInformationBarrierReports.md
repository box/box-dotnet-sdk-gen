# IShieldInformationBarrierReportsManager


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
await client.ShieldInformationBarrierReports.GetShieldInformationBarrierReportsAsync(queryParams: new GetShieldInformationBarrierReportsQueryParamsArg(shieldInformationBarrierId: barrierId)).ConfigureAwait(false)
```

### Arguments

- queryParams `GetShieldInformationBarrierReportsQueryParamsArg`
  - Query parameters of getShieldInformationBarrierReports method
- headers `GetShieldInformationBarrierReportsHeadersArg`
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
await client.ShieldInformationBarrierReports.CreateShieldInformationBarrierReportAsync(requestBody: new ShieldInformationBarrierReference(shieldInformationBarrier: new ShieldInformationBarrierBase(id: barrierId, type: ShieldInformationBarrierBaseTypeField.ShieldInformationBarrier))).ConfigureAwait(false)
```

### Arguments

- requestBody `ShieldInformationBarrierReference`
  - Request body of createShieldInformationBarrierReport method
- headers `CreateShieldInformationBarrierReportHeadersArg`
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
await client.ShieldInformationBarrierReports.GetShieldInformationBarrierReportByIdAsync(shieldInformationBarrierReportId: createdReport.Id!).ConfigureAwait(false)
```

### Arguments

- shieldInformationBarrierReportId `string`
  - The ID of the shield information barrier Report. Example: "3423"
- headers `GetShieldInformationBarrierReportByIdHeadersArg`
  - Headers of getShieldInformationBarrierReportById method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `ShieldInformationBarrierReport`.

Returns the  shield information barrier report object.


