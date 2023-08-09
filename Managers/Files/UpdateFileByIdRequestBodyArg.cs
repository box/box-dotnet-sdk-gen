using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class UpdateFileByIdRequestBodyArg {
        [JsonPropertyName("name")]
        public string Name { get; }

        [JsonPropertyName("description")]
        public string Description { get; }

        [JsonPropertyName("parent")]
        public UpdateFileByIdRequestBodyArgParentField Parent { get; }

        [JsonPropertyName("shared_link")]
        public UpdateFileByIdRequestBodyArgSharedLinkField SharedLink { get; }

        [JsonPropertyName("lock")]
        public UpdateFileByIdRequestBodyArgLockField Lock { get; }

        [JsonPropertyName("disposition_at")]
        public string DispositionAt { get; }

        [JsonPropertyName("permissions")]
        public UpdateFileByIdRequestBodyArgPermissionsField Permissions { get; }

        [JsonPropertyName("collections")]
        public IReadOnlyList<UpdateFileByIdRequestBodyArgCollectionsField> Collections { get; }

        [JsonPropertyName("tags")]
        public IReadOnlyList<string> Tags { get; }

        public UpdateFileByIdRequestBodyArg(string name, string description, UpdateFileByIdRequestBodyArgParentField parent, UpdateFileByIdRequestBodyArgSharedLinkField sharedLink, UpdateFileByIdRequestBodyArgLockField lockParam, string dispositionAt, UpdateFileByIdRequestBodyArgPermissionsField permissions, IReadOnlyList<UpdateFileByIdRequestBodyArgCollectionsField> collections, IReadOnlyList<string> tags) {
            Name = name;
            Description = description;
            Parent = parent;
            SharedLink = sharedLink;
            Lock = lockParam;
            DispositionAt = dispositionAt;
            Permissions = permissions;
            Collections = collections;
            Tags = tags;
        }
    }
}