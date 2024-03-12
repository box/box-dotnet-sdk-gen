
using Box.Sdk.Gen;
using Box.Sdk.Gen.Managers;

var client = new BoxClient(auth: new BoxDeveloperTokenAuth("InsertToken"));

var paginator = await client.RecentItems.GetRecentItemsAsync(new GetRecentItemsQueryParams() { Limit = 1 });
await foreach (var item in paginator)
{
    Console.WriteLine(item.InteractedAt.ToString());
}
