using Microsoft.VisualStudio.TestTools.UnitTesting;
using NullableExtensions;
using StringExtensions;
using System;
using Box.Sdk.Gen;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen.Managers;

namespace Box.Sdk.Gen.Tests.Integration {
    [TestClass]
    public class TaskAssignmentsManagerTests {
        public BoxClient client { get; }

        public TaskAssignmentsManagerTests() {
            client = new CommonsManager().GetDefaultClient();
        }
        [TestMethod]
        public async System.Threading.Tasks.Task TestCreateUpdateGetDeleteTaskAssignment() {
            FileFull file = await new CommonsManager().UploadNewFileAsync().ConfigureAwait(false);
            Task task = await client.Tasks.CreateTaskAsync(requestBody: new CreateTaskRequestBody(item: new CreateTaskRequestBodyItemField() { Type = CreateTaskRequestBodyItemTypeField.File, Id = file.Id }) { Message = "test message", DueAt = "2035-01-01T00:00:00Z", Action = CreateTaskRequestBodyActionField.Review, CompletionRule = CreateTaskRequestBodyCompletionRuleField.AllAssignees }).ConfigureAwait(false);
            Assert.IsTrue(task.Message == "test message");
            Assert.IsTrue(NullableUtils.Unwrap(task.Item).Id == file.Id);
            UserFull currentUser = await client.Users.GetUserMeAsync().ConfigureAwait(false);
            TaskAssignment taskAssignment = await client.TaskAssignments.CreateTaskAssignmentAsync(requestBody: new CreateTaskAssignmentRequestBody(task: new CreateTaskAssignmentRequestBodyTaskField(type: CreateTaskAssignmentRequestBodyTaskTypeField.Task, id: NullableUtils.Unwrap(task.Id)), assignTo: new CreateTaskAssignmentRequestBodyAssignToField() { Id = currentUser.Id })).ConfigureAwait(false);
            Assert.IsTrue(NullableUtils.Unwrap(taskAssignment.Item).Id == file.Id);
            Assert.IsTrue(NullableUtils.Unwrap(taskAssignment.AssignedTo).Id == currentUser.Id);
            TaskAssignment taskAssignmentById = await client.TaskAssignments.GetTaskAssignmentByIdAsync(taskAssignmentId: NullableUtils.Unwrap(taskAssignment.Id)).ConfigureAwait(false);
            Assert.IsTrue(taskAssignmentById.Id == taskAssignment.Id);
            TaskAssignments taskAssignmentsOnTask = await client.TaskAssignments.GetTaskAssignmentsAsync(taskId: NullableUtils.Unwrap(task.Id)).ConfigureAwait(false);
            Assert.IsTrue(NullableUtils.Unwrap(taskAssignmentsOnTask.TotalCount) == 1);
            TaskAssignment updatedTaskAssignment = await client.TaskAssignments.UpdateTaskAssignmentByIdAsync(taskAssignmentId: NullableUtils.Unwrap(taskAssignment.Id), requestBody: new UpdateTaskAssignmentByIdRequestBody() { Message = "updated message", ResolutionState = UpdateTaskAssignmentByIdRequestBodyResolutionStateField.Approved }).ConfigureAwait(false);
            Assert.IsTrue(updatedTaskAssignment.Message == "updated message");
            Assert.IsTrue(StringUtils.ToStringRepresentation(updatedTaskAssignment.ResolutionState) == "approved");
            await Assert.That.IsExceptionAsync(async() => await client.TaskAssignments.DeleteTaskAssignmentByIdAsync(taskAssignmentId: NullableUtils.Unwrap(taskAssignment.Id)).ConfigureAwait(false));
            await client.Files.DeleteFileByIdAsync(fileId: file.Id).ConfigureAwait(false);
        }

    }
}