using System.Collections.Generic;
using System.Collections.ObjectModel;
using Box.Managers;
using Box;

namespace Box {
    public class BoxClient {
        public IAuth Auth { get; set; }

        public NetworkSession NetworkSession { get; set; }

        public AuthorizationManager Authorization { get; set; }

        public FilesManager Files { get; set; }

        public TrashedFilesManager TrashedFiles { get; set; }

        public DownloadsManager Downloads { get; set; }

        public UploadsManager Uploads { get; set; }

        public ChunkedUploadsManager ChunkedUploads { get; set; }

        public ListCollaborationsManager ListCollaborations { get; set; }

        public CommentsManager Comments { get; set; }

        public TasksManager Tasks { get; set; }

        public FileVersionsManager FileVersions { get; set; }

        public FileMetadataManager FileMetadata { get; set; }

        public FileClassificationsManager FileClassifications { get; set; }

        public SkillsManager Skills { get; set; }

        public FileWatermarksManager FileWatermarks { get; set; }

        public FileRequestsManager FileRequests { get; set; }

        public FoldersManager Folders { get; set; }

        public TrashedFoldersManager TrashedFolders { get; set; }

        public FolderMetadataManager FolderMetadata { get; set; }

        public FolderClassificationsManager FolderClassifications { get; set; }

        public TrashedItemsManager TrashedItems { get; set; }

        public FolderWatermarksManager FolderWatermarks { get; set; }

        public FolderLocksManager FolderLocks { get; set; }

        public MetadataTemplatesManager MetadataTemplates { get; set; }

        public ClassificationsManager Classifications { get; set; }

        public MetadataCascadePoliciesManager MetadataCascadePolicies { get; set; }

        public SearchManager Search { get; set; }

        public UserCollaborationsManager UserCollaborations { get; set; }

        public TaskAssignmentsManager TaskAssignments { get; set; }

        public SharedLinksFilesManager SharedLinksFiles { get; set; }

        public SharedLinksFoldersManager SharedLinksFolders { get; set; }

        public WebLinksManager WebLinks { get; set; }

        public TrashedWebLinksManager TrashedWebLinks { get; set; }

        public SharedLinksWebLinksManager SharedLinksWebLinks { get; set; }

        public UsersManager Users { get; set; }

        public SessionTerminationManager SessionTermination { get; set; }

        public AvatarsManager Avatars { get; set; }

        public TransferManager Transfer { get; set; }

        public EmailAliasesManager EmailAliases { get; set; }

        public MembershipsManager Memberships { get; set; }

        public InvitesManager Invites { get; set; }

        public GroupsManager Groups { get; set; }

        public WebhooksManager Webhooks { get; set; }

        public EventsManager Events { get; set; }

        public CollectionsManager Collections { get; set; }

        public RecentItemsManager RecentItems { get; set; }

        public RetentionPoliciesManager RetentionPolicies { get; set; }

        public RetentionPolicyAssignmentsManager RetentionPolicyAssignments { get; set; }

        public LegalHoldPoliciesManager LegalHoldPolicies { get; set; }

        public LegalHoldPolicyAssignmentsManager LegalHoldPolicyAssignments { get; set; }

        public FileVersionRetentionsManager FileVersionRetentions { get; set; }

        public FileVersionLegalHoldsManager FileVersionLegalHolds { get; set; }

        public ShieldInformationBarriersManager ShieldInformationBarriers { get; set; }

        public ShieldInformationBarrierReportsManager ShieldInformationBarrierReports { get; set; }

        public ShieldInformationBarrierSegmentsManager ShieldInformationBarrierSegments { get; set; }

        public ShieldInformationBarrierSegmentMembersManager ShieldInformationBarrierSegmentMembers { get; set; }

        public ShieldInformationBarrierSegmentRestrictionsManager ShieldInformationBarrierSegmentRestrictions { get; set; }

        public DevicePinnersManager DevicePinners { get; set; }

        public TermsOfServicesManager TermsOfServices { get; set; }

        public TermsOfServiceUserStatusesManager TermsOfServiceUserStatuses { get; set; }

        public CollaborationAllowlistEntriesManager CollaborationAllowlistEntries { get; set; }

        public CollaborationAllowlistExemptTargetsManager CollaborationAllowlistExemptTargets { get; set; }

        public StoragePoliciesManager StoragePolicies { get; set; }

        public StoragePolicyAssignmentsManager StoragePolicyAssignments { get; set; }

        public ZipDownloadsManager ZipDownloads { get; set; }

        public SignRequestsManager SignRequests { get; set; }

        public WorkflowsManager Workflows { get; set; }

        public SignTemplatesManager SignTemplates { get; set; }

        public IntegrationMappingsManager IntegrationMappings { get; set; }

        public BoxClient(IAuth auth, NetworkSession networkSession = default) {
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
            return new BoxClient(auth: this.Auth, networkSession: this.NetworkSession.WithAdditionalHeaders(new Dictionary<string, string>() { { "As-User", userId } }));
        }

        /// <summary>
        /// Create a new client with suppressed notifications. Calls made with the new client will not trigger email or webhook notifications
        /// </summary>
        public BoxClient WithSuppressedNotifications() {
            return new BoxClient(auth: this.Auth, networkSession: this.NetworkSession.WithAdditionalHeaders(new Dictionary<string, string>() { { "Box-Notifications", "off" } }));
        }

        /// <summary>
        /// Create a new client with a custom set of headers that will be included in every API call
        /// </summary>
        /// <param name="extraHeaders">
        /// Custom set of headers that will be included in every API call
        /// </param>
        public BoxClient WithExtraHeaders(Dictionary<string, string>? extraHeaders = default) {
            extraHeaders = extraHeaders ?? new Dictionary<string, string>() {  };
            return new BoxClient(auth: this.Auth, networkSession: this.NetworkSession.WithAdditionalHeaders(extraHeaders));
        }

    }
}