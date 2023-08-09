using System.IO;
using Unions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class CopyFolderQueryParamsArg {
        public string Fields { get; }

        public CopyFolderQueryParamsArg(string fields) {
            Fields = fields;
        }
    }
}