using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using NullableExtensions;
using Box.Sdk.Gen;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen.Managers;

namespace Box.Sdk.Gen.Tests.Integration {
    [TestClass]
    public class SearchManagerTests {
        public BoxClient client { get; }

        public SearchManagerTests() {
            client = new CommonsManager().GetDefaultClient();
        }
        [TestMethod]
        public async System.Threading.Tasks.Task TestMetadataFilters() {
            string templateKey = string.Concat("key", Utils.GetUUID());
            MetadataTemplate template = await client.MetadataTemplates.CreateMetadataTemplateAsync(requestBody: new CreateMetadataTemplateRequestBody(scope: "enterprise", displayName: templateKey) { TemplateKey = templateKey, Fields = Array.AsReadOnly(new [] {new CreateMetadataTemplateRequestBodyFieldsField(type: CreateMetadataTemplateRequestBodyFieldsTypeField.String, key: "stringField", displayName: "stringField")}) });
            Files files = await client.Uploads.UploadFileAsync(requestBody: new UploadFileRequestBody(attributes: new UploadFileRequestBodyAttributesField(name: Utils.GetUUID(), parent: new UploadFileRequestBodyAttributesParentField(id: "0")), file: Utils.GenerateByteStream(size: 10)));
            FileFull file = NullableUtils.Unwrap(files.Entries)[0];
            await client.FileMetadata.CreateFileMetadataByIdAsync(fileId: file.Id, scope: CreateFileMetadataByIdScope.Enterprise, templateKey: templateKey, requestBody: new Dictionary<string, string>() { { "stringField", "stringValue" } });
            SearchResultsOrSearchResultsWithSharedLinks stringQuery = await client.Search.SearchForContentAsync(queryParams: new SearchForContentQueryParams() { AncestorFolderIds = Array.AsReadOnly(new [] {"0"}), Mdfilters = Array.AsReadOnly(new [] {new MetadataFilter() { Filters = new Dictionary<string, string>() { { "stringField", "stringValue" } }, Scope = MetadataFilterScopeField.Enterprise, TemplateKey = templateKey }}) });
            Assert.IsTrue(stringQuery != null);
            await client.MetadataTemplates.DeleteMetadataTemplateAsync(scope: DeleteMetadataTemplateScope.Enterprise, templateKey: templateKey);
            await client.Files.DeleteFileByIdAsync(fileId: file.Id);
        }

    }
}