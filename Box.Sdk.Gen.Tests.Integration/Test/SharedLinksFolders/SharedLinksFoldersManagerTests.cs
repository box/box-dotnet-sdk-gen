using Microsoft.VisualStudio.TestTools.UnitTesting;
using NullableExtensions;
using StringExtensions;
using System;
using Box.Sdk.Gen;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen.Managers;

namespace Box.Sdk.Gen.Tests.Integration {
    [TestClass]
    public class SharedLinksFoldersManagerTests {
        public BoxClient client { get; }

        public SharedLinksFoldersManagerTests() {
            client = new CommonsManager().GetDefaultClient();
        }
        [TestMethod]
        public async System.Threading.Tasks.Task TestSharedLinksFolders() {
            FolderFull folder = await client.Folders.CreateFolderAsync(requestBody: new CreateFolderRequestBody(name: Utils.GetUUID(), parent: new CreateFolderRequestBodyParentField(id: "0")));
            await client.SharedLinksFolders.AddShareLinkToFolderAsync(folderId: folder.Id, requestBody: new AddShareLinkToFolderRequestBody() { SharedLink = new AddShareLinkToFolderRequestBodySharedLinkField() { Access = AddShareLinkToFolderRequestBodySharedLinkAccessField.Open, Password = "Secret123@" } }, queryParams: new AddShareLinkToFolderQueryParams(fields: "shared_link"));
            FolderFull folderFromApi = await client.SharedLinksFolders.GetSharedLinkForFolderAsync(folderId: folder.Id, queryParams: new GetSharedLinkForFolderQueryParams(fields: "shared_link"));
            Assert.IsTrue(StringUtils.ToStringRepresentation(NullableUtils.Unwrap(folderFromApi.SharedLink).Access) == "open");
            string userId = Utils.GetEnvVar(name: "USER_ID");
            BoxClient userClient = new CommonsManager().GetDefaultClientAsUser(userId: userId);
            FolderFull folderFromSharedLinkPassword = await userClient.SharedLinksFolders.FindFolderForSharedLinkAsync(queryParams: new FindFolderForSharedLinkQueryParams(), headers: new FindFolderForSharedLinkHeaders(boxapi: string.Concat("shared_link=", NullableUtils.Unwrap(folderFromApi.SharedLink).Url, "&shared_link_password=Secret123@")));
            Assert.IsTrue(folder.Id == folderFromSharedLinkPassword.Id);
            await Assert.That.IsExceptionAsync(async() => await userClient.SharedLinksFolders.FindFolderForSharedLinkAsync(queryParams: new FindFolderForSharedLinkQueryParams(), headers: new FindFolderForSharedLinkHeaders(boxapi: string.Concat("shared_link=", NullableUtils.Unwrap(folderFromApi.SharedLink).Url, "&shared_link_password=incorrectPassword"))));
            FolderFull updatedFolder = await client.SharedLinksFolders.UpdateSharedLinkOnFolderAsync(folderId: folder.Id, requestBody: new UpdateSharedLinkOnFolderRequestBody() { SharedLink = new UpdateSharedLinkOnFolderRequestBodySharedLinkField() { Access = UpdateSharedLinkOnFolderRequestBodySharedLinkAccessField.Collaborators } }, queryParams: new UpdateSharedLinkOnFolderQueryParams(fields: "shared_link"));
            Assert.IsTrue(StringUtils.ToStringRepresentation(NullableUtils.Unwrap(updatedFolder.SharedLink).Access) == "collaborators");
            await client.Folders.DeleteFolderByIdAsync(folderId: folder.Id);
        }

    }
}