using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringExtensions;
using Box.Schemas;
using Box.Managers;
using Box;

namespace Box.Tests.Integration {
    [TestClass]
    public class ShieldInformationBarrierReportsManagerTests {
        [TestMethod]
        public async System.Threading.Tasks.Task ShieldInformationBarrierReports() {
            BoxClient client = await new CommonsManager().GetDefaultClientAsUserAsync(userId: Utils.GetEnvVar(name: "USER_ID")).ConfigureAwait(false);
            string enterpriseId = Utils.GetEnvVar(name: "ENTERPRISE_ID");
            ShieldInformationBarrier barrier = await new CommonsManager().GetOrCreateShieldInformationBarrierAsync(client: client, enterpriseId: enterpriseId).ConfigureAwait(false);
            Assert.IsTrue(StringUtils.ToStringRepresentation(barrier.Status!) == "draft");
            Assert.IsTrue(StringUtils.ToStringRepresentation(barrier.Type!) == "shield_information_barrier");
            Assert.IsTrue(barrier.Enterprise!.Id == enterpriseId);
            Assert.IsTrue(StringUtils.ToStringRepresentation(barrier.Enterprise!.Type) == "enterprise");
            string barrierId = barrier.Id!;
            ShieldInformationBarrierReports existingReports = await client.ShieldInformationBarrierReports.GetShieldInformationBarrierReportsAsync(queryParams: new GetShieldInformationBarrierReportsQueryParamsArg(shieldInformationBarrierId: barrierId)).ConfigureAwait(false);
            if (existingReports.Entries!.Count > 0) {
                return;
            }
            ShieldInformationBarrierReport createdReport = await client.ShieldInformationBarrierReports.CreateShieldInformationBarrierReportAsync(requestBody: new ShieldInformationBarrierReference() { ShieldInformationBarrier = new ShieldInformationBarrierBase() { Id = barrierId, Type = ShieldInformationBarrierBaseTypeField.ShieldInformationBarrier } }).ConfigureAwait(false);
            Assert.IsTrue(createdReport.ShieldInformationBarrier!.ShieldInformationBarrier!.Id == barrierId);
            ShieldInformationBarrierReport retrievedReport = await client.ShieldInformationBarrierReports.GetShieldInformationBarrierReportByIdAsync(shieldInformationBarrierReportId: createdReport.Id!).ConfigureAwait(false);
            Assert.IsTrue(retrievedReport.Id == createdReport.Id);
            ShieldInformationBarrierReports retrievedReports = await client.ShieldInformationBarrierReports.GetShieldInformationBarrierReportsAsync(queryParams: new GetShieldInformationBarrierReportsQueryParamsArg(shieldInformationBarrierId: barrierId)).ConfigureAwait(false);
            Assert.IsTrue(retrievedReports.Entries!.Count > 0);
        }

    }
}