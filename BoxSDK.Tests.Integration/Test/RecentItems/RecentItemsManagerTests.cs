using Microsoft.VisualStudio.TestTools.UnitTesting;
using Box.Schemas;
using Box;

namespace Box.Tests.Integration {
    [TestClass]
    public class RecentItemsManagerTests {
        public JwtConfig jwtConfig { get; }

        public BoxJwtAuth auth { get; }

        public RecentItemsManagerTests() {
            jwtConfig = JwtConfig.FromConfigJsonString(Utils.DecodeBase64(Utils.GetEnvVar("JWT_CONFIG_BASE_64")));
            auth = new BoxJwtAuth(config: jwtConfig);
        }
        [TestMethod]
        public async System.Threading.Tasks.Task TestRecentItems() {
            await auth.AsUser(Utils.GetEnvVar("USER_ID"));
            BoxClient client = new BoxClient(auth: auth);
            RecentItems recentItems = await client.RecentItems.GetRecentItems();
            Assert.IsTrue(recentItems.Entries.Count >= 0);
        }

    }
}