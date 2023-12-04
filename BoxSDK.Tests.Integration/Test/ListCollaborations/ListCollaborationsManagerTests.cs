using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringExtensions;
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
            GroupFull group = await client.Groups.CreateGroupAsync(requestBody: new CreateGroupRequestBodyArg(name: Utils.GetUUID())).ConfigureAwait(false);
            Collaboration groupCollaboration = await client.UserCollaborations.CreateCollaborationAsync(requestBody: new CreateCollaborationRequestBodyArg(item: new CreateCollaborationRequestBodyArgItemField() { Type = CreateCollaborationRequestBodyArgItemFieldTypeField.Folder, Id = folder.Id }, accessibleBy: new CreateCollaborationRequestBodyArgAccessibleByField(type: CreateCollaborationRequestBodyArgAccessibleByFieldTypeField.Group) { Id = group.Id }, role: CreateCollaborationRequestBodyArgRoleField.Editor)).ConfigureAwait(false);
            Collaboration fileCollaboration = await client.UserCollaborations.CreateCollaborationAsync(requestBody: new CreateCollaborationRequestBodyArg(item: new CreateCollaborationRequestBodyArgItemField() { Type = CreateCollaborationRequestBodyArgItemFieldTypeField.File, Id = file.Id }, accessibleBy: new CreateCollaborationRequestBodyArgAccessibleByField(type: CreateCollaborationRequestBodyArgAccessibleByFieldTypeField.User) { Id = Utils.GetEnvVar(name: "USER_ID") }, role: CreateCollaborationRequestBodyArgRoleField.Editor)).ConfigureAwait(false);
            Assert.IsTrue(StringUtils.ToStringRepresentation(groupCollaboration.Role) == "editor");
            Assert.IsTrue(StringUtils.ToStringRepresentation(groupCollaboration.Type) == "collaboration");
            Collaborations fileCollaborations = await client.ListCollaborations.GetFileCollaborationsAsync(fileId: file.Id).ConfigureAwait(false);
            Assert.IsTrue(fileCollaborations.Entries!.Count > 0);
            Collaborations folderCollaborations = await client.ListCollaborations.GetFolderCollaborationsAsync(folderId: folder.Id).ConfigureAwait(false);
            Assert.IsTrue(folderCollaborations.Entries!.Count > 0);
            Collaborations pendingCollaborations = await client.ListCollaborations.GetCollaborationsAsync(queryParams: new GetCollaborationsQueryParamsArg(status: GetCollaborationsQueryParamsArgStatusField.Pending)).ConfigureAwait(false);
            Assert.IsTrue(pendingCollaborations.Entries!.Count >= 0);
            Collaborations groupCollaborations = await client.ListCollaborations.GetGroupCollaborationsAsync(groupId: group.Id).ConfigureAwait(false);
            Assert.IsTrue(groupCollaborations.Entries!.Count > 0);
            await client.UserCollaborations.DeleteCollaborationByIdAsync(collaborationId: groupCollaboration.Id).ConfigureAwait(false);
            await client.Files.DeleteFileByIdAsync(fileId: file.Id).ConfigureAwait(false);
            await client.Folders.DeleteFolderByIdAsync(folderId: folder.Id).ConfigureAwait(false);
            await client.Groups.DeleteGroupByIdAsync(groupId: group.Id).ConfigureAwait(false);
        }

    }
}