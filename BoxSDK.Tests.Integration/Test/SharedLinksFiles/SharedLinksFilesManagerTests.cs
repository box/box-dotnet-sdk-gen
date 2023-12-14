using Microsoft.VisualStudio.TestTools.UnitTesting;
using NullableExtensions;
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
            Files uploadedFiles = await client.Uploads.UploadFileAsync(requestBody: new UploadFileRequestBody(attributes: new UploadFileRequestBodyAttributesField(name: Utils.GetUUID(), parent: new UploadFileRequestBodyAttributesParentField(id: "0")), file: Utils.GenerateByteStream(size: 10))).ConfigureAwait(false);
            string fileId = NullableUtils.Unwrap(uploadedFiles.Entries)[0].Id;
            await client.SharedLinksFiles.UpdateFileAddSharedLinkAsync(fileId: fileId, requestBody: new UpdateFileAddSharedLinkRequestBody() { SharedLink = new UpdateFileAddSharedLinkRequestBodySharedLinkField() { Access = UpdateFileAddSharedLinkRequestBodySharedLinkAccessField.Open, Password = "Secret123@" } }, queryParams: new UpdateFileAddSharedLinkQueryParams(fields: "shared_link")).ConfigureAwait(false);
            FileFull fileFromApi = await client.SharedLinksFiles.GetFileGetSharedLinkAsync(fileId: fileId, queryParams: new GetFileGetSharedLinkQueryParams(fields: "shared_link")).ConfigureAwait(false);
            Assert.IsTrue(StringUtils.ToStringRepresentation(NullableUtils.Unwrap(fileFromApi.SharedLink).Access) == "open");
            string userId = Utils.GetEnvVar(name: "USER_ID");
            BoxClient userClient = await new CommonsManager().GetDefaultClientAsUserAsync(userId: userId).ConfigureAwait(false);
            FileFull fileFromSharedLinkPassword = await userClient.SharedLinksFiles.GetSharedItemsAsync(queryParams: new GetSharedItemsQueryParams(), headers: new GetSharedItemsHeaders(boxapi: string.Concat("shared_link=", NullableUtils.Unwrap(fileFromApi.SharedLink).Url, "&shared_link_password=Secret123@"))).ConfigureAwait(false);
            Assert.IsTrue(fileId == fileFromSharedLinkPassword.Id);
            await Assert.That.IsExceptionAsync(async() => await userClient.SharedLinksFiles.GetSharedItemsAsync(queryParams: new GetSharedItemsQueryParams(), headers: new GetSharedItemsHeaders(boxapi: string.Concat("shared_link=", NullableUtils.Unwrap(fileFromApi.SharedLink).Url, "&shared_link_password=incorrectPassword"))).ConfigureAwait(false));
            FileFull updatedFile = await client.SharedLinksFiles.UpdateFileUpdateSharedLinkAsync(fileId: fileId, requestBody: new UpdateFileUpdateSharedLinkRequestBody() { SharedLink = new UpdateFileUpdateSharedLinkRequestBodySharedLinkField() { Access = UpdateFileUpdateSharedLinkRequestBodySharedLinkAccessField.Collaborators } }, queryParams: new UpdateFileUpdateSharedLinkQueryParams(fields: "shared_link")).ConfigureAwait(false);
            Assert.IsTrue(StringUtils.ToStringRepresentation(NullableUtils.Unwrap(updatedFile.SharedLink).Access) == "collaborators");
            await client.Files.DeleteFileByIdAsync(fileId: fileId).ConfigureAwait(false);
        }

    }
}