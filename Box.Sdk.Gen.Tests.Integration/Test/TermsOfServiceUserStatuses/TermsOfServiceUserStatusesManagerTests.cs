using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringExtensions;
using NullableExtensions;
using Box.Sdk.Gen;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen.Managers;

namespace Box.Sdk.Gen.Tests.Integration {
    [TestClass]
    public class TermsOfServiceUserStatusesManagerTests {
        [TestMethod]
        public async System.Threading.Tasks.Task TestGetTermsOfServiceUserStatuses() {
            string adminUserId = Utils.GetEnvVar(name: "USER_ID");
            BoxClient client = new CommonsManager().GetDefaultClientAsUser(userId: adminUserId);
            TermsOfService tos = await new CommonsManager().GetOrCreateTermsOfServicesAsync().ConfigureAwait(false);
            UserFull user = await client.Users.CreateUserAsync(requestBody: new CreateUserRequestBody(name: Utils.GetUUID()) { Login = string.Concat(Utils.GetUUID(), "@boxdemo.com"), IsPlatformAccessOnly = true }).ConfigureAwait(false);
            TermsOfServiceUserStatus createdTosUserStatus = await client.TermsOfServiceUserStatuses.CreateTermsOfServiceStatusForUserAsync(requestBody: new CreateTermsOfServiceStatusForUserRequestBody(tos: new CreateTermsOfServiceStatusForUserRequestBodyTosField(type: CreateTermsOfServiceStatusForUserRequestBodyTosTypeField.TermsOfService, id: tos.Id), user: new CreateTermsOfServiceStatusForUserRequestBodyUserField(type: CreateTermsOfServiceStatusForUserRequestBodyUserTypeField.User, id: user.Id), isAccepted: false)).ConfigureAwait(false);
            Assert.IsTrue(createdTosUserStatus.IsAccepted == false);
            Assert.IsTrue(StringUtils.ToStringRepresentation(createdTosUserStatus.Type) == "terms_of_service_user_status");
            Assert.IsTrue(StringUtils.ToStringRepresentation(NullableUtils.Unwrap(createdTosUserStatus.Tos).Type) == "terms_of_service");
            Assert.IsTrue(StringUtils.ToStringRepresentation(NullableUtils.Unwrap(createdTosUserStatus.User).Type) == "user");
            Assert.IsTrue(NullableUtils.Unwrap(createdTosUserStatus.Tos).Id == tos.Id);
            Assert.IsTrue(NullableUtils.Unwrap(createdTosUserStatus.User).Id == user.Id);
            TermsOfServiceUserStatus updatedTosUserStatus = await client.TermsOfServiceUserStatuses.UpdateTermsOfServiceStatusForUserByIdAsync(termsOfServiceUserStatusId: createdTosUserStatus.Id, requestBody: new UpdateTermsOfServiceStatusForUserByIdRequestBody(isAccepted: true)).ConfigureAwait(false);
            Assert.IsTrue(updatedTosUserStatus.IsAccepted == true);
            TermsOfServiceUserStatuses listTosUserStatuses = await client.TermsOfServiceUserStatuses.GetTermsOfServiceUserStatusesAsync(queryParams: new GetTermsOfServiceUserStatusesQueryParams(tosId: tos.Id) { UserId = user.Id }).ConfigureAwait(false);
            Assert.IsTrue(NullableUtils.Unwrap(listTosUserStatuses.TotalCount) > 0);
            await client.Users.DeleteUserByIdAsync(userId: user.Id).ConfigureAwait(false);
        }

    }
}