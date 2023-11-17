using Serializer;

namespace Json
{

    public class SerializedData
    {
        public object Data { get; }

        //TODO support other data types
        public bool IsJson { get; }

        public SerializedData(object data, bool isJson = false)
        {
            Data = data;
            //TODO determine based on content
            IsJson = isJson;
        }

        public string AsJson()
        {
            if (IsJson)
            {
                return Data as string;
            }
            else
            {
                return SimpleJsonSerializer.SdToJson(this);
            }
        }
    }
}
