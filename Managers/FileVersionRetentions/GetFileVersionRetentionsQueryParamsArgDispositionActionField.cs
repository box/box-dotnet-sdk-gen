using System.ComponentModel;
using Box.Schemas;
using Box;

namespace Box.Managers {
    public enum GetFileVersionRetentionsQueryParamsArgDispositionActionField {
        [Description("permanently_delete")]
        PermanentlyDelete,
        [Description("remove_retention")]
        RemoveRetention
    }
}