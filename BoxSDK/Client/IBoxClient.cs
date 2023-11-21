using Box.Managers;
using Box;

namespace Box {
    public interface IBoxClient {
        public IAuthentication Auth { get; set; }

        public NetworkSession NetworkSession { get; set; }

        public IAuthorizationManager Authorization { get; set; }

        public IFilesManager Files { get; set; }

        public ITrashedFilesManager TrashedFiles { get; set; }

        public IDownloadsManager Downloads { get; set; }

        public IUploadsManager Uploads { get; set; }

        public IChunkedUploadsManager ChunkedUploads { get; set; }

        public IListCollaborationsManager ListCollaborations { get; set; }

        public ICommentsManager Comments { get; set; }

        public ITasksManager Tasks { get; set; }

        public IFileVersionsManager FileVersions { get; set; }

        public IFileMetadataManager FileMetadata { get; set; }

        public IFileClassificationsManager FileClassifications { get; set; }

        public ISkillsManager Skills { get; set; }

        public IFileWatermarksManager FileWatermarks { get; set; }

        public IFileRequestsManager FileRequests { get; set; }

        public IFoldersManager Folders { get; set; }

        public ITrashedFoldersManager TrashedFolders { get; set; }

        public IFolderMetadataManager FolderMetadata { get; set; }

        public IFolderClassificationsManager FolderClassifications { get; set; }

        public ITrashedItemsManager TrashedItems { get; set; }

        public IFolderWatermarksManager FolderWatermarks { get; set; }

        public IFolderLocksManager FolderLocks { get; set; }

        public IMetadataTemplatesManager MetadataTemplates { get; set; }

        public IClassificationsManager Classifications { get; set; }

        public IMetadataCascadePoliciesManager MetadataCascadePolicies { get; set; }

        public ISearchManager Search { get; set; }

        public IUserCollaborationsManager UserCollaborations { get; set; }

        public ITaskAssignmentsManager TaskAssignments { get; set; }

        public ISharedLinksFilesManager SharedLinksFiles { get; set; }

        public ISharedLinksFoldersManager SharedLinksFolders { get; set; }

        public IWebLinksManager WebLinks { get; set; }

        public ITrashedWebLinksManager TrashedWebLinks { get; set; }

        public ISharedLinksWebLinksManager SharedLinksWebLinks { get; set; }

        public IUsersManager Users { get; set; }

        public ISessionTerminationManager SessionTermination { get; set; }

        public IAvatarsManager Avatars { get; set; }

        public ITransferManager Transfer { get; set; }

        public IEmailAliasesManager EmailAliases { get; set; }

        public IMembershipsManager Memberships { get; set; }

        public IInvitesManager Invites { get; set; }

        public IGroupsManager Groups { get; set; }

        public IWebhooksManager Webhooks { get; set; }

        public IEventsManager Events { get; set; }

        public ICollectionsManager Collections { get; set; }

        public IRecentItemsManager RecentItems { get; set; }

        public IRetentionPoliciesManager RetentionPolicies { get; set; }

        public IRetentionPolicyAssignmentsManager RetentionPolicyAssignments { get; set; }

        public ILegalHoldPoliciesManager LegalHoldPolicies { get; set; }

        public ILegalHoldPolicyAssignmentsManager LegalHoldPolicyAssignments { get; set; }

        public IFileVersionRetentionsManager FileVersionRetentions { get; set; }

        public IFileVersionLegalHoldsManager FileVersionLegalHolds { get; set; }

        public IShieldInformationBarriersManager ShieldInformationBarriers { get; set; }

        public IShieldInformationBarrierReportsManager ShieldInformationBarrierReports { get; set; }

        public IShieldInformationBarrierSegmentsManager ShieldInformationBarrierSegments { get; set; }

        public IShieldInformationBarrierSegmentMembersManager ShieldInformationBarrierSegmentMembers { get; set; }

        public IShieldInformationBarrierSegmentRestrictionsManager ShieldInformationBarrierSegmentRestrictions { get; set; }

        public IDevicePinnersManager DevicePinners { get; set; }

        public ITermsOfServicesManager TermsOfServices { get; set; }

        public ITermsOfServiceUserStatusesManager TermsOfServiceUserStatuses { get; set; }

        public ICollaborationAllowlistEntriesManager CollaborationAllowlistEntries { get; set; }

        public ICollaborationAllowlistExemptTargetsManager CollaborationAllowlistExemptTargets { get; set; }

        public IStoragePoliciesManager StoragePolicies { get; set; }

        public IStoragePolicyAssignmentsManager StoragePolicyAssignments { get; set; }

        public IZipDownloadsManager ZipDownloads { get; set; }

        public ISignRequestsManager SignRequests { get; set; }

        public IWorkflowsManager Workflows { get; set; }

        public ISignTemplatesManager SignTemplates { get; set; }

        public IIntegrationMappingsManager IntegrationMappings { get; set; }

    }
}