using NullableExtensions;
using System.Linq;
using StringExtensions;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Box.Sdk.Gen.Schemas;
using Box.Sdk.Gen.Managers;
using Box.Sdk.Gen;

namespace Box.Sdk.Gen {
public interface ICommonsManager {
    public BoxJwtAuth GetJwtAuth();

    public System.Threading.Tasks.Task<BoxClient> GetDefaultClientAsUserAsync(string userId);

    public BoxClient GetDefaultClient();

    public System.Threading.Tasks.Task<FolderFull> CreateNewFolderAsync();

    public System.Threading.Tasks.Task<FileFull> UploadNewFileAsync();

    public System.Threading.Tasks.Task<TermsOfService> GetOrCreateTermsOfServicesAsync();

    public System.Threading.Tasks.Task<ClassificationTemplateFieldsOptionsField> GetOrCreateClassificationAsync(ClassificationTemplate classificationTemplate);

    public System.Threading.Tasks.Task<ClassificationTemplate> GetOrCreateClassificationTemplateAsync();

    public System.Threading.Tasks.Task<ShieldInformationBarrier> GetOrCreateShieldInformationBarrierAsync(BoxClient client, string enterpriseId);

}
}