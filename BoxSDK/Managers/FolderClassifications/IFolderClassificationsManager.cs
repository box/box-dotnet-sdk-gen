using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface IFolderClassificationsManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession? NetworkSession { get; set; }

        public System.Threading.Tasks.Task<Classification> GetFolderMetadataEnterpriseSecurityClassification6VmVochwUWoAsync(string folderId, GetFolderMetadataEnterpriseSecurityClassification6VmVochwUWoHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<Classification> CreateFolderMetadataEnterpriseSecurityClassificationAsync(string folderId, CreateFolderMetadataEnterpriseSecurityClassificationRequestBodyArg? requestBody = default, CreateFolderMetadataEnterpriseSecurityClassificationHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<Classification> UpdateFolderMetadataEnterpriseSecurityClassificationAsync(string folderId, IReadOnlyList<UpdateFolderMetadataEnterpriseSecurityClassificationRequestBodyArg> requestBody, UpdateFolderMetadataEnterpriseSecurityClassificationHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteFolderMetadataEnterpriseSecurityClassificationAsync(string folderId, DeleteFolderMetadataEnterpriseSecurityClassificationHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}