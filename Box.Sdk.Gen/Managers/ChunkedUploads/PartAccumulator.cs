using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen.Managers {
    internal class PartAccumulator {
        internal int LastIndex { get; }

        internal IReadOnlyList<UploadPart> Parts { get; }

        internal long FileSize { get; }

        internal string UploadSessionId { get; }

        internal Hash FileHash { get; }

        public PartAccumulator(int lastIndex, IReadOnlyList<UploadPart> parts, long fileSize, string uploadSessionId, Hash fileHash) {
            LastIndex = lastIndex;
            Parts = parts;
            FileSize = fileSize;
            UploadSessionId = uploadSessionId;
            FileHash = fileHash;
        }
    }
}