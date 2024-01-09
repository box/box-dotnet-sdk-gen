using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringExtensions;
using NullableExtensions;
using Box;
using Box.Schemas;
using Box.Managers;

namespace Box.Tests.Integration {
    [TestClass]
    public class ListCollaborationsManagerTests {
        [TestMethod]
        public async System.Threading.Tasks.Task TestListCollaborations() {
            BoxClient client = new CommonsManager().GetDefaultClient();
            FolderFull folder = await new CommonsManager().CreateNewFolderAsync().ConfigureAwait(false);
            FileFull file = await new CommonsManager().UploadNewFileAsync().ConfigureAwait(false);
            GroupFull group = await client.Groups.CreateGroupAsync(requestBody: new CreateGroupRequestBody(name: Utils.GetUUID())).ConfigureAwait(false);
            Collaboration groupCollaboration = await client.UserCollaborations.CreateCollaborationAsync(requestBody: new CreateCollaborationRequestBody(item: new CreateCollaborationRequestBodyItemField() { Type = CreateCollaborationRequestBodyItemTypeField.Folder, Id = folder.Id }, accessibleBy: new CreateCollaborationRequestBodyAccessibleByField(type: CreateCollaborationRequestBodyAccessibleByTypeField.Group) { Id = group.Id }, role: CreateCollaborationRequestBodyRoleField.Editor)).ConfigureAwait(false);
            Collaboration fileCollaboration = await client.UserCollaborations.CreateCollaborationAsync(requestBody: new CreateCollaborationRequestBody(item: new CreateCollaborationRequestBodyItemField() { Type = CreateCollaborationRequestBodyItemTypeField.File, Id = file.Id }, accessibleBy: new CreateCollaborationRequestBodyAccessibleByField(type: CreateCollaborationRequestBodyAccessibleByTypeField.User) { Id = Utils.GetEnvVar(name: "USER_ID") }, role: CreateCollaborationRequestBodyRoleField.Editor)).ConfigureAwait(false);
            Assert.IsTrue(StringUtils.ToStringRepresentation(groupCollaboration.Role) == "editor");
            Assert.IsTrue(StringUtils.ToStringRepresentation(groupCollaboration.Type) == "collaboration");
            Collaborations fileCollaborations = await client.ListCollaborations.GetFileCollaborationsAsync(fileId: file.Id).ConfigureAwait(false);
            Assert.IsTrue(NullableUtils.Unwrap(fileCollaborations.Entries).Count > 0);
            Collaborations folderCollaborations = await client.ListCollaborations.GetFolderCollaborationsAsync(folderId: folder.Id).ConfigureAwait(false);
            Assert.IsTrue(NullableUtils.Unwrap(folderCollaborations.Entries).Count > 0);
            Collaborations pendingCollaborations = await client.ListCollaborations.GetCollaborationsAsync(queryParams: new GetCollaborationsQueryParams(status: GetCollaborationsQueryParamsStatusField.Pending)).ConfigureAwait(false);
            Assert.IsTrue(NullableUtils.Unwrap(pendingCollaborations.Entries).Count >= 0);
            Collaborations groupCollaborations = await client.ListCollaborations.GetGroupCollaborationsAsync(groupId: group.Id).ConfigureAwait(false);
            Assert.IsTrue(NullableUtils.Unwrap(groupCollaborations.Entries).Count > 0);
            await client.UserCollaborations.DeleteCollaborationByIdAsync(collaborationId: groupCollaboration.Id).ConfigureAwait(false);
            await client.Files.DeleteFileByIdAsync(fileId: file.Id).ConfigureAwait(false);
            await client.Folders.DeleteFolderByIdAsync(folderId: folder.Id).ConfigureAwait(false);
            await client.Groups.DeleteGroupByIdAsync(groupId: group.Id).ConfigureAwait(false);
        }

    }
}