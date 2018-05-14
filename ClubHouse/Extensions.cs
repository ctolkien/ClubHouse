using System;
using System.Reflection;
using System.Text.RegularExpressions;
using Humanizer;
namespace ClubHouse
{
    internal static class Extensions
    {
        internal static bool IsSubclassOfRawGeneric(this Type toCheck, Type generic)
        {
            while (toCheck != null && toCheck != typeof(object))
            {
                var cur = toCheck.GetTypeInfo().IsGenericType ? toCheck.GetGenericTypeDefinition() : toCheck;
                if (generic == cur)
                {
                    return true;
                }
                toCheck = toCheck.GetTypeInfo().BaseType;
            }
            return false;
        }

        internal static readonly Regex _uppercaseCharFollowedByLowercase = new Regex("([A-Z](?=[a-z]))", RegexOptions.Compiled);

        internal static string SeparateCamelCase(this string value)
        {
            //This inputs a space character at the beginning, hence the trim
            return _uppercaseCharFollowedByLowercase.Replace(value, " $1").Trim();
        }
    }
}
