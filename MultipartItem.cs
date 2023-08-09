using System.Threading.Tasks;

namespace Box 
{
    //TODO implement usage
    public class MultipartItem 
    {
        public string PartName { get; set; }

        public string Body { get; set; }
        
        //TODO change to more specific type
        public object FileStream { get; set; }
        
        public string FileName { get; set; }

        public string ContentType { get; set; }
        
        public MultipartItem(string partName = null, string body = null, object fileStream = null, string fileName = null, string contentType = null)
        {
            PartName = partName;
            Body = body;
            FileStream = fileStream;
            FileName = fileName;
            ContentType = contentType;
        }
    }
}
