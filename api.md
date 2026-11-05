# API Reference

> [!CAUTION]
> **`box-dotnet-sdk-gen` is deprecated and no longer maintained.** As of September 17, 2025, it receives no new features, bug fixes, or security patches. Do not use it for new projects.
>
> Use [`box-windows-sdk-v2`](https://github.com/box/box-windows-sdk-v2) v10+ instead: `Install-Package Box.V2.Core`. `box-windows-sdk-v2` v10 includes every manager listed below, plus newer ones.
> To migrate existing code, see the [migration guide](https://github.com/box/box-windows-sdk-v2/blob/main/migration-guides/from-dotnet-sdk-gen-v1-to-box-windows-sdk.md).

This file lists every manager and method exposed on `BoxClient`. For setup, authentication, and usage examples, see [README.md](README.md). Each section links to a page in [docs/](docs/README.md) with code samples. Parameters marked `?` are optional.

# Client

See [docs/Client.md](docs/Client.md).

Methods:

- <code>client.<a href="./Box.Sdk.Gen/Client/BoxClient.cs">MakeRequestAsync</a>(fetchOptions) -> FetchResponse</code>
- <code>client.<a href="./Box.Sdk.Gen/Client/BoxClient.cs">WithAsUserHeader</a>(userId) -> BoxClient</code>
- <code>client.<a href="./Box.Sdk.Gen/Client/BoxClient.cs">WithSuppressedNotifications</a>() -> BoxClient</code>
- <code>client.<a href="./Box.Sdk.Gen/Client/BoxClient.cs">WithExtraHeaders</a>(extraHeaders?) -> BoxClient</code>
- <code>client.<a href="./Box.Sdk.Gen/Client/BoxClient.cs">WithCustomBaseUrls</a>(baseUrls) -> BoxClient</code>
- <code>client.<a href="./Box.Sdk.Gen/Client/BoxClient.cs">WithProxy</a>(config) -> BoxClient</code>

# Authorization

Examples: [docs/Authorization.md](docs/Authorization.md)

Methods:

- <code title="get /authorize">client.Authorization.<a href="./Box.Sdk.Gen/Managers/Authorization/AuthorizationManager.cs">AuthorizeUserAsync</a>(queryParams, headers?, cancellationToken?) -> void</code>
- <code title="post /oauth2/token">client.Authorization.<a href="./Box.Sdk.Gen/Managers/Authorization/AuthorizationManager.cs">RequestAccessTokenAsync</a>(requestBody, headers?, cancellationToken?) -> AccessToken</code>
- <code title="post /oauth2/token">client.Authorization.<a href="./Box.Sdk.Gen/Managers/Authorization/AuthorizationManager.cs">RefreshAccessTokenAsync</a>(requestBody, headers?, cancellationToken?) -> AccessToken</code>
- <code title="post /oauth2/revoke">client.Authorization.<a href="./Box.Sdk.Gen/Managers/Authorization/AuthorizationManager.cs">RevokeAccessTokenAsync</a>(requestBody, headers?, cancellationToken?) -> void</code>

# Files

Examples: [docs/Files.md](docs/Files.md)

Methods:

- <code title="get /2.0/files/{fileId}">client.Files.<a href="./Box.Sdk.Gen/Managers/Files/FilesManager.cs">GetFileByIdAsync</a>(fileId, queryParams?, headers?, cancellationToken?) -> FileFull</code>
- <code title="put /2.0/files/{fileId}">client.Files.<a href="./Box.Sdk.Gen/Managers/Files/FilesManager.cs">UpdateFileByIdAsync</a>(fileId, requestBody?, queryParams?, headers?, cancellationToken?) -> FileFull</code>
- <code title="delete /2.0/files/{fileId}">client.Files.<a href="./Box.Sdk.Gen/Managers/Files/FilesManager.cs">DeleteFileByIdAsync</a>(fileId, headers?, cancellationToken?) -> void</code>
- <code title="post /2.0/files/{fileId}/copy">client.Files.<a href="./Box.Sdk.Gen/Managers/Files/FilesManager.cs">CopyFileAsync</a>(fileId, requestBody, queryParams?, headers?, cancellationToken?) -> FileFull</code>
- <code title="get /2.0/files/{fileId}/thumbnail.{extension}">client.Files.<a href="./Box.Sdk.Gen/Managers/Files/FilesManager.cs">GetFileThumbnailUrlAsync</a>(fileId, extension, queryParams?, headers?, cancellationToken?) -> string</code>
- <code title="get /2.0/files/{fileId}/thumbnail.{extension}">client.Files.<a href="./Box.Sdk.Gen/Managers/Files/FilesManager.cs">GetFileThumbnailByIdAsync</a>(fileId, extension, queryParams?, headers?, cancellationToken?) -> System.IO.Stream?</code>

# Trashed files

Examples: [docs/TrashedFiles.md](docs/TrashedFiles.md)

Methods:

- <code title="post /2.0/files/{fileId}">client.TrashedFiles.<a href="./Box.Sdk.Gen/Managers/TrashedFiles/TrashedFilesManager.cs">RestoreFileFromTrashAsync</a>(fileId, requestBody?, queryParams?, headers?, cancellationToken?) -> TrashFileRestored</code>
- <code title="get /2.0/files/{fileId}/trash">client.TrashedFiles.<a href="./Box.Sdk.Gen/Managers/TrashedFiles/TrashedFilesManager.cs">GetTrashedFileByIdAsync</a>(fileId, queryParams?, headers?, cancellationToken?) -> TrashFile</code>
- <code title="delete /2.0/files/{fileId}/trash">client.TrashedFiles.<a href="./Box.Sdk.Gen/Managers/TrashedFiles/TrashedFilesManager.cs">DeleteTrashedFileByIdAsync</a>(fileId, headers?, cancellationToken?) -> void</code>

# App item associations

Examples: [docs/AppItemAssociations.md](docs/AppItemAssociations.md)

Methods:

- <code title="get /2.0/files/{fileId}/app_item_associations">client.AppItemAssociations.<a href="./Box.Sdk.Gen/Managers/AppItemAssociations/AppItemAssociationsManager.cs">GetFileAppItemAssociationsAsync</a>(fileId, queryParams?, headers?, cancellationToken?) -> AppItemAssociations</code>
- <code title="get /2.0/folders/{folderId}/app_item_associations">client.AppItemAssociations.<a href="./Box.Sdk.Gen/Managers/AppItemAssociations/AppItemAssociationsManager.cs">GetFolderAppItemAssociationsAsync</a>(folderId, queryParams?, headers?, cancellationToken?) -> AppItemAssociations</code>

# Downloads

Examples: [docs/Downloads.md](docs/Downloads.md)

Methods:

- <code title="get /2.0/files/{fileId}/content">client.Downloads.<a href="./Box.Sdk.Gen/Managers/Downloads/DownloadsManager.cs">GetDownloadFileUrlAsync</a>(fileId, queryParams?, headers?, cancellationToken?) -> string</code>
- <code title="get /2.0/files/{fileId}/content">client.Downloads.<a href="./Box.Sdk.Gen/Managers/Downloads/DownloadsManager.cs">DownloadFileAsync</a>(fileId, queryParams?, headers?, cancellationToken?) -> System.IO.Stream?</code>

# Uploads

Examples: [docs/Uploads.md](docs/Uploads.md)

Methods:

- <code title="post /2.0/files/{fileId}/content">client.Uploads.<a href="./Box.Sdk.Gen/Managers/Uploads/UploadsManager.cs">UploadFileVersionAsync</a>(fileId, requestBody, queryParams?, headers?, cancellationToken?) -> Files</code>
- <code title="options /2.0/files/content">client.Uploads.<a href="./Box.Sdk.Gen/Managers/Uploads/UploadsManager.cs">PreflightFileUploadCheckAsync</a>(requestBody?, headers?, cancellationToken?) -> UploadUrl</code>
- <code title="post /2.0/files/content">client.Uploads.<a href="./Box.Sdk.Gen/Managers/Uploads/UploadsManager.cs">UploadFileAsync</a>(requestBody, queryParams?, headers?, cancellationToken?) -> Files</code>
- <code>client.Uploads.<a href="./Box.Sdk.Gen/Managers/Uploads/UploadsManager.cs">UploadWithPreflightCheckAsync</a>(requestBody, queryParams?, headers?, cancellationToken?) -> Files</code>

# Chunked uploads

Examples: [docs/ChunkedUploads.md](docs/ChunkedUploads.md)

Methods:

- <code title="post /2.0/files/upload_sessions">client.ChunkedUploads.<a href="./Box.Sdk.Gen/Managers/ChunkedUploads/ChunkedUploadsManager.cs">CreateFileUploadSessionAsync</a>(requestBody, headers?, cancellationToken?) -> UploadSession</code>
- <code title="post /2.0/files/{fileId}/upload_sessions">client.ChunkedUploads.<a href="./Box.Sdk.Gen/Managers/ChunkedUploads/ChunkedUploadsManager.cs">CreateFileUploadSessionForExistingFileAsync</a>(fileId, requestBody, headers?, cancellationToken?) -> UploadSession</code>
- <code>client.ChunkedUploads.<a href="./Box.Sdk.Gen/Managers/ChunkedUploads/ChunkedUploadsManager.cs">GetFileUploadSessionByUrlAsync</a>(url, headers?, cancellationToken?) -> UploadSession</code>
- <code title="get /2.0/files/upload_sessions/{uploadSessionId}">client.ChunkedUploads.<a href="./Box.Sdk.Gen/Managers/ChunkedUploads/ChunkedUploadsManager.cs">GetFileUploadSessionByIdAsync</a>(uploadSessionId, headers?, cancellationToken?) -> UploadSession</code>
- <code>client.ChunkedUploads.<a href="./Box.Sdk.Gen/Managers/ChunkedUploads/ChunkedUploadsManager.cs">UploadFilePartByUrlAsync</a>(url, requestBody, headers, cancellationToken?) -> UploadedPart</code>
- <code title="put /2.0/files/upload_sessions/{uploadSessionId}">client.ChunkedUploads.<a href="./Box.Sdk.Gen/Managers/ChunkedUploads/ChunkedUploadsManager.cs">UploadFilePartAsync</a>(uploadSessionId, requestBody, headers, cancellationToken?) -> UploadedPart</code>
- <code>client.ChunkedUploads.<a href="./Box.Sdk.Gen/Managers/ChunkedUploads/ChunkedUploadsManager.cs">DeleteFileUploadSessionByUrlAsync</a>(url, headers?, cancellationToken?) -> void</code>
- <code title="delete /2.0/files/upload_sessions/{uploadSessionId}">client.ChunkedUploads.<a href="./Box.Sdk.Gen/Managers/ChunkedUploads/ChunkedUploadsManager.cs">DeleteFileUploadSessionByIdAsync</a>(uploadSessionId, headers?, cancellationToken?) -> void</code>
- <code>client.ChunkedUploads.<a href="./Box.Sdk.Gen/Managers/ChunkedUploads/ChunkedUploadsManager.cs">GetFileUploadSessionPartsByUrlAsync</a>(url, queryParams?, headers?, cancellationToken?) -> UploadParts</code>
- <code title="get /2.0/files/upload_sessions/{uploadSessionId}/parts">client.ChunkedUploads.<a href="./Box.Sdk.Gen/Managers/ChunkedUploads/ChunkedUploadsManager.cs">GetFileUploadSessionPartsAsync</a>(uploadSessionId, queryParams?, headers?, cancellationToken?) -> UploadParts</code>
- <code>client.ChunkedUploads.<a href="./Box.Sdk.Gen/Managers/ChunkedUploads/ChunkedUploadsManager.cs">CreateFileUploadSessionCommitByUrlAsync</a>(url, requestBody, headers, cancellationToken?) -> Files?</code>
- <code title="post /2.0/files/upload_sessions/{uploadSessionId}/commit">client.ChunkedUploads.<a href="./Box.Sdk.Gen/Managers/ChunkedUploads/ChunkedUploadsManager.cs">CreateFileUploadSessionCommitAsync</a>(uploadSessionId, requestBody, headers, cancellationToken?) -> Files?</code>
- <code>client.ChunkedUploads.<a href="./Box.Sdk.Gen/Managers/ChunkedUploads/ChunkedUploadsManager.cs">UploadBigFileAsync</a>(file, fileName, fileSize, parentFolderId, cancellationToken?) -> FileFull</code>

# List collaborations

Examples: [docs/ListCollaborations.md](docs/ListCollaborations.md)

Methods:

- <code title="get /2.0/files/{fileId}/collaborations">client.ListCollaborations.<a href="./Box.Sdk.Gen/Managers/ListCollaborations/ListCollaborationsManager.cs">GetFileCollaborationsAsync</a>(fileId, queryParams?, headers?, cancellationToken?) -> Collaborations</code>
- <code title="get /2.0/folders/{folderId}/collaborations">client.ListCollaborations.<a href="./Box.Sdk.Gen/Managers/ListCollaborations/ListCollaborationsManager.cs">GetFolderCollaborationsAsync</a>(folderId, queryParams?, headers?, cancellationToken?) -> Collaborations</code>
- <code title="get /2.0/collaborations">client.ListCollaborations.<a href="./Box.Sdk.Gen/Managers/ListCollaborations/ListCollaborationsManager.cs">GetCollaborationsAsync</a>(queryParams, headers?, cancellationToken?) -> CollaborationsOffsetPaginated</code>
- <code title="get /2.0/groups/{groupId}/collaborations">client.ListCollaborations.<a href="./Box.Sdk.Gen/Managers/ListCollaborations/ListCollaborationsManager.cs">GetGroupCollaborationsAsync</a>(groupId, queryParams?, headers?, cancellationToken?) -> CollaborationsOffsetPaginated</code>

# Comments

Examples: [docs/Comments.md](docs/Comments.md)

Methods:

- <code title="get /2.0/files/{fileId}/comments">client.Comments.<a href="./Box.Sdk.Gen/Managers/Comments/CommentsManager.cs">GetFileCommentsAsync</a>(fileId, queryParams?, headers?, cancellationToken?) -> Comments</code>
- <code title="get /2.0/comments/{commentId}">client.Comments.<a href="./Box.Sdk.Gen/Managers/Comments/CommentsManager.cs">GetCommentByIdAsync</a>(commentId, queryParams?, headers?, cancellationToken?) -> CommentFull</code>
- <code title="put /2.0/comments/{commentId}">client.Comments.<a href="./Box.Sdk.Gen/Managers/Comments/CommentsManager.cs">UpdateCommentByIdAsync</a>(commentId, requestBody?, queryParams?, headers?, cancellationToken?) -> CommentFull</code>
- <code title="delete /2.0/comments/{commentId}">client.Comments.<a href="./Box.Sdk.Gen/Managers/Comments/CommentsManager.cs">DeleteCommentByIdAsync</a>(commentId, headers?, cancellationToken?) -> void</code>
- <code title="post /2.0/comments">client.Comments.<a href="./Box.Sdk.Gen/Managers/Comments/CommentsManager.cs">CreateCommentAsync</a>(requestBody, queryParams?, headers?, cancellationToken?) -> CommentFull</code>

# Tasks

Examples: [docs/Tasks.md](docs/Tasks.md)

Methods:

- <code title="get /2.0/files/{fileId}/tasks">client.Tasks.<a href="./Box.Sdk.Gen/Managers/Tasks/TasksManager.cs">GetFileTasksAsync</a>(fileId, headers?, cancellationToken?) -> Tasks</code>
- <code title="post /2.0/tasks">client.Tasks.<a href="./Box.Sdk.Gen/Managers/Tasks/TasksManager.cs">CreateTaskAsync</a>(requestBody, headers?, cancellationToken?) -> Task</code>
- <code title="get /2.0/tasks/{taskId}">client.Tasks.<a href="./Box.Sdk.Gen/Managers/Tasks/TasksManager.cs">GetTaskByIdAsync</a>(taskId, headers?, cancellationToken?) -> Task</code>
- <code title="put /2.0/tasks/{taskId}">client.Tasks.<a href="./Box.Sdk.Gen/Managers/Tasks/TasksManager.cs">UpdateTaskByIdAsync</a>(taskId, requestBody?, headers?, cancellationToken?) -> Task</code>
- <code title="delete /2.0/tasks/{taskId}">client.Tasks.<a href="./Box.Sdk.Gen/Managers/Tasks/TasksManager.cs">DeleteTaskByIdAsync</a>(taskId, headers?, cancellationToken?) -> void</code>

# File versions

Examples: [docs/FileVersions.md](docs/FileVersions.md)

Methods:

- <code title="get /2.0/files/{fileId}/versions">client.FileVersions.<a href="./Box.Sdk.Gen/Managers/FileVersions/FileVersionsManager.cs">GetFileVersionsAsync</a>(fileId, queryParams?, headers?, cancellationToken?) -> FileVersions</code>
- <code title="get /2.0/files/{fileId}/versions/{fileVersionId}">client.FileVersions.<a href="./Box.Sdk.Gen/Managers/FileVersions/FileVersionsManager.cs">GetFileVersionByIdAsync</a>(fileId, fileVersionId, queryParams?, headers?, cancellationToken?) -> FileVersionFull</code>
- <code title="delete /2.0/files/{fileId}/versions/{fileVersionId}">client.FileVersions.<a href="./Box.Sdk.Gen/Managers/FileVersions/FileVersionsManager.cs">DeleteFileVersionByIdAsync</a>(fileId, fileVersionId, headers?, cancellationToken?) -> void</code>
- <code title="put /2.0/files/{fileId}/versions/{fileVersionId}">client.FileVersions.<a href="./Box.Sdk.Gen/Managers/FileVersions/FileVersionsManager.cs">UpdateFileVersionByIdAsync</a>(fileId, fileVersionId, requestBody?, headers?, cancellationToken?) -> FileVersionFull</code>
- <code title="post /2.0/files/{fileId}/versions/current">client.FileVersions.<a href="./Box.Sdk.Gen/Managers/FileVersions/FileVersionsManager.cs">PromoteFileVersionAsync</a>(fileId, requestBody?, queryParams?, headers?, cancellationToken?) -> FileVersionFull</code>

# File metadata

Examples: [docs/FileMetadata.md](docs/FileMetadata.md)

Methods:

- <code title="get /2.0/files/{fileId}/metadata">client.FileMetadata.<a href="./Box.Sdk.Gen/Managers/FileMetadata/FileMetadataManager.cs">GetFileMetadataAsync</a>(fileId, headers?, cancellationToken?) -> Metadatas</code>
- <code title="get /2.0/files/{fileId}/metadata/{scope}/{templateKey}">client.FileMetadata.<a href="./Box.Sdk.Gen/Managers/FileMetadata/FileMetadataManager.cs">GetFileMetadataByIdAsync</a>(fileId, scope, templateKey, headers?, cancellationToken?) -> MetadataFull</code>
- <code title="post /2.0/files/{fileId}/metadata/{scope}/{templateKey}">client.FileMetadata.<a href="./Box.Sdk.Gen/Managers/FileMetadata/FileMetadataManager.cs">CreateFileMetadataByIdAsync</a>(fileId, scope, templateKey, requestBody, headers?, cancellationToken?) -> MetadataFull</code>
- <code title="put /2.0/files/{fileId}/metadata/{scope}/{templateKey}">client.FileMetadata.<a href="./Box.Sdk.Gen/Managers/FileMetadata/FileMetadataManager.cs">UpdateFileMetadataByIdAsync</a>(fileId, scope, templateKey, requestBody, headers?, cancellationToken?) -> MetadataFull</code>
- <code title="delete /2.0/files/{fileId}/metadata/{scope}/{templateKey}">client.FileMetadata.<a href="./Box.Sdk.Gen/Managers/FileMetadata/FileMetadataManager.cs">DeleteFileMetadataByIdAsync</a>(fileId, scope, templateKey, headers?, cancellationToken?) -> void</code>

# File classifications

Examples: [docs/FileClassifications.md](docs/FileClassifications.md)

Methods:

- <code title="get /2.0/files/{fileId}/metadata/enterprise/securityClassification-6VMVochwUWo">client.FileClassifications.<a href="./Box.Sdk.Gen/Managers/FileClassifications/FileClassificationsManager.cs">GetClassificationOnFileAsync</a>(fileId, headers?, cancellationToken?) -> Classification</code>
- <code title="post /2.0/files/{fileId}/metadata/enterprise/securityClassification-6VMVochwUWo">client.FileClassifications.<a href="./Box.Sdk.Gen/Managers/FileClassifications/FileClassificationsManager.cs">AddClassificationToFileAsync</a>(fileId, requestBody?, headers?, cancellationToken?) -> Classification</code>
- <code title="put /2.0/files/{fileId}/metadata/enterprise/securityClassification-6VMVochwUWo">client.FileClassifications.<a href="./Box.Sdk.Gen/Managers/FileClassifications/FileClassificationsManager.cs">UpdateClassificationOnFileAsync</a>(fileId, requestBody, headers?, cancellationToken?) -> Classification</code>
- <code title="delete /2.0/files/{fileId}/metadata/enterprise/securityClassification-6VMVochwUWo">client.FileClassifications.<a href="./Box.Sdk.Gen/Managers/FileClassifications/FileClassificationsManager.cs">DeleteClassificationFromFileAsync</a>(fileId, headers?, cancellationToken?) -> void</code>

# Skills

Examples: [docs/Skills.md](docs/Skills.md)

Methods:

- <code title="get /2.0/files/{fileId}/metadata/global/boxSkillsCards">client.Skills.<a href="./Box.Sdk.Gen/Managers/Skills/SkillsManager.cs">GetBoxSkillCardsOnFileAsync</a>(fileId, headers?, cancellationToken?) -> SkillCardsMetadata</code>
- <code title="post /2.0/files/{fileId}/metadata/global/boxSkillsCards">client.Skills.<a href="./Box.Sdk.Gen/Managers/Skills/SkillsManager.cs">CreateBoxSkillCardsOnFileAsync</a>(fileId, requestBody, headers?, cancellationToken?) -> SkillCardsMetadata</code>
- <code title="put /2.0/files/{fileId}/metadata/global/boxSkillsCards">client.Skills.<a href="./Box.Sdk.Gen/Managers/Skills/SkillsManager.cs">UpdateBoxSkillCardsOnFileAsync</a>(fileId, requestBody, headers?, cancellationToken?) -> SkillCardsMetadata</code>
- <code title="delete /2.0/files/{fileId}/metadata/global/boxSkillsCards">client.Skills.<a href="./Box.Sdk.Gen/Managers/Skills/SkillsManager.cs">DeleteBoxSkillCardsFromFileAsync</a>(fileId, headers?, cancellationToken?) -> void</code>
- <code title="put /2.0/skill_invocations/{skillId}">client.Skills.<a href="./Box.Sdk.Gen/Managers/Skills/SkillsManager.cs">UpdateAllSkillCardsOnFileAsync</a>(skillId, requestBody, headers?, cancellationToken?) -> void</code>

# File watermarks

Examples: [docs/FileWatermarks.md](docs/FileWatermarks.md)

Methods:

- <code title="get /2.0/files/{fileId}/watermark">client.FileWatermarks.<a href="./Box.Sdk.Gen/Managers/FileWatermarks/FileWatermarksManager.cs">GetFileWatermarkAsync</a>(fileId, headers?, cancellationToken?) -> Watermark</code>
- <code title="put /2.0/files/{fileId}/watermark">client.FileWatermarks.<a href="./Box.Sdk.Gen/Managers/FileWatermarks/FileWatermarksManager.cs">UpdateFileWatermarkAsync</a>(fileId, requestBody, headers?, cancellationToken?) -> Watermark</code>
- <code title="delete /2.0/files/{fileId}/watermark">client.FileWatermarks.<a href="./Box.Sdk.Gen/Managers/FileWatermarks/FileWatermarksManager.cs">DeleteFileWatermarkAsync</a>(fileId, headers?, cancellationToken?) -> void</code>

# File requests

Examples: [docs/FileRequests.md](docs/FileRequests.md)

Methods:

- <code title="get /2.0/file_requests/{fileRequestId}">client.FileRequests.<a href="./Box.Sdk.Gen/Managers/FileRequests/FileRequestsManager.cs">GetFileRequestByIdAsync</a>(fileRequestId, headers?, cancellationToken?) -> FileRequest</code>
- <code title="put /2.0/file_requests/{fileRequestId}">client.FileRequests.<a href="./Box.Sdk.Gen/Managers/FileRequests/FileRequestsManager.cs">UpdateFileRequestByIdAsync</a>(fileRequestId, requestBody, headers?, cancellationToken?) -> FileRequest</code>
- <code title="delete /2.0/file_requests/{fileRequestId}">client.FileRequests.<a href="./Box.Sdk.Gen/Managers/FileRequests/FileRequestsManager.cs">DeleteFileRequestByIdAsync</a>(fileRequestId, headers?, cancellationToken?) -> void</code>
- <code title="post /2.0/file_requests/{fileRequestId}/copy">client.FileRequests.<a href="./Box.Sdk.Gen/Managers/FileRequests/FileRequestsManager.cs">CreateFileRequestCopyAsync</a>(fileRequestId, requestBody, headers?, cancellationToken?) -> FileRequest</code>

# Folders

Examples: [docs/Folders.md](docs/Folders.md)

Methods:

- <code title="get /2.0/folders/{folderId}">client.Folders.<a href="./Box.Sdk.Gen/Managers/Folders/FoldersManager.cs">GetFolderByIdAsync</a>(folderId, queryParams?, headers?, cancellationToken?) -> FolderFull</code>
- <code title="put /2.0/folders/{folderId}">client.Folders.<a href="./Box.Sdk.Gen/Managers/Folders/FoldersManager.cs">UpdateFolderByIdAsync</a>(folderId, requestBody?, queryParams?, headers?, cancellationToken?) -> FolderFull</code>
- <code title="delete /2.0/folders/{folderId}">client.Folders.<a href="./Box.Sdk.Gen/Managers/Folders/FoldersManager.cs">DeleteFolderByIdAsync</a>(folderId, queryParams?, headers?, cancellationToken?) -> void</code>
- <code title="get /2.0/folders/{folderId}/items">client.Folders.<a href="./Box.Sdk.Gen/Managers/Folders/FoldersManager.cs">GetFolderItemsAsync</a>(folderId, queryParams?, headers?, cancellationToken?) -> Items</code>
- <code title="post /2.0/folders">client.Folders.<a href="./Box.Sdk.Gen/Managers/Folders/FoldersManager.cs">CreateFolderAsync</a>(requestBody, queryParams?, headers?, cancellationToken?) -> FolderFull</code>
- <code title="post /2.0/folders/{folderId}/copy">client.Folders.<a href="./Box.Sdk.Gen/Managers/Folders/FoldersManager.cs">CopyFolderAsync</a>(folderId, requestBody, queryParams?, headers?, cancellationToken?) -> FolderFull</code>

# Trashed folders

Examples: [docs/TrashedFolders.md](docs/TrashedFolders.md)

Methods:

- <code title="post /2.0/folders/{folderId}">client.TrashedFolders.<a href="./Box.Sdk.Gen/Managers/TrashedFolders/TrashedFoldersManager.cs">RestoreFolderFromTrashAsync</a>(folderId, requestBody?, queryParams?, headers?, cancellationToken?) -> TrashFolderRestored</code>
- <code title="get /2.0/folders/{folderId}/trash">client.TrashedFolders.<a href="./Box.Sdk.Gen/Managers/TrashedFolders/TrashedFoldersManager.cs">GetTrashedFolderByIdAsync</a>(folderId, queryParams?, headers?, cancellationToken?) -> TrashFolder</code>
- <code title="delete /2.0/folders/{folderId}/trash">client.TrashedFolders.<a href="./Box.Sdk.Gen/Managers/TrashedFolders/TrashedFoldersManager.cs">DeleteTrashedFolderByIdAsync</a>(folderId, headers?, cancellationToken?) -> void</code>

# Folder metadata

Examples: [docs/FolderMetadata.md](docs/FolderMetadata.md)

Methods:

- <code title="get /2.0/folders/{folderId}/metadata">client.FolderMetadata.<a href="./Box.Sdk.Gen/Managers/FolderMetadata/FolderMetadataManager.cs">GetFolderMetadataAsync</a>(folderId, headers?, cancellationToken?) -> Metadatas</code>
- <code title="get /2.0/folders/{folderId}/metadata/{scope}/{templateKey}">client.FolderMetadata.<a href="./Box.Sdk.Gen/Managers/FolderMetadata/FolderMetadataManager.cs">GetFolderMetadataByIdAsync</a>(folderId, scope, templateKey, headers?, cancellationToken?) -> MetadataFull</code>
- <code title="post /2.0/folders/{folderId}/metadata/{scope}/{templateKey}">client.FolderMetadata.<a href="./Box.Sdk.Gen/Managers/FolderMetadata/FolderMetadataManager.cs">CreateFolderMetadataByIdAsync</a>(folderId, scope, templateKey, requestBody, headers?, cancellationToken?) -> MetadataFull</code>
- <code title="put /2.0/folders/{folderId}/metadata/{scope}/{templateKey}">client.FolderMetadata.<a href="./Box.Sdk.Gen/Managers/FolderMetadata/FolderMetadataManager.cs">UpdateFolderMetadataByIdAsync</a>(folderId, scope, templateKey, requestBody, headers?, cancellationToken?) -> MetadataFull</code>
- <code title="delete /2.0/folders/{folderId}/metadata/{scope}/{templateKey}">client.FolderMetadata.<a href="./Box.Sdk.Gen/Managers/FolderMetadata/FolderMetadataManager.cs">DeleteFolderMetadataByIdAsync</a>(folderId, scope, templateKey, headers?, cancellationToken?) -> void</code>

# Folder classifications

Examples: [docs/FolderClassifications.md](docs/FolderClassifications.md)

Methods:

- <code title="get /2.0/folders/{folderId}/metadata/enterprise/securityClassification-6VMVochwUWo">client.FolderClassifications.<a href="./Box.Sdk.Gen/Managers/FolderClassifications/FolderClassificationsManager.cs">GetClassificationOnFolderAsync</a>(folderId, headers?, cancellationToken?) -> Classification</code>
- <code title="post /2.0/folders/{folderId}/metadata/enterprise/securityClassification-6VMVochwUWo">client.FolderClassifications.<a href="./Box.Sdk.Gen/Managers/FolderClassifications/FolderClassificationsManager.cs">AddClassificationToFolderAsync</a>(folderId, requestBody?, headers?, cancellationToken?) -> Classification</code>
- <code title="put /2.0/folders/{folderId}/metadata/enterprise/securityClassification-6VMVochwUWo">client.FolderClassifications.<a href="./Box.Sdk.Gen/Managers/FolderClassifications/FolderClassificationsManager.cs">UpdateClassificationOnFolderAsync</a>(folderId, requestBody, headers?, cancellationToken?) -> Classification</code>
- <code title="delete /2.0/folders/{folderId}/metadata/enterprise/securityClassification-6VMVochwUWo">client.FolderClassifications.<a href="./Box.Sdk.Gen/Managers/FolderClassifications/FolderClassificationsManager.cs">DeleteClassificationFromFolderAsync</a>(folderId, headers?, cancellationToken?) -> void</code>

# Trashed items

Examples: [docs/TrashedItems.md](docs/TrashedItems.md)

Methods:

- <code title="get /2.0/folders/trash/items">client.TrashedItems.<a href="./Box.Sdk.Gen/Managers/TrashedItems/TrashedItemsManager.cs">GetTrashedItemsAsync</a>(queryParams?, headers?, cancellationToken?) -> Items</code>

# Folder watermarks

Examples: [docs/FolderWatermarks.md](docs/FolderWatermarks.md)

Methods:

- <code title="get /2.0/folders/{folderId}/watermark">client.FolderWatermarks.<a href="./Box.Sdk.Gen/Managers/FolderWatermarks/FolderWatermarksManager.cs">GetFolderWatermarkAsync</a>(folderId, headers?, cancellationToken?) -> Watermark</code>
- <code title="put /2.0/folders/{folderId}/watermark">client.FolderWatermarks.<a href="./Box.Sdk.Gen/Managers/FolderWatermarks/FolderWatermarksManager.cs">UpdateFolderWatermarkAsync</a>(folderId, requestBody, headers?, cancellationToken?) -> Watermark</code>
- <code title="delete /2.0/folders/{folderId}/watermark">client.FolderWatermarks.<a href="./Box.Sdk.Gen/Managers/FolderWatermarks/FolderWatermarksManager.cs">DeleteFolderWatermarkAsync</a>(folderId, headers?, cancellationToken?) -> void</code>

# Folder locks

Examples: [docs/FolderLocks.md](docs/FolderLocks.md)

Methods:

- <code title="get /2.0/folder_locks">client.FolderLocks.<a href="./Box.Sdk.Gen/Managers/FolderLocks/FolderLocksManager.cs">GetFolderLocksAsync</a>(queryParams, headers?, cancellationToken?) -> FolderLocks</code>
- <code title="post /2.0/folder_locks">client.FolderLocks.<a href="./Box.Sdk.Gen/Managers/FolderLocks/FolderLocksManager.cs">CreateFolderLockAsync</a>(requestBody, headers?, cancellationToken?) -> FolderLock</code>
- <code title="delete /2.0/folder_locks/{folderLockId}">client.FolderLocks.<a href="./Box.Sdk.Gen/Managers/FolderLocks/FolderLocksManager.cs">DeleteFolderLockByIdAsync</a>(folderLockId, headers?, cancellationToken?) -> void</code>

# Metadata templates

Examples: [docs/MetadataTemplates.md](docs/MetadataTemplates.md)

Methods:

- <code title="get /2.0/metadata_templates">client.MetadataTemplates.<a href="./Box.Sdk.Gen/Managers/MetadataTemplates/MetadataTemplatesManager.cs">GetMetadataTemplatesByInstanceIdAsync</a>(queryParams, headers?, cancellationToken?) -> MetadataTemplates</code>
- <code title="get /2.0/metadata_templates/{scope}/{templateKey}/schema">client.MetadataTemplates.<a href="./Box.Sdk.Gen/Managers/MetadataTemplates/MetadataTemplatesManager.cs">GetMetadataTemplateAsync</a>(scope, templateKey, headers?, cancellationToken?) -> MetadataTemplate</code>
- <code title="put /2.0/metadata_templates/{scope}/{templateKey}/schema">client.MetadataTemplates.<a href="./Box.Sdk.Gen/Managers/MetadataTemplates/MetadataTemplatesManager.cs">UpdateMetadataTemplateAsync</a>(scope, templateKey, requestBody, headers?, cancellationToken?) -> MetadataTemplate</code>
- <code title="delete /2.0/metadata_templates/{scope}/{templateKey}/schema">client.MetadataTemplates.<a href="./Box.Sdk.Gen/Managers/MetadataTemplates/MetadataTemplatesManager.cs">DeleteMetadataTemplateAsync</a>(scope, templateKey, headers?, cancellationToken?) -> void</code>
- <code title="get /2.0/metadata_templates/{templateId}">client.MetadataTemplates.<a href="./Box.Sdk.Gen/Managers/MetadataTemplates/MetadataTemplatesManager.cs">GetMetadataTemplateByIdAsync</a>(templateId, headers?, cancellationToken?) -> MetadataTemplate</code>
- <code title="get /2.0/metadata_templates/global">client.MetadataTemplates.<a href="./Box.Sdk.Gen/Managers/MetadataTemplates/MetadataTemplatesManager.cs">GetGlobalMetadataTemplatesAsync</a>(queryParams?, headers?, cancellationToken?) -> MetadataTemplates</code>
- <code title="get /2.0/metadata_templates/enterprise">client.MetadataTemplates.<a href="./Box.Sdk.Gen/Managers/MetadataTemplates/MetadataTemplatesManager.cs">GetEnterpriseMetadataTemplatesAsync</a>(queryParams?, headers?, cancellationToken?) -> MetadataTemplates</code>
- <code title="post /2.0/metadata_templates/schema">client.MetadataTemplates.<a href="./Box.Sdk.Gen/Managers/MetadataTemplates/MetadataTemplatesManager.cs">CreateMetadataTemplateAsync</a>(requestBody, headers?, cancellationToken?) -> MetadataTemplate</code>

# Classifications

Examples: [docs/Classifications.md](docs/Classifications.md)

Methods:

- <code title="get /2.0/metadata_templates/enterprise/securityClassification-6VMVochwUWo/schema">client.Classifications.<a href="./Box.Sdk.Gen/Managers/Classifications/ClassificationsManager.cs">GetClassificationTemplateAsync</a>(headers?, cancellationToken?) -> ClassificationTemplate</code>
- <code title="put /2.0/metadata_templates/enterprise/securityClassification-6VMVochwUWo/schema">client.Classifications.<a href="./Box.Sdk.Gen/Managers/Classifications/ClassificationsManager.cs">AddClassificationAsync</a>(requestBody, headers?, cancellationToken?) -> ClassificationTemplate</code>
- <code title="put /2.0/metadata_templates/enterprise/securityClassification-6VMVochwUWo/schema">client.Classifications.<a href="./Box.Sdk.Gen/Managers/Classifications/ClassificationsManager.cs">UpdateClassificationAsync</a>(requestBody, headers?, cancellationToken?) -> ClassificationTemplate</code>
- <code title="post /2.0/metadata_templates/schema">client.Classifications.<a href="./Box.Sdk.Gen/Managers/Classifications/ClassificationsManager.cs">CreateClassificationTemplateAsync</a>(requestBody, headers?, cancellationToken?) -> ClassificationTemplate</code>

# Metadata cascade policies

Examples: [docs/MetadataCascadePolicies.md](docs/MetadataCascadePolicies.md)

Methods:

- <code title="get /2.0/metadata_cascade_policies">client.MetadataCascadePolicies.<a href="./Box.Sdk.Gen/Managers/MetadataCascadePolicies/MetadataCascadePoliciesManager.cs">GetMetadataCascadePoliciesAsync</a>(queryParams, headers?, cancellationToken?) -> MetadataCascadePolicies</code>
- <code title="post /2.0/metadata_cascade_policies">client.MetadataCascadePolicies.<a href="./Box.Sdk.Gen/Managers/MetadataCascadePolicies/MetadataCascadePoliciesManager.cs">CreateMetadataCascadePolicyAsync</a>(requestBody, headers?, cancellationToken?) -> MetadataCascadePolicy</code>
- <code title="get /2.0/metadata_cascade_policies/{metadataCascadePolicyId}">client.MetadataCascadePolicies.<a href="./Box.Sdk.Gen/Managers/MetadataCascadePolicies/MetadataCascadePoliciesManager.cs">GetMetadataCascadePolicyByIdAsync</a>(metadataCascadePolicyId, headers?, cancellationToken?) -> MetadataCascadePolicy</code>
- <code title="delete /2.0/metadata_cascade_policies/{metadataCascadePolicyId}">client.MetadataCascadePolicies.<a href="./Box.Sdk.Gen/Managers/MetadataCascadePolicies/MetadataCascadePoliciesManager.cs">DeleteMetadataCascadePolicyByIdAsync</a>(metadataCascadePolicyId, headers?, cancellationToken?) -> void</code>
- <code title="post /2.0/metadata_cascade_policies/{metadataCascadePolicyId}/apply">client.MetadataCascadePolicies.<a href="./Box.Sdk.Gen/Managers/MetadataCascadePolicies/MetadataCascadePoliciesManager.cs">ApplyMetadataCascadePolicyAsync</a>(metadataCascadePolicyId, requestBody, headers?, cancellationToken?) -> void</code>

# Search

Examples: [docs/Search.md](docs/Search.md)

Methods:

- <code title="post /2.0/metadata_queries/execute_read">client.Search.<a href="./Box.Sdk.Gen/Managers/Search/SearchManager.cs">SearchByMetadataQueryAsync</a>(requestBody, headers?, cancellationToken?) -> MetadataQueryResults</code>
- <code title="get /2.0/search">client.Search.<a href="./Box.Sdk.Gen/Managers/Search/SearchManager.cs">SearchForContentAsync</a>(queryParams?, headers?, cancellationToken?) -> SearchResultsOrSearchResultsWithSharedLinks</code>

# User collaborations

Examples: [docs/UserCollaborations.md](docs/UserCollaborations.md)

Methods:

- <code title="get /2.0/collaborations/{collaborationId}">client.UserCollaborations.<a href="./Box.Sdk.Gen/Managers/UserCollaborations/UserCollaborationsManager.cs">GetCollaborationByIdAsync</a>(collaborationId, queryParams?, headers?, cancellationToken?) -> Collaboration</code>
- <code title="put /2.0/collaborations/{collaborationId}">client.UserCollaborations.<a href="./Box.Sdk.Gen/Managers/UserCollaborations/UserCollaborationsManager.cs">UpdateCollaborationByIdAsync</a>(collaborationId, requestBody, headers?, cancellationToken?) -> Collaboration?</code>
- <code title="delete /2.0/collaborations/{collaborationId}">client.UserCollaborations.<a href="./Box.Sdk.Gen/Managers/UserCollaborations/UserCollaborationsManager.cs">DeleteCollaborationByIdAsync</a>(collaborationId, headers?, cancellationToken?) -> void</code>
- <code title="post /2.0/collaborations">client.UserCollaborations.<a href="./Box.Sdk.Gen/Managers/UserCollaborations/UserCollaborationsManager.cs">CreateCollaborationAsync</a>(requestBody, queryParams?, headers?, cancellationToken?) -> Collaboration</code>

# Task assignments

Examples: [docs/TaskAssignments.md](docs/TaskAssignments.md)

Methods:

- <code title="get /2.0/tasks/{taskId}/assignments">client.TaskAssignments.<a href="./Box.Sdk.Gen/Managers/TaskAssignments/TaskAssignmentsManager.cs">GetTaskAssignmentsAsync</a>(taskId, headers?, cancellationToken?) -> TaskAssignments</code>
- <code title="post /2.0/task_assignments">client.TaskAssignments.<a href="./Box.Sdk.Gen/Managers/TaskAssignments/TaskAssignmentsManager.cs">CreateTaskAssignmentAsync</a>(requestBody, headers?, cancellationToken?) -> TaskAssignment</code>
- <code title="get /2.0/task_assignments/{taskAssignmentId}">client.TaskAssignments.<a href="./Box.Sdk.Gen/Managers/TaskAssignments/TaskAssignmentsManager.cs">GetTaskAssignmentByIdAsync</a>(taskAssignmentId, headers?, cancellationToken?) -> TaskAssignment</code>
- <code title="put /2.0/task_assignments/{taskAssignmentId}">client.TaskAssignments.<a href="./Box.Sdk.Gen/Managers/TaskAssignments/TaskAssignmentsManager.cs">UpdateTaskAssignmentByIdAsync</a>(taskAssignmentId, requestBody?, headers?, cancellationToken?) -> TaskAssignment</code>
- <code title="delete /2.0/task_assignments/{taskAssignmentId}">client.TaskAssignments.<a href="./Box.Sdk.Gen/Managers/TaskAssignments/TaskAssignmentsManager.cs">DeleteTaskAssignmentByIdAsync</a>(taskAssignmentId, headers?, cancellationToken?) -> void</code>

# Shared links files

Examples: [docs/SharedLinksFiles.md](docs/SharedLinksFiles.md)

Methods:

- <code title="get /2.0/shared_items">client.SharedLinksFiles.<a href="./Box.Sdk.Gen/Managers/SharedLinksFiles/SharedLinksFilesManager.cs">FindFileForSharedLinkAsync</a>(headers, queryParams?, cancellationToken?) -> FileFull</code>
- <code title="get /2.0/files/{fileId}">client.SharedLinksFiles.<a href="./Box.Sdk.Gen/Managers/SharedLinksFiles/SharedLinksFilesManager.cs">GetSharedLinkForFileAsync</a>(fileId, queryParams, headers?, cancellationToken?) -> FileFull</code>
- <code title="put /2.0/files/{fileId}">client.SharedLinksFiles.<a href="./Box.Sdk.Gen/Managers/SharedLinksFiles/SharedLinksFilesManager.cs">AddShareLinkToFileAsync</a>(fileId, queryParams, requestBody?, headers?, cancellationToken?) -> FileFull</code>
- <code title="put /2.0/files/{fileId}">client.SharedLinksFiles.<a href="./Box.Sdk.Gen/Managers/SharedLinksFiles/SharedLinksFilesManager.cs">UpdateSharedLinkOnFileAsync</a>(fileId, queryParams, requestBody?, headers?, cancellationToken?) -> FileFull</code>
- <code title="put /2.0/files/{fileId}">client.SharedLinksFiles.<a href="./Box.Sdk.Gen/Managers/SharedLinksFiles/SharedLinksFilesManager.cs">RemoveSharedLinkFromFileAsync</a>(fileId, queryParams, requestBody?, headers?, cancellationToken?) -> FileFull</code>

# Shared links folders

Examples: [docs/SharedLinksFolders.md](docs/SharedLinksFolders.md)

Methods:

- <code title="get /2.0/shared_items">client.SharedLinksFolders.<a href="./Box.Sdk.Gen/Managers/SharedLinksFolders/SharedLinksFoldersManager.cs">FindFolderForSharedLinkAsync</a>(headers, queryParams?, cancellationToken?) -> FolderFull</code>
- <code title="get /2.0/folders/{folderId}">client.SharedLinksFolders.<a href="./Box.Sdk.Gen/Managers/SharedLinksFolders/SharedLinksFoldersManager.cs">GetSharedLinkForFolderAsync</a>(folderId, queryParams, headers?, cancellationToken?) -> FolderFull</code>
- <code title="put /2.0/folders/{folderId}">client.SharedLinksFolders.<a href="./Box.Sdk.Gen/Managers/SharedLinksFolders/SharedLinksFoldersManager.cs">AddShareLinkToFolderAsync</a>(folderId, queryParams, requestBody?, headers?, cancellationToken?) -> FolderFull</code>
- <code title="put /2.0/folders/{folderId}">client.SharedLinksFolders.<a href="./Box.Sdk.Gen/Managers/SharedLinksFolders/SharedLinksFoldersManager.cs">UpdateSharedLinkOnFolderAsync</a>(folderId, queryParams, requestBody?, headers?, cancellationToken?) -> FolderFull</code>
- <code title="put /2.0/folders/{folderId}">client.SharedLinksFolders.<a href="./Box.Sdk.Gen/Managers/SharedLinksFolders/SharedLinksFoldersManager.cs">RemoveSharedLinkFromFolderAsync</a>(folderId, queryParams, requestBody?, headers?, cancellationToken?) -> FolderFull</code>

# Web links

Examples: [docs/WebLinks.md](docs/WebLinks.md)

Methods:

- <code title="post /2.0/web_links">client.WebLinks.<a href="./Box.Sdk.Gen/Managers/WebLinks/WebLinksManager.cs">CreateWebLinkAsync</a>(requestBody, headers?, cancellationToken?) -> WebLink</code>
- <code title="get /2.0/web_links/{webLinkId}">client.WebLinks.<a href="./Box.Sdk.Gen/Managers/WebLinks/WebLinksManager.cs">GetWebLinkByIdAsync</a>(webLinkId, headers?, cancellationToken?) -> WebLink</code>
- <code title="put /2.0/web_links/{webLinkId}">client.WebLinks.<a href="./Box.Sdk.Gen/Managers/WebLinks/WebLinksManager.cs">UpdateWebLinkByIdAsync</a>(webLinkId, requestBody?, headers?, cancellationToken?) -> WebLink</code>
- <code title="delete /2.0/web_links/{webLinkId}">client.WebLinks.<a href="./Box.Sdk.Gen/Managers/WebLinks/WebLinksManager.cs">DeleteWebLinkByIdAsync</a>(webLinkId, headers?, cancellationToken?) -> void</code>

# Trashed web links

Examples: [docs/TrashedWebLinks.md](docs/TrashedWebLinks.md)

Methods:

- <code title="post /2.0/web_links/{webLinkId}">client.TrashedWebLinks.<a href="./Box.Sdk.Gen/Managers/TrashedWebLinks/TrashedWebLinksManager.cs">RestoreWeblinkFromTrashAsync</a>(webLinkId, requestBody?, queryParams?, headers?, cancellationToken?) -> TrashWebLinkRestored</code>
- <code title="get /2.0/web_links/{webLinkId}/trash">client.TrashedWebLinks.<a href="./Box.Sdk.Gen/Managers/TrashedWebLinks/TrashedWebLinksManager.cs">GetTrashedWebLinkByIdAsync</a>(webLinkId, queryParams?, headers?, cancellationToken?) -> TrashWebLink</code>
- <code title="delete /2.0/web_links/{webLinkId}/trash">client.TrashedWebLinks.<a href="./Box.Sdk.Gen/Managers/TrashedWebLinks/TrashedWebLinksManager.cs">DeleteTrashedWebLinkByIdAsync</a>(webLinkId, headers?, cancellationToken?) -> void</code>

# Shared links web links

Examples: [docs/SharedLinksWebLinks.md](docs/SharedLinksWebLinks.md)

Methods:

- <code title="get /2.0/shared_items">client.SharedLinksWebLinks.<a href="./Box.Sdk.Gen/Managers/SharedLinksWebLinks/SharedLinksWebLinksManager.cs">FindWebLinkForSharedLinkAsync</a>(headers, queryParams?, cancellationToken?) -> WebLink</code>
- <code title="get /2.0/web_links/{webLinkId}">client.SharedLinksWebLinks.<a href="./Box.Sdk.Gen/Managers/SharedLinksWebLinks/SharedLinksWebLinksManager.cs">GetSharedLinkForWebLinkAsync</a>(webLinkId, queryParams, headers?, cancellationToken?) -> WebLink</code>
- <code title="put /2.0/web_links/{webLinkId}">client.SharedLinksWebLinks.<a href="./Box.Sdk.Gen/Managers/SharedLinksWebLinks/SharedLinksWebLinksManager.cs">AddShareLinkToWebLinkAsync</a>(webLinkId, queryParams, requestBody?, headers?, cancellationToken?) -> WebLink</code>
- <code title="put /2.0/web_links/{webLinkId}">client.SharedLinksWebLinks.<a href="./Box.Sdk.Gen/Managers/SharedLinksWebLinks/SharedLinksWebLinksManager.cs">UpdateSharedLinkOnWebLinkAsync</a>(webLinkId, queryParams, requestBody?, headers?, cancellationToken?) -> WebLink</code>
- <code title="put /2.0/web_links/{webLinkId}">client.SharedLinksWebLinks.<a href="./Box.Sdk.Gen/Managers/SharedLinksWebLinks/SharedLinksWebLinksManager.cs">RemoveSharedLinkFromWebLinkAsync</a>(webLinkId, queryParams, requestBody?, headers?, cancellationToken?) -> WebLink</code>

# Shared links app items

Examples: [docs/SharedLinksAppItems.md](docs/SharedLinksAppItems.md)

Methods:

- <code title="get /2.0/shared_items">client.SharedLinksAppItems.<a href="./Box.Sdk.Gen/Managers/SharedLinksAppItems/SharedLinksAppItemsManager.cs">FindAppItemForSharedLinkAsync</a>(headers, cancellationToken?) -> AppItem</code>

# Users

Examples: [docs/Users.md](docs/Users.md)

Methods:

- <code title="get /2.0/users">client.Users.<a href="./Box.Sdk.Gen/Managers/Users/UsersManager.cs">GetUsersAsync</a>(queryParams?, headers?, cancellationToken?) -> Users</code>
- <code title="post /2.0/users">client.Users.<a href="./Box.Sdk.Gen/Managers/Users/UsersManager.cs">CreateUserAsync</a>(requestBody, queryParams?, headers?, cancellationToken?) -> UserFull</code>
- <code title="get /2.0/users/me">client.Users.<a href="./Box.Sdk.Gen/Managers/Users/UsersManager.cs">GetUserMeAsync</a>(queryParams?, headers?, cancellationToken?) -> UserFull</code>
- <code title="get /2.0/users/{userId}">client.Users.<a href="./Box.Sdk.Gen/Managers/Users/UsersManager.cs">GetUserByIdAsync</a>(userId, queryParams?, headers?, cancellationToken?) -> UserFull</code>
- <code title="put /2.0/users/{userId}">client.Users.<a href="./Box.Sdk.Gen/Managers/Users/UsersManager.cs">UpdateUserByIdAsync</a>(userId, requestBody?, queryParams?, headers?, cancellationToken?) -> UserFull</code>
- <code title="delete /2.0/users/{userId}">client.Users.<a href="./Box.Sdk.Gen/Managers/Users/UsersManager.cs">DeleteUserByIdAsync</a>(userId, queryParams?, headers?, cancellationToken?) -> void</code>

# Session termination

Examples: [docs/SessionTermination.md](docs/SessionTermination.md)

Methods:

- <code title="post /2.0/users/terminate_sessions">client.SessionTermination.<a href="./Box.Sdk.Gen/Managers/SessionTermination/SessionTerminationManager.cs">TerminateUsersSessionsAsync</a>(requestBody, headers?, cancellationToken?) -> SessionTerminationMessage</code>
- <code title="post /2.0/groups/terminate_sessions">client.SessionTermination.<a href="./Box.Sdk.Gen/Managers/SessionTermination/SessionTerminationManager.cs">TerminateGroupsSessionsAsync</a>(requestBody, headers?, cancellationToken?) -> SessionTerminationMessage</code>

# Avatars

Examples: [docs/Avatars.md](docs/Avatars.md)

Methods:

- <code title="get /2.0/users/{userId}/avatar">client.Avatars.<a href="./Box.Sdk.Gen/Managers/Avatars/AvatarsManager.cs">GetUserAvatarAsync</a>(userId, headers?, cancellationToken?) -> System.IO.Stream</code>
- <code title="post /2.0/users/{userId}/avatar">client.Avatars.<a href="./Box.Sdk.Gen/Managers/Avatars/AvatarsManager.cs">CreateUserAvatarAsync</a>(userId, requestBody, headers?, cancellationToken?) -> UserAvatar</code>
- <code title="delete /2.0/users/{userId}/avatar">client.Avatars.<a href="./Box.Sdk.Gen/Managers/Avatars/AvatarsManager.cs">DeleteUserAvatarAsync</a>(userId, headers?, cancellationToken?) -> void</code>

# Transfer

Examples: [docs/Transfer.md](docs/Transfer.md)

Methods:

- <code title="put /2.0/users/{userId}/folders/0">client.Transfer.<a href="./Box.Sdk.Gen/Managers/Transfer/TransferManager.cs">TransferOwnedFolderAsync</a>(userId, requestBody, queryParams?, headers?, cancellationToken?) -> FolderFull</code>

# Email aliases

Examples: [docs/EmailAliases.md](docs/EmailAliases.md)

Methods:

- <code title="get /2.0/users/{userId}/email_aliases">client.EmailAliases.<a href="./Box.Sdk.Gen/Managers/EmailAliases/EmailAliasesManager.cs">GetUserEmailAliasesAsync</a>(userId, headers?, cancellationToken?) -> EmailAliases</code>
- <code title="post /2.0/users/{userId}/email_aliases">client.EmailAliases.<a href="./Box.Sdk.Gen/Managers/EmailAliases/EmailAliasesManager.cs">CreateUserEmailAliasAsync</a>(userId, requestBody, headers?, cancellationToken?) -> EmailAlias</code>
- <code title="delete /2.0/users/{userId}/email_aliases/{emailAliasId}">client.EmailAliases.<a href="./Box.Sdk.Gen/Managers/EmailAliases/EmailAliasesManager.cs">DeleteUserEmailAliasByIdAsync</a>(userId, emailAliasId, headers?, cancellationToken?) -> void</code>

# Memberships

Examples: [docs/Memberships.md](docs/Memberships.md)

Methods:

- <code title="get /2.0/users/{userId}/memberships">client.Memberships.<a href="./Box.Sdk.Gen/Managers/Memberships/MembershipsManager.cs">GetUserMembershipsAsync</a>(userId, queryParams?, headers?, cancellationToken?) -> GroupMemberships</code>
- <code title="get /2.0/groups/{groupId}/memberships">client.Memberships.<a href="./Box.Sdk.Gen/Managers/Memberships/MembershipsManager.cs">GetGroupMembershipsAsync</a>(groupId, queryParams?, headers?, cancellationToken?) -> GroupMemberships</code>
- <code title="post /2.0/group_memberships">client.Memberships.<a href="./Box.Sdk.Gen/Managers/Memberships/MembershipsManager.cs">CreateGroupMembershipAsync</a>(requestBody, queryParams?, headers?, cancellationToken?) -> GroupMembership</code>
- <code title="get /2.0/group_memberships/{groupMembershipId}">client.Memberships.<a href="./Box.Sdk.Gen/Managers/Memberships/MembershipsManager.cs">GetGroupMembershipByIdAsync</a>(groupMembershipId, queryParams?, headers?, cancellationToken?) -> GroupMembership</code>
- <code title="put /2.0/group_memberships/{groupMembershipId}">client.Memberships.<a href="./Box.Sdk.Gen/Managers/Memberships/MembershipsManager.cs">UpdateGroupMembershipByIdAsync</a>(groupMembershipId, requestBody?, queryParams?, headers?, cancellationToken?) -> GroupMembership</code>
- <code title="delete /2.0/group_memberships/{groupMembershipId}">client.Memberships.<a href="./Box.Sdk.Gen/Managers/Memberships/MembershipsManager.cs">DeleteGroupMembershipByIdAsync</a>(groupMembershipId, headers?, cancellationToken?) -> void</code>

# Invites

Examples: [docs/Invites.md](docs/Invites.md)

Methods:

- <code title="post /2.0/invites">client.Invites.<a href="./Box.Sdk.Gen/Managers/Invites/InvitesManager.cs">CreateInviteAsync</a>(requestBody, queryParams?, headers?, cancellationToken?) -> Invite</code>
- <code title="get /2.0/invites/{inviteId}">client.Invites.<a href="./Box.Sdk.Gen/Managers/Invites/InvitesManager.cs">GetInviteByIdAsync</a>(inviteId, queryParams?, headers?, cancellationToken?) -> Invite</code>

# Groups

Examples: [docs/Groups.md](docs/Groups.md)

Methods:

- <code title="get /2.0/groups">client.Groups.<a href="./Box.Sdk.Gen/Managers/Groups/GroupsManager.cs">GetGroupsAsync</a>(queryParams?, headers?, cancellationToken?) -> Groups</code>
- <code title="post /2.0/groups">client.Groups.<a href="./Box.Sdk.Gen/Managers/Groups/GroupsManager.cs">CreateGroupAsync</a>(requestBody, queryParams?, headers?, cancellationToken?) -> GroupFull</code>
- <code title="get /2.0/groups/{groupId}">client.Groups.<a href="./Box.Sdk.Gen/Managers/Groups/GroupsManager.cs">GetGroupByIdAsync</a>(groupId, queryParams?, headers?, cancellationToken?) -> GroupFull</code>
- <code title="put /2.0/groups/{groupId}">client.Groups.<a href="./Box.Sdk.Gen/Managers/Groups/GroupsManager.cs">UpdateGroupByIdAsync</a>(groupId, requestBody?, queryParams?, headers?, cancellationToken?) -> GroupFull</code>
- <code title="delete /2.0/groups/{groupId}">client.Groups.<a href="./Box.Sdk.Gen/Managers/Groups/GroupsManager.cs">DeleteGroupByIdAsync</a>(groupId, headers?, cancellationToken?) -> void</code>

# Webhooks

Examples: [docs/Webhooks.md](docs/Webhooks.md)

Methods:

- <code title="get /2.0/webhooks">client.Webhooks.<a href="./Box.Sdk.Gen/Managers/Webhooks/WebhooksManager.cs">GetWebhooksAsync</a>(queryParams?, headers?, cancellationToken?) -> Webhooks</code>
- <code title="post /2.0/webhooks">client.Webhooks.<a href="./Box.Sdk.Gen/Managers/Webhooks/WebhooksManager.cs">CreateWebhookAsync</a>(requestBody, headers?, cancellationToken?) -> Webhook</code>
- <code title="get /2.0/webhooks/{webhookId}">client.Webhooks.<a href="./Box.Sdk.Gen/Managers/Webhooks/WebhooksManager.cs">GetWebhookByIdAsync</a>(webhookId, headers?, cancellationToken?) -> Webhook</code>
- <code title="put /2.0/webhooks/{webhookId}">client.Webhooks.<a href="./Box.Sdk.Gen/Managers/Webhooks/WebhooksManager.cs">UpdateWebhookByIdAsync</a>(webhookId, requestBody?, headers?, cancellationToken?) -> Webhook</code>
- <code title="delete /2.0/webhooks/{webhookId}">client.Webhooks.<a href="./Box.Sdk.Gen/Managers/Webhooks/WebhooksManager.cs">DeleteWebhookByIdAsync</a>(webhookId, headers?, cancellationToken?) -> void</code>

# Events

Examples: [docs/Events.md](docs/Events.md)

Methods:

- <code title="options /2.0/events">client.Events.<a href="./Box.Sdk.Gen/Managers/Events/EventsManager.cs">GetEventsWithLongPollingAsync</a>(headers?, cancellationToken?) -> RealtimeServers</code>
- <code title="get /2.0/events">client.Events.<a href="./Box.Sdk.Gen/Managers/Events/EventsManager.cs">GetEventsAsync</a>(queryParams?, headers?, cancellationToken?) -> Events</code>

# Collections

Examples: [docs/Collections.md](docs/Collections.md)

Methods:

- <code title="get /2.0/collections">client.Collections.<a href="./Box.Sdk.Gen/Managers/Collections/CollectionsManager.cs">GetCollectionsAsync</a>(queryParams?, headers?, cancellationToken?) -> Collections</code>
- <code title="get /2.0/collections/{collectionId}/items">client.Collections.<a href="./Box.Sdk.Gen/Managers/Collections/CollectionsManager.cs">GetCollectionItemsAsync</a>(collectionId, queryParams?, headers?, cancellationToken?) -> ItemsOffsetPaginated</code>
- <code title="get /2.0/collections/{collectionId}">client.Collections.<a href="./Box.Sdk.Gen/Managers/Collections/CollectionsManager.cs">GetCollectionByIdAsync</a>(collectionId, headers?, cancellationToken?) -> Collection</code>

# Recent items

Examples: [docs/RecentItems.md](docs/RecentItems.md)

Methods:

- <code title="get /2.0/recent_items">client.RecentItems.<a href="./Box.Sdk.Gen/Managers/RecentItems/RecentItemsManager.cs">GetRecentItemsAsync</a>(queryParams?, headers?, cancellationToken?) -> RecentItems</code>

# Retention policies

Examples: [docs/RetentionPolicies.md](docs/RetentionPolicies.md)

Methods:

- <code title="get /2.0/retention_policies">client.RetentionPolicies.<a href="./Box.Sdk.Gen/Managers/RetentionPolicies/RetentionPoliciesManager.cs">GetRetentionPoliciesAsync</a>(queryParams?, headers?, cancellationToken?) -> RetentionPolicies</code>
- <code title="post /2.0/retention_policies">client.RetentionPolicies.<a href="./Box.Sdk.Gen/Managers/RetentionPolicies/RetentionPoliciesManager.cs">CreateRetentionPolicyAsync</a>(requestBody, headers?, cancellationToken?) -> RetentionPolicy</code>
- <code title="get /2.0/retention_policies/{retentionPolicyId}">client.RetentionPolicies.<a href="./Box.Sdk.Gen/Managers/RetentionPolicies/RetentionPoliciesManager.cs">GetRetentionPolicyByIdAsync</a>(retentionPolicyId, queryParams?, headers?, cancellationToken?) -> RetentionPolicy</code>
- <code title="put /2.0/retention_policies/{retentionPolicyId}">client.RetentionPolicies.<a href="./Box.Sdk.Gen/Managers/RetentionPolicies/RetentionPoliciesManager.cs">UpdateRetentionPolicyByIdAsync</a>(retentionPolicyId, requestBody?, headers?, cancellationToken?) -> RetentionPolicy</code>
- <code title="delete /2.0/retention_policies/{retentionPolicyId}">client.RetentionPolicies.<a href="./Box.Sdk.Gen/Managers/RetentionPolicies/RetentionPoliciesManager.cs">DeleteRetentionPolicyByIdAsync</a>(retentionPolicyId, headers?, cancellationToken?) -> void</code>

# Retention policy assignments

Examples: [docs/RetentionPolicyAssignments.md](docs/RetentionPolicyAssignments.md)

Methods:

- <code title="get /2.0/retention_policies/{retentionPolicyId}/assignments">client.RetentionPolicyAssignments.<a href="./Box.Sdk.Gen/Managers/RetentionPolicyAssignments/RetentionPolicyAssignmentsManager.cs">GetRetentionPolicyAssignmentsAsync</a>(retentionPolicyId, queryParams?, headers?, cancellationToken?) -> RetentionPolicyAssignments</code>
- <code title="post /2.0/retention_policy_assignments">client.RetentionPolicyAssignments.<a href="./Box.Sdk.Gen/Managers/RetentionPolicyAssignments/RetentionPolicyAssignmentsManager.cs">CreateRetentionPolicyAssignmentAsync</a>(requestBody, headers?, cancellationToken?) -> RetentionPolicyAssignment</code>
- <code title="get /2.0/retention_policy_assignments/{retentionPolicyAssignmentId}">client.RetentionPolicyAssignments.<a href="./Box.Sdk.Gen/Managers/RetentionPolicyAssignments/RetentionPolicyAssignmentsManager.cs">GetRetentionPolicyAssignmentByIdAsync</a>(retentionPolicyAssignmentId, queryParams?, headers?, cancellationToken?) -> RetentionPolicyAssignment</code>
- <code title="delete /2.0/retention_policy_assignments/{retentionPolicyAssignmentId}">client.RetentionPolicyAssignments.<a href="./Box.Sdk.Gen/Managers/RetentionPolicyAssignments/RetentionPolicyAssignmentsManager.cs">DeleteRetentionPolicyAssignmentByIdAsync</a>(retentionPolicyAssignmentId, headers?, cancellationToken?) -> void</code>
- <code title="get /2.0/retention_policy_assignments/{retentionPolicyAssignmentId}/files_under_retention">client.RetentionPolicyAssignments.<a href="./Box.Sdk.Gen/Managers/RetentionPolicyAssignments/RetentionPolicyAssignmentsManager.cs">GetFilesUnderRetentionPolicyAssignmentAsync</a>(retentionPolicyAssignmentId, queryParams?, headers?, cancellationToken?) -> FilesUnderRetention</code>

# Legal hold policies

Examples: [docs/LegalHoldPolicies.md](docs/LegalHoldPolicies.md)

Methods:

- <code title="get /2.0/legal_hold_policies">client.LegalHoldPolicies.<a href="./Box.Sdk.Gen/Managers/LegalHoldPolicies/LegalHoldPoliciesManager.cs">GetLegalHoldPoliciesAsync</a>(queryParams?, headers?, cancellationToken?) -> LegalHoldPolicies</code>
- <code title="post /2.0/legal_hold_policies">client.LegalHoldPolicies.<a href="./Box.Sdk.Gen/Managers/LegalHoldPolicies/LegalHoldPoliciesManager.cs">CreateLegalHoldPolicyAsync</a>(requestBody, headers?, cancellationToken?) -> LegalHoldPolicy</code>
- <code title="get /2.0/legal_hold_policies/{legalHoldPolicyId}">client.LegalHoldPolicies.<a href="./Box.Sdk.Gen/Managers/LegalHoldPolicies/LegalHoldPoliciesManager.cs">GetLegalHoldPolicyByIdAsync</a>(legalHoldPolicyId, headers?, cancellationToken?) -> LegalHoldPolicy</code>
- <code title="put /2.0/legal_hold_policies/{legalHoldPolicyId}">client.LegalHoldPolicies.<a href="./Box.Sdk.Gen/Managers/LegalHoldPolicies/LegalHoldPoliciesManager.cs">UpdateLegalHoldPolicyByIdAsync</a>(legalHoldPolicyId, requestBody?, headers?, cancellationToken?) -> LegalHoldPolicy</code>
- <code title="delete /2.0/legal_hold_policies/{legalHoldPolicyId}">client.LegalHoldPolicies.<a href="./Box.Sdk.Gen/Managers/LegalHoldPolicies/LegalHoldPoliciesManager.cs">DeleteLegalHoldPolicyByIdAsync</a>(legalHoldPolicyId, headers?, cancellationToken?) -> void</code>

# Legal hold policy assignments

Examples: [docs/LegalHoldPolicyAssignments.md](docs/LegalHoldPolicyAssignments.md)

Methods:

- <code title="get /2.0/legal_hold_policy_assignments">client.LegalHoldPolicyAssignments.<a href="./Box.Sdk.Gen/Managers/LegalHoldPolicyAssignments/LegalHoldPolicyAssignmentsManager.cs">GetLegalHoldPolicyAssignmentsAsync</a>(queryParams, headers?, cancellationToken?) -> LegalHoldPolicyAssignments</code>
- <code title="post /2.0/legal_hold_policy_assignments">client.LegalHoldPolicyAssignments.<a href="./Box.Sdk.Gen/Managers/LegalHoldPolicyAssignments/LegalHoldPolicyAssignmentsManager.cs">CreateLegalHoldPolicyAssignmentAsync</a>(requestBody, headers?, cancellationToken?) -> LegalHoldPolicyAssignment</code>
- <code title="get /2.0/legal_hold_policy_assignments/{legalHoldPolicyAssignmentId}">client.LegalHoldPolicyAssignments.<a href="./Box.Sdk.Gen/Managers/LegalHoldPolicyAssignments/LegalHoldPolicyAssignmentsManager.cs">GetLegalHoldPolicyAssignmentByIdAsync</a>(legalHoldPolicyAssignmentId, headers?, cancellationToken?) -> LegalHoldPolicyAssignment</code>
- <code title="delete /2.0/legal_hold_policy_assignments/{legalHoldPolicyAssignmentId}">client.LegalHoldPolicyAssignments.<a href="./Box.Sdk.Gen/Managers/LegalHoldPolicyAssignments/LegalHoldPolicyAssignmentsManager.cs">DeleteLegalHoldPolicyAssignmentByIdAsync</a>(legalHoldPolicyAssignmentId, headers?, cancellationToken?) -> void</code>
- <code title="get /2.0/legal_hold_policy_assignments/{legalHoldPolicyAssignmentId}/files_on_hold">client.LegalHoldPolicyAssignments.<a href="./Box.Sdk.Gen/Managers/LegalHoldPolicyAssignments/LegalHoldPolicyAssignmentsManager.cs">GetLegalHoldPolicyAssignmentFileOnHoldAsync</a>(legalHoldPolicyAssignmentId, queryParams?, headers?, cancellationToken?) -> FilesOnHold</code>

# File version retentions

Examples: [docs/FileVersionRetentions.md](docs/FileVersionRetentions.md)

Methods:

- <code title="get /2.0/file_version_retentions">client.FileVersionRetentions.<a href="./Box.Sdk.Gen/Managers/FileVersionRetentions/FileVersionRetentionsManager.cs">GetFileVersionRetentionsAsync</a>(queryParams?, headers?, cancellationToken?) -> FileVersionRetentions</code>
- <code title="get /2.0/file_version_retentions/{fileVersionRetentionId}">client.FileVersionRetentions.<a href="./Box.Sdk.Gen/Managers/FileVersionRetentions/FileVersionRetentionsManager.cs">GetFileVersionRetentionByIdAsync</a>(fileVersionRetentionId, headers?, cancellationToken?) -> FileVersionRetention</code>

# File version legal holds

Examples: [docs/FileVersionLegalHolds.md](docs/FileVersionLegalHolds.md)

Methods:

- <code title="get /2.0/file_version_legal_holds/{fileVersionLegalHoldId}">client.FileVersionLegalHolds.<a href="./Box.Sdk.Gen/Managers/FileVersionLegalHolds/FileVersionLegalHoldsManager.cs">GetFileVersionLegalHoldByIdAsync</a>(fileVersionLegalHoldId, headers?, cancellationToken?) -> FileVersionLegalHold</code>
- <code title="get /2.0/file_version_legal_holds">client.FileVersionLegalHolds.<a href="./Box.Sdk.Gen/Managers/FileVersionLegalHolds/FileVersionLegalHoldsManager.cs">GetFileVersionLegalHoldsAsync</a>(queryParams, headers?, cancellationToken?) -> FileVersionLegalHolds</code>

# Shield information barriers

Examples: [docs/ShieldInformationBarriers.md](docs/ShieldInformationBarriers.md)

Methods:

- <code title="get /2.0/shield_information_barriers/{shieldInformationBarrierId}">client.ShieldInformationBarriers.<a href="./Box.Sdk.Gen/Managers/ShieldInformationBarriers/ShieldInformationBarriersManager.cs">GetShieldInformationBarrierByIdAsync</a>(shieldInformationBarrierId, headers?, cancellationToken?) -> ShieldInformationBarrier</code>
- <code title="post /2.0/shield_information_barriers/change_status">client.ShieldInformationBarriers.<a href="./Box.Sdk.Gen/Managers/ShieldInformationBarriers/ShieldInformationBarriersManager.cs">UpdateShieldInformationBarrierStatusAsync</a>(requestBody, headers?, cancellationToken?) -> ShieldInformationBarrier</code>
- <code title="get /2.0/shield_information_barriers">client.ShieldInformationBarriers.<a href="./Box.Sdk.Gen/Managers/ShieldInformationBarriers/ShieldInformationBarriersManager.cs">GetShieldInformationBarriersAsync</a>(queryParams?, headers?, cancellationToken?) -> ShieldInformationBarriers</code>
- <code title="post /2.0/shield_information_barriers">client.ShieldInformationBarriers.<a href="./Box.Sdk.Gen/Managers/ShieldInformationBarriers/ShieldInformationBarriersManager.cs">CreateShieldInformationBarrierAsync</a>(requestBody, headers?, cancellationToken?) -> ShieldInformationBarrier</code>

# Shield information barrier reports

Examples: [docs/ShieldInformationBarrierReports.md](docs/ShieldInformationBarrierReports.md)

Methods:

- <code title="get /2.0/shield_information_barrier_reports">client.ShieldInformationBarrierReports.<a href="./Box.Sdk.Gen/Managers/ShieldInformationBarrierReports/ShieldInformationBarrierReportsManager.cs">GetShieldInformationBarrierReportsAsync</a>(queryParams, headers?, cancellationToken?) -> ShieldInformationBarrierReports</code>
- <code title="post /2.0/shield_information_barrier_reports">client.ShieldInformationBarrierReports.<a href="./Box.Sdk.Gen/Managers/ShieldInformationBarrierReports/ShieldInformationBarrierReportsManager.cs">CreateShieldInformationBarrierReportAsync</a>(requestBody, headers?, cancellationToken?) -> ShieldInformationBarrierReport</code>
- <code title="get /2.0/shield_information_barrier_reports/{shieldInformationBarrierReportId}">client.ShieldInformationBarrierReports.<a href="./Box.Sdk.Gen/Managers/ShieldInformationBarrierReports/ShieldInformationBarrierReportsManager.cs">GetShieldInformationBarrierReportByIdAsync</a>(shieldInformationBarrierReportId, headers?, cancellationToken?) -> ShieldInformationBarrierReport</code>

# Shield information barrier segments

Examples: [docs/ShieldInformationBarrierSegments.md](docs/ShieldInformationBarrierSegments.md)

Methods:

- <code title="get /2.0/shield_information_barrier_segments/{shieldInformationBarrierSegmentId}">client.ShieldInformationBarrierSegments.<a href="./Box.Sdk.Gen/Managers/ShieldInformationBarrierSegments/ShieldInformationBarrierSegmentsManager.cs">GetShieldInformationBarrierSegmentByIdAsync</a>(shieldInformationBarrierSegmentId, headers?, cancellationToken?) -> ShieldInformationBarrierSegment</code>
- <code title="delete /2.0/shield_information_barrier_segments/{shieldInformationBarrierSegmentId}">client.ShieldInformationBarrierSegments.<a href="./Box.Sdk.Gen/Managers/ShieldInformationBarrierSegments/ShieldInformationBarrierSegmentsManager.cs">DeleteShieldInformationBarrierSegmentByIdAsync</a>(shieldInformationBarrierSegmentId, headers?, cancellationToken?) -> void</code>
- <code title="put /2.0/shield_information_barrier_segments/{shieldInformationBarrierSegmentId}">client.ShieldInformationBarrierSegments.<a href="./Box.Sdk.Gen/Managers/ShieldInformationBarrierSegments/ShieldInformationBarrierSegmentsManager.cs">UpdateShieldInformationBarrierSegmentByIdAsync</a>(shieldInformationBarrierSegmentId, requestBody?, headers?, cancellationToken?) -> ShieldInformationBarrierSegment</code>
- <code title="get /2.0/shield_information_barrier_segments">client.ShieldInformationBarrierSegments.<a href="./Box.Sdk.Gen/Managers/ShieldInformationBarrierSegments/ShieldInformationBarrierSegmentsManager.cs">GetShieldInformationBarrierSegmentsAsync</a>(queryParams, headers?, cancellationToken?) -> ShieldInformationBarrierSegments</code>
- <code title="post /2.0/shield_information_barrier_segments">client.ShieldInformationBarrierSegments.<a href="./Box.Sdk.Gen/Managers/ShieldInformationBarrierSegments/ShieldInformationBarrierSegmentsManager.cs">CreateShieldInformationBarrierSegmentAsync</a>(requestBody, headers?, cancellationToken?) -> ShieldInformationBarrierSegment</code>

# Shield information barrier segment members

Examples: [docs/ShieldInformationBarrierSegmentMembers.md](docs/ShieldInformationBarrierSegmentMembers.md)

Methods:

- <code title="get /2.0/shield_information_barrier_segment_members/{shieldInformationBarrierSegmentMemberId}">client.ShieldInformationBarrierSegmentMembers.<a href="./Box.Sdk.Gen/Managers/ShieldInformationBarrierSegmentMembers/ShieldInformationBarrierSegmentMembersManager.cs">GetShieldInformationBarrierSegmentMemberByIdAsync</a>(shieldInformationBarrierSegmentMemberId, headers?, cancellationToken?) -> ShieldInformationBarrierSegmentMember</code>
- <code title="delete /2.0/shield_information_barrier_segment_members/{shieldInformationBarrierSegmentMemberId}">client.ShieldInformationBarrierSegmentMembers.<a href="./Box.Sdk.Gen/Managers/ShieldInformationBarrierSegmentMembers/ShieldInformationBarrierSegmentMembersManager.cs">DeleteShieldInformationBarrierSegmentMemberByIdAsync</a>(shieldInformationBarrierSegmentMemberId, headers?, cancellationToken?) -> void</code>
- <code title="get /2.0/shield_information_barrier_segment_members">client.ShieldInformationBarrierSegmentMembers.<a href="./Box.Sdk.Gen/Managers/ShieldInformationBarrierSegmentMembers/ShieldInformationBarrierSegmentMembersManager.cs">GetShieldInformationBarrierSegmentMembersAsync</a>(queryParams, headers?, cancellationToken?) -> ShieldInformationBarrierSegmentMembers</code>
- <code title="post /2.0/shield_information_barrier_segment_members">client.ShieldInformationBarrierSegmentMembers.<a href="./Box.Sdk.Gen/Managers/ShieldInformationBarrierSegmentMembers/ShieldInformationBarrierSegmentMembersManager.cs">CreateShieldInformationBarrierSegmentMemberAsync</a>(requestBody, headers?, cancellationToken?) -> ShieldInformationBarrierSegmentMember</code>

# Shield information barrier segment restrictions

Examples: [docs/ShieldInformationBarrierSegmentRestrictions.md](docs/ShieldInformationBarrierSegmentRestrictions.md)

Methods:

- <code title="get /2.0/shield_information_barrier_segment_restrictions/{shieldInformationBarrierSegmentRestrictionId}">client.ShieldInformationBarrierSegmentRestrictions.<a href="./Box.Sdk.Gen/Managers/ShieldInformationBarrierSegmentRestrictions/ShieldInformationBarrierSegmentRestrictionsManager.cs">GetShieldInformationBarrierSegmentRestrictionByIdAsync</a>(shieldInformationBarrierSegmentRestrictionId, headers?, cancellationToken?) -> ShieldInformationBarrierSegmentRestriction</code>
- <code title="delete /2.0/shield_information_barrier_segment_restrictions/{shieldInformationBarrierSegmentRestrictionId}">client.ShieldInformationBarrierSegmentRestrictions.<a href="./Box.Sdk.Gen/Managers/ShieldInformationBarrierSegmentRestrictions/ShieldInformationBarrierSegmentRestrictionsManager.cs">DeleteShieldInformationBarrierSegmentRestrictionByIdAsync</a>(shieldInformationBarrierSegmentRestrictionId, headers?, cancellationToken?) -> void</code>
- <code title="get /2.0/shield_information_barrier_segment_restrictions">client.ShieldInformationBarrierSegmentRestrictions.<a href="./Box.Sdk.Gen/Managers/ShieldInformationBarrierSegmentRestrictions/ShieldInformationBarrierSegmentRestrictionsManager.cs">GetShieldInformationBarrierSegmentRestrictionsAsync</a>(queryParams, headers?, cancellationToken?) -> ShieldInformationBarrierSegmentRestrictions</code>
- <code title="post /2.0/shield_information_barrier_segment_restrictions">client.ShieldInformationBarrierSegmentRestrictions.<a href="./Box.Sdk.Gen/Managers/ShieldInformationBarrierSegmentRestrictions/ShieldInformationBarrierSegmentRestrictionsManager.cs">CreateShieldInformationBarrierSegmentRestrictionAsync</a>(requestBody, headers?, cancellationToken?) -> ShieldInformationBarrierSegmentRestriction</code>

# Device pinners

Examples: [docs/DevicePinners.md](docs/DevicePinners.md)

Methods:

- <code title="get /2.0/device_pinners/{devicePinnerId}">client.DevicePinners.<a href="./Box.Sdk.Gen/Managers/DevicePinners/DevicePinnersManager.cs">GetDevicePinnerByIdAsync</a>(devicePinnerId, headers?, cancellationToken?) -> DevicePinner</code>
- <code title="delete /2.0/device_pinners/{devicePinnerId}">client.DevicePinners.<a href="./Box.Sdk.Gen/Managers/DevicePinners/DevicePinnersManager.cs">DeleteDevicePinnerByIdAsync</a>(devicePinnerId, headers?, cancellationToken?) -> void</code>
- <code title="get /2.0/enterprises/{enterpriseId}/device_pinners">client.DevicePinners.<a href="./Box.Sdk.Gen/Managers/DevicePinners/DevicePinnersManager.cs">GetEnterpriseDevicePinnersAsync</a>(enterpriseId, queryParams?, headers?, cancellationToken?) -> DevicePinners</code>

# Terms of services

Examples: [docs/TermsOfServices.md](docs/TermsOfServices.md)

Methods:

- <code title="get /2.0/terms_of_services">client.TermsOfServices.<a href="./Box.Sdk.Gen/Managers/TermsOfServices/TermsOfServicesManager.cs">GetTermsOfServiceAsync</a>(queryParams?, headers?, cancellationToken?) -> TermsOfServices</code>
- <code title="post /2.0/terms_of_services">client.TermsOfServices.<a href="./Box.Sdk.Gen/Managers/TermsOfServices/TermsOfServicesManager.cs">CreateTermsOfServiceAsync</a>(requestBody, headers?, cancellationToken?) -> TermsOfService</code>
- <code title="get /2.0/terms_of_services/{termsOfServiceId}">client.TermsOfServices.<a href="./Box.Sdk.Gen/Managers/TermsOfServices/TermsOfServicesManager.cs">GetTermsOfServiceByIdAsync</a>(termsOfServiceId, headers?, cancellationToken?) -> TermsOfService</code>
- <code title="put /2.0/terms_of_services/{termsOfServiceId}">client.TermsOfServices.<a href="./Box.Sdk.Gen/Managers/TermsOfServices/TermsOfServicesManager.cs">UpdateTermsOfServiceByIdAsync</a>(termsOfServiceId, requestBody, headers?, cancellationToken?) -> TermsOfService</code>

# Terms of service user statuses

Examples: [docs/TermsOfServiceUserStatuses.md](docs/TermsOfServiceUserStatuses.md)

Methods:

- <code title="get /2.0/terms_of_service_user_statuses">client.TermsOfServiceUserStatuses.<a href="./Box.Sdk.Gen/Managers/TermsOfServiceUserStatuses/TermsOfServiceUserStatusesManager.cs">GetTermsOfServiceUserStatusesAsync</a>(queryParams, headers?, cancellationToken?) -> TermsOfServiceUserStatuses</code>
- <code title="post /2.0/terms_of_service_user_statuses">client.TermsOfServiceUserStatuses.<a href="./Box.Sdk.Gen/Managers/TermsOfServiceUserStatuses/TermsOfServiceUserStatusesManager.cs">CreateTermsOfServiceStatusForUserAsync</a>(requestBody, headers?, cancellationToken?) -> TermsOfServiceUserStatus</code>
- <code title="put /2.0/terms_of_service_user_statuses/{termsOfServiceUserStatusId}">client.TermsOfServiceUserStatuses.<a href="./Box.Sdk.Gen/Managers/TermsOfServiceUserStatuses/TermsOfServiceUserStatusesManager.cs">UpdateTermsOfServiceStatusForUserByIdAsync</a>(termsOfServiceUserStatusId, requestBody, headers?, cancellationToken?) -> TermsOfServiceUserStatus</code>

# Collaboration allowlist entries

Examples: [docs/CollaborationAllowlistEntries.md](docs/CollaborationAllowlistEntries.md)

Methods:

- <code title="get /2.0/collaboration_whitelist_entries">client.CollaborationAllowlistEntries.<a href="./Box.Sdk.Gen/Managers/CollaborationAllowlistEntries/CollaborationAllowlistEntriesManager.cs">GetCollaborationWhitelistEntriesAsync</a>(queryParams?, headers?, cancellationToken?) -> CollaborationAllowlistEntries</code>
- <code title="post /2.0/collaboration_whitelist_entries">client.CollaborationAllowlistEntries.<a href="./Box.Sdk.Gen/Managers/CollaborationAllowlistEntries/CollaborationAllowlistEntriesManager.cs">CreateCollaborationWhitelistEntryAsync</a>(requestBody, headers?, cancellationToken?) -> CollaborationAllowlistEntry</code>
- <code title="get /2.0/collaboration_whitelist_entries/{collaborationWhitelistEntryId}">client.CollaborationAllowlistEntries.<a href="./Box.Sdk.Gen/Managers/CollaborationAllowlistEntries/CollaborationAllowlistEntriesManager.cs">GetCollaborationWhitelistEntryByIdAsync</a>(collaborationWhitelistEntryId, headers?, cancellationToken?) -> CollaborationAllowlistEntry</code>
- <code title="delete /2.0/collaboration_whitelist_entries/{collaborationWhitelistEntryId}">client.CollaborationAllowlistEntries.<a href="./Box.Sdk.Gen/Managers/CollaborationAllowlistEntries/CollaborationAllowlistEntriesManager.cs">DeleteCollaborationWhitelistEntryByIdAsync</a>(collaborationWhitelistEntryId, headers?, cancellationToken?) -> void</code>

# Collaboration allowlist exempt targets

Examples: [docs/CollaborationAllowlistExemptTargets.md](docs/CollaborationAllowlistExemptTargets.md)

Methods:

- <code title="get /2.0/collaboration_whitelist_exempt_targets">client.CollaborationAllowlistExemptTargets.<a href="./Box.Sdk.Gen/Managers/CollaborationAllowlistExemptTargets/CollaborationAllowlistExemptTargetsManager.cs">GetCollaborationWhitelistExemptTargetsAsync</a>(queryParams?, headers?, cancellationToken?) -> CollaborationAllowlistExemptTargets</code>
- <code title="post /2.0/collaboration_whitelist_exempt_targets">client.CollaborationAllowlistExemptTargets.<a href="./Box.Sdk.Gen/Managers/CollaborationAllowlistExemptTargets/CollaborationAllowlistExemptTargetsManager.cs">CreateCollaborationWhitelistExemptTargetAsync</a>(requestBody, headers?, cancellationToken?) -> CollaborationAllowlistExemptTarget</code>
- <code title="get /2.0/collaboration_whitelist_exempt_targets/{collaborationWhitelistExemptTargetId}">client.CollaborationAllowlistExemptTargets.<a href="./Box.Sdk.Gen/Managers/CollaborationAllowlistExemptTargets/CollaborationAllowlistExemptTargetsManager.cs">GetCollaborationWhitelistExemptTargetByIdAsync</a>(collaborationWhitelistExemptTargetId, headers?, cancellationToken?) -> CollaborationAllowlistExemptTarget</code>
- <code title="delete /2.0/collaboration_whitelist_exempt_targets/{collaborationWhitelistExemptTargetId}">client.CollaborationAllowlistExemptTargets.<a href="./Box.Sdk.Gen/Managers/CollaborationAllowlistExemptTargets/CollaborationAllowlistExemptTargetsManager.cs">DeleteCollaborationWhitelistExemptTargetByIdAsync</a>(collaborationWhitelistExemptTargetId, headers?, cancellationToken?) -> void</code>

# Storage policies

Examples: [docs/StoragePolicies.md](docs/StoragePolicies.md)

Methods:

- <code title="get /2.0/storage_policies">client.StoragePolicies.<a href="./Box.Sdk.Gen/Managers/StoragePolicies/StoragePoliciesManager.cs">GetStoragePoliciesAsync</a>(queryParams?, headers?, cancellationToken?) -> StoragePolicies</code>
- <code title="get /2.0/storage_policies/{storagePolicyId}">client.StoragePolicies.<a href="./Box.Sdk.Gen/Managers/StoragePolicies/StoragePoliciesManager.cs">GetStoragePolicyByIdAsync</a>(storagePolicyId, headers?, cancellationToken?) -> StoragePolicy</code>

# Storage policy assignments

Examples: [docs/StoragePolicyAssignments.md](docs/StoragePolicyAssignments.md)

Methods:

- <code title="get /2.0/storage_policy_assignments">client.StoragePolicyAssignments.<a href="./Box.Sdk.Gen/Managers/StoragePolicyAssignments/StoragePolicyAssignmentsManager.cs">GetStoragePolicyAssignmentsAsync</a>(queryParams, headers?, cancellationToken?) -> StoragePolicyAssignments</code>
- <code title="post /2.0/storage_policy_assignments">client.StoragePolicyAssignments.<a href="./Box.Sdk.Gen/Managers/StoragePolicyAssignments/StoragePolicyAssignmentsManager.cs">CreateStoragePolicyAssignmentAsync</a>(requestBody, headers?, cancellationToken?) -> StoragePolicyAssignment</code>
- <code title="get /2.0/storage_policy_assignments/{storagePolicyAssignmentId}">client.StoragePolicyAssignments.<a href="./Box.Sdk.Gen/Managers/StoragePolicyAssignments/StoragePolicyAssignmentsManager.cs">GetStoragePolicyAssignmentByIdAsync</a>(storagePolicyAssignmentId, headers?, cancellationToken?) -> StoragePolicyAssignment</code>
- <code title="put /2.0/storage_policy_assignments/{storagePolicyAssignmentId}">client.StoragePolicyAssignments.<a href="./Box.Sdk.Gen/Managers/StoragePolicyAssignments/StoragePolicyAssignmentsManager.cs">UpdateStoragePolicyAssignmentByIdAsync</a>(storagePolicyAssignmentId, requestBody, headers?, cancellationToken?) -> StoragePolicyAssignment</code>
- <code title="delete /2.0/storage_policy_assignments/{storagePolicyAssignmentId}">client.StoragePolicyAssignments.<a href="./Box.Sdk.Gen/Managers/StoragePolicyAssignments/StoragePolicyAssignmentsManager.cs">DeleteStoragePolicyAssignmentByIdAsync</a>(storagePolicyAssignmentId, headers?, cancellationToken?) -> void</code>

# Zip downloads

Examples: [docs/ZipDownloads.md](docs/ZipDownloads.md)

Methods:

- <code title="post /2.0/zip_downloads">client.ZipDownloads.<a href="./Box.Sdk.Gen/Managers/ZipDownloads/ZipDownloadsManager.cs">CreateZipDownloadAsync</a>(requestBody, headers?, cancellationToken?) -> ZipDownload</code>
- <code>client.ZipDownloads.<a href="./Box.Sdk.Gen/Managers/ZipDownloads/ZipDownloadsManager.cs">GetZipDownloadContentAsync</a>(downloadUrl, headers?, cancellationToken?) -> System.IO.Stream</code>
- <code>client.ZipDownloads.<a href="./Box.Sdk.Gen/Managers/ZipDownloads/ZipDownloadsManager.cs">GetZipDownloadStatusAsync</a>(statusUrl, headers?, cancellationToken?) -> ZipDownloadStatus</code>
- <code>client.ZipDownloads.<a href="./Box.Sdk.Gen/Managers/ZipDownloads/ZipDownloadsManager.cs">DownloadZipAsync</a>(requestBody, headers?, cancellationToken?) -> System.IO.Stream</code>

# Sign requests

Examples: [docs/SignRequests.md](docs/SignRequests.md)

Methods:

- <code title="post /2.0/sign_requests/{signRequestId}/cancel">client.SignRequests.<a href="./Box.Sdk.Gen/Managers/SignRequests/SignRequestsManager.cs">CancelSignRequestAsync</a>(signRequestId, headers?, cancellationToken?) -> SignRequest</code>
- <code title="post /2.0/sign_requests/{signRequestId}/resend">client.SignRequests.<a href="./Box.Sdk.Gen/Managers/SignRequests/SignRequestsManager.cs">ResendSignRequestAsync</a>(signRequestId, headers?, cancellationToken?) -> void</code>
- <code title="get /2.0/sign_requests/{signRequestId}">client.SignRequests.<a href="./Box.Sdk.Gen/Managers/SignRequests/SignRequestsManager.cs">GetSignRequestByIdAsync</a>(signRequestId, headers?, cancellationToken?) -> SignRequest</code>
- <code title="get /2.0/sign_requests">client.SignRequests.<a href="./Box.Sdk.Gen/Managers/SignRequests/SignRequestsManager.cs">GetSignRequestsAsync</a>(queryParams?, headers?, cancellationToken?) -> SignRequests</code>
- <code title="post /2.0/sign_requests">client.SignRequests.<a href="./Box.Sdk.Gen/Managers/SignRequests/SignRequestsManager.cs">CreateSignRequestAsync</a>(requestBody, headers?, cancellationToken?) -> SignRequest</code>

# Workflows

Examples: [docs/Workflows.md](docs/Workflows.md)

Methods:

- <code title="get /2.0/workflows">client.Workflows.<a href="./Box.Sdk.Gen/Managers/Workflows/WorkflowsManager.cs">GetWorkflowsAsync</a>(queryParams, headers?, cancellationToken?) -> Workflows</code>
- <code title="post /2.0/workflows/{workflowId}/start">client.Workflows.<a href="./Box.Sdk.Gen/Managers/Workflows/WorkflowsManager.cs">StartWorkflowAsync</a>(workflowId, requestBody, headers?, cancellationToken?) -> void</code>

# Sign templates

Examples: [docs/SignTemplates.md](docs/SignTemplates.md)

Methods:

- <code title="get /2.0/sign_templates">client.SignTemplates.<a href="./Box.Sdk.Gen/Managers/SignTemplates/SignTemplatesManager.cs">GetSignTemplatesAsync</a>(queryParams?, headers?, cancellationToken?) -> SignTemplates</code>
- <code title="get /2.0/sign_templates/{templateId}">client.SignTemplates.<a href="./Box.Sdk.Gen/Managers/SignTemplates/SignTemplatesManager.cs">GetSignTemplateByIdAsync</a>(templateId, headers?, cancellationToken?) -> SignTemplate</code>

# Integration mappings

Examples: [docs/IntegrationMappings.md](docs/IntegrationMappings.md)

Methods:

- <code title="get /2.0/integration_mappings/slack">client.IntegrationMappings.<a href="./Box.Sdk.Gen/Managers/IntegrationMappings/IntegrationMappingsManager.cs">GetSlackIntegrationMappingAsync</a>(queryParams?, headers?, cancellationToken?) -> IntegrationMappings</code>
- <code title="post /2.0/integration_mappings/slack">client.IntegrationMappings.<a href="./Box.Sdk.Gen/Managers/IntegrationMappings/IntegrationMappingsManager.cs">CreateSlackIntegrationMappingAsync</a>(requestBody, headers?, cancellationToken?) -> IntegrationMapping</code>
- <code title="put /2.0/integration_mappings/slack/{integrationMappingId}">client.IntegrationMappings.<a href="./Box.Sdk.Gen/Managers/IntegrationMappings/IntegrationMappingsManager.cs">UpdateSlackIntegrationMappingByIdAsync</a>(integrationMappingId, requestBody?, headers?, cancellationToken?) -> IntegrationMapping</code>
- <code title="delete /2.0/integration_mappings/slack/{integrationMappingId}">client.IntegrationMappings.<a href="./Box.Sdk.Gen/Managers/IntegrationMappings/IntegrationMappingsManager.cs">DeleteSlackIntegrationMappingByIdAsync</a>(integrationMappingId, headers?, cancellationToken?) -> void</code>
- <code title="get /2.0/integration_mappings/teams">client.IntegrationMappings.<a href="./Box.Sdk.Gen/Managers/IntegrationMappings/IntegrationMappingsManager.cs">GetTeamsIntegrationMappingAsync</a>(queryParams?, headers?, cancellationToken?) -> IntegrationMappingsTeams</code>
- <code title="post /2.0/integration_mappings/teams">client.IntegrationMappings.<a href="./Box.Sdk.Gen/Managers/IntegrationMappings/IntegrationMappingsManager.cs">CreateTeamsIntegrationMappingAsync</a>(requestBody, headers?, cancellationToken?) -> IntegrationMappingTeams</code>
- <code title="put /2.0/integration_mappings/teams/{integrationMappingId}">client.IntegrationMappings.<a href="./Box.Sdk.Gen/Managers/IntegrationMappings/IntegrationMappingsManager.cs">UpdateTeamsIntegrationMappingByIdAsync</a>(integrationMappingId, requestBody?, headers?, cancellationToken?) -> IntegrationMappingTeams</code>
- <code title="delete /2.0/integration_mappings/teams/{integrationMappingId}">client.IntegrationMappings.<a href="./Box.Sdk.Gen/Managers/IntegrationMappings/IntegrationMappingsManager.cs">DeleteTeamsIntegrationMappingByIdAsync</a>(integrationMappingId, headers?, cancellationToken?) -> void</code>

# Ai

Examples: [docs/Ai.md](docs/Ai.md)

Methods:

- <code title="post /2.0/ai/ask">client.Ai.<a href="./Box.Sdk.Gen/Managers/Ai/AiManager.cs">CreateAiAskAsync</a>(requestBody, headers?, cancellationToken?) -> AiResponseFull?</code>
- <code title="post /2.0/ai/text_gen">client.Ai.<a href="./Box.Sdk.Gen/Managers/Ai/AiManager.cs">CreateAiTextGenAsync</a>(requestBody, headers?, cancellationToken?) -> AiResponse</code>
- <code title="get /2.0/ai_agent_default">client.Ai.<a href="./Box.Sdk.Gen/Managers/Ai/AiManager.cs">GetAiAgentDefaultConfigAsync</a>(queryParams, headers?, cancellationToken?) -> AiAgentAskOrAiAgentExtractOrAiAgentExtractStructuredOrAiAgentTextGen</code>
- <code title="post /2.0/ai/extract">client.Ai.<a href="./Box.Sdk.Gen/Managers/Ai/AiManager.cs">CreateAiExtractAsync</a>(requestBody, headers?, cancellationToken?) -> AiResponse</code>
- <code title="post /2.0/ai/extract_structured">client.Ai.<a href="./Box.Sdk.Gen/Managers/Ai/AiManager.cs">CreateAiExtractStructuredAsync</a>(requestBody, headers?, cancellationToken?) -> AiExtractStructuredResponse</code>

# Ai studio

Examples: [docs/AiStudio.md](docs/AiStudio.md)

Methods:

- <code title="get /2.0/ai_agents">client.AiStudio.<a href="./Box.Sdk.Gen/Managers/AiStudio/AiStudioManager.cs">GetAiAgentsAsync</a>(queryParams?, headers?, cancellationToken?) -> AiMultipleAgentResponse</code>
- <code title="post /2.0/ai_agents">client.AiStudio.<a href="./Box.Sdk.Gen/Managers/AiStudio/AiStudioManager.cs">CreateAiAgentAsync</a>(requestBody, headers?, cancellationToken?) -> AiSingleAgentResponseFull</code>
- <code title="put /2.0/ai_agents/{agentId}">client.AiStudio.<a href="./Box.Sdk.Gen/Managers/AiStudio/AiStudioManager.cs">UpdateAiAgentByIdAsync</a>(agentId, requestBody, headers?, cancellationToken?) -> AiSingleAgentResponseFull</code>
- <code title="get /2.0/ai_agents/{agentId}">client.AiStudio.<a href="./Box.Sdk.Gen/Managers/AiStudio/AiStudioManager.cs">GetAiAgentByIdAsync</a>(agentId, queryParams?, headers?, cancellationToken?) -> AiSingleAgentResponseFull</code>
- <code title="delete /2.0/ai_agents/{agentId}">client.AiStudio.<a href="./Box.Sdk.Gen/Managers/AiStudio/AiStudioManager.cs">DeleteAiAgentByIdAsync</a>(agentId, headers?, cancellationToken?) -> void</code>

# Docgen template

Examples: [docs/DocgenTemplate.md](docs/DocgenTemplate.md)

Methods:

- <code title="post /2.0/docgen_templates">client.DocgenTemplate.<a href="./Box.Sdk.Gen/Managers/DocgenTemplate/DocgenTemplateManager.cs">CreateDocgenTemplateV2025R0Async</a>(requestBody, headers?, cancellationToken?) -> DocGenTemplateBaseV2025R0</code>
- <code title="get /2.0/docgen_templates">client.DocgenTemplate.<a href="./Box.Sdk.Gen/Managers/DocgenTemplate/DocgenTemplateManager.cs">GetDocgenTemplatesV2025R0Async</a>(queryParams?, headers?, cancellationToken?) -> DocGenTemplatesV2025R0</code>
- <code title="delete /2.0/docgen_templates/{templateId}">client.DocgenTemplate.<a href="./Box.Sdk.Gen/Managers/DocgenTemplate/DocgenTemplateManager.cs">DeleteDocgenTemplateByIdV2025R0Async</a>(templateId, headers?, cancellationToken?) -> void</code>
- <code title="get /2.0/docgen_templates/{templateId}">client.DocgenTemplate.<a href="./Box.Sdk.Gen/Managers/DocgenTemplate/DocgenTemplateManager.cs">GetDocgenTemplateByIdV2025R0Async</a>(templateId, headers?, cancellationToken?) -> DocGenTemplateV2025R0</code>
- <code title="get /2.0/docgen_templates/{templateId}/tags">client.DocgenTemplate.<a href="./Box.Sdk.Gen/Managers/DocgenTemplate/DocgenTemplateManager.cs">GetDocgenTemplateTagsV2025R0Async</a>(templateId, queryParams?, headers?, cancellationToken?) -> DocGenTagsV2025R0</code>
- <code title="get /2.0/docgen_template_jobs/{templateId}">client.DocgenTemplate.<a href="./Box.Sdk.Gen/Managers/DocgenTemplate/DocgenTemplateManager.cs">GetDocgenTemplateJobByIdV2025R0Async</a>(templateId, queryParams?, headers?, cancellationToken?) -> DocGenJobsV2025R0</code>

# Docgen

Examples: [docs/Docgen.md](docs/Docgen.md)

Methods:

- <code title="get /2.0/docgen_jobs/{jobId}">client.Docgen.<a href="./Box.Sdk.Gen/Managers/Docgen/DocgenManager.cs">GetDocgenJobByIdV2025R0Async</a>(jobId, headers?, cancellationToken?) -> DocGenJobV2025R0</code>
- <code title="get /2.0/docgen_jobs">client.Docgen.<a href="./Box.Sdk.Gen/Managers/Docgen/DocgenManager.cs">GetDocgenJobsV2025R0Async</a>(queryParams?, headers?, cancellationToken?) -> DocGenJobsFullV2025R0</code>
- <code title="get /2.0/docgen_batch_jobs/{batchId}">client.Docgen.<a href="./Box.Sdk.Gen/Managers/Docgen/DocgenManager.cs">GetDocgenBatchJobByIdV2025R0Async</a>(batchId, queryParams?, headers?, cancellationToken?) -> DocGenJobsV2025R0</code>
- <code title="post /2.0/docgen_batches">client.Docgen.<a href="./Box.Sdk.Gen/Managers/Docgen/DocgenManager.cs">CreateDocgenBatchV2025R0Async</a>(requestBody, headers?, cancellationToken?) -> DocGenBatchBaseV2025R0</code>

# Hubs

Examples: [docs/Hubs.md](docs/Hubs.md)

Methods:

- <code title="get /2.0/hubs">client.Hubs.<a href="./Box.Sdk.Gen/Managers/Hubs/HubsManager.cs">GetHubsV2025R0Async</a>(queryParams?, headers?, cancellationToken?) -> HubsV2025R0</code>
- <code title="post /2.0/hubs">client.Hubs.<a href="./Box.Sdk.Gen/Managers/Hubs/HubsManager.cs">CreateHubV2025R0Async</a>(requestBody, headers?, cancellationToken?) -> HubV2025R0</code>
- <code title="get /2.0/enterprise_hubs">client.Hubs.<a href="./Box.Sdk.Gen/Managers/Hubs/HubsManager.cs">GetEnterpriseHubsV2025R0Async</a>(queryParams?, headers?, cancellationToken?) -> HubsV2025R0</code>
- <code title="get /2.0/hubs/{hubId}">client.Hubs.<a href="./Box.Sdk.Gen/Managers/Hubs/HubsManager.cs">GetHubByIdV2025R0Async</a>(hubId, headers?, cancellationToken?) -> HubV2025R0</code>
- <code title="put /2.0/hubs/{hubId}">client.Hubs.<a href="./Box.Sdk.Gen/Managers/Hubs/HubsManager.cs">UpdateHubByIdV2025R0Async</a>(hubId, requestBody, headers?, cancellationToken?) -> HubV2025R0</code>
- <code title="delete /2.0/hubs/{hubId}">client.Hubs.<a href="./Box.Sdk.Gen/Managers/Hubs/HubsManager.cs">DeleteHubByIdV2025R0Async</a>(hubId, headers?, cancellationToken?) -> void</code>
- <code title="post /2.0/hubs/{hubId}/copy">client.Hubs.<a href="./Box.Sdk.Gen/Managers/Hubs/HubsManager.cs">CopyHubV2025R0Async</a>(hubId, requestBody, headers?, cancellationToken?) -> HubV2025R0</code>

# Hub collaborations

Examples: [docs/HubCollaborations.md](docs/HubCollaborations.md)

Methods:

- <code title="get /2.0/hub_collaborations">client.HubCollaborations.<a href="./Box.Sdk.Gen/Managers/HubCollaborations/HubCollaborationsManager.cs">GetHubCollaborationsV2025R0Async</a>(queryParams, headers?, cancellationToken?) -> HubCollaborationsV2025R0</code>
- <code title="post /2.0/hub_collaborations">client.HubCollaborations.<a href="./Box.Sdk.Gen/Managers/HubCollaborations/HubCollaborationsManager.cs">CreateHubCollaborationV2025R0Async</a>(requestBody, headers?, cancellationToken?) -> HubCollaborationV2025R0</code>
- <code title="get /2.0/hub_collaborations/{hubCollaborationId}">client.HubCollaborations.<a href="./Box.Sdk.Gen/Managers/HubCollaborations/HubCollaborationsManager.cs">GetHubCollaborationByIdV2025R0Async</a>(hubCollaborationId, headers?, cancellationToken?) -> HubCollaborationV2025R0</code>
- <code title="put /2.0/hub_collaborations/{hubCollaborationId}">client.HubCollaborations.<a href="./Box.Sdk.Gen/Managers/HubCollaborations/HubCollaborationsManager.cs">UpdateHubCollaborationByIdV2025R0Async</a>(hubCollaborationId, requestBody, headers?, cancellationToken?) -> HubCollaborationV2025R0</code>
- <code title="delete /2.0/hub_collaborations/{hubCollaborationId}">client.HubCollaborations.<a href="./Box.Sdk.Gen/Managers/HubCollaborations/HubCollaborationsManager.cs">DeleteHubCollaborationByIdV2025R0Async</a>(hubCollaborationId, headers?, cancellationToken?) -> void</code>

# Hub items

Examples: [docs/HubItems.md](docs/HubItems.md)

Methods:

- <code title="get /2.0/hub_items">client.HubItems.<a href="./Box.Sdk.Gen/Managers/HubItems/HubItemsManager.cs">GetHubItemsV2025R0Async</a>(queryParams, headers?, cancellationToken?) -> HubItemsV2025R0</code>
- <code title="post /2.0/hubs/{hubId}/manage_items">client.HubItems.<a href="./Box.Sdk.Gen/Managers/HubItems/HubItemsManager.cs">ManageHubItemsV2025R0Async</a>(hubId, requestBody, headers?, cancellationToken?) -> HubItemsManageResponseV2025R0</code>

# Shield lists

Examples: [docs/ShieldLists.md](docs/ShieldLists.md)

Methods:

- <code title="get /2.0/shield_lists">client.ShieldLists.<a href="./Box.Sdk.Gen/Managers/ShieldLists/ShieldListsManager.cs">GetShieldListsV2025R0Async</a>(headers?, cancellationToken?) -> ShieldListsV2025R0</code>
- <code title="post /2.0/shield_lists">client.ShieldLists.<a href="./Box.Sdk.Gen/Managers/ShieldLists/ShieldListsManager.cs">CreateShieldListV2025R0Async</a>(requestBody, headers?, cancellationToken?) -> ShieldListV2025R0</code>
- <code title="get /2.0/shield_lists/{shieldListId}">client.ShieldLists.<a href="./Box.Sdk.Gen/Managers/ShieldLists/ShieldListsManager.cs">GetShieldListByIdV2025R0Async</a>(shieldListId, headers?, cancellationToken?) -> ShieldListV2025R0</code>
- <code title="delete /2.0/shield_lists/{shieldListId}">client.ShieldLists.<a href="./Box.Sdk.Gen/Managers/ShieldLists/ShieldListsManager.cs">DeleteShieldListByIdV2025R0Async</a>(shieldListId, headers?, cancellationToken?) -> void</code>
- <code title="put /2.0/shield_lists/{shieldListId}">client.ShieldLists.<a href="./Box.Sdk.Gen/Managers/ShieldLists/ShieldListsManager.cs">UpdateShieldListByIdV2025R0Async</a>(shieldListId, requestBody, headers?, cancellationToken?) -> ShieldListV2025R0</code>

# Archives

Examples: [docs/Archives.md](docs/Archives.md)

Methods:

- <code title="get /2.0/archives">client.Archives.<a href="./Box.Sdk.Gen/Managers/Archives/ArchivesManager.cs">GetArchivesV2025R0Async</a>(queryParams?, headers?, cancellationToken?) -> ArchivesV2025R0</code>
- <code title="post /2.0/archives">client.Archives.<a href="./Box.Sdk.Gen/Managers/Archives/ArchivesManager.cs">CreateArchiveV2025R0Async</a>(requestBody, headers?, cancellationToken?) -> ArchiveV2025R0</code>
- <code title="delete /2.0/archives/{archiveId}">client.Archives.<a href="./Box.Sdk.Gen/Managers/Archives/ArchivesManager.cs">DeleteArchiveByIdV2025R0Async</a>(archiveId, headers?, cancellationToken?) -> void</code>
