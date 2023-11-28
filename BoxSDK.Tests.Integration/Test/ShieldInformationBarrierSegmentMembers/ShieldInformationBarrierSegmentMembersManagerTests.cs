using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            string barrierId = barrier.Id!;
            string segmentName = Utils.GetUUID();
            ShieldInformationBarrierSegment segment = await client.ShieldInformationBarrierSegments.CreateShieldInformationBarrierSegmentAsync(requestBody: new CreateShieldInformationBarrierSegmentRequestBodyArg(shieldInformationBarrier: new ShieldInformationBarrierBase() { Id = barrierId, Type = ShieldInformationBarrierBaseTypeField.ShieldInformationBarrier }, name: segmentName)).ConfigureAwait(false);
            Assert.IsTrue(segment.Name! == segmentName);
            ShieldInformationBarrierSegmentMember segmentMember = await client.ShieldInformationBarrierSegmentMembers.CreateShieldInformationBarrierSegmentMemberAsync(requestBody: new CreateShieldInformationBarrierSegmentMemberRequestBodyArg(shieldInformationBarrierSegment: new CreateShieldInformationBarrierSegmentMemberRequestBodyArgShieldInformationBarrierSegmentField() { Id = segment.Id!, Type = CreateShieldInformationBarrierSegmentMemberRequestBodyArgShieldInformationBarrierSegmentFieldTypeField.ShieldInformationBarrierSegment }, user: new UserBase(id: Utils.GetEnvVar(name: "USER_ID"), type: UserBaseTypeField.User))).ConfigureAwait(false);
            Assert.IsTrue(segmentMember.User!.Id == Utils.GetEnvVar(name: "USER_ID"));
            Assert.IsTrue(segmentMember.ShieldInformationBarrierSegment!.Id == segment.Id!);
            ShieldInformationBarrierSegmentMembers segmentMembers = await client.ShieldInformationBarrierSegmentMembers.GetShieldInformationBarrierSegmentMembersAsync(queryParams: new GetShieldInformationBarrierSegmentMembersQueryParamsArg(shieldInformationBarrierSegmentId: segment.Id!)).ConfigureAwait(false);
            Assert.IsTrue(segmentMembers.Entries!.Count > 0);
            ShieldInformationBarrierSegmentMember segmentMemberGet = await client.ShieldInformationBarrierSegmentMembers.GetShieldInformationBarrierSegmentMemberByIdAsync(shieldInformationBarrierSegmentMemberId: segmentMember.Id!).ConfigureAwait(false);
            Assert.IsTrue(segmentMemberGet.Id! == segmentMember.Id!);
            await client.ShieldInformationBarrierSegmentMembers.DeleteShieldInformationBarrierSegmentMemberByIdAsync(shieldInformationBarrierSegmentMemberId: segmentMember.Id!).ConfigureAwait(false);
            await Assert.That.IsExceptionAsync(async() => await client.ShieldInformationBarrierSegmentMembers.GetShieldInformationBarrierSegmentMemberByIdAsync(shieldInformationBarrierSegmentMemberId: segmentMember.Id!).ConfigureAwait(false));
            await client.ShieldInformationBarrierSegments.DeleteShieldInformationBarrierSegmentByIdAsync(shieldInformationBarrierSegmentId: segment.Id!).ConfigureAwait(false);
        }

    }
}