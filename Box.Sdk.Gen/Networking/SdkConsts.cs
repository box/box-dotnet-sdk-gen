using System.Collections.Generic;

namespace Fetch
{
    internal static class SdkConsts
    {
        static string RunTimeVersion = System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription;

        static KeyValuePair<string, string> UserAgentHeader = new KeyValuePair<string, string>("User-Agent", $"box-dotnet-generated-sdk/{Version.sdkVersion}");
        static KeyValuePair<string, string> BoxUAHeader = new KeyValuePair<string, string>("X-Box-UA", $"agent={UserAgentHeader.Value}; env=dotnet/{RunTimeVersion}");

        internal static List<KeyValuePair<string, string>> AnalyticsHeaders = new List<KeyValuePair<string, string>>() { UserAgentHeader, BoxUAHeader };
    }
}
