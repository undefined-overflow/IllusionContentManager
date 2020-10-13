using System;
using System.Collections.Generic;

namespace PluginSdk.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class PluginAttribute : Attribute
    {
        public Guid Guid { get; init; }
        public IReadOnlyList<Type> Dependencies { get; init; }

        public PluginAttribute(string guid, params Type[] dependencies) =>
            (Guid, Dependencies) = (new(guid), dependencies ?? Array.Empty<Type>());
    }
}