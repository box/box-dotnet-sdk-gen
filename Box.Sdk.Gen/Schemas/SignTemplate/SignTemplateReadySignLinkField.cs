using Box.Sdk.Gen;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Internal;
using System.Linq;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class SignTemplateReadySignLinkField {
        /// <summary>
        /// The URL that can be sent to signers.
        /// </summary>
        [JsonPropertyName("url")]
        public string? Url { get; init; }

        /// <summary>
        /// Request name.
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; init; }

        /// <summary>
        /// Extra instructions for all signers.
        /// </summary>
        [JsonPropertyName("instructions")]
        public string? Instructions { get; init; }

        /// <summary>
        /// The destination folder to place final,
        /// signed document and signing
        /// log. Only `ID` and `type` fields are required.
        /// The root folder,
        /// folder ID `0`, cannot be used.
        /// </summary>
        [JsonPropertyName("folder_id")]
        public string? FolderId { get; init; }

        /// <summary>
        /// Whether to disable notifications when
        /// a signer has signed.
        /// </summary>
        [JsonPropertyName("is_notification_disabled")]
        public bool? IsNotificationDisabled { get; init; }

        /// <summary>
        /// Whether the ready sign link is enabled or not.
        /// </summary>
        [JsonPropertyName("is_active")]
        public bool? IsActive { get; init; }

        public SignTemplateReadySignLinkField() {
            
        }
    }
}