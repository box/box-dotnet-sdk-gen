using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public interface ISkillsManager {
        public IAuthentication? Auth { get; init; }

        public NetworkSession NetworkSession { get; }

        public System.Threading.Tasks.Task<SkillCardsMetadata> GetBoxSkillCardsOnFileAsync(string fileId, GetBoxSkillCardsOnFileHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<SkillCardsMetadata> CreateBoxSkillCardsOnFileAsync(string fileId, CreateBoxSkillCardsOnFileRequestBody requestBody, CreateBoxSkillCardsOnFileHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<SkillCardsMetadata> UpdateBoxSkillCardsOnFileAsync(string fileId, IReadOnlyList<UpdateBoxSkillCardsOnFileRequestBody> requestBody, UpdateBoxSkillCardsOnFileHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteBoxSkillCardsFromFileAsync(string fileId, DeleteBoxSkillCardsFromFileHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task UpdateAllSkillCardsOnFileAsync(string skillId, UpdateAllSkillCardsOnFileRequestBody requestBody, UpdateAllSkillCardsOnFileHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}