using Core;
using System;

namespace PluginSdk.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class LanguageAttribute : Attribute
    {
        public LanguageType Type { get; init; }

        public string Name { get; init; }
        public string Description { get; init; }

        public LanguageAttribute(LanguageType type, string name, string description) =>
            (Type, Name, Description) = (type, name, description);
    }
}