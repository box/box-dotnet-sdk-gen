using System.IO;
using Unions;
using Box.Managers;
using Box;

namespace Box {
    public class Client {
        public IAuth Auth { get; }

        public NetworkSession NetworkSession { get; }

        public AuthorizationManager Authorization { get; }

        public FilesManager Files { get; }

        public TrashedFilesManager TrashedFiles { get; }

        public DownloadsManager Downloads { get; }

        public UploadsManager Uploads { get; }

        public ChunkedUploadsManager ChunkedUploads { get; }

        public ListCollaborationsManager ListCollaborations { get; }

        public CommentsManager Comments { get; }

        public TasksManager Tasks { get; }

        public FileVersionsManager FileVersions { get; }

        public FileMetadataManager FileMetadata { get; }

        public FileClassificationsManager FileClassifications { get; }

        public SkillsManager Skills { get; }

        public FileWatermarksManager FileWatermarks { get; }

        public FileRequestsManager FileRequests { get; }

        public FoldersManager Folders { get; }

        public TrashedFoldersManager TrashedFolders { get; }

        public FolderMetadataManager FolderMetadata { get; }

        public FolderClassificationsManager FolderClassifications { get; }

        public TrashedItemsManager TrashedItems { get; }

        public FolderWatermarksManager FolderWatermarks { get; }

        public FolderLocksManager FolderLocks { get; }

        public MetadataTemplatesManager MetadataTemplates { get; }

        public ClassificationsManager Classifications { get; }

        public MetadataCascadePoliciesManager MetadataCascadePolicies { get; }

        public SearchManager Search { get; }

        public UserCollaborationsManager UserCollaborations { get; }

        public TaskAssignmentsManager TaskAssignments { get; }

        public SharedLinksFilesManager SharedLinksFiles { get; }

        public SharedLinksFoldersManager SharedLinksFolders { get; }

        public WebLinksManager WebLinks { get; }

        public TrashedWebLinksManager TrashedWebLinks { get; }

        public SharedLinksWebLinksManager SharedLinksWebLinks { get; }

        public UsersManager Users { get; }

        public SessionTerminationManager SessionTermination { get; }

        public AvatarsManager Avatars { get; }

        public TransferManager Transfer { get; }

        public EmailAliasesManager EmailAliases { get; }

        public MembershipsManager Memberships { get; }

        public InvitesManager Invites { get; }

        public GroupsManager Groups { get; }

        public WebhooksManager Webhooks { get; }

        public EventsManager Events { get; }

        public CollectionsManager Collections { get; }

        public RecentItemsManager RecentItems { get; }

        public RetentionPoliciesManager RetentionPolicies { get; }

        public RetentionPolicyAssignmentsManager RetentionPolicyAssignments { get; }

        public LegalHoldPoliciesManager LegalHoldPolicies { get; }

        public LegalHoldPolicyAssignmentsManager LegalHoldPolicyAssignments { get; }

        public FileVersionRetentionsManager FileVersionRetentions { get; }

        public FileVersionLegalHoldsManager FileVersionLegalHolds { get; }

        public ShieldInformationBarriersManager ShieldInformationBarriers { get; }

        public ShieldInformationBarrierReportsManager ShieldInformationBarrierReports { get; }

        public ShieldInformationBarrierSegmentsManager ShieldInformationBarrierSegments { get; }

        public ShieldInformationBarrierSegmentMembersManager ShieldInformationBarrierSegmentMembers { get; }

        public ShieldInformationBarrierSegmentRestrictionsManager ShieldInformationBarrierSegmentRestrictions { get; }

        public DevicePinnersManager DevicePinners { get; }

        public TermsOfServicesManager TermsOfServices { get; }

        public TermsOfServiceUserStatusesManager TermsOfServiceUserStatuses { get; }

        public CollaborationAllowlistEntriesManager CollaborationAllowlistEntries { get; }

        public CollaborationAllowlistExemptTargetsManager CollaborationAllowlistExemptTargets { get; }

        public StoragePoliciesManager StoragePolicies { get; }

        public StoragePolicyAssignmentsManager StoragePolicyAssignments { get; }

        public ZipDownloadsManager ZipDownloads { get; }

        public SignRequestsManager SignRequests { get; }

        public WorkflowsManager Workflows { get; }

        public SignTemplatesManager SignTemplates { get; }

        public IntegrationMappingsManager IntegrationMappings { get; }

