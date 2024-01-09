using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using NullableExtensions;
using StringExtensions;
using Box;
using Box.Schemas;
using Box.Managers;

namespace Box.Tests.Integration {
    [TestClass]
    public class InvitesManagerTests {
        [TestMethod]
        public async System.Threading.Tasks.Task TestInvites() {
            string userId = Utils.GetEnvVar(name: "USER_ID");
            BoxClient client = await new CommonsManager().GetDefaultClientAsUserAsync(userId: userId).ConfigureAwait(false);
            UserFull currentUser = await client.Users.GetUserMeAsync(queryParams: new GetUserMeQueryParams() { Fields = Array.AsReadOnly(new [] {"enterprise"}) }).ConfigureAwait(false);
            string email = Utils.GetEnvVar(name: "BOX_EXTERNAL_USER_EMAIL");
            Invite invitation = await client.Invites.CreateInviteAsync(requestBody: new CreateInviteRequestBody(enterprise: new CreateInviteRequestBodyEnterpriseField(id: NullableUtils.Unwrap(NullableUtils.Unwrap(currentUser.Enterprise).Id)), actionableBy: new CreateInviteRequestBodyActionableByField() { Login = email })).ConfigureAwait(false);
            Assert.IsTrue(StringUtils.ToStringRepresentation(invitation.Type) == "invite");
            Assert.IsTrue(NullableUtils.Unwrap(invitation.InvitedTo).Id == NullableUtils.Unwrap(currentUser.Enterprise).Id);
            Assert.IsTrue(NullableUtils.Unwrap(invitation.ActionableBy).Login == email);
            Invite getInvitation = await client.Invites.GetInviteByIdAsync(inviteId: invitation.Id).ConfigureAwait(false);
            Assert.IsTrue(getInvitation.Id == invitation.Id);
        }

    }
}