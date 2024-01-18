using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    public class PartAccumulator {
        public int LastIndex { get; set; }

        public IReadOnlyList<UploadPart> Parts { get; set; }

        public int FileSize { get; set; }

        public string UploadSessionId { get; set; }

        public Hash FileHash { get; set; }

        public PartAccumulator(int lastIndex, IReadOnlyList<UploadPart> parts, int fileSize, string uploadSessionId, Hash fileHash) {
            LastIndex = lastIndex;
            Parts = parts;
            FileSize = fileSize;
            UploadSessionId = uploadSessionId;
            FileHash = fileHash;
        }
    }
}