using Unions;
using System.Text.Json.Serialization;
using Box.Sdk.Gen;
using Serializer;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class FileFullRepresentationsEntriesStatusField {
        /// <summary>
        /// The status of the representation.
        /// 
        /// * `success` defines the representation as ready to be viewed.
        /// * `viewable` defines a video to be ready for viewing.
        /// * `pending` defines the representation as to be generated. Retry
        ///   this endpoint to re-check the status.
        /// * `none` defines that the representation will be created when
        ///   requested. Request the URL defined in the `info` object to
        ///   trigger this generation.
        /// </summary>
        [JsonPropertyName("state")]
        [JsonConverter(typeof(StringEnumConverter<FileFullRepresentationsEntriesStatusStateField>))]
        public StringEnum<FileFullRepresentationsEntriesStatusStateField>? State { get; init; }

        public FileFullRepresentationsEntriesStatusField() {
            
        }
    }
}