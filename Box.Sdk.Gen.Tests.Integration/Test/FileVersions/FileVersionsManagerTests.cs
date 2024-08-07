using Microsoft.VisualStudio.TestTools.UnitTesting;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen.Managers;

namespace Box.Sdk.Gen.Tests.Integration {
    [TestClass]
    public class FileVersionsManagerTests {
        public BoxClient client { get; }

        public FileVersionsManagerTests() {
            client = new CommonsManager().GetDefaultClient();
        }
        [TestMethod]
        public async System.Threading.Tasks.Task TestCreateListGetPromoteFileVersion() {
            string oldName = Utils.GetUUID();
            string newName = Utils.GetUUID();
            Files files = await client.Uploads.UploadFileAsync(requestBody: new UploadFileRequestBody(attributes: new UploadFileRequestBodyAttributesField(name: oldName, parent: new UploadFileRequestBodyAttributesParentField(id: "0")), file: Utils.GenerateByteStream(size: 10)));
            FileFull file = NullableUtils.Unwrap(files.Entries)[0];
            Assert.IsTrue(file.Name == oldName);
            Assert.IsTrue(file.Size == 10);
            Files newFiles = await client.Uploads.UploadFileVersionAsync(fileId: file.Id, requestBody: new UploadFileVersionRequestBody(attributes: new UploadFileVersionRequestBodyAttributesField(name: newName), file: Utils.GenerateByteStream(size: 20)));
            FileFull newFile = NullableUtils.Unwrap(newFiles.Entries)[0];
            Assert.IsTrue(newFile.Name == newName);
            Assert.IsTrue(newFile.Size == 20);
            FileVersions fileVersions = await client.FileVersions.GetFileVersionsAsync(fileId: file.Id);
            Assert.IsTrue(fileVersions.TotalCount == 1);
            FileVersionFull fileVersion = await client.FileVersions.GetFileVersionByIdAsync(fileId: file.Id, fileVersionId: NullableUtils.Unwrap(fileVersions.Entries)[0].Id);
            Assert.IsTrue(fileVersion.Id == NullableUtils.Unwrap(fileVersions.Entries)[0].Id);
            await client.FileVersions.PromoteFileVersionAsync(fileId: file.Id, requestBody: new PromoteFileVersionRequestBody() { Id = NullableUtils.Unwrap(fileVersions.Entries)[0].Id, Type = PromoteFileVersionRequestBodyTypeField.FileVersion });
            FileFull fileWithPromotedVersion = await client.Files.GetFileByIdAsync(fileId: file.Id);
            Assert.IsTrue(fileWithPromotedVersion.Name == oldName);
            Assert.IsTrue(fileWithPromotedVersion.Size == 10);
            await client.FileVersions.DeleteFileVersionByIdAsync(fileId: file.Id, fileVersionId: fileVersion.Id);
            await client.Files.DeleteFileByIdAsync(fileId: file.Id);
        }

    }
}