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

        public NetworkSession NetworkSession { get; set; }

        public System.Threading.Tasks.Task<Classification> GetClassificationOnFileAsync(string fileId, GetClassificationOnFileHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<Classification> AddClassificationToFileAsync(string fileId, AddClassificationToFileRequestBody? requestBody = default, AddClassificationToFileHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<Classification> UpdateClassificationOnFileAsync(string fileId, IReadOnlyList<UpdateClassificationOnFileRequestBody> requestBody, UpdateClassificationOnFileHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteClassificationFromFileAsync(string fileId, DeleteClassificationFromFileHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}