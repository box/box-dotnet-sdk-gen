using Microsoft.VisualStudio.TestTools.UnitTesting;
using NullableExtensions;
using Box.Sdk.Gen;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen.Managers;

namespace Box.Sdk.Gen.Tests.Integration {
    [TestClass]
    public class TasksManagerTests {
        public BoxClient client { get; }

        public TasksManagerTests() {
            client = new CommonsManager().GetDefaultClient();
        }
        [TestMethod]
        public async System.Threading.Tasks.Task TestCreateUpdateGetDeleteTask() {
            Files files = await client.Uploads.UploadFileAsync(requestBody: new UploadFileRequestBody(attributes: new UploadFileRequestBodyAttributesField(name: Utils.GetUUID(), parent: new UploadFileRequestBodyAttributesParentField(id: "0")), file: Utils.GenerateByteStream(size: 10))).ConfigureAwait(false);
            FileFull file = NullableUtils.Unwrap(files.Entries)[0];
            Task task = await client.Tasks.CreateTaskAsync(requestBody: new CreateTaskRequestBody(item: new CreateTaskRequestBodyItemField() { Type = CreateTaskRequestBodyItemTypeField.File, Id = file.Id }) { Message = "test message", DueAt = "2035-01-01T00:00:00Z", Action = CreateTaskRequestBodyActionField.Review, CompletionRule = CreateTaskRequestBodyCompletionRuleField.AllAssignees }).ConfigureAwait(false);
            Assert.IsTrue(task.Message == "test message");
            Assert.IsTrue(NullableUtils.Unwrap(task.Item).Id == file.Id);
            Task taskById = await client.Tasks.GetTaskByIdAsync(taskId: NullableUtils.Unwrap(task.Id)).ConfigureAwait(false);
            Assert.IsTrue(taskById.Id == task.Id);
            Tasks taskOnFile = await client.Tasks.GetFileTasksAsync(fileId: file.Id).ConfigureAwait(false);
            Assert.IsTrue(taskOnFile.TotalCount == 1);
            Task updatedTask = await client.Tasks.UpdateTaskByIdAsync(taskId: NullableUtils.Unwrap(task.Id), requestBody: new UpdateTaskByIdRequestBody() { Message = "updated message" }).ConfigureAwait(false);
            Assert.IsTrue(updatedTask.Message == "updated message");
            await client.Tasks.DeleteTaskByIdAsync(taskId: NullableUtils.Unwrap(task.Id)).ConfigureAwait(false);
            await client.Files.DeleteFileByIdAsync(fileId: file.Id).ConfigureAwait(false);
        }

    }
}