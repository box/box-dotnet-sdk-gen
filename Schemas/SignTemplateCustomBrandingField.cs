using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.Json;

namespace Box.Schemas {
    public class SignTemplateCustomBrandingField {
        [JsonPropertyName("company_name")]
        public string CompanyName { get; }

        [JsonPropertyName("logo_uri")]
        public string LogoUri { get; }

        [JsonPropertyName("branding_color")]
        public string BrandingColor { get; }

        [JsonPropertyName("email_footer_text")]
        public string EmailFooterText { get; }

        public SignTemplateCustomBrandingField(string companyName, string logoUri, string brandingColor, string emailFooterText) {
            CompanyName = companyName;
            LogoUri = logoUri;
            BrandingColor = brandingColor;
            EmailFooterText = emailFooterText;
        }
    }
}