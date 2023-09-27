using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using Serializer;

namespace StringExtensions {
    public static class StringUtils {
        public static string? ToStringRepresentation<T>(T? obj)
        {
             var isList = (obj is IList || obj is IEnumerable) && obj.GetType().IsGenericType;
            if (obj != null && isList)
            {
                var listOfStrings = new List<string>();
                foreach (var value in (IList)obj)
                {
                    if (value != null)
                    {
                        listOfStrings.Add(ToStringRepresentation(value));
                    }
                }
                return string.Join(",", listOfStrings);
            }
            else if (obj is Enum)
            {
                FieldInfo fieldInfo = obj.GetType().GetField(obj.ToString());

                DescriptionAttribute[] attributes =
                    (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

                return attributes[0].Description;
            }
            else if (obj != null && !obj.GetType().IsPrimitive && obj.GetType() != typeof(string))
            {
                return JsonSerializer.Serialize(obj);
            }
            else
            {
                return obj?.ToString();
            }
        }
    }
}
