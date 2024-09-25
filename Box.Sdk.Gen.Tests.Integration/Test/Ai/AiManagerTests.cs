using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Sdk.Gen.Internal;
using Box.Sdk.Gen;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen.Managers;

namespace Box.Sdk.Gen.Tests.Integration {
    [TestClass]
    public class AiManagerTests {
        public BoxClient client { get; }

        public AiManagerTests() {
            client = new CommonsManager().GetDefaultClient();
        }
        [TestMethod]
        public async System.Threading.Tasks.Task TestAskAiSingleItem() {
            FileFull fileToAsk = await new CommonsManager().UploadNewFileAsync();
            AiResponseFull response = await client.Ai.CreateAiAskAsync(requestBody: new AiAsk(mode: AiAskModeField.SingleItemQa, prompt: "which direction sun rises", items: Array.AsReadOnly(new [] {new AiItemBase(id: fileToAsk.Id, type: AiItemBaseTypeField.File) { Content = "Sun rises in the East" }})));
            Assert.IsTrue(response.Answer.Contains("East"));
            Assert.IsTrue(response.CompletionReason == "done");
            await client.Files.DeleteFileByIdAsync(fileId: fileToAsk.Id);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestAskAiMultipleItems() {
            FileFull fileToAsk1 = await new CommonsManager().UploadNewFileAsync();
            FileFull fileToAsk2 = await new CommonsManager().UploadNewFileAsync();
            AiResponseFull response = await client.Ai.CreateAiAskAsync(requestBody: new AiAsk(mode: AiAskModeField.MultipleItemQa, prompt: "Which direction sun rises?", items: Array.AsReadOnly(new [] {new AiItemBase(id: fileToAsk1.Id, type: AiItemBaseTypeField.File) { Content = "Earth goes around the sun" },new AiItemBase(id: fileToAsk2.Id, type: AiItemBaseTypeField.File) { Content = "Sun rises in the East in the morning" }})));
            Assert.IsTrue(response.Answer.Contains("East"));
            Assert.IsTrue(response.CompletionReason == "done");
            await client.Files.DeleteFileByIdAsync(fileId: fileToAsk1.Id);
            await client.Files.DeleteFileByIdAsync(fileId: fileToAsk2.Id);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestAiTextGenWithDialogueHistory() {
            FileFull fileToAsk = await new CommonsManager().UploadNewFileAsync();
            AiResponse response = await client.Ai.CreateAiTextGenAsync(requestBody: new AiTextGen(prompt: "Parapharse the document.s", items: Array.AsReadOnly(new [] {new AiTextGenItemsField(id: fileToAsk.Id, type: AiTextGenItemsTypeField.File) { Content = "The Earth goes around the sun. Sun rises in the East in the morning." }})) { DialogueHistory = Array.AsReadOnly(new [] {new AiDialogueHistory() { Prompt = "What does the earth go around?", Answer = "The sun", CreatedAt = Utils.DateTimeFromString(dateTime: "2021-01-01T00:00:00Z") },new AiDialogueHistory() { Prompt = "On Earth, where does the sun rise?", Answer = "East", CreatedAt = Utils.DateTimeFromString(dateTime: "2021-01-01T00:00:00Z") }}) });
            Assert.IsTrue(response.Answer.Contains("sun"));
            Assert.IsTrue(response.CompletionReason == "done");
            await client.Files.DeleteFileByIdAsync(fileId: fileToAsk.Id);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestGettingAiAskAgentConfig() {
            AiAgentAskOrAiAgentExtractOrAiAgentExtractStructuredOrAiAgentTextGen aiAskConfig = await client.Ai.GetAiAgentDefaultConfigAsync(queryParams: new GetAiAgentDefaultConfigQueryParams(mode: GetAiAgentDefaultConfigQueryParamsModeField.Ask) { Language = "en-US" });
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestGettingAiTextGenAgentConfig() {
            AiAgentAskOrAiAgentExtractOrAiAgentExtractStructuredOrAiAgentTextGen aiTextGenConfig = await client.Ai.GetAiAgentDefaultConfigAsync(queryParams: new GetAiAgentDefaultConfigQueryParams(mode: GetAiAgentDefaultConfigQueryParamsModeField.TextGen) { Language = "en-US" });
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestAiExtract() {
            Files uploadedFiles = await client.Uploads.UploadFileAsync(requestBody: new UploadFileRequestBody(attributes: new UploadFileRequestBodyAttributesField(name: string.Concat(Utils.GetUUID(), ".txt"), parent: new UploadFileRequestBodyAttributesParentField(id: "0")), file: Utils.StringToByteStream(text: "My name is John Doe. I live in San Francisco. I was born in 1990. I work at Box.")));
            FileFull file = NullableUtils.Unwrap(uploadedFiles.Entries)[0];
            await Utils.DelayInSecondsAsync(seconds: 5);
            AiResponse response = await client.Ai.CreateAiExtractAsync(requestBody: new AiExtract(prompt: "firstName, lastName, location, yearOfBirth, company", items: Array.AsReadOnly(new [] {new AiItemBase(id: file.Id)})));
            const string expectedResponse = "{\"firstName\": \"John\", \"lastName\": \"Doe\", \"location\": \"San Francisco\", \"yearOfBirth\": \"1990\", \"company\": \"Box\"}";
            Assert.IsTrue(response.Answer == expectedResponse);
            Assert.IsTrue(response.CompletionReason == "done");
            await client.Files.DeleteFileByIdAsync(fileId: file.Id);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestAiExtractStructuredWithFields() {
            Files uploadedFiles = await client.Uploads.UploadFileAsync(requestBody: new UploadFileRequestBody(attributes: new UploadFileRequestBodyAttributesField(name: string.Concat(Utils.GetUUID(), ".txt"), parent: new UploadFileRequestBodyAttributesParentField(id: "0")), file: Utils.StringToByteStream(text: "My name is John Doe. I was born in 4th July 1990. I am 34 years old. My hobby is guitar and books.")));
            FileFull file = NullableUtils.Unwrap(uploadedFiles.Entries)[0];
            await Utils.DelayInSecondsAsync(seconds: 5);
            AiExtractResponse response = await client.Ai.CreateAiExtractStructuredAsync(requestBody: new AiExtractStructured(items: Array.AsReadOnly(new [] {new AiItemBase(id: file.Id)})) { Fields = Array.AsReadOnly(new [] {new AiExtractStructuredFieldsField(key: "firstName") { DisplayName = "First name", Description = "Person first name", Prompt = "What is the your first name?", Type = "string" },new AiExtractStructuredFieldsField(key: "lastName") { DisplayName = "Last name", Description = "Person last name", Prompt = "What is the your last name?", Type = "string" },new AiExtractStructuredFieldsField(key: "dateOfBirth") { DisplayName = "Birth date", Description = "Person date of birth", Prompt = "What is the date of your birth?", Type = "date" },new AiExtractStructuredFieldsField(key: "age") { DisplayName = "Age", Description = "Person age", Prompt = "How old are you?", Type = "float" },new AiExtractStructuredFieldsField(key: "hobby") { DisplayName = "Hobby", Description = "Person hobby", Prompt = "What is your hobby?", Type = "multiSelect" }}) });
            Assert.IsTrue(StringUtils.ToStringRepresentation(Utils.GetValueFromObjectRawData(obj: response, key: "firstName")) == "John");
            Assert.IsTrue(StringUtils.ToStringRepresentation(Utils.GetValueFromObjectRawData(obj: response, key: "lastName")) == "Doe");
            Assert.IsTrue(StringUtils.ToStringRepresentation(Utils.GetValueFromObjectRawData(obj: response, key: "dateOfBirth")) == "1990-07-04");
            Assert.IsTrue(StringUtils.ToStringRepresentation(Utils.GetValueFromObjectRawData(obj: response, key: "age")) == "34");
            Assert.IsTrue(StringUtils.ToStringRepresentation(Utils.GetValueFromObjectRawData(obj: response, key: "hobby")) == StringUtils.ToStringRepresentation(Array.AsReadOnly(new [] {"guitar","books"})));
            await client.Files.DeleteFileByIdAsync(fileId: file.Id);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestAiExtractStructuredWithMetadataTemplate() {
            Files uploadedFiles = await client.Uploads.UploadFileAsync(requestBody: new UploadFileRequestBody(attributes: new UploadFileRequestBodyAttributesField(name: string.Concat(Utils.GetUUID(), ".txt"), parent: new UploadFileRequestBodyAttributesParentField(id: "0")), file: Utils.StringToByteStream(text: "My name is John Doe. I was born in 4th July 1990. I am 34 years old. My hobby is guitar and books.")));
            FileFull file = NullableUtils.Unwrap(uploadedFiles.Entries)[0];
            await Utils.DelayInSecondsAsync(seconds: 5);
            string templateKey = string.Concat("key", Utils.GetUUID());
            MetadataTemplate template = await client.MetadataTemplates.CreateMetadataTemplateAsync(requestBody: new CreateMetadataTemplateRequestBody(scope: "enterprise", displayName: templateKey) { TemplateKey = templateKey, Fields = Array.AsReadOnly(new [] {new CreateMetadataTemplateRequestBodyFieldsField(key: "firstName", displayName: "First name", type: CreateMetadataTemplateRequestBodyFieldsTypeField.String) { Description = "Person first name" },new CreateMetadataTemplateRequestBodyFieldsField(key: "lastName", displayName: "Last name", type: CreateMetadataTemplateRequestBodyFieldsTypeField.String) { Description = "Person last name" },new CreateMetadataTemplateRequestBodyFieldsField(key: "dateOfBirth", displayName: "Birth date", type: CreateMetadataTemplateRequestBodyFieldsTypeField.Date) { Description = "Person date of birth" },new CreateMetadataTemplateRequestBodyFieldsField(key: "age", displayName: "Age", type: CreateMetadataTemplateRequestBodyFieldsTypeField.Float) { Description = "Person age" },new CreateMetadataTemplateRequestBodyFieldsField(key: "hobby", displayName: "Hobby", type: CreateMetadataTemplateRequestBodyFieldsTypeField.MultiSelect) { Description = "Person hobby" }}) });
            AiExtractResponse response = await client.Ai.CreateAiExtractStructuredAsync(requestBody: new AiExtractStructured(items: Array.AsReadOnly(new [] {new AiItemBase(id: file.Id)})) { MetadataTemplate = new AiExtractStructuredMetadataTemplateField() { TemplateKey = templateKey, Scope = "enterprise" } });
            Assert.IsTrue(StringUtils.ToStringRepresentation(Utils.GetValueFromObjectRawData(obj: response, key: "firstName")) == "John");
            Assert.IsTrue(StringUtils.ToStringRepresentation(Utils.GetValueFromObjectRawData(obj: response, key: "lastName")) == "Doe");
            Assert.IsTrue(StringUtils.ToStringRepresentation(Utils.GetValueFromObjectRawData(obj: response, key: "dateOfBirth")) == "1990-07-04");
            Assert.IsTrue(StringUtils.ToStringRepresentation(Utils.GetValueFromObjectRawData(obj: response, key: "age")) == "34");
            Assert.IsTrue(StringUtils.ToStringRepresentation(Utils.GetValueFromObjectRawData(obj: response, key: "hobby")) == StringUtils.ToStringRepresentation(Array.AsReadOnly(new [] {"guitar","books"})));
            await client.MetadataTemplates.DeleteMetadataTemplateAsync(scope: DeleteMetadataTemplateScope.Enterprise, templateKey: NullableUtils.Unwrap(template.TemplateKey));
            await client.Files.DeleteFileByIdAsync(fileId: file.Id);
        }

    }
}