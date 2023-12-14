using Microsoft.VisualStudio.TestTools.UnitTesting;
using NullableExtensions;
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
            FolderFull folder = await client.Folders.CreateFolderAsync(requestBody: new CreateFolderRequestBody(name: Utils.GetUUID(), parent: new CreateFolderRequestBodyParentField(id: "0"))).ConfigureAwait(false);
            await client.SharedLinksFolders.UpdateFolderAddSharedLinkAsync(folderId: folder.Id, requestBody: new UpdateFolderAddSharedLinkRequestBody() { SharedLink = new UpdateFolderAddSharedLinkRequestBodySharedLinkField() { Access = UpdateFolderAddSharedLinkRequestBodySharedLinkAccessField.Open, Password = "Secret123@" } }, queryParams: new UpdateFolderAddSharedLinkQueryParams(fields: "shared_link")).ConfigureAwait(false);
            FolderFull folderFromApi = await client.SharedLinksFolders.GetFolderGetSharedLinkAsync(folderId: folder.Id, queryParams: new GetFolderGetSharedLinkQueryParams(fields: "shared_link")).ConfigureAwait(false);
            Assert.IsTrue(StringUtils.ToStringRepresentation(NullableUtils.Unwrap(folderFromApi.SharedLink).Access) == "open");
            string userId = Utils.GetEnvVar(name: "USER_ID");
            BoxClient userClient = await new CommonsManager().GetDefaultClientAsUserAsync(userId: userId).ConfigureAwait(false);
            FolderFull folderFromSharedLinkPassword = await userClient.SharedLinksFolders.GetSharedItemFoldersAsync(queryParams: new GetSharedItemFoldersQueryParams(), headers: new GetSharedItemFoldersHeaders(boxapi: string.Concat("shared_link=", NullableUtils.Unwrap(folderFromApi.SharedLink).Url, "&shared_link_password=Secret123@"))).ConfigureAwait(false);
            Assert.IsTrue(folder.Id == folderFromSharedLinkPassword.Id);
            await Assert.That.IsExceptionAsync(async() => await userClient.SharedLinksFolders.GetSharedItemFoldersAsync(queryParams: new GetSharedItemFoldersQueryParams(), headers: new GetSharedItemFoldersHeaders(boxapi: string.Concat("shared_link=", NullableUtils.Unwrap(folderFromApi.SharedLink).Url, "&shared_link_password=incorrectPassword"))).ConfigureAwait(false));
            FolderFull updatedFolder = await client.SharedLinksFolders.UpdateFolderUpdateSharedLinkAsync(folderId: folder.Id, requestBody: new UpdateFolderUpdateSharedLinkRequestBody() { SharedLink = new UpdateFolderUpdateSharedLinkRequestBodySharedLinkField() { Access = UpdateFolderUpdateSharedLinkRequestBodySharedLinkAccessField.Collaborators } }, queryParams: new UpdateFolderUpdateSharedLinkQueryParams(fields: "shared_link")).ConfigureAwait(false);
            Assert.IsTrue(StringUtils.ToStringRepresentation(NullableUtils.Unwrap(updatedFolder.SharedLink).Access) == "collaborators");
            await client.Folders.DeleteFolderByIdAsync(folderId: folder.Id).ConfigureAwait(false);
        }

    }
}