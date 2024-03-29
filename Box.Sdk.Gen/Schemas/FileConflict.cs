using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Sdk.Gen.Schemas {
    public class FileConflict : FileMini {
        public FileConflict(string id, FileBaseTypeField type = FileBaseTypeField.File) : base(id, type) {
            
        }
    }
}