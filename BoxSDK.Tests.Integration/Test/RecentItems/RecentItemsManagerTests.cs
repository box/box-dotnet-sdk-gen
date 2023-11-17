using Microsoft.VisualStudio.TestTools.UnitTesting;
using Box;
using Box.Schemas;

namespace Box.Tests.Integration {
    [TestClass]
    public class RecentItemsManagerTests {
        [TestMethod]
        public async System.Threading.Tasks.Task TestRecentItems() {
            BoxClient client = await new CommonsManager().GetDefaultClientAsUserAsync(Utils.GetEnvVar("USER_ID")).ConfigureAwait(false);
            RecentItems recentItems = await client.RecentItems.GetRecentItemsAsync().ConfigureAwait(false);
            Assert.IsTrue(recentItems.Entries!.Count >= 0);
        }

    }
}