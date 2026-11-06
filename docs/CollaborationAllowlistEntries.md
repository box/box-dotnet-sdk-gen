# ICollaborationAllowlistEntriesManager

<!-- box-dotnet-sdk-gen deprecation banner -->
> [!CAUTION]
> **`box-dotnet-sdk-gen` is deprecated and no longer maintained.** As of September 17, 2025, it receives no new features, bug fixes, or security patches. Do not use it for new projects.
>
> Use [`box-windows-sdk-v2`](https://github.com/box/box-windows-sdk-v2) v10+ instead: `Install-Package Box.V2.Core`.
> The equivalent of this page is [box-windows-sdk-v2/docs/CollaborationAllowlistEntries.md](https://github.com/box/box-windows-sdk-v2/blob/main/docs/CollaborationAllowlistEntries.md). To migrate existing code, see the [migration guide](https://github.com/box/box-windows-sdk-v2/blob/main/migration-guides/from-dotnet-sdk-gen-v1-to-box-windows-sdk.md).


- [List allowed collaboration domains](#list-allowed-collaboration-domains)
- [Add domain to list of allowed collaboration domains](#add-domain-to-list-of-allowed-collaboration-domains)
- [Get allowed collaboration domain](#get-allowed-collaboration-domain)
- [Remove domain from list of allowed collaboration domains](#remove-domain-from-list-of-allowed-collaboration-domains)

## List allowed collaboration domains

Returns the list domains that have been deemed safe to create collaborations
for within the current enterprise.

This operation is performed by calling function `GetCollaborationWhitelistEntries`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-collaboration-whitelist-entries/).

<!-- sample get_collaboration_whitelist_entries -->
```
await client.CollaborationAllowlistEntries.GetCollaborationWhitelistEntriesAsync();
```

### Arguments

- queryParams `GetCollaborationWhitelistEntriesQueryParams`
  - Query parameters of getCollaborationWhitelistEntries method
- headers `GetCollaborationWhitelistEntriesHeaders`
  - Headers of getCollaborationWhitelistEntries method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `CollaborationAllowlistEntries`.

Returns a collection of domains that are allowed for collaboration.


## Add domain to list of allowed collaboration domains

Creates a new entry in the list of allowed domains to allow
collaboration for.

This operation is performed by calling function `CreateCollaborationWhitelistEntry`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/post-collaboration-whitelist-entries/).

<!-- sample post_collaboration_whitelist_entries -->
```
await client.CollaborationAllowlistEntries.CreateCollaborationWhitelistEntryAsync(requestBody: new CreateCollaborationWhitelistEntryRequestBody(direction: CreateCollaborationWhitelistEntryRequestBodyDirectionField.Inbound, domain: domain));
```

### Arguments

- requestBody `CreateCollaborationWhitelistEntryRequestBody`
  - Request body of createCollaborationWhitelistEntry method
- headers `CreateCollaborationWhitelistEntryHeaders`
  - Headers of createCollaborationWhitelistEntry method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `CollaborationAllowlistEntry`.

Returns a new entry on the list of allowed domains.


## Get allowed collaboration domain

Returns a domain that has been deemed safe to create collaborations
for within the current enterprise.

This operation is performed by calling function `GetCollaborationWhitelistEntryById`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-collaboration-whitelist-entries-id/).

<!-- sample get_collaboration_whitelist_entries_id -->
```
await client.CollaborationAllowlistEntries.GetCollaborationWhitelistEntryByIdAsync(collaborationWhitelistEntryId: NullableUtils.Unwrap(newEntry.Id));
```

### Arguments

- collaborationWhitelistEntryId `string`
  - The ID of the entry in the list. Example: "213123"
- headers `GetCollaborationWhitelistEntryByIdHeaders`
  - Headers of getCollaborationWhitelistEntryById method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `CollaborationAllowlistEntry`.

Returns an entry on the list of allowed domains.


## Remove domain from list of allowed collaboration domains

Removes a domain from the list of domains that have been deemed safe to create
collaborations for within the current enterprise.

This operation is performed by calling function `DeleteCollaborationWhitelistEntryById`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/delete-collaboration-whitelist-entries-id/).

<!-- sample delete_collaboration_whitelist_entries_id -->
```
await client.CollaborationAllowlistEntries.DeleteCollaborationWhitelistEntryByIdAsync(collaborationWhitelistEntryId: NullableUtils.Unwrap(entry.Id));
```

### Arguments

- collaborationWhitelistEntryId `string`
  - The ID of the entry in the list. Example: "213123"
- headers `DeleteCollaborationWhitelistEntryByIdHeaders`
  - Headers of deleteCollaborationWhitelistEntryById method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `null`.

A blank response is returned if the entry was
successfully deleted.


