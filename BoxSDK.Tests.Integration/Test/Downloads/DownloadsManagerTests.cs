using Microsoft.VisualStudio.TestTools.UnitTesting;
using Box;
using Box.Schemas;
using Box.Managers;

namespace Box.Tests.Integration {
    [TestClass]
    public class DownloadsManagerTests {
        public JwtConfig jwtConfig { get; }

        public BoxJwtAuth auth { get; }

        public BoxClient client { get; }

        public DownloadsManagerTests() {
            jwtConfig = JwtConfig.FromConfigJsonString(Utils.DecodeBase64(Utils.GetEnvVar("JWT_CONFIG_BASE_64")));
            auth = new BoxJwtAuth(config: jwtConfig);
            client = new BoxClient(auth: auth);
        }
        [TestMethod]
        public async System.Threading.Tasks.Task TestDownloadFile() {
            string newFileName = Utils.GetUUID();
            byte[] fileBuffer = Utils.GenerateByteBuffer(1048576);
            System.IO.Stream fileContentStream = Utils.GenerateByteStreamFromBuffer(fileBuffer);
            Files uploadedFiles = await client.Uploads.UploadFile(new UploadFileRequestBodyArg(attributes: new UploadFileRequestBodyArgAttributesField(name: newFileName, parent: new UploadFileRequestBodyArgAttributesFieldParentField(id: "0")), file: fileContentStream));
            File uploadedFile = uploadedFiles.Entries[0];
            System.IO.Stream downloadedFileContent = await client.Downloads.DownloadFile(uploadedFile.Id);
            Assert.IsTrue(Utils.BufferEquals(await Utils.ReadByteStream(downloadedFileContent), fileBuffer));
            await client.Files.DeleteFileById(uploadedFile.Id);
        }

    }
}