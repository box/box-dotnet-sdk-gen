using Microsoft.VisualStudio.TestTools.UnitTesting;
using NullableExtensions;
using StringExtensions;
using System;
using Box.Sdk.Gen;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen.Managers;

namespace Box.Sdk.Gen.Tests.Integration {
    [TestClass]
    public class ShieldInformationBarrierSegmentsManagerTests {
        [TestMethod]
        public async System.Threading.Tasks.Task TestShieldInformationBarrierSegments() {
            BoxClient client = await new CommonsManager().GetDefaultClientAsUserAsync(userId: Utils.GetEnvVar(name: "USER_ID")).ConfigureAwait(false);
            string enterpriseId = Utils.GetEnvVar(name: "ENTERPRISE_ID");
            ShieldInformationBarrier barrier = await new CommonsManager().GetOrCreateShieldInformationBarrierAsync(client: client, enterpriseId: enterpriseId).ConfigureAwait(false);
            string barrierId = NullableUtils.Unwrap(barrier.Id);
            string segmentName = Utils.GetUUID();
            const string segmentDescription = "barrier segment description";
            ShieldInformationBarrierSegment segment = await client.ShieldInformationBarrierSegments.CreateShieldInformationBarrierSegmentAsync(requestBody: new CreateShieldInformationBarrierSegmentRequestBody(shieldInformationBarrier: new ShieldInformationBarrierBase() { Id = barrierId, Type = ShieldInformationBarrierBaseTypeField.ShieldInformationBarrier }, name: segmentName) { Description = segmentDescription }).ConfigureAwait(false);
            Assert.IsTrue(NullableUtils.Unwrap(segment.Name) == segmentName);
            ShieldInformationBarrierSegments segments = await client.ShieldInformationBarrierSegments.GetShieldInformationBarrierSegmentsAsync(queryParams: new GetShieldInformationBarrierSegmentsQueryParams(shieldInformationBarrierId: barrierId)).ConfigureAwait(false);
            Assert.IsTrue(NullableUtils.Unwrap(segments.Entries).Count > 0);
            string segmentId = NullableUtils.Unwrap(segment.Id);
            ShieldInformationBarrierSegment segmentFromApi = await client.ShieldInformationBarrierSegments.GetShieldInformationBarrierSegmentByIdAsync(shieldInformationBarrierSegmentId: segmentId).ConfigureAwait(false);
            Assert.IsTrue(StringUtils.ToStringRepresentation(NullableUtils.Unwrap(segmentFromApi.Type)) == "shield_information_barrier_segment");
            Assert.IsTrue(NullableUtils.Unwrap(segmentFromApi.Id) == segmentId);
            Assert.IsTrue(NullableUtils.Unwrap(segmentFromApi.Name) == segmentName);
            Assert.IsTrue(NullableUtils.Unwrap(segmentFromApi.Description) == segmentDescription);
            Assert.IsTrue(NullableUtils.Unwrap(segmentFromApi.ShieldInformationBarrier).Id == barrierId);
            const string updatedSegmentDescription = "updated barrier segment description";
            ShieldInformationBarrierSegment updatedSegment = await client.ShieldInformationBarrierSegments.UpdateShieldInformationBarrierSegmentByIdAsync(shieldInformationBarrierSegmentId: segmentId, requestBody: new UpdateShieldInformationBarrierSegmentByIdRequestBody() { Description = updatedSegmentDescription }).ConfigureAwait(false);
            Assert.IsTrue(NullableUtils.Unwrap(updatedSegment.Description) == updatedSegmentDescription);
            await client.ShieldInformationBarrierSegments.DeleteShieldInformationBarrierSegmentByIdAsync(shieldInformationBarrierSegmentId: segmentId).ConfigureAwait(false);
            await Assert.That.IsExceptionAsync(async() => await client.ShieldInformationBarrierSegments.GetShieldInformationBarrierSegmentByIdAsync(shieldInformationBarrierSegmentId: segmentId).ConfigureAwait(false));
        }

    }
}