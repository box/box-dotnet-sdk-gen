using System.IO;
using System.Text.Json.Serialization;
using Unions;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public class TransferOwnedFolderQueryParamsArg {
        public string Fields { get; }

        public bool? Notify { get; }

        public TransferOwnedFolderQueryParamsArg(string fields, bool? notify) {
            Fields = fields;
            Notify = notify;
        }
    }
}