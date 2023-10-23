using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringExtensions;
using System;
using Box;
using Box.Schemas;
using Box.Managers;

namespace Box.Tests.Integration {
    [TestClass]
    public class TrashedFilesManagerTests {
        public BoxClient client { get; }

        public TrashedFilesManagerTests() {
            client = new CommonsManager().GetDefaultClient();
        }
        [TestMethod]
        public async System.Threading.Tasks.Task TestTrashedFiles() {
            int fileSize = 1024 * 1024;
            string fileName = Utils.GetUUID();
            System.IO.Stream fileByteStream = Utils.GenerateByteStream(fileSize);
            Files files = await client.Uploads.UploadFileAsync(new UploadFileRequestBodyArg(attributes: new UploadFileRequestBodyArgAttributesField(name: fileName, parent: new UploadFileRequestBodyArgAttributesFieldParentField(id: "0")), file: fileByteStream)).ConfigureAwait(false);
            File file = files.Entries![0];
            await client.Files.DeleteFileByIdAsync(file.Id).ConfigureAwait(false);
            TrashFile fromTrash = await client.TrashedFiles.GetFileTrashAsync(file.Id).ConfigureAwait(false);
            Assert.IsTrue(fromTrash.Id == file.Id);
            Assert.IsTrue(fromTrash.Name == file.Name);
            FileFull fromApiAfterTrashed = await client.Files.GetFileByIdAsync(file.Id).ConfigureAwait(false);
            Assert.IsTrue(StringUtils.ToStringRepresentation(fromApiAfterTrashed.ItemStatus) == "trashed");
            TrashFileRestored restoredFile = await client.TrashedFiles.RestoreFileFromTrashAsync(file.Id).ConfigureAwait(false);
            FileFull fromApiAfterRestore = await client.Files.GetFileByIdAsync(file.Id).ConfigureAwait(false);
            Assert.IsTrue(restoredFile.Id == fromApiAfterRestore.Id);
            Assert.IsTrue(restoredFile.Name == fromApiAfterRestore.Name);
            Assert.IsTrue(StringUtils.ToStringRepresentation(fromApiAfterRestore.ItemStatus) == "active");
            await client.Files.DeleteFileByIdAsync(file.Id).ConfigureAwait(false);
            await client.TrashedFiles.DeleteFileTrashAsync(file.Id).ConfigureAwait(false);
            await Assert.That.IsExceptionAsync(async() => await client.TrashedFiles.GetFileTrashAsync(file.Id).ConfigureAwait(false));
        }

    }
}