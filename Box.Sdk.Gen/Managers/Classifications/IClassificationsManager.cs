using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public interface IClassificationsManager {
        public IAuthentication? Auth { get; init; }

        public NetworkSession NetworkSession { get; }

        public System.Threading.Tasks.Task<ClassificationTemplate> GetClassificationTemplateAsync(GetClassificationTemplateHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<ClassificationTemplate> AddClassificationAsync(IReadOnlyList<AddClassificationRequestBody> requestBody, AddClassificationHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<ClassificationTemplate> UpdateClassificationAsync(IReadOnlyList<UpdateClassificationRequestBody> requestBody, UpdateClassificationHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<ClassificationTemplate> CreateClassificationTemplateAsync(CreateClassificationTemplateRequestBody requestBody, CreateClassificationTemplateHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}