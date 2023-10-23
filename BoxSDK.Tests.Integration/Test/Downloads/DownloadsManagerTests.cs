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
            byte[] fileBuffer = Utils.GenerateByteBuffer(1048576);
            System.IO.Stream fileContentStream = Utils.GenerateByteStreamFromBuffer(fileBuffer);
            Files uploadedFiles = await client.Uploads.UploadFileAsync(new UploadFileRequestBodyArg(attributes: new UploadFileRequestBodyArgAttributesField(name: newFileName, parent: new UploadFileRequestBodyArgAttributesFieldParentField(id: "0")), file: fileContentStream)).ConfigureAwait(false);
            File uploadedFile = uploadedFiles.Entries![0];
            System.IO.Stream downloadedFileContent = await client.Downloads.DownloadFileAsync(uploadedFile.Id).ConfigureAwait(false);
            Assert.IsTrue(Utils.BufferEquals(await Utils.ReadByteStreamAsync(downloadedFileContent).ConfigureAwait(false), fileBuffer));
            await client.Files.DeleteFileByIdAsync(uploadedFile.Id).ConfigureAwait(false);
        }

    }
}