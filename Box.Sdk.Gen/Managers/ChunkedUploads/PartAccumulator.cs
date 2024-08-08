using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen.Internal;

namespace Box.Sdk.Gen.Managers {
    internal class PartAccumulator {
        internal int LastIndex { get; }

        internal IReadOnlyList<UploadPart> Parts { get; }

        internal long FileSize { get; }

        internal string UploadPartUrl { get; }

        internal Hash FileHash { get; }

        public PartAccumulator(int lastIndex, IReadOnlyList<UploadPart> parts, long fileSize, string uploadPartUrl, Hash fileHash) {
            LastIndex = lastIndex;
            Parts = parts;
            FileSize = fileSize;
            UploadPartUrl = uploadPartUrl;
            FileHash = fileHash;
        }
    }
}