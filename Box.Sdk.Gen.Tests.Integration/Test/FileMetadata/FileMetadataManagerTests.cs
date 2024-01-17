using Microsoft.VisualStudio.TestTools.UnitTesting;
using NullableExtensions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using StringExtensions;
using System;
using Box.Sdk.Gen;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen.Managers;

namespace Box.Sdk.Gen.Tests.Integration {
    [TestClass]
    public class FileMetadataManagerTests {
        public BoxClient client { get; }

        public FileMetadataManagerTests() {
            client = new CommonsManager().GetDefaultClient();
        }
        [TestMethod]
        public async System.Threading.Tasks.Task TestFileMetadata() {
            FileFull file = await new CommonsManager().UploadNewFileAsync().ConfigureAwait(false);
            Metadatas fileMetadata = await client.FileMetadata.GetFileMetadataAsync(fileId: file.Id).ConfigureAwait(false);
            Assert.IsTrue(NullableUtils.Unwrap(fileMetadata.Entries).Count == 0);
            MetadataFull createdMetadata = await client.FileMetadata.CreateFileMetadataByIdAsync(fileId: file.Id, scope: CreateFileMetadataByIdScope.Global, templateKey: "properties", requestBody: new Dictionary<string, string>() { { "abc", "xyz" } }).ConfigureAwait(false);
            Assert.IsTrue(StringUtils.ToStringRepresentation(createdMetadata.Template) == "properties");
            Assert.IsTrue(StringUtils.ToStringRepresentation(createdMetadata.Scope) == "global");
            Assert.IsTrue(createdMetadata.Version == 0);
            MetadataFull receivedMetadata = await client.FileMetadata.GetFileMetadataByIdAsync(fileId: file.Id, scope: GetFileMetadataByIdScope.Global, templateKey: "properties").ConfigureAwait(false);
            Assert.IsTrue(NullableUtils.Unwrap(receivedMetadata.ExtraData)["abc"] == "xyz");
            const string newValue = "bar";
            MetadataFull updatedMetadata = await client.FileMetadata.UpdateFileMetadataByIdAsync(fileId: file.Id, scope: UpdateFileMetadataByIdScope.Global, templateKey: "properties", requestBody: Array.AsReadOnly(new [] {new UpdateFileMetadataByIdRequestBody() { Op = UpdateFileMetadataByIdRequestBodyOpField.Replace, Path = "/abc", Value = newValue }})).ConfigureAwait(false);
            MetadataFull receivedUpdatedMetadata = await client.FileMetadata.GetFileMetadataByIdAsync(fileId: file.Id, scope: GetFileMetadataByIdScope.Global, templateKey: "properties").ConfigureAwait(false);
            Assert.IsTrue(NullableUtils.Unwrap(receivedUpdatedMetadata.ExtraData)["abc"] == newValue);
            await client.FileMetadata.DeleteFileMetadataByIdAsync(fileId: file.Id, scope: DeleteFileMetadataByIdScope.Global, templateKey: "properties").ConfigureAwait(false);
            await Assert.That.IsExceptionAsync(async() => await client.FileMetadata.GetFileMetadataByIdAsync(fileId: file.Id, scope: GetFileMetadataByIdScope.Global, templateKey: "properties").ConfigureAwait(false));
            await client.Files.DeleteFileByIdAsync(fileId: file.Id).ConfigureAwait(false);
        }

    }
}