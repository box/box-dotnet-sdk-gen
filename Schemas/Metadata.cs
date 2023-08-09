using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class Metadata : MetadataBase {
        public Metadata(string parent, string template, string scope, int? version) : base(parent, template, scope, version) {
            
        }
    }
}