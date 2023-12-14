using Microsoft.VisualStudio.TestTools.UnitTesting;
using NullableExtensions;
using System;
using Box;
using Box.Schemas;
using Box.Managers;

namespace Box.Tests.Integration {
    [TestClass]
    public class ShieldInformationBarrierSegmentMembersManagerTests {
        [TestMethod]
        public async System.Threading.Tasks.Task TestShieldInformationBarrierSegmentMembers() {
            BoxClient client = await new CommonsManager().GetDefaultClientAsUserAsync(userId: Utils.GetEnvVar(name: "USER_ID")).ConfigureAwait(false);
            string enterpriseId = Utils.GetEnvVar(name: "ENTERPRISE_ID");
            ShieldInformationBarrier barrier = await new CommonsManager().GetOrCreateShieldInformationBarrierAsync(client: client, enterpriseId: enterpriseId).ConfigureAwait(false);
            string barrierId = NullableUtils.Unwrap(barrier.Id);
            string segmentName = Utils.GetUUID();
            ShieldInformationBarrierSegment segment = await client.ShieldInformationBarrierSegments.CreateShieldInformationBarrierSegmentAsync(requestBody: new CreateShieldInformationBarrierSegmentRequestBody(shieldInformationBarrier: new ShieldInformationBarrierBase() { Id = barrierId, Type = ShieldInformationBarrierBaseTypeField.ShieldInformationBarrier }, name: segmentName)).ConfigureAwait(false);
            Assert.IsTrue(NullableUtils.Unwrap(segment.Name) == segmentName);
            ShieldInformationBarrierSegmentMember segmentMember = await client.ShieldInformationBarrierSegmentMembers.CreateShieldInformationBarrierSegmentMemberAsync(requestBody: new CreateShieldInformationBarrierSegmentMemberRequestBody(shieldInformationBarrierSegment: new CreateShieldInformationBarrierSegmentMemberRequestBodyShieldInformationBarrierSegmentField() { Id = NullableUtils.Unwrap(segment.Id), Type = CreateShieldInformationBarrierSegmentMemberRequestBodyShieldInformationBarrierSegmentTypeField.ShieldInformationBarrierSegment }, user: new UserBase(id: Utils.GetEnvVar(name: "USER_ID"), type: UserBaseTypeField.User))).ConfigureAwait(false);
            Assert.IsTrue(NullableUtils.Unwrap(segmentMember.User).Id == Utils.GetEnvVar(name: "USER_ID"));
            Assert.IsTrue(NullableUtils.Unwrap(segmentMember.ShieldInformationBarrierSegment).Id == NullableUtils.Unwrap(segment.Id));
            ShieldInformationBarrierSegmentMembers segmentMembers = await client.ShieldInformationBarrierSegmentMembers.GetShieldInformationBarrierSegmentMembersAsync(queryParams: new GetShieldInformationBarrierSegmentMembersQueryParams(shieldInformationBarrierSegmentId: NullableUtils.Unwrap(segment.Id))).ConfigureAwait(false);
            Assert.IsTrue(NullableUtils.Unwrap(segmentMembers.Entries).Count > 0);
            ShieldInformationBarrierSegmentMember segmentMemberGet = await client.ShieldInformationBarrierSegmentMembers.GetShieldInformationBarrierSegmentMemberByIdAsync(shieldInformationBarrierSegmentMemberId: NullableUtils.Unwrap(segmentMember.Id)).ConfigureAwait(false);
            Assert.IsTrue(NullableUtils.Unwrap(segmentMemberGet.Id) == NullableUtils.Unwrap(segmentMember.Id));
            await client.ShieldInformationBarrierSegmentMembers.DeleteShieldInformationBarrierSegmentMemberByIdAsync(shieldInformationBarrierSegmentMemberId: NullableUtils.Unwrap(segmentMember.Id)).ConfigureAwait(false);
            await Assert.That.IsExceptionAsync(async() => await client.ShieldInformationBarrierSegmentMembers.GetShieldInformationBarrierSegmentMemberByIdAsync(shieldInformationBarrierSegmentMemberId: NullableUtils.Unwrap(segmentMember.Id)).ConfigureAwait(false));
            await client.ShieldInformationBarrierSegments.DeleteShieldInformationBarrierSegmentByIdAsync(shieldInformationBarrierSegmentId: NullableUtils.Unwrap(segment.Id)).ConfigureAwait(false);
        }

    }
}