# ISearchManager


- [Query files/folders by metadata](#query-files-folders-by-metadata)
- [List metadata query indices](#list-metadata-query-indices)
- [Search for content](#search-for-content)

## Query files/folders by metadata

Create a search using SQL-like syntax to return items that match specific
metadata.

By default, this endpoint returns only the most basic info about the items for
which the query matches. To get additional fields for each item, including any
of the metadata, use the `fields` attribute in the query.

This operation is performed by calling function `SearchByMetadataQuery`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/post-metadata-queries-execute-read/).

*Currently we don't have an example for calling `SearchByMetadataQuery` in integration tests*

### Arguments

- requestBody `MetadataQuery`
  - Request body of searchByMetadataQuery method
- headers `SearchByMetadataQueryHeaders`
  - Headers of searchByMetadataQuery method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `MetadataQueryResults`.

Returns a list of files and folders that match this metadata query.


## List metadata query indices

Retrieves the metadata query indices for a given scope and template key.

This operation is performed by calling function `GetMetadataQueryIndices`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-metadata-query-indices/).

*Currently we don't have an example for calling `GetMetadataQueryIndices` in integration tests*

### Arguments

- queryParams `GetMetadataQueryIndicesQueryParams`
  - Query parameters of getMetadataQueryIndices method
- headers `GetMetadataQueryIndicesHeaders`
  - Headers of getMetadataQueryIndices method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `MetadataQueryIndices`.

Returns a collection of metadata query indices for scope and template key.


## Search for content

Searches for files, folders, web links, and shared files across the
users content or across the entire enterprise.

This operation is performed by calling function `SearchForContent`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-search/).

*Currently we don't have an example for calling `SearchForContent` in integration tests*

### Arguments

- queryParams `SearchForContentQueryParams`
  - Query parameters of searchForContent method
- headers `SearchForContentHeaders`
  - Headers of searchForContent method
- cancellationToken `System.Threading.CancellationToken?`
  - Token used for request cancellation.


### Returns

This function returns a value of type `SearchResultsOrSearchResultsWithSharedLinks`.

Returns a collection of search results. If there are no matching
search results, the `entries` array will be empty.


