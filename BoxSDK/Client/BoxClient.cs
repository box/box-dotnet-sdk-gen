using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Managers;
using Box;

namespace Box {
    public class BoxClient : IBoxClient {
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

        public BoxClient(IAuthentication auth, NetworkSession networkSession = default) {
            Auth = auth;
            NetworkSession = networkSession ?? new NetworkSession();
            Authorization = new AuthorizationManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            Files = new FilesManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            TrashedFiles = new TrashedFilesManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            Downloads = new DownloadsManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            Uploads = new UploadsManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            ChunkedUploads = new ChunkedUploadsManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            ListCollaborations = new ListCollaborationsManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            Comments = new CommentsManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            Tasks = new TasksManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            FileVersions = new FileVersionsManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            FileMetadata = new FileMetadataManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            FileClassifications = new FileClassificationsManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            Skills = new SkillsManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            FileWatermarks = new FileWatermarksManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            FileRequests = new FileRequestsManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            Folders = new FoldersManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            TrashedFolders = new TrashedFoldersManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            FolderMetadata = new FolderMetadataManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            FolderClassifications = new FolderClassificationsManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            TrashedItems = new TrashedItemsManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            FolderWatermarks = new FolderWatermarksManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            FolderLocks = new FolderLocksManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            MetadataTemplates = new MetadataTemplatesManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            Classifications = new ClassificationsManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            MetadataCascadePolicies = new MetadataCascadePoliciesManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            Search = new SearchManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            UserCollaborations = new UserCollaborationsManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            TaskAssignments = new TaskAssignmentsManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            SharedLinksFiles = new SharedLinksFilesManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            SharedLinksFolders = new SharedLinksFoldersManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            WebLinks = new WebLinksManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            TrashedWebLinks = new TrashedWebLinksManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            SharedLinksWebLinks = new SharedLinksWebLinksManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            Users = new UsersManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            SessionTermination = new SessionTerminationManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            Avatars = new AvatarsManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            Transfer = new TransferManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            EmailAliases = new EmailAliasesManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            Memberships = new MembershipsManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            Invites = new InvitesManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            Groups = new GroupsManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            Webhooks = new WebhooksManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            Events = new EventsManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            Collections = new CollectionsManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            RecentItems = new RecentItemsManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            RetentionPolicies = new RetentionPoliciesManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            RetentionPolicyAssignments = new RetentionPolicyAssignmentsManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            LegalHoldPolicies = new LegalHoldPoliciesManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            LegalHoldPolicyAssignments = new LegalHoldPolicyAssignmentsManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            FileVersionRetentions = new FileVersionRetentionsManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            FileVersionLegalHolds = new FileVersionLegalHoldsManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            ShieldInformationBarriers = new ShieldInformationBarriersManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            ShieldInformationBarrierReports = new ShieldInformationBarrierReportsManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            ShieldInformationBarrierSegments = new ShieldInformationBarrierSegmentsManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            ShieldInformationBarrierSegmentMembers = new ShieldInformationBarrierSegmentMembersManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            ShieldInformationBarrierSegmentRestrictions = new ShieldInformationBarrierSegmentRestrictionsManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            DevicePinners = new DevicePinnersManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            TermsOfServices = new TermsOfServicesManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            TermsOfServiceUserStatuses = new TermsOfServiceUserStatusesManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            CollaborationAllowlistEntries = new CollaborationAllowlistEntriesManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            CollaborationAllowlistExemptTargets = new CollaborationAllowlistExemptTargetsManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            StoragePolicies = new StoragePoliciesManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            StoragePolicyAssignments = new StoragePolicyAssignmentsManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            ZipDownloads = new ZipDownloadsManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            SignRequests = new SignRequestsManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            Workflows = new WorkflowsManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            SignTemplates = new SignTemplatesManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
            IntegrationMappings = new IntegrationMappingsManager() { Auth = this.Auth, NetworkSession = this.NetworkSession };
        }
        /// <summary>
        /// Create a new client to impersonate user with the provided ID. All calls made with the new client will be made in context of the impersonated user, leaving the original client unmodified.
        /// </summary>
        /// <param name="userId">
        /// ID of an user to impersonate
        /// </param>
        public BoxClient WithAsUserHeader(string userId) {
            return new BoxClient(auth: this.Auth, networkSession: this.NetworkSession.WithAdditionalHeaders(additionalHeaders: new Dictionary<string, string>() { { "As-User", userId } }));
        }

        /// <summary>
        /// Create a new client with suppressed notifications. Calls made with the new client will not trigger email or webhook notifications
        /// </summary>
        public BoxClient WithSuppressedNotifications() {
            return new BoxClient(auth: this.Auth, networkSession: this.NetworkSession.WithAdditionalHeaders(additionalHeaders: new Dictionary<string, string>() { { "Box-Notifications", "off" } }));
        }

        /// <summary>
        /// Create a new client with a custom set of headers that will be included in every API call
        /// </summary>
        /// <param name="extraHeaders">
        /// Custom set of headers that will be included in every API call
        /// </param>
        public BoxClient WithExtraHeaders(Dictionary<string, string>? extraHeaders = default) {
            extraHeaders = extraHeaders ?? new Dictionary<string, string>() {  };
            return new BoxClient(auth: this.Auth, networkSession: this.NetworkSession.WithAdditionalHeaders(additionalHeaders: extraHeaders));
        }

    }
}