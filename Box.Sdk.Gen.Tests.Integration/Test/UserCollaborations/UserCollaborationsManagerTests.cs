using Microsoft.VisualStudio.TestTools.UnitTesting;
using NullableExtensions;
using StringExtensions;
using System;
using Box.Sdk.Gen;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen.Managers;

namespace Box.Sdk.Gen.Tests.Integration {
    [TestClass]
    public class UserCollaborationsManagerTests {
        public BoxClient client { get; }

        public UserCollaborationsManagerTests() {
            client = new CommonsManager().GetDefaultClient();
        }
        [TestMethod]
        public async System.Threading.Tasks.Task TestUserCollaborations() {
            string userName = Utils.GetUUID();
            string userLogin = string.Concat(Utils.GetUUID(), "@gmail.com");
            UserFull user = await client.Users.CreateUserAsync(requestBody: new CreateUserRequestBody(name: userName) { Login = userLogin, IsPlatformAccessOnly = true }).ConfigureAwait(false);
            FolderFull folder = await new CommonsManager().CreateNewFolderAsync().ConfigureAwait(false);
            Collaboration collaboration = await client.UserCollaborations.CreateCollaborationAsync(requestBody: new CreateCollaborationRequestBody(item: new CreateCollaborationRequestBodyItemField() { Type = CreateCollaborationRequestBodyItemTypeField.Folder, Id = folder.Id }, accessibleBy: new CreateCollaborationRequestBodyAccessibleByField(type: CreateCollaborationRequestBodyAccessibleByTypeField.User) { Id = user.Id }, role: CreateCollaborationRequestBodyRoleField.Editor)).ConfigureAwait(false);
            Assert.IsTrue(StringUtils.ToStringRepresentation(NullableUtils.Unwrap(collaboration.Role)) == "editor");
            string collaborationId = collaboration.Id;
            Collaboration collaborationFromApi = await client.UserCollaborations.GetCollaborationByIdAsync(collaborationId: collaborationId).ConfigureAwait(false);
            Assert.IsTrue(collaborationId == collaborationFromApi.Id);
            Assert.IsTrue(StringUtils.ToStringRepresentation(NullableUtils.Unwrap(collaborationFromApi.Status)) == "accepted");
            Assert.IsTrue(StringUtils.ToStringRepresentation(collaborationFromApi.Type) == "collaboration");
            Assert.IsTrue(collaborationFromApi.InviteEmail == null);
            Collaboration updatedCollaboration = await client.UserCollaborations.UpdateCollaborationByIdAsync(collaborationId: collaborationId, requestBody: new UpdateCollaborationByIdRequestBody(role: UpdateCollaborationByIdRequestBodyRoleField.Viewer)).ConfigureAwait(false);
            Assert.IsTrue(StringUtils.ToStringRepresentation(NullableUtils.Unwrap(updatedCollaboration.Role)) == "viewer");
            await client.UserCollaborations.DeleteCollaborationByIdAsync(collaborationId: collaborationId).ConfigureAwait(false);
            await Assert.That.IsExceptionAsync(async() => await client.UserCollaborations.GetCollaborationByIdAsync(collaborationId: collaborationId).ConfigureAwait(false));
            await client.Folders.DeleteFolderByIdAsync(folderId: folder.Id).ConfigureAwait(false);
            await client.Users.DeleteUserByIdAsync(userId: user.Id).ConfigureAwait(false);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestExternalUserCollaborations() {
            string userName = Utils.GetUUID();
            string userLogin = string.Concat(Utils.GetUUID(), "@boxdemo.com");
            FolderFull folder = await new CommonsManager().CreateNewFolderAsync().ConfigureAwait(false);
            Collaboration collaboration = await client.UserCollaborations.CreateCollaborationAsync(requestBody: new CreateCollaborationRequestBody(item: new CreateCollaborationRequestBodyItemField() { Type = CreateCollaborationRequestBodyItemTypeField.Folder, Id = folder.Id }, accessibleBy: new CreateCollaborationRequestBodyAccessibleByField(type: CreateCollaborationRequestBodyAccessibleByTypeField.User) { Login = userLogin }, role: CreateCollaborationRequestBodyRoleField.Editor)).ConfigureAwait(false);
            Assert.IsTrue(StringUtils.ToStringRepresentation(NullableUtils.Unwrap(collaboration.Role)) == "editor");
            string collaborationId = collaboration.Id;
            Collaboration collaborationFromApi = await client.UserCollaborations.GetCollaborationByIdAsync(collaborationId: collaborationId).ConfigureAwait(false);
            Assert.IsTrue(collaborationId == collaborationFromApi.Id);
            Assert.IsTrue(StringUtils.ToStringRepresentation(NullableUtils.Unwrap(collaborationFromApi.Status)) == "pending");
            Assert.IsTrue(StringUtils.ToStringRepresentation(collaborationFromApi.Type) == "collaboration");
            Assert.IsTrue(collaborationFromApi.InviteEmail == userLogin);
            Collaboration updatedCollaboration = await client.UserCollaborations.UpdateCollaborationByIdAsync(collaborationId: collaborationId, requestBody: new UpdateCollaborationByIdRequestBody(role: UpdateCollaborationByIdRequestBodyRoleField.Viewer)).ConfigureAwait(false);
            Assert.IsTrue(StringUtils.ToStringRepresentation(NullableUtils.Unwrap(updatedCollaboration.Role)) == "viewer");
            await client.UserCollaborations.DeleteCollaborationByIdAsync(collaborationId: collaborationId).ConfigureAwait(false);
            await Assert.That.IsExceptionAsync(async() => await client.UserCollaborations.GetCollaborationByIdAsync(collaborationId: collaborationId).ConfigureAwait(false));
            await client.Folders.DeleteFolderByIdAsync(folderId: folder.Id).ConfigureAwait(false);
        }

    }
}