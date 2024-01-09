using NullableExtensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box;
using Box.Schemas;
using Box.Managers;

namespace Box.Tests.Integration {
    [TestClass]
    public class FilesManagerTests {
        public BoxClient client { get; }

        public FilesManagerTests() {
            client = new CommonsManager().GetDefaultClient();
        }
        public async System.Threading.Tasks.Task<FileFull> UploadFileAsync(string fileName, System.IO.Stream fileStream) {
            Files uploadedFiles = await client.Uploads.UploadFileAsync(requestBody: new UploadFileRequestBody(attributes: new UploadFileRequestBodyAttributesField(name: fileName, parent: new UploadFileRequestBodyAttributesParentField(id: "0")), file: fileStream)).ConfigureAwait(false);
            return NullableUtils.Unwrap(uploadedFiles.Entries)[0];
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestGetFileThumbnail() {
            string thumbnailFileName = Utils.GetUUID();
            System.IO.Stream thumbnailContentStream = Utils.GenerateByteStream(size: 1024 * 1024);
            FileFull thumbnailFile = await UploadFileAsync(fileName: thumbnailFileName, fileStream: thumbnailContentStream).ConfigureAwait(false);
            Assert.IsTrue(Utils.BufferEquals(buffer1: await Utils.ReadByteStreamAsync(byteStream: await client.Files.GetFileThumbnailByIdAsync(fileId: thumbnailFile.Id, extension: GetFileThumbnailByIdExtension.Png).ConfigureAwait(false)).ConfigureAwait(false), buffer2: await Utils.ReadByteStreamAsync(byteStream: thumbnailContentStream).ConfigureAwait(false)) != true);
            await client.Files.DeleteFileByIdAsync(fileId: thumbnailFile.Id).ConfigureAwait(false);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestGetFileFullExtraFields() {
            string newFileName = Utils.GetUUID();
            System.IO.Stream fileStream = Utils.GenerateByteStream(size: 1024 * 1024);
            FileFull uploadedFile = await UploadFileAsync(fileName: newFileName, fileStream: fileStream).ConfigureAwait(false);
            FileFull file = await client.Files.GetFileByIdAsync(fileId: uploadedFile.Id, queryParams: new GetFileByIdQueryParams() { Fields = Array.AsReadOnly(new [] {"is_externally_owned","has_collaborations"}) }).ConfigureAwait(false);
            Assert.IsTrue(file.IsExternallyOwned == false);
            Assert.IsTrue(file.HasCollaborations == false);
            await client.Files.DeleteFileByIdAsync(fileId: file.Id).ConfigureAwait(false);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestCreateGetAndDeleteFile() {
            string newFileName = Utils.GetUUID();
            System.IO.Stream updatedContentStream = Utils.GenerateByteStream(size: 1024 * 1024);
            FileFull uploadedFile = await UploadFileAsync(fileName: newFileName, fileStream: updatedContentStream).ConfigureAwait(false);
            FileFull file = await client.Files.GetFileByIdAsync(fileId: uploadedFile.Id).ConfigureAwait(false);
            await Assert.That.IsExceptionAsync(async() => await client.Files.GetFileByIdAsync(fileId: uploadedFile.Id, queryParams: new GetFileByIdQueryParams() { Fields = Array.AsReadOnly(new [] {"name"}) }, headers: new GetFileByIdHeaders() { ExtraHeaders = new Dictionary<string, string>() { { "if-none-match", file.Etag } } }).ConfigureAwait(false));
            Assert.IsTrue(file.Name == newFileName);
            await client.Files.DeleteFileByIdAsync(fileId: uploadedFile.Id).ConfigureAwait(false);
            TrashFile trashedFile = await client.TrashedFiles.GetTrashedFileByIdAsync(fileId: uploadedFile.Id).ConfigureAwait(false);
            Assert.IsTrue(file.Id == trashedFile.Id);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestUpdateFile() {
            FileFull fileToUpdate = await new CommonsManager().UploadNewFileAsync().ConfigureAwait(false);
            string updatedName = Utils.GetUUID();
            FileFull updatedFile = await client.Files.UpdateFileByIdAsync(fileId: fileToUpdate.Id, requestBody: new UpdateFileByIdRequestBody() { Name = updatedName, Description = "Updated description" }).ConfigureAwait(false);
            Assert.IsTrue(updatedFile.Name == updatedName);
            Assert.IsTrue(updatedFile.Description == "Updated description");
            await client.Files.DeleteFileByIdAsync(fileId: updatedFile.Id).ConfigureAwait(false);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestCopyFile() {
            FileFull fileOrigin = await new CommonsManager().UploadNewFileAsync().ConfigureAwait(false);
            string copiedFileName = Utils.GetUUID();
            FileFull copiedFile = await client.Files.CopyFileAsync(fileId: fileOrigin.Id, requestBody: new CopyFileRequestBody(parent: new CopyFileRequestBodyParentField(id: "0")) { Name = copiedFileName }).ConfigureAwait(false);
            Assert.IsTrue(NullableUtils.Unwrap(copiedFile.Parent).Id == "0");
            Assert.IsTrue(copiedFile.Name == copiedFileName);
            await client.Files.DeleteFileByIdAsync(fileId: fileOrigin.Id).ConfigureAwait(false);
            await client.Files.DeleteFileByIdAsync(fileId: copiedFile.Id).ConfigureAwait(false);
        }

    }
}