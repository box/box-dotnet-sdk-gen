using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text.Json.Serialization;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface ISkillsManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession NetworkSession { get; set; }

        public System.Threading.Tasks.Task<SkillCardsMetadata> GetFileMetadataGlobalBoxSkillsCardsAsync(string fileId, GetFileMetadataGlobalBoxSkillsCardsHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<SkillCardsMetadata> CreateFileMetadataGlobalBoxSkillsCardAsync(string fileId, CreateFileMetadataGlobalBoxSkillsCardRequestBody requestBody, CreateFileMetadataGlobalBoxSkillsCardHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<SkillCardsMetadata> UpdateFileMetadataGlobalBoxSkillsCardAsync(string fileId, IReadOnlyList<UpdateFileMetadataGlobalBoxSkillsCardRequestBody> requestBody, UpdateFileMetadataGlobalBoxSkillsCardHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteFileMetadataGlobalBoxSkillsCardAsync(string fileId, DeleteFileMetadataGlobalBoxSkillsCardHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task UpdateSkillInvocationByIdAsync(string skillId, UpdateSkillInvocationByIdRequestBody requestBody, UpdateSkillInvocationByIdHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}