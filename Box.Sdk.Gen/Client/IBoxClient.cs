using Box.Sdk.Gen.Managers;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen {
    public interface IBoxClient {
        public IAuthentication Auth { get; }

        public NetworkSession NetworkSession { get; }

        public IAuthorizationManager Authorization { get; }

        public IFilesManager Files { get; }

        public ITrashedFilesManager TrashedFiles { get; }

        public IDownloadsManager Downloads { get; }

        public IUploadsManager Uploads { get; }

        public IChunkedUploadsManager ChunkedUploads { get; }

        public IListCollaborationsManager ListCollaborations { get; }

        public ICommentsManager Comments { get; }

        public ITasksManager Tasks { get; }

        public IFileVersionsManager FileVersions { get; }

        public IFileMetadataManager FileMetadata { get; }

        public IFileClassificationsManager FileClassifications { get; }

        public ISkillsManager Skills { get; }

        public IFileWatermarksManager FileWatermarks { get; }

        public IFileRequestsManager FileRequests { get; }

        public IFoldersManager Folders { get; }

        public ITrashedFoldersManager TrashedFolders { get; }

        public IFolderMetadataManager FolderMetadata { get; }

        public IFolderClassificationsManager FolderClassifications { get; }

        public ITrashedItemsManager TrashedItems { get; }

        public IFolderWatermarksManager FolderWatermarks { get; }

        public IFolderLocksManager FolderLocks { get; }

        public IMetadataTemplatesManager MetadataTemplates { get; }

        public IClassificationsManager Classifications { get; }

        public IMetadataCascadePoliciesManager MetadataCascadePolicies { get; }

        public ISearchManager Search { get; }

        public IUserCollaborationsManager UserCollaborations { get; }

        public ITaskAssignmentsManager TaskAssignments { get; }

        public ISharedLinksFilesManager SharedLinksFiles { get; }

        public ISharedLinksFoldersManager SharedLinksFolders { get; }

        public IWebLinksManager WebLinks { get; }

        public ITrashedWebLinksManager TrashedWebLinks { get; }

        public ISharedLinksWebLinksManager SharedLinksWebLinks { get; }

        public IUsersManager Users { get; }

        public ISessionTerminationManager SessionTermination { get; }

        public IAvatarsManager Avatars { get; }

        public ITransferManager Transfer { get; }

        public IEmailAliasesManager EmailAliases { get; }

        public IMembershipsManager Memberships { get; }

        public IInvitesManager Invites { get; }

        public IGroupsManager Groups { get; }

        public IWebhooksManager Webhooks { get; }

        public IEventsManager Events { get; }

        public ICollectionsManager Collections { get; }

        public IRecentItemsManager RecentItems { get; }

        public IRetentionPoliciesManager RetentionPolicies { get; }

        public IRetentionPolicyAssignmentsManager RetentionPolicyAssignments { get; }

        public ILegalHoldPoliciesManager LegalHoldPolicies { get; }

        public ILegalHoldPolicyAssignmentsManager LegalHoldPolicyAssignments { get; }

        public IFileVersionRetentionsManager FileVersionRetentions { get; }

        public IFileVersionLegalHoldsManager FileVersionLegalHolds { get; }

        public IShieldInformationBarriersManager ShieldInformationBarriers { get; }

        public IShieldInformationBarrierReportsManager ShieldInformationBarrierReports { get; }

        public IShieldInformationBarrierSegmentsManager ShieldInformationBarrierSegments { get; }

        public IShieldInformationBarrierSegmentMembersManager ShieldInformationBarrierSegmentMembers { get; }

        public IShieldInformationBarrierSegmentRestrictionsManager ShieldInformationBarrierSegmentRestrictions { get; }

        public IDevicePinnersManager DevicePinners { get; }

        public ITermsOfServicesManager TermsOfServices { get; }

        public ITermsOfServiceUserStatusesManager TermsOfServiceUserStatuses { get; }

        public ICollaborationAllowlistEntriesManager CollaborationAllowlistEntries { get; }

        public ICollaborationAllowlistExemptTargetsManager CollaborationAllowlistExemptTargets { get; }

        public IStoragePoliciesManager StoragePolicies { get; }

        public IStoragePolicyAssignmentsManager StoragePolicyAssignments { get; }

        public IZipDownloadsManager ZipDownloads { get; }

        public ISignRequestsManager SignRequests { get; }

        public IWorkflowsManager Workflows { get; }

        public ISignTemplatesManager SignTemplates { get; }

        public IIntegrationMappingsManager IntegrationMappings { get; }

        public IAiManager Ai { get; }

    }
}