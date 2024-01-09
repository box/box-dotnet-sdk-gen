using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public interface IClassificationsManager {
        public IAuthentication? Auth { get; set; }

        public NetworkSession NetworkSession { get; set; }

        public System.Threading.Tasks.Task<ClassificationTemplate> GetClassificationTemplateAsync(GetClassificationTemplateHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<ClassificationTemplate> AddClassificationAsync(IReadOnlyList<AddClassificationRequestBody> requestBody, AddClassificationHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<ClassificationTemplate> UpdateClassificationAsync(IReadOnlyList<UpdateClassificationRequestBody> requestBody, UpdateClassificationHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<ClassificationTemplate> CreateClassificationTemplateAsync(CreateClassificationTemplateRequestBody requestBody, CreateClassificationTemplateHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}