using Microsoft.VisualStudio.TestTools.UnitTesting;
using NullableExtensions;
using Box;
using Box.Schemas;

namespace Box.Tests.Integration {
    [TestClass]
    public class ChunkedUploadsManagerTests {
        public BoxClient client { get; }

        public ChunkedUploadsManagerTests() {
            client = new CommonsManager().GetDefaultClient();
        }
        [TestMethod]
        public async System.Threading.Tasks.Task TestChunkedUpload() {
            int fileSize = 20 * 1024 * 1024;
            System.IO.Stream fileByteStream = Utils.GenerateByteStream(size: fileSize);
            string fileName = Utils.GetUUID();
            const string parentFolderId = "0";
            File uploadedFile = await client.ChunkedUploads.UploadBigFileAsync(file: fileByteStream, fileName: fileName, fileSize: fileSize, parentFolderId: parentFolderId).ConfigureAwait(false);
            Assert.IsTrue(uploadedFile.Name == fileName);
            Assert.IsTrue(uploadedFile.Size == fileSize);
            Assert.IsTrue(NullableUtils.Unwrap(uploadedFile.Parent).Id == parentFolderId);
            await client.Files.DeleteFileByIdAsync(fileId: uploadedFile.Id).ConfigureAwait(false);
        }

    }
}