        public Client(IAuth auth, NetworkSession networkSession, AuthorizationManager authorization, FilesManager files, TrashedFilesManager trashedFiles, DownloadsManager downloads, UploadsManager uploads, ChunkedUploadsManager chunkedUploads, ListCollaborationsManager listCollaborations, CommentsManager comments, TasksManager tasks, FileVersionsManager fileVersions, FileMetadataManager fileMetadata, FileClassificationsManager fileClassifications, SkillsManager skills, FileWatermarksManager fileWatermarks, FileRequestsManager fileRequests, FoldersManager folders, TrashedFoldersManager trashedFolders, FolderMetadataManager folderMetadata, FolderClassificationsManager folderClassifications, TrashedItemsManager trashedItems, FolderWatermarksManager folderWatermarks, FolderLocksManager folderLocks, MetadataTemplatesManager metadataTemplates, ClassificationsManager classifications, MetadataCascadePoliciesManager metadataCascadePolicies, SearchManager search, UserCollaborationsManager userCollaborations, TaskAssignmentsManager taskAssignments, SharedLinksFilesManager sharedLinksFiles, SharedLinksFoldersManager sharedLinksFolders, WebLinksManager webLinks, TrashedWebLinksManager trashedWebLinks, SharedLinksWebLinksManager sharedLinksWebLinks, UsersManager users, SessionTerminationManager sessionTermination, AvatarsManager avatars, TransferManager transfer, EmailAliasesManager emailAliases, MembershipsManager memberships, InvitesManager invites, GroupsManager groups, WebhooksManager webhooks, EventsManager events, CollectionsManager collections, RecentItemsManager recentItems, RetentionPoliciesManager retentionPolicies, RetentionPolicyAssignmentsManager retentionPolicyAssignments, LegalHoldPoliciesManager legalHoldPolicies, LegalHoldPolicyAssignmentsManager legalHoldPolicyAssignments, FileVersionRetentionsManager fileVersionRetentions, FileVersionLegalHoldsManager fileVersionLegalHolds, ShieldInformationBarriersManager shieldInformationBarriers, ShieldInformationBarrierReportsManager shieldInformationBarrierReports, ShieldInformationBarrierSegmentsManager shieldInformationBarrierSegments, ShieldInformationBarrierSegmentMembersManager shieldInformationBarrierSegmentMembers, ShieldInformationBarrierSegmentRestrictionsManager shieldInformationBarrierSegmentRestrictions, DevicePinnersManager devicePinners, TermsOfServicesManager termsOfServices, TermsOfServiceUserStatusesManager termsOfServiceUserStatuses, CollaborationAllowlistEntriesManager collaborationAllowlistEntries, CollaborationAllowlistExemptTargetsManager collaborationAllowlistExemptTargets, StoragePoliciesManager storagePolicies, StoragePolicyAssignmentsManager storagePolicyAssignments, ZipDownloadsManager zipDownloads, SignRequestsManager signRequests, WorkflowsManager workflows, SignTemplatesManager signTemplates, IntegrationMappingsManager integrationMappings) {
            Auth = auth;
            NetworkSession = networkSession;
            Authorization = authorization;
            Files = files;
            TrashedFiles = trashedFiles;
            Downloads = downloads;
            Uploads = uploads;
            ChunkedUploads = chunkedUploads;
            ListCollaborations = listCollaborations;
            Comments = comments;
            Tasks = tasks;
            FileVersions = fileVersions;
            FileMetadata = fileMetadata;
            FileClassifications = fileClassifications;
            Skills = skills;
            FileWatermarks = fileWatermarks;
            FileRequests = fileRequests;
            Folders = folders;
            TrashedFolders = trashedFolders;
            FolderMetadata = folderMetadata;
            FolderClassifications = folderClassifications;
            TrashedItems = trashedItems;
            FolderWatermarks = folderWatermarks;
            FolderLocks = folderLocks;
            MetadataTemplates = metadataTemplates;
            Classifications = classifications;
            MetadataCascadePolicies = metadataCascadePolicies;
            Search = search;
            UserCollaborations = userCollaborations;
            TaskAssignments = taskAssignments;
            SharedLinksFiles = sharedLinksFiles;
            SharedLinksFolders = sharedLinksFolders;
            WebLinks = webLinks;
            TrashedWebLinks = trashedWebLinks;
            SharedLinksWebLinks = sharedLinksWebLinks;
            Users = users;
            SessionTermination = sessionTermination;
            Avatars = avatars;
            Transfer = transfer;
            EmailAliases = emailAliases;
            Memberships = memberships;
            Invites = invites;
            Groups = groups;
            Webhooks = webhooks;
            Events = events;
            Collections = collections;
            RecentItems = recentItems;
            RetentionPolicies = retentionPolicies;
            RetentionPolicyAssignments = retentionPolicyAssignments;
            LegalHoldPolicies = legalHoldPolicies;
            LegalHoldPolicyAssignments = legalHoldPolicyAssignments;
            FileVersionRetentions = fileVersionRetentions;
            FileVersionLegalHolds = fileVersionLegalHolds;
            ShieldInformationBarriers = shieldInformationBarriers;
            ShieldInformationBarrierReports = shieldInformationBarrierReports;
            ShieldInformationBarrierSegments = shieldInformationBarrierSegments;
            ShieldInformationBarrierSegmentMembers = shieldInformationBarrierSegmentMembers;
            ShieldInformationBarrierSegmentRestrictions = shieldInformationBarrierSegmentRestrictions;
            DevicePinners = devicePinners;
            TermsOfServices = termsOfServices;
            TermsOfServiceUserStatuses = termsOfServiceUserStatuses;
            CollaborationAllowlistEntries = collaborationAllowlistEntries;
            CollaborationAllowlistExemptTargets = collaborationAllowlistExemptTargets;
            StoragePolicies = storagePolicies;
            StoragePolicyAssignments = storagePolicyAssignments;
            ZipDownloads = zipDownloads;
            SignRequests = signRequests;
            Workflows = workflows;
            SignTemplates = signTemplates;
            IntegrationMappings = integrationMappings;
        }
    }
}