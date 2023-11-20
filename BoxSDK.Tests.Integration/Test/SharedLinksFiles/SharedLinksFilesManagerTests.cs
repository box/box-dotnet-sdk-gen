using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringExtensions;
using System;
using Box;
using Box.Schemas;
using Box.Managers;

namespace Box.Tests.Integration {
    [TestClass]
    public class SharedLinksFilesManagerTests {
        public BoxClient client { get; }

        public SharedLinksFilesManagerTests() {
            client = new CommonsManager().GetDefaultClient();
        }
        [TestMethod]
        public async System.Threading.Tasks.Task TestSharedLinksFiles() {
            Files uploadedFiles = await client.Uploads.UploadFileAsync(requestBody: new UploadFileRequestBodyArg(attributes: new UploadFileRequestBodyArgAttributesField(name: Utils.GetUUID(), parent: new UploadFileRequestBodyArgAttributesFieldParentField(id: "0")), file: Utils.GenerateByteStream(size: 10))).ConfigureAwait(false);
            string fileId = uploadedFiles.Entries![0].Id;
            await client.SharedLinksFiles.UpdateFileAddSharedLinkAsync(fileId: fileId, requestBody: new UpdateFileAddSharedLinkRequestBodyArg() { SharedLink = new UpdateFileAddSharedLinkRequestBodyArgSharedLinkField() { Access = UpdateFileAddSharedLinkRequestBodyArgSharedLinkFieldAccessField.Open, Password = "Secret123@" } }, queryParams: new UpdateFileAddSharedLinkQueryParamsArg(fields: "shared_link")).ConfigureAwait(false);
            FileFull fileFromApi = await client.SharedLinksFiles.GetFileGetSharedLinkAsync(fileId: fileId, queryParams: new GetFileGetSharedLinkQueryParamsArg(fields: "shared_link")).ConfigureAwait(false);
            Assert.IsTrue(StringUtils.ToStringRepresentation(fileFromApi.SharedLink!.Access) == "open");
            string userId = Utils.GetEnvVar(name: "USER_ID");
            BoxClient userClient = await new CommonsManager().GetDefaultClientAsUserAsync(userId: userId).ConfigureAwait(false);
            FileFull fileFromSharedLinkPassword = await userClient.SharedLinksFiles.GetSharedItemsAsync(queryParams: new GetSharedItemsQueryParamsArg(), headers: new GetSharedItemsHeadersArg(boxapi: string.Concat("shared_link=", fileFromApi.SharedLink!.Url, "&shared_link_password=Secret123@"))).ConfigureAwait(false);
            Assert.IsTrue(fileId == fileFromSharedLinkPassword.Id);
            await Assert.That.IsExceptionAsync(async() => await userClient.SharedLinksFiles.GetSharedItemsAsync(queryParams: new GetSharedItemsQueryParamsArg(), headers: new GetSharedItemsHeadersArg(boxapi: string.Concat("shared_link=", fileFromApi.SharedLink!.Url, "&shared_link_password=incorrectPassword"))).ConfigureAwait(false));
            FileFull updatedFile = await client.SharedLinksFiles.UpdateFileUpdateSharedLinkAsync(fileId: fileId, requestBody: new UpdateFileUpdateSharedLinkRequestBodyArg() { SharedLink = new UpdateFileUpdateSharedLinkRequestBodyArgSharedLinkField() { Access = UpdateFileUpdateSharedLinkRequestBodyArgSharedLinkFieldAccessField.Collaborators } }, queryParams: new UpdateFileUpdateSharedLinkQueryParamsArg(fields: "shared_link")).ConfigureAwait(false);
            Assert.IsTrue(StringUtils.ToStringRepresentation(updatedFile.SharedLink!.Access) == "collaborators");
            await client.Files.DeleteFileByIdAsync(fileId: fileId).ConfigureAwait(false);
        }

    }
}