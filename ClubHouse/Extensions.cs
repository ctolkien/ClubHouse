using System;
using System.Reflection;
using System.Text.RegularExpressions;

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

        internal static string SeparateCamelCase(this string value)
        {
            //todo: there is a bug here which inputs a space character at the beginning
            return Regex.Replace(value, "((?<=[a-z])[A-Z]|[A-Z](?=[a-z]))", " $1");
        }
    }
}
