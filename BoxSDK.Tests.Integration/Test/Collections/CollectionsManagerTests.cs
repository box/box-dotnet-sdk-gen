using Microsoft.VisualStudio.TestTools.UnitTesting;
using NullableExtensions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using Box;
using Box.Schemas;
using Box.Managers;

namespace Box.Tests.Integration {
    [TestClass]
    public class CollectionsManagerTests {
        public BoxClient client { get; }

        public CollectionsManagerTests() {
            client = new CommonsManager().GetDefaultClient();
        }
        [TestMethod]
        public async System.Threading.Tasks.Task TestCollections() {
            Collections collections = await client.Collections.GetCollectionsAsync().ConfigureAwait(false);
            Collection favouriteCollection = NullableUtils.Unwrap(collections.Entries)[0];
            Items collectionItems = await client.Collections.GetCollectionItemsAsync(collectionId: NullableUtils.Unwrap(favouriteCollection.Id)).ConfigureAwait(false);
            FolderFull folder = await client.Folders.CreateFolderAsync(requestBody: new CreateFolderRequestBody(name: Utils.GetUUID(), parent: new CreateFolderRequestBodyParentField(id: "0"))).ConfigureAwait(false);
            await client.Folders.UpdateFolderByIdAsync(folderId: folder.Id, requestBody: new UpdateFolderByIdRequestBody() { Collections = Array.AsReadOnly(new [] {new UpdateFolderByIdRequestBodyCollectionsField() { Id = favouriteCollection.Id }}) }).ConfigureAwait(false);
            Items collectionItemsAfterUpdate = await client.Collections.GetCollectionItemsAsync(collectionId: NullableUtils.Unwrap(favouriteCollection.Id)).ConfigureAwait(false);
            Assert.IsTrue(NullableUtils.Unwrap(collectionItemsAfterUpdate.Entries).Count == NullableUtils.Unwrap(collectionItems.Entries).Count + 1);
            await client.Folders.UpdateFolderByIdAsync(folderId: folder.Id, requestBody: new UpdateFolderByIdRequestBody() { Collections = Enumerable.Empty<UpdateFolderByIdRequestBodyCollectionsField>().ToList() }).ConfigureAwait(false);
            Items collectionItemsAfterRemove = await client.Collections.GetCollectionItemsAsync(collectionId: NullableUtils.Unwrap(favouriteCollection.Id)).ConfigureAwait(false);
            Assert.IsTrue(NullableUtils.Unwrap(collectionItemsAfterRemove.Entries).Count == NullableUtils.Unwrap(collectionItems.Entries).Count);
            await client.Folders.DeleteFolderByIdAsync(folderId: folder.Id).ConfigureAwait(false);
        }

    }
}