using Microsoft.VisualStudio.TestTools.UnitTesting;
using NullableExtensions;
using System;
using Box.Sdk.Gen;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen.Managers;

namespace Box.Sdk.Gen.Tests.Integration {
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
            Files uploadedFiles = await client.Uploads.UploadFileAsync(requestBody: new UploadFileRequestBody(attributes: new UploadFileRequestBodyAttributesField(name: newFileName, parent: new UploadFileRequestBodyAttributesParentField(id: "0")), file: fileContentStream));
            FileFull uploadedFile = NullableUtils.Unwrap(uploadedFiles.Entries)[0];
            Assert.IsTrue(uploadedFile.Name == newFileName);
            string newFileVersionName = Utils.GetUUID();
            System.IO.Stream newFileContentStream = Utils.GenerateByteStream(size: 1024 * 1024);
            Files uploadedFilesVersion = await client.Uploads.UploadFileVersionAsync(fileId: uploadedFile.Id, requestBody: new UploadFileVersionRequestBody(attributes: new UploadFileVersionRequestBodyAttributesField(name: newFileVersionName), file: newFileContentStream));
            FileFull newFileVersion = NullableUtils.Unwrap(uploadedFilesVersion.Entries)[0];
            Assert.IsTrue(newFileVersion.Name == newFileVersionName);
            await client.Files.DeleteFileByIdAsync(fileId: newFileVersion.Id);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestRequestCancellation() {
            int fileSize = 1024 * 1024;
            string fileName = Utils.GetUUID();
            System.IO.Stream fileByteStream = Utils.GenerateByteStream(size: fileSize);
            System.Threading.CancellationToken cancellationToken = Utils.CreateTokenAndCancelAfter(delay: 1);
            await Assert.That.IsExceptionAsync(async() => await client.Uploads.UploadFileAsync(requestBody: new UploadFileRequestBody(attributes: new UploadFileRequestBodyAttributesField(name: fileName, parent: new UploadFileRequestBodyAttributesParentField(id: "0")), file: fileByteStream), queryParams: new UploadFileQueryParams(), headers: new UploadFileHeaders(), cancellationToken: cancellationToken));
        }

    }
}