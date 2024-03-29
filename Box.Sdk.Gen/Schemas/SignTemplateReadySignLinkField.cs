using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Sdk.Gen.Schemas {
    public class SignTemplateReadySignLinkField {
        /// <summary>
        /// The URL that can be sent to signers.
        /// </summary>
        [JsonPropertyName("url")]
        public string? Url { get; set; } = default;

        /// <summary>
        /// Request name.
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; } = default;

        /// <summary>
        /// Extra instructions for all signers.
        /// </summary>
        [JsonPropertyName("instructions")]
        public string? Instructions { get; set; } = default;

        /// <summary>
        /// The destination folder to place final,
        /// signed document and signing
        /// log. Only `ID` and `type` fields are required.
        /// The root folder,
        /// folder ID `0`, cannot be used.
        /// </summary>
        [JsonPropertyName("folder_id")]
        public string? FolderId { get; set; } = default;

        /// <summary>
        /// Whether to disable notifications when
        /// a signer has signed.
        /// </summary>
        [JsonPropertyName("is_notification_disabled")]
        public bool? IsNotificationDisabled { get; set; } = default;

        /// <summary>
        /// Whether the ready sign link is enabled or not.
        /// </summary>
        [JsonPropertyName("is_active")]
        public bool? IsActive { get; set; } = default;

        public SignTemplateReadySignLinkField() {
            
        }
    }
}