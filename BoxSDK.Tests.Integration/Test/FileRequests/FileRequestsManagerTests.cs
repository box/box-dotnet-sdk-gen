using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringExtensions;
using System;
using Box;
using Box.Schemas;

namespace Box.Tests.Integration {
    [TestClass]
    public class FileRequestsManagerTests {
        [TestMethod]
        public async System.Threading.Tasks.Task TestGetCopyUpdateDeleteFileRequest() {
            string fileRequestId = Utils.GetEnvVar("BOX_FILE_REQUEST_ID");
            string userId = Utils.GetEnvVar("USER_ID");
            BoxClient client = await new CommonsManager().GetDefaultClientAsUserAsync(userId).ConfigureAwait(false);
            FileRequest fileRequest = await client.FileRequests.GetFileRequestByIdAsync(fileRequestId).ConfigureAwait(false);
            Assert.IsTrue(fileRequest.Id == fileRequestId);
            Assert.IsTrue(StringUtils.ToStringRepresentation(fileRequest.Type) == "file_request");
            FileRequest copiedFileRequest = await client.FileRequests.CreateFileRequestCopyAsync(fileRequestId, new FileRequestCopyRequest(folder: new FileRequestCopyRequestFolderField(id: fileRequest.Folder.Id) { Type = FileRequestCopyRequestFolderFieldTypeField.Folder })).ConfigureAwait(false);
            Assert.IsTrue(copiedFileRequest.Id != fileRequestId);
            Assert.IsTrue(copiedFileRequest.Title == fileRequest.Title);
            Assert.IsTrue(copiedFileRequest.Description == fileRequest.Description);
            FileRequest updatedFileRequest = await client.FileRequests.UpdateFileRequestByIdAsync(copiedFileRequest.Id, new FileRequestUpdateRequest() { Title = "updated title", Description = "updated description" }).ConfigureAwait(false);
            Assert.IsTrue(updatedFileRequest.Id == copiedFileRequest.Id);
            Assert.IsTrue(updatedFileRequest.Title == "updated title");
            Assert.IsTrue(updatedFileRequest.Description == "updated description");
            await client.FileRequests.DeleteFileRequestByIdAsync(updatedFileRequest.Id).ConfigureAwait(false);
            await Assert.That.IsExceptionAsync(async() => await client.FileRequests.GetFileRequestByIdAsync(updatedFileRequest.Id).ConfigureAwait(false));
        }

    }
}