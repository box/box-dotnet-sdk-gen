using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Box;
using Box.Schemas;
using Box.Managers;

namespace Box.Tests.Integration {
    [TestClass]
    public class FileClassificationsManagerTests {
        public BoxClient client { get; }

        public FileClassificationsManagerTests() {
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
        public async System.Threading.Tasks.Task TestFileClassifications() {
            ClassificationTemplate classificationTemplate = await new CommonsManager().GetOrCreateClassificationTemplateAsync().ConfigureAwait(false);
            ClassificationTemplateFieldsOptionsField classification = await new CommonsManager().GetOrCreateClassificationAsync(classificationTemplate: classificationTemplate).ConfigureAwait(false);
            FileFull file = await new CommonsManager().UploadNewFileAsync().ConfigureAwait(false);
            await Assert.That.IsExceptionAsync(async() => await client.FileClassifications.GetClassificationOnFileAsync(fileId: file.Id).ConfigureAwait(false));
            Classification createdFileClassification = await client.FileClassifications.AddClassificationToFileAsync(fileId: file.Id, requestBody: new AddClassificationToFileRequestBody() { BoxSecurityClassificationKey = classification.Key }).ConfigureAwait(false);
            Assert.IsTrue(createdFileClassification.BoxSecurityClassificationKey == classification.Key);
            Classification fileClassification = await client.FileClassifications.GetClassificationOnFileAsync(fileId: file.Id).ConfigureAwait(false);
            Assert.IsTrue(fileClassification.BoxSecurityClassificationKey == classification.Key);
            ClassificationTemplateFieldsOptionsField secondClassification = await GetOrCreateSecondClassificationAsync(classificationTemplate: classificationTemplate).ConfigureAwait(false);
            Classification updatedFileClassification = await client.FileClassifications.UpdateClassificationOnFileAsync(fileId: file.Id, requestBody: Array.AsReadOnly(new [] {new UpdateClassificationOnFileRequestBody(op: UpdateClassificationOnFileRequestBodyOpField.Replace, path: UpdateClassificationOnFileRequestBodyPathField.BoxSecurityClassificationKey, value: secondClassification.Key)})).ConfigureAwait(false);
            Assert.IsTrue(updatedFileClassification.BoxSecurityClassificationKey == secondClassification.Key);
            await client.FileClassifications.DeleteClassificationFromFileAsync(fileId: file.Id).ConfigureAwait(false);
            await Assert.That.IsExceptionAsync(async() => await client.FileClassifications.GetClassificationOnFileAsync(fileId: file.Id).ConfigureAwait(false));
            await client.Files.DeleteFileByIdAsync(fileId: file.Id).ConfigureAwait(false);
        }

    }
}