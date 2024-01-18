using System;

namespace Box.Sdk.Gen
{
    enum SubjectType
    {
        User,
        Enterprise
    }

    static class SubjectTypeExtensions
    {
        public static string AsString(this SubjectType subType)
        {
            switch (subType)
            {
                case SubjectType.User:
                    return "user";
                case SubjectType.Enterprise:
                    return "enterprise";
                default:
                    throw new ArgumentException($"Unknown Subject type: {subType}");
            }
        }
    }
}
