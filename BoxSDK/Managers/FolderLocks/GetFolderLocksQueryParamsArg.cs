using Box.Schemas;
using Box;

namespace Box.Managers {
    public class GetFolderLocksQueryParamsArg {
        /// <summary>
        /// The unique identifier that represent a folder.
        /// 
        /// The ID for any folder can be determined
        /// by visiting this folder in the web application
        /// and copying the ID from the URL. For example,
        /// for the URL `https://*.app.box.com/folder/123`
        /// the `folder_id` is `123`.
        /// 
        /// The root folder of a Box account is
        /// always represented by the ID `0`.
        /// </summary>
        public string FolderId { get; set; }

        public GetFolderLocksQueryParamsArg(string folderId) {
            FolderId = folderId;
        }
    }
}