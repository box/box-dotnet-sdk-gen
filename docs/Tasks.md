# TasksManager


- [List tasks on file](#list-tasks-on-file)
- [Create task](#create-task)
- [Get task](#get-task)
- [Update task](#update-task)
- [Remove task](#remove-task)

## List tasks on file

Retrieves a list of all the tasks for a file. This
endpoint does not support pagination.

This operation is performed by calling function `GetFileTasks`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-files-id-tasks/).

<!-- sample get_files_id_tasks -->
```
await client.Tasks.GetFileTasks(file.Id)
```

### Arguments

- fileId `string`
  - The unique identifier that represents a file.  The ID for any file can be determined by visiting a file in the web application and copying the ID from the URL. For example, for the URL `https://*.app.box.com/files/123` the `file_id` is `123`. Example: "12345"
- headers `GetFileTasksHeadersArg`
  - Headers of getFileTasks method


### Returns

This function returns a value of type `Tasks`.

Returns a list of tasks on a file.

If there are no tasks on this file an empty collection is returned
instead.


## Create task

Creates a single task on a file. This task is not assigned to any user and
will need to be assigned separately.

This operation is performed by calling function `CreateTask`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/post-tasks/).

<!-- sample post_tasks -->
```
await client.Tasks.CreateTask(new CreateTaskRequestBodyArg(item: new CreateTaskRequestBodyArgItemField(type: CreateTaskRequestBodyArgItemFieldTypeField.File, id: file.Id), message: "test message", dueAt: "2035-01-01T00:00:00Z", action: CreateTaskRequestBodyArgActionField.Review, completionRule: CreateTaskRequestBodyArgCompletionRuleField.AllAssignees))
```

### Arguments

- requestBody `CreateTaskRequestBodyArg`
  - Request body of createTask method
- headers `CreateTaskHeadersArg`
  - Headers of createTask method


### Returns

This function returns a value of type `Task`.

Returns the newly created task.


## Get task

Retrieves information about a specific task.

This operation is performed by calling function `GetTaskById`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/get-tasks-id/).

<!-- sample get_tasks_id -->
```
await client.Tasks.GetTaskById(task.Id)
```

### Arguments

- taskId `string`
  - The ID of the task. Example: "12345"
- headers `GetTaskByIdHeadersArg`
  - Headers of getTaskById method


### Returns

This function returns a value of type `Task`.

Returns a task object.


## Update task

Updates a task. This can be used to update a task's configuration, or to
update its completion state.

This operation is performed by calling function `UpdateTaskById`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/put-tasks-id/).

<!-- sample put_tasks_id -->
```
await client.Tasks.UpdateTaskById(task.Id, new UpdateTaskByIdRequestBodyArg(message: "updated message"))
```

### Arguments

- taskId `string`
  - The ID of the task. Example: "12345"
- requestBody `UpdateTaskByIdRequestBodyArg`
  - Request body of updateTaskById method
- headers `UpdateTaskByIdHeadersArg`
  - Headers of updateTaskById method


### Returns

This function returns a value of type `Task`.

Returns the updated task object


## Remove task

Removes a task from a file.

This operation is performed by calling function `DeleteTaskById`.

See the endpoint docs at
[API Reference](https://developer.box.com/reference/delete-tasks-id/).

<!-- sample delete_tasks_id -->
```
await client.Tasks.DeleteTaskById(task.Id)
```

### Arguments

- taskId `string`
  - The ID of the task. Example: "12345"
- headers `DeleteTaskByIdHeadersArg`
  - Headers of deleteTaskById method


### Returns

This function returns a value of type `null`.

Returns an empty response when the task was successfully deleted.

