using System.ComponentModel;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen.Schemas {
    public enum EventEventTypeField {
        [Description("ACCESS_GRANTED")]
        AccessGranted,
        [Description("ACCESS_REVOKED")]
        AccessRevoked,
        [Description("ADD_DEVICE_ASSOCIATION")]
        AddDeviceAssociation,
        [Description("ADD_LOGIN_ACTIVITY_DEVICE")]
        AddLoginActivityDevice,
        [Description("ADMIN_LOGIN")]
        AdminLogin,
        [Description("APPLICATION_CREATED")]
        ApplicationCreated,
        [Description("APPLICATION_PUBLIC_KEY_ADDED")]
        ApplicationPublicKeyAdded,
        [Description("APPLICATION_PUBLIC_KEY_DELETED")]
        ApplicationPublicKeyDeleted,
        [Description("CHANGE_ADMIN_ROLE")]
        ChangeAdminRole,
        [Description("CHANGE_FOLDER_PERMISSION")]
        ChangeFolderPermission,
        [Description("COLLABORATION_ACCEPT")]
        CollaborationAccept,
        [Description("COLLABORATION_EXPIRATION")]
        CollaborationExpiration,
        [Description("COLLABORATION_INVITE")]
        CollaborationInvite,
        [Description("COLLABORATION_REMOVE")]
        CollaborationRemove,
        [Description("COLLABORATION_ROLE_CHANGE")]
        CollaborationRoleChange,
        [Description("COLLAB_ADD_COLLABORATOR")]
        CollabAddCollaborator,
        [Description("COLLAB_INVITE_COLLABORATOR")]
        CollabInviteCollaborator,
        [Description("COLLAB_REMOVE_COLLABORATOR")]
        CollabRemoveCollaborator,
        [Description("COLLAB_ROLE_CHANGE")]
        CollabRoleChange,
        [Description("COMMENT_CREATE")]
        CommentCreate,
        [Description("COMMENT_DELETE")]
        CommentDelete,
        [Description("CONTENT_ACCESS")]
        ContentAccess,
        [Description("CONTENT_WORKFLOW_ABNORMAL_DOWNLOAD_ACTIVITY")]
        ContentWorkflowAbnormalDownloadActivity,
        [Description("CONTENT_WORKFLOW_AUTOMATION_ADD")]
        ContentWorkflowAutomationAdd,
        [Description("CONTENT_WORKFLOW_AUTOMATION_DELETE")]
        ContentWorkflowAutomationDelete,
        [Description("CONTENT_WORKFLOW_POLICY_ADD")]
        ContentWorkflowPolicyAdd,
        [Description("CONTENT_WORKFLOW_SHARING_POLICY_VIOLATION")]
        ContentWorkflowSharingPolicyViolation,
        [Description("CONTENT_WORKFLOW_UPLOAD_POLICY_VIOLATION")]
        ContentWorkflowUploadPolicyViolation,
        [Description("COPY")]
        Copy,
        [Description("DATA_RETENTION_CREATE_RETENTION")]
        DataRetentionCreateRetention,
        [Description("DATA_RETENTION_REMOVE_RETENTION")]
        DataRetentionRemoveRetention,
        [Description("DELETE")]
        Delete,
        [Description("DELETE_USER")]
        DeleteUser,
        [Description("DEVICE_TRUST_CHECK_FAILED")]
        DeviceTrustCheckFailed,
        [Description("DOWNLOAD")]
        Download,
        [Description("EDIT")]
        Edit,
        [Description("EDIT_USER")]
        EditUser,
        [Description("EDR_CROWDSTRIKE_DEVICE_DETECTED")]
        EdrCrowdstrikeDeviceDetected,
        [Description("EDR_CROWDSTRIKE_NO_BOX_TOOLS")]
        EdrCrowdstrikeNoBoxTools,
        [Description("EDR_CROWDSTRIKE_BOX_TOOLS_OUTDATED")]
        EdrCrowdstrikeBoxToolsOutdated,
        [Description("EDR_CROWDSTRIKE_DRIVE_OUTDATED")]
        EdrCrowdstrikeDriveOutdated,
        [Description("EDR_CROWDSTRIKE_ACCESS_ALLOWED_NO_CROWDSTRIKE_DEVICE")]
        EdrCrowdstrikeAccessAllowedNoCrowdstrikeDevice,
        [Description("EDR_CROWDSTRIKE_ACCESS_REVOKED")]
        EdrCrowdstrikeAccessRevoked,
        [Description("EMAIL_ALIAS_CONFIRM")]
        EmailAliasConfirm,
        [Description("EMAIL_ALIAS_REMOVE")]
        EmailAliasRemove,
        [Description("ENABLE_TWO_FACTOR_AUTH")]
        EnableTwoFactorAuth,
        [Description("ENTERPRISE_APP_AUTHORIZATION_UPDATE")]
        EnterpriseAppAuthorizationUpdate,
        [Description("FAILED_LOGIN")]
        FailedLogin,
        [Description("FILE_MARKED_MALICIOUS")]
        FileMarkedMalicious,
        [Description("FILE_WATERMARKED_DOWNLOAD")]
        FileWatermarkedDownload,
        [Description("GROUP_ADD_ITEM")]
        GroupAddItem,
        [Description("GROUP_ADD_USER")]
        GroupAddUser,
        [Description("GROUP_CREATION")]
        GroupCreation,
        [Description("GROUP_DELETION")]
        GroupDeletion,
        [Description("GROUP_EDITED")]
        GroupEdited,
        [Description("GROUP_REMOVE_ITEM")]
        GroupRemoveItem,
        [Description("GROUP_REMOVE_USER")]
        GroupRemoveUser,
        [Description("ITEM_COPY")]
        ItemCopy,
        [Description("ITEM_CREATE")]
        ItemCreate,
        [Description("ITEM_DOWNLOAD")]
        ItemDownload,
        [Description("ITEM_EMAIL_SEND")]
        ItemEmailSend,
        [Description("ITEM_MAKE_CURRENT_VERSION")]
        ItemMakeCurrentVersion,
        [Description("ITEM_MODIFY")]
        ItemModify,
        [Description("ITEM_MOVE")]
        ItemMove,
        [Description("ITEM_OPEN")]
        ItemOpen,
        [Description("ITEM_PREVIEW")]
        ItemPreview,
        [Description("ITEM_RENAME")]
        ItemRename,
        [Description("ITEM_SHARED")]
        ItemShared,
        [Description("ITEM_SHARED_CREATE")]
        ItemSharedCreate,
        [Description("ITEM_SHARED_UNSHARE")]
        ItemSharedUnshare,
        [Description("ITEM_SHARED_UPDATE")]
        ItemSharedUpdate,
        [Description("ITEM_SYNC")]
        ItemSync,
        [Description("ITEM_TRASH")]
        ItemTrash,
        [Description("ITEM_UNDELETE_VIA_TRASH")]
        ItemUndeleteViaTrash,
        [Description("ITEM_UNSYNC")]
        ItemUnsync,
        [Description("ITEM_UPLOAD")]
        ItemUpload,
        [Description("LEGAL_HOLD_ASSIGNMENT_CREATE")]
        LegalHoldAssignmentCreate,
        [Description("LEGAL_HOLD_ASSIGNMENT_DELETE")]
        LegalHoldAssignmentDelete,
        [Description("LEGAL_HOLD_POLICY_CREATE")]
        LegalHoldPolicyCreate,
        [Description("LEGAL_HOLD_POLICY_DELETE")]
        LegalHoldPolicyDelete,
        [Description("LEGAL_HOLD_POLICY_UPDATE")]
        LegalHoldPolicyUpdate,
        [Description("LOCK")]
        Lock,
        [Description("LOCK_CREATE")]
        LockCreate,
        [Description("LOCK_DESTROY")]
        LockDestroy,
        [Description("LOGIN")]
        Login,
        [Description("MASTER_INVITE_ACCEPT")]
        MasterInviteAccept,
        [Description("MASTER_INVITE_REJECT")]
        MasterInviteReject,
        [Description("METADATA_INSTANCE_CREATE")]
        MetadataInstanceCreate,
        [Description("METADATA_INSTANCE_DELETE")]
        MetadataInstanceDelete,
        [Description("METADATA_INSTANCE_UPDATE")]
        MetadataInstanceUpdate,
        [Description("METADATA_TEMPLATE_CREATE")]
        MetadataTemplateCreate,
        [Description("METADATA_TEMPLATE_DELETE")]
        MetadataTemplateDelete,
        [Description("METADATA_TEMPLATE_UPDATE")]
        MetadataTemplateUpdate,
        [Description("MOVE")]
        Move,
        [Description("NEW_USER")]
        NewUser,
        [Description("PREVIEW")]
        Preview,
        [Description("REMOVE_DEVICE_ASSOCIATION")]
        RemoveDeviceAssociation,
        [Description("REMOVE_LOGIN_ACTIVITY_DEVICE")]
        RemoveLoginActivityDevice,
        [Description("RENAME")]
        Rename,
        [Description("RETENTION_POLICY_ASSIGNMENT_ADD")]
        RetentionPolicyAssignmentAdd,
        [Description("SHARE")]
        Share,
        [Description("SHARED_LINK_SEND")]
        SharedLinkSend,
        [Description("SHARE_EXPIRATION")]
        ShareExpiration,
        [Description("SHIELD_ALERT")]
        ShieldAlert,
        [Description("SHIELD_EXTERNAL_COLLAB_ACCESS_BLOCKED")]
        ShieldExternalCollabAccessBlocked,
        [Description("SHIELD_EXTERNAL_COLLAB_ACCESS_BLOCKED_MISSING_JUSTIFICATION")]
        ShieldExternalCollabAccessBlockedMissingJustification,
        [Description("SHIELD_EXTERNAL_COLLAB_INVITE_BLOCKED")]
        ShieldExternalCollabInviteBlocked,
        [Description("SHIELD_EXTERNAL_COLLAB_INVITE_BLOCKED_MISSING_JUSTIFICATION")]
        ShieldExternalCollabInviteBlockedMissingJustification,
        [Description("SHIELD_JUSTIFICATION_APPROVAL")]
        ShieldJustificationApproval,
        [Description("SHIELD_SHARED_LINK_ACCESS_BLOCKED")]
        ShieldSharedLinkAccessBlocked,
        [Description("SHIELD_SHARED_LINK_STATUS_RESTRICTED_ON_CREATE")]
        ShieldSharedLinkStatusRestrictedOnCreate,
        [Description("SHIELD_SHARED_LINK_STATUS_RESTRICTED_ON_UPDATE")]
        ShieldSharedLinkStatusRestrictedOnUpdate,
        [Description("SIGN_DOCUMENT_ASSIGNED")]
        SignDocumentAssigned,
        [Description("SIGN_DOCUMENT_CANCELLED")]
        SignDocumentCancelled,
        [Description("SIGN_DOCUMENT_COMPLETED")]
        SignDocumentCompleted,
        [Description("SIGN_DOCUMENT_CONVERTED")]
        SignDocumentConverted,
        [Description("SIGN_DOCUMENT_CREATED")]
        SignDocumentCreated,
        [Description("SIGN_DOCUMENT_DECLINED")]
        SignDocumentDeclined,
        [Description("SIGN_DOCUMENT_EXPIRED")]
        SignDocumentExpired,
        [Description("SIGN_DOCUMENT_SIGNED")]
        SignDocumentSigned,
        [Description("SIGN_DOCUMENT_VIEWED_BY_SIGNED")]
        SignDocumentViewedBySigned,
        [Description("SIGNER_DOWNLOADED")]
        SignerDownloaded,
        [Description("SIGNER_FORWARDED")]
        SignerForwarded,
        [Description("STORAGE_EXPIRATION")]
        StorageExpiration,
        [Description("TAG_ITEM_CREATE")]
        TagItemCreate,
        [Description("TASK_ASSIGNMENT_CREATE")]
        TaskAssignmentCreate,
        [Description("TASK_ASSIGNMENT_DELETE")]
        TaskAssignmentDelete,
        [Description("TASK_ASSIGNMENT_UPDATE")]
        TaskAssignmentUpdate,
        [Description("TASK_CREATE")]
        TaskCreate,
        [Description("TASK_UPDATE")]
        TaskUpdate,
        [Description("TERMS_OF_SERVICE_ACCEPT")]
        TermsOfServiceAccept,
        [Description("TERMS_OF_SERVICE_REJECT")]
        TermsOfServiceReject,
        [Description("UNDELETE")]
        Undelete,
        [Description("UNLOCK")]
        Unlock,
        [Description("UNSHARE")]
        Unshare,
        [Description("UPDATE_COLLABORATION_EXPIRATION")]
        UpdateCollaborationExpiration,
        [Description("UPDATE_SHARE_EXPIRATION")]
        UpdateShareExpiration,
        [Description("UPLOAD")]
        Upload,
        [Description("USER_AUTHENTICATE_OAUTH2_ACCESS_TOKEN_CREATE")]
        UserAuthenticateOauth2AccessTokenCreate,
        [Description("WATERMARK_LABEL_CREATE")]
        WatermarkLabelCreate,
        [Description("WATERMARK_LABEL_DELETE")]
        WatermarkLabelDelete
    }
}