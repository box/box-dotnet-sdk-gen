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
        public async System.Threading.Tasks.Task<File> UploadFile(string fileName, System.IO.Stream fileStream) {
            Files uploadedFiles = await client.Uploads.UploadFile(new UploadFileRequestBodyArg(attributes: new UploadFileRequestBodyArgAttributesField(name: fileName, parent: new UploadFileRequestBodyArgAttributesFieldParentField(id: "0")), file: fileStream));
            return uploadedFiles.Entries[0];
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestGetFileThumbnail() {
            string thumbnailFileName = Utils.GetUUID();
            System.IO.Stream thumbnailContentStream = Utils.GenerateByteStream(1048576);
            File thumbnailFile = await UploadFile(thumbnailFileName, thumbnailContentStream);
            Assert.IsTrue(Utils.BufferEquals(await Utils.ReadByteStream(await client.Files.GetFileThumbnailById(thumbnailFile.Id, GetFileThumbnailByIdExtensionArg.Png)), await Utils.ReadByteStream(thumbnailContentStream)) != true);
            await client.Files.DeleteFileById(thumbnailFile.Id);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestGetFileFullExtraFields() {
            string newFileName = Utils.GetUUID();
            System.IO.Stream fileContent = Utils.GenerateByteStream(1048576);
            File uploadedFile = await UploadFile(newFileName, fileContent);
            FileFull file = await client.Files.GetFileById(uploadedFile.Id, new GetFileByIdQueryParamsArg() { Fields = Array.AsReadOnly(new [] {"is_externally_owned","has_collaborations"}) });
            Assert.IsTrue(file.IsExternallyOwned == false);
            Assert.IsTrue(file.HasCollaborations == false);
            await client.Files.DeleteFileById(file.Id);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestCreateGetAndDeleteFile() {
            string newFileName = Utils.GetUUID();
            System.IO.Stream updatedContentStream = Utils.GenerateByteStream(1048576);
            File uploadedFile = await UploadFile(newFileName, updatedContentStream);
            FileFull file = await client.Files.GetFileById(uploadedFile.Id);
            await Assert.ThrowsExceptionAsync<Exception>(async() => await client.Files.GetFileById(uploadedFile.Id, new GetFileByIdQueryParamsArg() { Fields = Array.AsReadOnly(new [] {"name"}) }, new GetFileByIdHeadersArg() { ExtraHeaders = new Dictionary<string, string>() { { "if-none-match", file.Etag } } }));
            Assert.IsTrue(file.Name == newFileName);
            await client.Files.DeleteFileById(uploadedFile.Id);
            TrashFile trashedFile = await client.TrashedFiles.GetFileTrash(uploadedFile.Id);
            Assert.IsTrue(file.Id == trashedFile.Id);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestUpdateFile() {
            File fileToUpdate = await new CommonsManager().UploadNewFile();
            string updatedName = Utils.GetUUID();
            FileFull updatedFile = await client.Files.UpdateFileById(fileToUpdate.Id, new UpdateFileByIdRequestBodyArg() { Name = updatedName, Description = "Updated description" });
            Assert.IsTrue(updatedFile.Name == updatedName);
            Assert.IsTrue(updatedFile.Description == "Updated description");
            await client.Files.DeleteFileById(updatedFile.Id);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestCopyFile() {
            File fileOrigin = await new CommonsManager().UploadNewFile();
            string copiedFileName = Utils.GetUUID();
            FileFull copiedFile = await client.Files.CopyFile(fileOrigin.Id, new CopyFileRequestBodyArg(parent: new CopyFileRequestBodyArgParentField(id: "0")) { Name = copiedFileName });
            Assert.IsTrue(copiedFile.Parent.Id == "0");
            Assert.IsTrue(copiedFile.Name == copiedFileName);
            await client.Files.DeleteFileById(fileOrigin.Id);
            await client.Files.DeleteFileById(copiedFile.Id);
        }

    }
}