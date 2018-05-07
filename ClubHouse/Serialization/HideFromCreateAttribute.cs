using System;

namespace ClubHouse.Serialization
{
    [AttributeUsage(AttributeTargets.Property)]
    internal sealed class HideFromCreateAttribute : Attribute
    {
    }
}
