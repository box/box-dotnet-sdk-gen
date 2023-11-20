using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringExtensions;
using System;
using Box;
using Box.Schemas;
using Box.Managers;

namespace Box.Tests.Integration {
    [TestClass]
    public class SharedLinksFoldersManagerTests {
        public BoxClient client { get; }

        public SharedLinksFoldersManagerTests() {
            client = new CommonsManager().GetDefaultClient();
        }
        [TestMethod]
        public async System.Threading.Tasks.Task TestSharedLinksFolders() {
            FolderFull folder = await client.Folders.CreateFolderAsync(requestBody: new CreateFolderRequestBodyArg(name: Utils.GetUUID(), parent: new CreateFolderRequestBodyArgParentField(id: "0"))).ConfigureAwait(false);
            await client.SharedLinksFolders.UpdateFolderAddSharedLinkAsync(folderId: folder.Id, requestBody: new UpdateFolderAddSharedLinkRequestBodyArg() { SharedLink = new UpdateFolderAddSharedLinkRequestBodyArgSharedLinkField() { Access = UpdateFolderAddSharedLinkRequestBodyArgSharedLinkFieldAccessField.Open, Password = "Secret123@" } }, queryParams: new UpdateFolderAddSharedLinkQueryParamsArg(fields: "shared_link")).ConfigureAwait(false);
            FolderFull folderFromApi = await client.SharedLinksFolders.GetFolderGetSharedLinkAsync(folderId: folder.Id, queryParams: new GetFolderGetSharedLinkQueryParamsArg(fields: "shared_link")).ConfigureAwait(false);
            Assert.IsTrue(StringUtils.ToStringRepresentation(folderFromApi.SharedLink!.Access) == "open");
            string userId = Utils.GetEnvVar(name: "USER_ID");
            BoxClient userClient = await new CommonsManager().GetDefaultClientAsUserAsync(userId: userId).ConfigureAwait(false);
            FolderFull folderFromSharedLinkPassword = await userClient.SharedLinksFolders.GetSharedItemFoldersAsync(queryParams: new GetSharedItemFoldersQueryParamsArg(), headers: new GetSharedItemFoldersHeadersArg(boxapi: string.Concat("shared_link=", folderFromApi.SharedLink!.Url, "&shared_link_password=Secret123@"))).ConfigureAwait(false);
            Assert.IsTrue(folder.Id == folderFromSharedLinkPassword.Id);
            await Assert.That.IsExceptionAsync(async() => await userClient.SharedLinksFolders.GetSharedItemFoldersAsync(queryParams: new GetSharedItemFoldersQueryParamsArg(), headers: new GetSharedItemFoldersHeadersArg(boxapi: string.Concat("shared_link=", folderFromApi.SharedLink!.Url, "&shared_link_password=incorrectPassword"))).ConfigureAwait(false));
            FolderFull updatedFolder = await client.SharedLinksFolders.UpdateFolderUpdateSharedLinkAsync(folderId: folder.Id, requestBody: new UpdateFolderUpdateSharedLinkRequestBodyArg() { SharedLink = new UpdateFolderUpdateSharedLinkRequestBodyArgSharedLinkField() { Access = UpdateFolderUpdateSharedLinkRequestBodyArgSharedLinkFieldAccessField.Collaborators } }, queryParams: new UpdateFolderUpdateSharedLinkQueryParamsArg(fields: "shared_link")).ConfigureAwait(false);
            Assert.IsTrue(StringUtils.ToStringRepresentation(updatedFolder.SharedLink!.Access) == "collaborators");
            await client.Folders.DeleteFolderByIdAsync(folderId: folder.Id).ConfigureAwait(false);
        }

    }
}