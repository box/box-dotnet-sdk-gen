namespace Box.Sdk.Gen.Internal
{

    public class SerializedData
    {
        internal object Data { get; }

        //TODO support other data types
        internal bool IsJson { get; }

        internal SerializedData(object data, bool isJson = false)
        {
            Data = data;
            //TODO determine based on content
            IsJson = isJson;
        }

        internal string AsJson()
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
