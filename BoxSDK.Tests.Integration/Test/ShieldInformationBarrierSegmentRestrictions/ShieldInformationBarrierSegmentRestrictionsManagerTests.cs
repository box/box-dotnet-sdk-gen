using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Box;
using Box.Schemas;
using Box.Managers;

namespace Box.Tests.Integration {
    [TestClass]
    public class ShieldInformationBarrierSegmentRestrictionsManagerTests {
        [TestMethod]
        public async System.Threading.Tasks.Task TestShieldInformationBarrierSegmentRestrictions() {
            BoxClient client = await new CommonsManager().GetDefaultClientAsUserAsync(userId: Utils.GetEnvVar(name: "USER_ID")).ConfigureAwait(false);
            string enterpriseId = Utils.GetEnvVar(name: "ENTERPRISE_ID");
            ShieldInformationBarrier barrier = await new CommonsManager().GetOrCreateShieldInformationBarrierAsync(client: client, enterpriseId: enterpriseId).ConfigureAwait(false);
            string barrierId = barrier.Id!;
            ShieldInformationBarrierSegment segment = await client.ShieldInformationBarrierSegments.CreateShieldInformationBarrierSegmentAsync(requestBody: new CreateShieldInformationBarrierSegmentRequestBodyArg(shieldInformationBarrier: new ShieldInformationBarrierBase() { Id = barrierId, Type = ShieldInformationBarrierBaseTypeField.ShieldInformationBarrier }, name: Utils.GetUUID()) { Description = "barrier segment description" }).ConfigureAwait(false);
            string segmentId = segment.Id!;
            ShieldInformationBarrierSegment segmentToRestrict = await client.ShieldInformationBarrierSegments.CreateShieldInformationBarrierSegmentAsync(requestBody: new CreateShieldInformationBarrierSegmentRequestBodyArg(shieldInformationBarrier: new ShieldInformationBarrierBase() { Id = barrierId, Type = ShieldInformationBarrierBaseTypeField.ShieldInformationBarrier }, name: Utils.GetUUID()) { Description = "barrier segment description" }).ConfigureAwait(false);
            string segmentToRestrictId = segmentToRestrict.Id!;
            ShieldInformationBarrierSegmentRestriction segmentRestriction = await client.ShieldInformationBarrierSegmentRestrictions.CreateShieldInformationBarrierSegmentRestrictionAsync(requestBody: new CreateShieldInformationBarrierSegmentRestrictionRequestBodyArg(restrictedSegment: new CreateShieldInformationBarrierSegmentRestrictionRequestBodyArgRestrictedSegmentField() { Id = segmentToRestrictId, Type = CreateShieldInformationBarrierSegmentRestrictionRequestBodyArgRestrictedSegmentFieldTypeField.ShieldInformationBarrierSegment }, shieldInformationBarrierSegment: new CreateShieldInformationBarrierSegmentRestrictionRequestBodyArgShieldInformationBarrierSegmentField() { Id = segmentId, Type = CreateShieldInformationBarrierSegmentRestrictionRequestBodyArgShieldInformationBarrierSegmentFieldTypeField.ShieldInformationBarrierSegment }, type: CreateShieldInformationBarrierSegmentRestrictionRequestBodyArgTypeField.ShieldInformationBarrierSegmentRestriction)).ConfigureAwait(false);
            string segmentRestrictionId = segmentRestriction.Id!;
            Assert.IsTrue(segmentRestriction.ShieldInformationBarrierSegment.Id == segmentId);
            ShieldInformationBarrierSegmentRestrictions segmentRestrictions = await client.ShieldInformationBarrierSegmentRestrictions.GetShieldInformationBarrierSegmentRestrictionsAsync(queryParams: new GetShieldInformationBarrierSegmentRestrictionsQueryParamsArg(shieldInformationBarrierSegmentId: segmentId)).ConfigureAwait(false);
            Assert.IsTrue(segmentRestrictions.Entries!.Count > 0);
            ShieldInformationBarrierSegmentRestriction segmentRestrictionFromApi = await client.ShieldInformationBarrierSegmentRestrictions.GetShieldInformationBarrierSegmentRestrictionByIdAsync(shieldInformationBarrierSegmentRestrictionId: segmentRestrictionId).ConfigureAwait(false);
            Assert.IsTrue(segmentRestrictionFromApi.Id! == segmentRestrictionId);
            Assert.IsTrue(segmentRestrictionFromApi.ShieldInformationBarrierSegment.Id == segmentId);
            Assert.IsTrue(segmentRestrictionFromApi.RestrictedSegment.Id == segmentToRestrictId);
            Assert.IsTrue(segmentRestrictionFromApi.ShieldInformationBarrier!.Id == barrierId);
            await client.ShieldInformationBarrierSegmentRestrictions.DeleteShieldInformationBarrierSegmentRestrictionByIdAsync(shieldInformationBarrierSegmentRestrictionId: segmentRestrictionId).ConfigureAwait(false);
            await Assert.That.IsExceptionAsync(async() => await client.ShieldInformationBarrierSegmentRestrictions.GetShieldInformationBarrierSegmentRestrictionByIdAsync(shieldInformationBarrierSegmentRestrictionId: segmentRestrictionId).ConfigureAwait(false));
            await client.ShieldInformationBarrierSegments.DeleteShieldInformationBarrierSegmentByIdAsync(shieldInformationBarrierSegmentId: segmentId).ConfigureAwait(false);
            await client.ShieldInformationBarrierSegments.DeleteShieldInformationBarrierSegmentByIdAsync(shieldInformationBarrierSegmentId: segmentToRestrictId).ConfigureAwait(false);
        }

    }
}