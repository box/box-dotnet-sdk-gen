using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringExtensions;
using System;
using Box;
using Box.Schemas;
using Box.Managers;

namespace Box.Tests.Integration {
    [TestClass]
    public class ShieldInformationBarrierSegmentsManagerTests {
        [TestMethod]
        public async System.Threading.Tasks.Task TestShieldInformationBarrierSegments() {
            BoxClient client = await new CommonsManager().GetDefaultClientAsUserAsync(userId: Utils.GetEnvVar(name: "USER_ID")).ConfigureAwait(false);
            string enterpriseId = Utils.GetEnvVar(name: "ENTERPRISE_ID");
            ShieldInformationBarrier barrier = await new CommonsManager().GetOrCreateShieldInformationBarrierAsync(client: client, enterpriseId: enterpriseId).ConfigureAwait(false);
            string barrierId = barrier.Id!;
            string segmentName = Utils.GetUUID();
            const string segmentDescription = "barrier segment description";
            ShieldInformationBarrierSegment segment = await client.ShieldInformationBarrierSegments.CreateShieldInformationBarrierSegmentAsync(requestBody: new CreateShieldInformationBarrierSegmentRequestBodyArg(shieldInformationBarrier: new ShieldInformationBarrierBase() { Id = barrierId, Type = ShieldInformationBarrierBaseTypeField.ShieldInformationBarrier }, name: segmentName) { Description = segmentDescription }).ConfigureAwait(false);
            Assert.IsTrue(segment.Name! == segmentName);
            ShieldInformationBarrierSegments segments = await client.ShieldInformationBarrierSegments.GetShieldInformationBarrierSegmentsAsync(queryParams: new GetShieldInformationBarrierSegmentsQueryParamsArg(shieldInformationBarrierId: barrierId)).ConfigureAwait(false);
            Assert.IsTrue(segments.Entries!.Count > 0);
            string segmentId = segment.Id!;
            ShieldInformationBarrierSegment segmentFromApi = await client.ShieldInformationBarrierSegments.GetShieldInformationBarrierSegmentByIdAsync(shieldInformationBarrierSegmentId: segmentId).ConfigureAwait(false);
            Assert.IsTrue(StringUtils.ToStringRepresentation(segmentFromApi.Type!) == "shield_information_barrier_segment");
            Assert.IsTrue(segmentFromApi.Id! == segmentId);
            Assert.IsTrue(segmentFromApi.Name! == segmentName);
            Assert.IsTrue(segmentFromApi.Description! == segmentDescription);
            Assert.IsTrue(segmentFromApi.ShieldInformationBarrier!.Id == barrierId);
            const string updatedSegmentDescription = "updated barrier segment description";
            ShieldInformationBarrierSegment updatedSegment = await client.ShieldInformationBarrierSegments.UpdateShieldInformationBarrierSegmentByIdAsync(shieldInformationBarrierSegmentId: segmentId, requestBody: new UpdateShieldInformationBarrierSegmentByIdRequestBodyArg() { Description = updatedSegmentDescription }).ConfigureAwait(false);
            Assert.IsTrue(updatedSegment.Description! == updatedSegmentDescription);
            await client.ShieldInformationBarrierSegments.DeleteShieldInformationBarrierSegmentByIdAsync(shieldInformationBarrierSegmentId: segmentId).ConfigureAwait(false);
            await Assert.That.IsExceptionAsync(async() => await client.ShieldInformationBarrierSegments.GetShieldInformationBarrierSegmentByIdAsync(shieldInformationBarrierSegmentId: segmentId).ConfigureAwait(false));
        }

    }
}