using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringExtensions;
using System;
using Box.Schemas;
using Box.Managers;
using Box;

namespace Box.Tests.Integration {
    [TestClass]
    public class ShieldInformationBarriersManagerTests {
        public async System.Threading.Tasks.Task<ShieldInformationBarrier> GetOrCreateShieldInformationBarrierAsync(BoxClient client, string enterpriseId) {
            ShieldInformationBarriers barriers = await client.ShieldInformationBarriers.GetShieldInformationBarriersAsync().ConfigureAwait(false);
            int numberOfBarriers = barriers.Entries!.Count;
            if (numberOfBarriers == 0) {
                return await client.ShieldInformationBarriers.CreateShieldInformationBarrierAsync(requestBody: new CreateShieldInformationBarrierRequestBodyArg(enterprise: new EnterpriseBase() { Id = enterpriseId, Type = EnterpriseBaseTypeField.Enterprise })).ConfigureAwait(false);
            }
            return barriers.Entries!.ElementAt(numberOfBarriers - 1);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestShieldInformationBarriers() {
            BoxClient client = await new CommonsManager().GetDefaultClientAsUserAsync(userId: Utils.GetEnvVar(name: "USER_ID")).ConfigureAwait(false);
            string enterpriseId = Utils.GetEnvVar(name: "ENTERPRISE_ID");
            ShieldInformationBarrier barrier = await GetOrCreateShieldInformationBarrierAsync(client: client, enterpriseId: enterpriseId).ConfigureAwait(false);
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