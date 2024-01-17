using Microsoft.VisualStudio.TestTools.UnitTesting;
using NullableExtensions;
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
        public async System.Threading.Tasks.Task TestCreateListGetRestoreDeleteFileVersion() {
            string oldName = Utils.GetUUID();
            string newName = Utils.GetUUID();
            Files files = await client.Uploads.UploadFileAsync(requestBody: new UploadFileRequestBody(attributes: new UploadFileRequestBodyAttributesField(name: oldName, parent: new UploadFileRequestBodyAttributesParentField(id: "0")), file: Utils.GenerateByteStream(size: 10))).ConfigureAwait(false);
            FileFull file = NullableUtils.Unwrap(files.Entries)[0];
            Assert.IsTrue(file.Name == oldName);
            Assert.IsTrue(file.Size == 10);
            Files newFiles = await client.Uploads.UploadFileVersionAsync(fileId: file.Id, requestBody: new UploadFileVersionRequestBody(attributes: new UploadFileVersionRequestBodyAttributesField(name: newName), file: Utils.GenerateByteStream(size: 20))).ConfigureAwait(false);
            FileFull newFile = NullableUtils.Unwrap(newFiles.Entries)[0];
            Assert.IsTrue(newFile.Name == newName);
            Assert.IsTrue(newFile.Size == 20);
            FileVersions fileVersions = await client.FileVersions.GetFileVersionsAsync(fileId: file.Id).ConfigureAwait(false);
            Assert.IsTrue(fileVersions.TotalCount == 1);
            FileVersionFull fileVersion = await client.FileVersions.GetFileVersionByIdAsync(fileId: file.Id, fileVersionId: NullableUtils.Unwrap(fileVersions.Entries)[0].Id).ConfigureAwait(false);
            Assert.IsTrue(fileVersion.Id == NullableUtils.Unwrap(fileVersions.Entries)[0].Id);
            await client.FileVersions.PromoteFileVersionAsync(fileId: file.Id, requestBody: new PromoteFileVersionRequestBody() { Id = NullableUtils.Unwrap(fileVersions.Entries)[0].Id, Type = PromoteFileVersionRequestBodyTypeField.FileVersion }).ConfigureAwait(false);
            FileFull fileRestored = await client.Files.GetFileByIdAsync(fileId: file.Id).ConfigureAwait(false);
            Assert.IsTrue(fileRestored.Name == oldName);
            Assert.IsTrue(fileRestored.Size == 10);
            FileVersions fileVersionsRestored = await client.FileVersions.GetFileVersionsAsync(fileId: file.Id).ConfigureAwait(false);
            await client.FileVersions.DeleteFileVersionByIdAsync(fileId: file.Id, fileVersionId: NullableUtils.Unwrap(fileVersionsRestored.Entries)[0].Id).ConfigureAwait(false);
            await client.FileVersions.GetFileVersionsAsync(fileId: file.Id).ConfigureAwait(false);
            await client.Files.DeleteFileByIdAsync(fileId: file.Id).ConfigureAwait(false);
        }

    }
}