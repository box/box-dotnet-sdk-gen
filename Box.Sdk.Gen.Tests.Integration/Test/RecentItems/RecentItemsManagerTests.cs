using Microsoft.VisualStudio.TestTools.UnitTesting;
using NullableExtensions;

namespace Box.Sdk.Gen.Tests.Integration
{
    [TestClass]
    public class RecentItemsManagerTests
    {
        [TestMethod]
        public async System.Threading.Tasks.Task TestRecentItems()
        {
            BoxClient client = new CommonsManager().GetDefaultClientAsUser(userId: Utils.GetEnvVar(name: "USER_ID"));
            RecentItemsPaginator recentItems = await client.RecentItems.GetRecentItemsAsync().ConfigureAwait(false);
            Assert.IsTrue(NullableUtils.Unwrap(recentItems.Entries).Count >= 0);
        }

    }
}