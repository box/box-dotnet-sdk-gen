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

        public NetworkSession NetworkSession { get; set; }

        public System.Threading.Tasks.Task<Classification> GetClassificationOnFolderAsync(string folderId, GetClassificationOnFolderHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<Classification> AddClassificationToFolderAsync(string folderId, AddClassificationToFolderRequestBody? requestBody = default, AddClassificationToFolderHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task<Classification> UpdateClassificationOnFolderAsync(string folderId, IReadOnlyList<UpdateClassificationOnFolderRequestBody> requestBody, UpdateClassificationOnFolderHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

        public System.Threading.Tasks.Task DeleteClassificationFromFolderAsync(string folderId, DeleteClassificationFromFolderHeaders? headers = default, System.Threading.CancellationToken? cancellationToken = null);

    }
}