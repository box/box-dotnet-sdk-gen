using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Sdk.Gen.Managers;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen {
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
            NetworkSession = networkSession ?? new NetworkSession(baseUrls: new BaseUrls());
            Authorization = new AuthorizationManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            Files = new FilesManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            TrashedFiles = new TrashedFilesManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            Downloads = new DownloadsManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            Uploads = new UploadsManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            ChunkedUploads = new ChunkedUploadsManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            ListCollaborations = new ListCollaborationsManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            Comments = new CommentsManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            Tasks = new TasksManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            FileVersions = new FileVersionsManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            FileMetadata = new FileMetadataManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            FileClassifications = new FileClassificationsManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            Skills = new SkillsManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            FileWatermarks = new FileWatermarksManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            FileRequests = new FileRequestsManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            Folders = new FoldersManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            TrashedFolders = new TrashedFoldersManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            FolderMetadata = new FolderMetadataManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            FolderClassifications = new FolderClassificationsManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            TrashedItems = new TrashedItemsManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            FolderWatermarks = new FolderWatermarksManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            FolderLocks = new FolderLocksManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            MetadataTemplates = new MetadataTemplatesManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            Classifications = new ClassificationsManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            MetadataCascadePolicies = new MetadataCascadePoliciesManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            Search = new SearchManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            UserCollaborations = new UserCollaborationsManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            TaskAssignments = new TaskAssignmentsManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            SharedLinksFiles = new SharedLinksFilesManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            SharedLinksFolders = new SharedLinksFoldersManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            WebLinks = new WebLinksManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            TrashedWebLinks = new TrashedWebLinksManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            SharedLinksWebLinks = new SharedLinksWebLinksManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            Users = new UsersManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            SessionTermination = new SessionTerminationManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            Avatars = new AvatarsManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            Transfer = new TransferManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            EmailAliases = new EmailAliasesManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            Memberships = new MembershipsManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            Invites = new InvitesManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            Groups = new GroupsManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            Webhooks = new WebhooksManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            Events = new EventsManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            Collections = new CollectionsManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            RecentItems = new RecentItemsManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            RetentionPolicies = new RetentionPoliciesManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            RetentionPolicyAssignments = new RetentionPolicyAssignmentsManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            LegalHoldPolicies = new LegalHoldPoliciesManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            LegalHoldPolicyAssignments = new LegalHoldPolicyAssignmentsManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            FileVersionRetentions = new FileVersionRetentionsManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            FileVersionLegalHolds = new FileVersionLegalHoldsManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            ShieldInformationBarriers = new ShieldInformationBarriersManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            ShieldInformationBarrierReports = new ShieldInformationBarrierReportsManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            ShieldInformationBarrierSegments = new ShieldInformationBarrierSegmentsManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            ShieldInformationBarrierSegmentMembers = new ShieldInformationBarrierSegmentMembersManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            ShieldInformationBarrierSegmentRestrictions = new ShieldInformationBarrierSegmentRestrictionsManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            DevicePinners = new DevicePinnersManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            TermsOfServices = new TermsOfServicesManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            TermsOfServiceUserStatuses = new TermsOfServiceUserStatusesManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            CollaborationAllowlistEntries = new CollaborationAllowlistEntriesManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            CollaborationAllowlistExemptTargets = new CollaborationAllowlistExemptTargetsManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            StoragePolicies = new StoragePoliciesManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            StoragePolicyAssignments = new StoragePolicyAssignmentsManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            ZipDownloads = new ZipDownloadsManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            SignRequests = new SignRequestsManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            Workflows = new WorkflowsManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            SignTemplates = new SignTemplatesManager(networkSession: this.NetworkSession) { Auth = this.Auth };
            IntegrationMappings = new IntegrationMappingsManager(networkSession: this.NetworkSession) { Auth = this.Auth };
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

        /// <summary>
        /// Create a new client with a custom set of base urls that will be used for every API call
        /// </summary>
        /// <param name="baseUrls">
        /// Custom set of base urls that will be used for every API call
        /// </param>
        public BoxClient WithCustomBaseUrls(BaseUrls baseUrls) {
            return new BoxClient(auth: this.Auth, networkSession: this.NetworkSession.WithCustomBaseUrls(baseUrls: baseUrls));
        }

    }
}