using Microsoft.VisualStudio.TestTools.UnitTesting;
using NullableExtensions;
using StringExtensions;
using System;
using Box.Sdk.Gen;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen.Managers;

namespace Box.Sdk.Gen.Tests.Integration {
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
            await client.SharedLinksFiles.AddShareLinkToFileAsync(fileId: fileId, requestBody: new AddShareLinkToFileRequestBody() { SharedLink = new AddShareLinkToFileRequestBodySharedLinkField() { Access = AddShareLinkToFileRequestBodySharedLinkAccessField.Open, Password = "Secret123@" } }, queryParams: new AddShareLinkToFileQueryParams(fields: "shared_link")).ConfigureAwait(false);
            FileFull fileFromApi = await client.SharedLinksFiles.GetSharedLinkForFileAsync(fileId: fileId, queryParams: new GetSharedLinkForFileQueryParams(fields: "shared_link")).ConfigureAwait(false);
            Assert.IsTrue(StringUtils.ToStringRepresentation(NullableUtils.Unwrap(fileFromApi.SharedLink).Access) == "open");
            string userId = Utils.GetEnvVar(name: "USER_ID");
            BoxClient userClient = await new CommonsManager().GetDefaultClientAsUserAsync(userId: userId).ConfigureAwait(false);
            FileFull fileFromSharedLinkPassword = await userClient.SharedLinksFiles.FindFileForSharedLinkAsync(queryParams: new FindFileForSharedLinkQueryParams(), headers: new FindFileForSharedLinkHeaders(boxapi: string.Concat("shared_link=", NullableUtils.Unwrap(fileFromApi.SharedLink).Url, "&shared_link_password=Secret123@"))).ConfigureAwait(false);
            Assert.IsTrue(fileId == fileFromSharedLinkPassword.Id);
            await Assert.That.IsExceptionAsync(async() => await userClient.SharedLinksFiles.FindFileForSharedLinkAsync(queryParams: new FindFileForSharedLinkQueryParams(), headers: new FindFileForSharedLinkHeaders(boxapi: string.Concat("shared_link=", NullableUtils.Unwrap(fileFromApi.SharedLink).Url, "&shared_link_password=incorrectPassword"))).ConfigureAwait(false));
            FileFull updatedFile = await client.SharedLinksFiles.UpdateSharedLinkOnFileAsync(fileId: fileId, requestBody: new UpdateSharedLinkOnFileRequestBody() { SharedLink = new UpdateSharedLinkOnFileRequestBodySharedLinkField() { Access = UpdateSharedLinkOnFileRequestBodySharedLinkAccessField.Collaborators } }, queryParams: new UpdateSharedLinkOnFileQueryParams(fields: "shared_link")).ConfigureAwait(false);
            Assert.IsTrue(StringUtils.ToStringRepresentation(NullableUtils.Unwrap(updatedFile.SharedLink).Access) == "collaborators");
            await client.Files.DeleteFileByIdAsync(fileId: fileId).ConfigureAwait(false);
        }

    }
}