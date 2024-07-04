using System.ComponentModel;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen.Managers {
    public enum UpdateWebhookByIdRequestBodyTriggersField {
        [Description("FILE.UPLOADED")]
        FileUploaded,
        [Description("FILE.PREVIEWED")]
        FilePreviewed,
        [Description("FILE.DOWNLOADED")]
        FileDownloaded,
        [Description("FILE.TRASHED")]
        FileTrashed,
        [Description("FILE.DELETED")]
        FileDeleted,
        [Description("FILE.RESTORED")]
        FileRestored,
        [Description("FILE.COPIED")]
        FileCopied,
        [Description("FILE.MOVED")]
        FileMoved,
        [Description("FILE.LOCKED")]
        FileLocked,
        [Description("FILE.UNLOCKED")]
        FileUnlocked,
        [Description("FILE.RENAMED")]
        FileRenamed,
        [Description("COMMENT.CREATED")]
        CommentCreated,
        [Description("COMMENT.UPDATED")]
        CommentUpdated,
        [Description("COMMENT.DELETED")]
        CommentDeleted,
        [Description("TASK_ASSIGNMENT.CREATED")]
        TaskAssignmentCreated,
        [Description("TASK_ASSIGNMENT.UPDATED")]
        TaskAssignmentUpdated,
        [Description("METADATA_INSTANCE.CREATED")]
        MetadataInstanceCreated,
        [Description("METADATA_INSTANCE.UPDATED")]
        MetadataInstanceUpdated,
        [Description("METADATA_INSTANCE.DELETED")]
        MetadataInstanceDeleted,
        [Description("FOLDER.CREATED")]
        FolderCreated,
        [Description("FOLDER.RENAMED")]
        FolderRenamed,
        [Description("FOLDER.DOWNLOADED")]
        FolderDownloaded,
        [Description("FOLDER.RESTORED")]
        FolderRestored,
        [Description("FOLDER.DELETED")]
        FolderDeleted,
        [Description("FOLDER.COPIED")]
        FolderCopied,
        [Description("FOLDER.MOVED")]
        FolderMoved,
        [Description("FOLDER.TRASHED")]
        FolderTrashed,
        [Description("WEBHOOK.DELETED")]
        WebhookDeleted,
        [Description("COLLABORATION.CREATED")]
        CollaborationCreated,
        [Description("COLLABORATION.ACCEPTED")]
        CollaborationAccepted,
        [Description("COLLABORATION.REJECTED")]
        CollaborationRejected,
        [Description("COLLABORATION.REMOVED")]
        CollaborationRemoved,
        [Description("COLLABORATION.UPDATED")]
        CollaborationUpdated,
        [Description("SHARED_LINK.DELETED")]
        SharedLinkDeleted,
        [Description("SHARED_LINK.CREATED")]
        SharedLinkCreated,
        [Description("SHARED_LINK.UPDATED")]
        SharedLinkUpdated,
        [Description("SIGN_REQUEST.COMPLETED")]
        SignRequestCompleted,
        [Description("SIGN_REQUEST.DECLINED")]
        SignRequestDeclined,
        [Description("SIGN_REQUEST.EXPIRED")]
        SignRequestExpired,
        [Description("SIGN_REQUEST.SIGNER_EMAIL_BOUNCED")]
        SignRequestSignerEmailBounced
    }
}