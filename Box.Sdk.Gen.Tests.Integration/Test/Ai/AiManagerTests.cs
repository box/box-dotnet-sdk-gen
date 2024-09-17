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
            Utils.DelayInSeconds(seconds: 1);
            AiResponse response = await client.Ai.CreateAiExtractAsync(requestBody: new AiExtract(prompt: "firstName, lastName, location, yearOfBirth, company", items: Array.AsReadOnly(new [] {new AiItemBase(id: file.Id)})));
            const string expectedResponse = "{\"firstName\": \"John\", \"lastName\": \"Doe\", \"location\": \"San Francisco\", \"yearOfBirth\": \"1990\", \"company\": \"Box\"}";
            Assert.IsTrue(response.Answer == expectedResponse);
            Assert.IsTrue(response.CompletionReason == "done");
            await client.Files.DeleteFileByIdAsync(fileId: file.Id);
        }

    }
}