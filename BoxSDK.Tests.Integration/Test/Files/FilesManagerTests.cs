using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Schemas;
using Box.Managers;
using Box;

namespace Box.Tests.Integration {
    [TestClass]
    public class FilesManagerTests {
        public JwtConfig jwtConfig { get; }

        public BoxJwtAuth auth { get; }

        public BoxClient client { get; }

        public FilesManagerTests() {
            jwtConfig = JwtConfig.FromConfigJsonString(Utils.DecodeBase64(Utils.GetEnvVar("JWT_CONFIG_BASE_64")));
            auth = new BoxJwtAuth(config: jwtConfig);
            client = new BoxClient(auth: auth);
        }
        public async System.Threading.Tasks.Task<File> UploadFileAsync(string fileName, System.IO.Stream fileStream) {
            Files uploadedFiles = await client.Uploads.UploadFileAsync(new UploadFileRequestBodyArg(attributes: new UploadFileRequestBodyArgAttributesField(name: fileName, parent: new UploadFileRequestBodyArgAttributesFieldParentField(id: "0")), file: fileStream)).ConfigureAwait(false);
            return uploadedFiles.Entries[0];
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestGetFileThumbnail() {
            string thumbnailFileName = Utils.GetUUID();
            System.IO.Stream thumbnailContentStream = Utils.GenerateByteStream(1048576);
            File thumbnailFile = await UploadFileAsync(thumbnailFileName, thumbnailContentStream).ConfigureAwait(false);
            Assert.IsTrue(Utils.BufferEquals(await Utils.ReadByteStreamAsync(await client.Files.GetFileThumbnailByIdAsync(thumbnailFile.Id, GetFileThumbnailByIdExtensionArg.Png).ConfigureAwait(false)).ConfigureAwait(false), await Utils.ReadByteStreamAsync(thumbnailContentStream).ConfigureAwait(false)) != true);
            await client.Files.DeleteFileByIdAsync(thumbnailFile.Id).ConfigureAwait(false);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestGetFileFullExtraFields() {
            string newFileName = Utils.GetUUID();
            System.IO.Stream fileContent = Utils.GenerateByteStream(1048576);
            File uploadedFile = await UploadFileAsync(newFileName, fileContent).ConfigureAwait(false);
            FileFull file = await client.Files.GetFileByIdAsync(uploadedFile.Id, new GetFileByIdQueryParamsArg() { Fields = Array.AsReadOnly(new [] {"is_externally_owned","has_collaborations"}) }).ConfigureAwait(false);
            Assert.IsTrue(file.IsExternallyOwned == false);
            Assert.IsTrue(file.HasCollaborations == false);
            await client.Files.DeleteFileByIdAsync(file.Id).ConfigureAwait(false);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestCreateGetAndDeleteFile() {
            string newFileName = Utils.GetUUID();
            System.IO.Stream updatedContentStream = Utils.GenerateByteStream(1048576);
            File uploadedFile = await UploadFileAsync(newFileName, updatedContentStream).ConfigureAwait(false);
            FileFull file = await client.Files.GetFileByIdAsync(uploadedFile.Id).ConfigureAwait(false);
            await Assert.That.IsExceptionAsync(async() => await client.Files.GetFileByIdAsync(uploadedFile.Id, new GetFileByIdQueryParamsArg() { Fields = Array.AsReadOnly(new [] {"name"}) }, new GetFileByIdHeadersArg() { ExtraHeaders = new Dictionary<string, string>() { { "if-none-match", file.Etag } } }).ConfigureAwait(false));
            Assert.IsTrue(file.Name == newFileName);
            await client.Files.DeleteFileByIdAsync(uploadedFile.Id).ConfigureAwait(false);
            TrashFile trashedFile = await client.TrashedFiles.GetFileTrashAsync(uploadedFile.Id).ConfigureAwait(false);
            Assert.IsTrue(file.Id == trashedFile.Id);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestUpdateFile() {
            File fileToUpdate = await new CommonsManager().UploadNewFileAsync().ConfigureAwait(false);
            string updatedName = Utils.GetUUID();
            FileFull updatedFile = await client.Files.UpdateFileByIdAsync(fileToUpdate.Id, new UpdateFileByIdRequestBodyArg() { Name = updatedName, Description = "Updated description" }).ConfigureAwait(false);
            Assert.IsTrue(updatedFile.Name == updatedName);
            Assert.IsTrue(updatedFile.Description == "Updated description");
            await client.Files.DeleteFileByIdAsync(updatedFile.Id).ConfigureAwait(false);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestCopyFile() {
            File fileOrigin = await new CommonsManager().UploadNewFileAsync().ConfigureAwait(false);
            string copiedFileName = Utils.GetUUID();
            FileFull copiedFile = await client.Files.CopyFileAsync(fileOrigin.Id, new CopyFileRequestBodyArg(parent: new CopyFileRequestBodyArgParentField(id: "0")) { Name = copiedFileName }).ConfigureAwait(false);
            Assert.IsTrue(copiedFile.Parent.Id == "0");
            Assert.IsTrue(copiedFile.Name == copiedFileName);
            await client.Files.DeleteFileByIdAsync(fileOrigin.Id).ConfigureAwait(false);
            await client.Files.DeleteFileByIdAsync(copiedFile.Id).ConfigureAwait(false);
        }

    }
}