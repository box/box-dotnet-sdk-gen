using Box.Sdk.Gen;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text.Json;

namespace Box.Sdk.Gen.Internal 
{
    public static class StringUtils
    {
        public static string? ToStringRepresentation<T>(T? obj)
        {
            Type objType = obj?.GetType();
            var isList = (obj is IList || obj is IEnumerable) && objType.IsGenericType;
            if (obj != null && isList)
            {
                var listOfStrings = new List<string>();
                var asList = (IList)obj;
                foreach (var value in asList)
                {
                    if (value != null)
                    {
                        listOfStrings.Add(ToStringRepresentation(value));
                    }
                }
                var listAsString = string.Join(",", listOfStrings);
                return anyNonPrimitives(asList) ? $"[{listAsString}]" : listAsString;
            }
            else if (obj is Enum)
            {
                FieldInfo fieldInfo = obj.GetType().GetField(obj.ToString());

                DescriptionAttribute[] attributes =
                    (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

                return attributes[0].Description;
            }
            else if (objType != null && objType.IsGenericType && objType.GetGenericTypeDefinition() == typeof(StringEnum<>))
            {
                var field = objType.GetProperty("StringValue");
                return (string)field.GetValue(obj);
            }
            else if (isNotPrimitive(obj))
            {
                return JsonSerializer.Serialize(obj);
            }
            else
            {
                return obj?.ToString();
            }
        }

        private static bool isNotPrimitive(object obj) => obj != null && !obj.GetType().IsPrimitive && obj.GetType() != typeof(string);

        private static bool anyNonPrimitives(IList list)
        {
            foreach (var item in list)
            {
                if (isNotPrimitive(item))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
