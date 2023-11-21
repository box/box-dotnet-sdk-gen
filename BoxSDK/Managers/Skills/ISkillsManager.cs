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

        public NetworkSession? NetworkSession { get; set; }

        public System.Threading.Tasks.Task<SkillCardsMetadata> GetFileMetadataGlobalBoxSkillsCardsAsync(string fileId, GetFileMetadataGlobalBoxSkillsCardsHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<SkillCardsMetadata> CreateFileMetadataGlobalBoxSkillsCardAsync(string fileId, CreateFileMetadataGlobalBoxSkillsCardRequestBodyArg requestBody, CreateFileMetadataGlobalBoxSkillsCardHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<SkillCardsMetadata> UpdateFileMetadataGlobalBoxSkillsCardAsync(string fileId, IReadOnlyList<UpdateFileMetadataGlobalBoxSkillsCardRequestBodyArg> requestBody, UpdateFileMetadataGlobalBoxSkillsCardHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteFileMetadataGlobalBoxSkillsCardAsync(string fileId, DeleteFileMetadataGlobalBoxSkillsCardHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task UpdateSkillInvocationByIdAsync(string skillId, UpdateSkillInvocationByIdRequestBodyArg requestBody, UpdateSkillInvocationByIdHeadersArg? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}