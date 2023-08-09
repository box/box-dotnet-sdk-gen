using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class TrashWebLinkPathCollectionFieldEntriesField {
        [JsonPropertyName("type")]
        public TrashWebLinkPathCollectionFieldEntriesFieldTypeField Type { get; }

        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("sequence_id")]
        public string SequenceId { get; }

        [JsonPropertyName("etag")]
        public string Etag { get; }

        [JsonPropertyName("name")]
        public string Name { get; }

        public TrashWebLinkPathCollectionFieldEntriesField(TrashWebLinkPathCollectionFieldEntriesFieldTypeField type, string id, string sequenceId, string etag, string name) {
            Type = type;
            Id = id;
            SequenceId = sequenceId;
            Etag = etag;
            Name = name;
        }
    }
}