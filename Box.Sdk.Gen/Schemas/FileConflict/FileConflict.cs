using System.Text.Json.Serialization;
using Box.Sdk.Gen.Schemas;

namespace Box.Sdk.Gen.Schemas {
    public class FileConflict : FileMini {
        public FileConflict(string id, FileBaseTypeField type = FileBaseTypeField.File) : base(id, type) {
            
        }
    }
}