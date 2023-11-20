using Microsoft.VisualStudio.TestTools.UnitTesting;
using Box;
using Box.Schemas;
using Box.Managers;

namespace Box.Tests.Integration {
    [TestClass]
    public class DownloadsManagerTests {
        public BoxClient client { get; }

        public DownloadsManagerTests() {
            client = new CommonsManager().GetDefaultClient();
        }
        [TestMethod]
        public async System.Threading.Tasks.Task TestDownloadFile() {
            string newFileName = Utils.GetUUID();
            byte[] fileBuffer = Utils.GenerateByteBuffer(size: 1024 * 1024);
            System.IO.Stream fileContentStream = Utils.GenerateByteStreamFromBuffer(buffer: fileBuffer);
            Files uploadedFiles = await client.Uploads.UploadFileAsync(requestBody: new UploadFileRequestBodyArg(attributes: new UploadFileRequestBodyArgAttributesField(name: newFileName, parent: new UploadFileRequestBodyArgAttributesFieldParentField(id: "0")), file: fileContentStream)).ConfigureAwait(false);
            FileFull uploadedFile = uploadedFiles.Entries![0];
            System.IO.Stream downloadedFileContent = await client.Downloads.DownloadFileAsync(fileId: uploadedFile.Id).ConfigureAwait(false);
            Assert.IsTrue(Utils.BufferEquals(buffer1: await Utils.ReadByteStreamAsync(byteStream: downloadedFileContent).ConfigureAwait(false), buffer2: fileBuffer));
            await client.Files.DeleteFileByIdAsync(fileId: uploadedFile.Id).ConfigureAwait(false);
        }

    }
}