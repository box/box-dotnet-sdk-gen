using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class MetadataFilter {
        /// <summary>
        /// Specifies the scope of the template to filter search results by.
        /// 
        /// This will be `enterprise_{enterprise_id}` for templates defined
        /// for use in this enterprise, and `global` for general templates
        /// that are available to all enterprises using Box.
        /// </summary>
        [JsonPropertyName("scope")]
        public MetadataFilterScopeField? Scope { get; set; } = default;

        /// <summary>
        /// The key of the template used to filter search results.
        /// 
        /// In many cases the template key is automatically derived
        /// of its display name, for example `Contract Template` would
        /// become `contractTemplate`. In some cases the creator of the
        /// template will have provided its own template key.
        /// 
        /// Please [list the templates for an enterprise][list], or
        /// get all instances on a [file][file] or [folder][folder]
        /// to inspect a template's key.
        /// 
        /// [list]: e://get-metadata-templates-enterprise
        /// [file]: e://get-files-id-metadata
        /// [folder]: e://get-folders-id-metadata
        /// </summary>
        [JsonPropertyName("templateKey")]
        public string? TemplateKey { get; set; } = default;

        /// <summary>
        /// Specifies which fields on the template to filter the search
        /// results by. When more than one field is specified, the query
        /// performs a logical `AND` to ensure that the instance of the
        /// template matches each of the fields specified.
        /// </summary>
        [JsonPropertyName("filters")]
        public Dictionary<string, MetadataFieldFilterDateRangeOrMetadataFieldFilterFloatRangeOrArrayOfStringOrNumberOrString>? Filters { get; set; } = default;

        public MetadataFilter() {
            
        }
    }
}