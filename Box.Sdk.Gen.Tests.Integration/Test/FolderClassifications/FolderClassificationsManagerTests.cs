using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Box.Sdk.Gen;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen.Managers;

namespace Box.Sdk.Gen.Tests.Integration {
    [TestClass]
    public class FolderClassificationsManagerTests {
        public BoxClient client { get; }

        public FolderClassificationsManagerTests() {
            client = new CommonsManager().GetDefaultClient();
        }
        public async System.Threading.Tasks.Task<ClassificationTemplateFieldsOptionsField> GetOrCreateSecondClassificationAsync(ClassificationTemplate classificationTemplate) {
            IReadOnlyList<ClassificationTemplateFieldsOptionsField> classifications = classificationTemplate.Fields[0].Options;
            int currentNumberOfClassifications = classifications.Count;
            if (currentNumberOfClassifications == 1) {
                ClassificationTemplate classificationTemplateWithNewClassification = await client.Classifications.AddClassificationAsync(requestBody: Array.AsReadOnly(new [] {new AddClassificationRequestBody(op: AddClassificationRequestBodyOpField.AddEnumOption, fieldKey: AddClassificationRequestBodyFieldKeyField.BoxSecurityClassificationKey, data: new AddClassificationRequestBodyDataField(key: Utils.GetUUID()) { StaticConfig = new AddClassificationRequestBodyDataStaticConfigField() { Classification = new AddClassificationRequestBodyDataStaticConfigClassificationField() { ColorId = 4, ClassificationDefinition = "Other description" } } })})).ConfigureAwait(false);
                return classificationTemplateWithNewClassification.Fields[0].Options[1];
            }
            return classifications.ElementAt(1);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestFolderClassifications() {
            ClassificationTemplate classificationTemplate = await new CommonsManager().GetOrCreateClassificationTemplateAsync().ConfigureAwait(false);
            ClassificationTemplateFieldsOptionsField classification = await new CommonsManager().GetOrCreateClassificationAsync(classificationTemplate: classificationTemplate).ConfigureAwait(false);
            FolderFull folder = await new CommonsManager().CreateNewFolderAsync().ConfigureAwait(false);
            await Assert.That.IsExceptionAsync(async() => await client.FolderClassifications.GetClassificationOnFolderAsync(folderId: folder.Id).ConfigureAwait(false));
            Classification createdFolderClassification = await client.FolderClassifications.AddClassificationToFolderAsync(folderId: folder.Id, requestBody: new AddClassificationToFolderRequestBody() { BoxSecurityClassificationKey = classification.Key }).ConfigureAwait(false);
            Assert.IsTrue(createdFolderClassification.BoxSecurityClassificationKey == classification.Key);
            Classification folderClassification = await client.FolderClassifications.GetClassificationOnFolderAsync(folderId: folder.Id).ConfigureAwait(false);
            Assert.IsTrue(folderClassification.BoxSecurityClassificationKey == classification.Key);
            ClassificationTemplateFieldsOptionsField secondClassification = await GetOrCreateSecondClassificationAsync(classificationTemplate: classificationTemplate).ConfigureAwait(false);
            Classification updatedFolderClassification = await client.FolderClassifications.UpdateClassificationOnFolderAsync(folderId: folder.Id, requestBody: Array.AsReadOnly(new [] {new UpdateClassificationOnFolderRequestBody(op: UpdateClassificationOnFolderRequestBodyOpField.Replace, path: UpdateClassificationOnFolderRequestBodyPathField.BoxSecurityClassificationKey, value: secondClassification.Key)})).ConfigureAwait(false);
            Assert.IsTrue(updatedFolderClassification.BoxSecurityClassificationKey == secondClassification.Key);
            await client.FolderClassifications.DeleteClassificationFromFolderAsync(folderId: folder.Id).ConfigureAwait(false);
            await Assert.That.IsExceptionAsync(async() => await client.FolderClassifications.GetClassificationOnFolderAsync(folderId: folder.Id).ConfigureAwait(false));
            await client.Folders.DeleteFolderByIdAsync(folderId: folder.Id).ConfigureAwait(false);
        }

    }
}