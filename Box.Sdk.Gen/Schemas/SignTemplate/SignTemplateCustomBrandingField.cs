using Unions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class SignTemplateCustomBrandingField {
        /// <summary>
        /// Name of the company
        /// </summary>
        [JsonPropertyName("company_name")]
        public string? CompanyName { get; set; } = default;

        /// <summary>
        /// Custom branding logo URI in the form of a base64 image.
        /// </summary>
        [JsonPropertyName("logo_uri")]
        public string? LogoUri { get; set; } = default;

        /// <summary>
        /// Custom branding color in hex.
        /// </summary>
        [JsonPropertyName("branding_color")]
        public string? BrandingColor { get; set; } = default;

        /// <summary>
        /// Content of the email footer.
        /// </summary>
        [JsonPropertyName("email_footer_text")]
        public string? EmailFooterText { get; set; } = default;

        public SignTemplateCustomBrandingField() {
            
        }
    }
}