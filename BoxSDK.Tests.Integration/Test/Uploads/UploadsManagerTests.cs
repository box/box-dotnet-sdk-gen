using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Box;
using Box.Schemas;
using Box.Managers;

namespace Box.Tests.Integration {
    [TestClass]
    public class UploadsManagerTests {
        public BoxClient client { get; }

        public UploadsManagerTests() {
            client = new CommonsManager().GetDefaultClient();
        }
        [TestMethod]
        public async System.Threading.Tasks.Task TestUploadFileAndFileVersion() {
            string newFileName = Utils.GetUUID();
            System.IO.Stream fileContentStream = Utils.GenerateByteStream(size: 1024 * 1024);
            Files uploadedFiles = await client.Uploads.UploadFileAsync(requestBody: new UploadFileRequestBodyArg(attributes: new UploadFileRequestBodyArgAttributesField(name: newFileName, parent: new UploadFileRequestBodyArgAttributesFieldParentField(id: "0")), file: fileContentStream)).ConfigureAwait(false);
            FileFull uploadedFile = uploadedFiles.Entries![0];
            Assert.IsTrue(uploadedFile.Name == newFileName);
            string newFileVersionName = Utils.GetUUID();
            System.IO.Stream newFileContentStream = Utils.GenerateByteStream(size: 1024 * 1024);
            Files uploadedFilesVersion = await client.Uploads.UploadFileVersionAsync(fileId: uploadedFile.Id, requestBody: new UploadFileVersionRequestBodyArg(attributes: new UploadFileVersionRequestBodyArgAttributesField(name: newFileVersionName), file: newFileContentStream)).ConfigureAwait(false);
            FileFull newFileVersion = uploadedFilesVersion.Entries![0];
            Assert.IsTrue(newFileVersion.Name == newFileVersionName);
            await client.Files.DeleteFileByIdAsync(fileId: newFileVersion.Id).ConfigureAwait(false);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestRequestCancellation() {
            int fileSize = 1024 * 1024;
            string fileName = Utils.GetUUID();
            System.IO.Stream fileByteStream = Utils.GenerateByteStream(size: fileSize);
            System.Threading.CancellationToken cancellationToken = Utils.CreateTokenAndCancelAfter(delay: 1);
            await Assert.That.IsExceptionAsync(async() => await client.Uploads.UploadFileAsync(requestBody: new UploadFileRequestBodyArg(attributes: new UploadFileRequestBodyArgAttributesField(name: fileName, parent: new UploadFileRequestBodyArgAttributesFieldParentField(id: "0")), file: fileByteStream), queryParams: new UploadFileQueryParamsArg(), headers: new UploadFileHeadersArg(), cancellationToken: cancellationToken).ConfigureAwait(false));
        }

    }
}