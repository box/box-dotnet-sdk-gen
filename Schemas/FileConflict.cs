using System.IO;
using Unions;
using System.Text.Json.Serialization;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Box.Schemas {
    public class FileConflict : FileMini {
        public FileConflict(string id, string etag, FileBaseTypeField type, string sequenceId, string name, string sha1, FileVersionMini fileVersion) : base(id, etag, type, sequenceId, name, sha1, fileVersion) {
            
        }
    }
}