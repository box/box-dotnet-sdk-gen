using Microsoft.VisualStudio.TestTools.UnitTesting;
using Box.Sdk.Gen.Internal;
using System.Linq;
using Box.Sdk.Gen;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen.Managers;

namespace Box.Sdk.Gen.Tests.Integration {
    [TestClass]
    public class HubsManagerTests {
        public BoxClient client { get; }

        public HubsManagerTests() {
            client = new CommonsManager().GetDefaultClientWithUserSubject(userId: Utils.GetEnvVar(name: "USER_ID"));
        }
        [RetryableTest]
        public async System.Threading.Tasks.Task TestGetAndDeleteHubs() {
            HubsV2025R0 userHubs = await client.Hubs.GetHubsV2025R0Async(queryParams: new GetHubsV2025R0QueryParams() { Scope = "all", Sort = "name", Direction = GetHubsV2025R0QueryParamsDirectionField.Asc });
            Assert.IsTrue(NullableUtils.Unwrap(userHubs.Entries).Count > 0);
            HubV2025R0 userHub = NullableUtils.Unwrap(userHubs.Entries).ElementAt(0);
            Assert.IsTrue(userHub.Title != "");
            Assert.IsTrue(userHub.Id != "");
            Assert.IsTrue(StringUtils.ToStringRepresentation(userHub.Type?.Value) == "hubs");
            HubsV2025R0 enterpriseHubs = await client.Hubs.GetEnterpriseHubsV2025R0Async(queryParams: new GetEnterpriseHubsV2025R0QueryParams() { Sort = "name", Direction = GetEnterpriseHubsV2025R0QueryParamsDirectionField.Asc });
            Assert.IsTrue(NullableUtils.Unwrap(enterpriseHubs.Entries).Count > 0);
            HubV2025R0 enterpriseHub = NullableUtils.Unwrap(enterpriseHubs.Entries).ElementAt(0);
            Assert.IsTrue(enterpriseHub.Title != "");
            Assert.IsTrue(enterpriseHub.Id != "");
            Assert.IsTrue(StringUtils.ToStringRepresentation(enterpriseHub.Type?.Value) == "hubs");
            HubV2025R0 hub = await client.Hubs.GetHubByIdV2025R0Async(hubId: userHub.Id);
            Assert.IsTrue(hub.Title != "");
            Assert.IsTrue(hub.Id != "");
            Assert.IsTrue(StringUtils.ToStringRepresentation(hub.Type?.Value) == "hubs");
            if (NullableUtils.Unwrap(enterpriseHubs.Entries).Count > 10) {
                await client.Hubs.DeleteHubByIdV2025R0Async(hubId: hub.Id);
            }
        }

    }
}