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
    public class FolderMetadataManagerTests {
        public BoxClient client { get; }

        public FolderMetadataManagerTests() {
            client = new CommonsManager().GetDefaultClient();
        }
        [TestMethod]
        public async System.Threading.Tasks.Task TestFolderMetadata() {
            FolderFull folder = await new CommonsManager().CreateNewFolderAsync().ConfigureAwait(false);
            Metadatas folderMetadata = await client.FolderMetadata.GetFolderMetadataAsync(folderId: folder.Id).ConfigureAwait(false);
            Assert.IsTrue(NullableUtils.Unwrap(folderMetadata.Entries).Count == 0);
            MetadataFull createdMetadata = await client.FolderMetadata.CreateFolderMetadataByIdAsync(folderId: folder.Id, scope: CreateFolderMetadataByIdScope.Global, templateKey: "properties", requestBody: new Dictionary<string, string>() { { "abc", "xyz" } }).ConfigureAwait(false);
            Assert.IsTrue(StringUtils.ToStringRepresentation(createdMetadata.Template) == "properties");
            Assert.IsTrue(StringUtils.ToStringRepresentation(createdMetadata.Scope) == "global");
            Assert.IsTrue(createdMetadata.Version == 0);
            MetadataFull receivedMetadata = await client.FolderMetadata.GetFolderMetadataByIdAsync(folderId: folder.Id, scope: GetFolderMetadataByIdScope.Global, templateKey: "properties").ConfigureAwait(false);
            Assert.IsTrue(NullableUtils.Unwrap(receivedMetadata.ExtraData)["abc"] == "xyz");
            const string newValue = "bar";
            MetadataFull updatedMetadata = await client.FolderMetadata.UpdateFolderMetadataByIdAsync(folderId: folder.Id, scope: UpdateFolderMetadataByIdScope.Global, templateKey: "properties", requestBody: Array.AsReadOnly(new [] {new UpdateFolderMetadataByIdRequestBody() { Op = UpdateFolderMetadataByIdRequestBodyOpField.Replace, Path = "/abc", Value = newValue }})).ConfigureAwait(false);
            MetadataFull receivedUpdatedMetadata = await client.FolderMetadata.GetFolderMetadataByIdAsync(folderId: folder.Id, scope: GetFolderMetadataByIdScope.Global, templateKey: "properties").ConfigureAwait(false);
            Assert.IsTrue(NullableUtils.Unwrap(receivedUpdatedMetadata.ExtraData)["abc"] == newValue);
            await client.FolderMetadata.DeleteFolderMetadataByIdAsync(folderId: folder.Id, scope: DeleteFolderMetadataByIdScope.Global, templateKey: "properties").ConfigureAwait(false);
            await Assert.That.IsExceptionAsync(async() => await client.FolderMetadata.GetFolderMetadataByIdAsync(folderId: folder.Id, scope: GetFolderMetadataByIdScope.Global, templateKey: "properties").ConfigureAwait(false));
            await client.Folders.DeleteFolderByIdAsync(folderId: folder.Id).ConfigureAwait(false);
        }

    }
}