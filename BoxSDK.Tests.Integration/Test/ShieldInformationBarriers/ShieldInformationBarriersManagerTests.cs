using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringExtensions;
using System;
using Box;
using Box.Schemas;
using Box.Managers;

namespace Box.Tests.Integration {
    [TestClass]
    public class ShieldInformationBarriersManagerTests {
        [TestMethod]
        public async System.Threading.Tasks.Task TestShieldInformationBarriers() {
            BoxClient client = await new CommonsManager().GetDefaultClientAsUserAsync(userId: Utils.GetEnvVar(name: "USER_ID")).ConfigureAwait(false);
            string enterpriseId = Utils.GetEnvVar(name: "ENTERPRISE_ID");
            ShieldInformationBarrier barrier = await new CommonsManager().GetOrCreateShieldInformationBarrierAsync(client: client, enterpriseId: enterpriseId).ConfigureAwait(false);
            Assert.IsTrue(StringUtils.ToStringRepresentation(barrier.Status!) == "draft");
            Assert.IsTrue(StringUtils.ToStringRepresentation(barrier.Type!) == "shield_information_barrier");
            Assert.IsTrue(barrier.Enterprise!.Id == enterpriseId);
            Assert.IsTrue(StringUtils.ToStringRepresentation(barrier.Enterprise!.Type) == "enterprise");
            string barrierId = barrier.Id!;
            ShieldInformationBarrier barrierFromApi = await client.ShieldInformationBarriers.GetShieldInformationBarrierByIdAsync(shieldInformationBarrierId: barrierId).ConfigureAwait(false);
            Assert.IsTrue(barrierFromApi.Id! == barrierId);
            ShieldInformationBarriers barriers = await client.ShieldInformationBarriers.GetShieldInformationBarriersAsync().ConfigureAwait(false);
            Assert.IsTrue(barriers.Entries!.Count == 1);
            await Assert.That.IsExceptionAsync(async() => await client.ShieldInformationBarriers.CreateShieldInformationBarrierChangeStatusAsync(requestBody: new CreateShieldInformationBarrierChangeStatusRequestBodyArg(id: barrierId, status: CreateShieldInformationBarrierChangeStatusRequestBodyArgStatusField.Disabled)).ConfigureAwait(false));
        }

    }
}