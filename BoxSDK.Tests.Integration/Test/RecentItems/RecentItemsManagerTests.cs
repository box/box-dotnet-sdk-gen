using Microsoft.VisualStudio.TestTools.UnitTesting;
using NullableExtensions;
using Box;
using Box.Schemas;

namespace Box.Tests.Integration {
    [TestClass]
    public class RecentItemsManagerTests {
        [TestMethod]
        public async System.Threading.Tasks.Task TestRecentItems() {
            BoxClient client = await new CommonsManager().GetDefaultClientAsUserAsync(userId: Utils.GetEnvVar(name: "USER_ID")).ConfigureAwait(false);
            RecentItems recentItems = await client.RecentItems.GetRecentItemsAsync().ConfigureAwait(false);
            Assert.IsTrue(NullableUtils.Unwrap(recentItems.Entries).Count >= 0);
        }

    }
}