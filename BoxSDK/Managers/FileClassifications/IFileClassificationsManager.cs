using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface IFileClassificationsManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession? NetworkSession { get; set; }

        public System.Threading.Tasks.Task<Classification> GetFileMetadataEnterpriseSecurityClassification6VmVochwUWoAsync(string fileId, GetFileMetadataEnterpriseSecurityClassification6VmVochwUWoHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<Classification> CreateFileMetadataEnterpriseSecurityClassificationAsync(string fileId, CreateFileMetadataEnterpriseSecurityClassificationRequestBodyArg? requestBody = default, CreateFileMetadataEnterpriseSecurityClassificationHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<Classification> UpdateFileMetadataEnterpriseSecurityClassificationAsync(string fileId, IReadOnlyList<UpdateFileMetadataEnterpriseSecurityClassificationRequestBodyArg> requestBody, UpdateFileMetadataEnterpriseSecurityClassificationHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteFileMetadataEnterpriseSecurityClassificationAsync(string fileId, DeleteFileMetadataEnterpriseSecurityClassificationHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}