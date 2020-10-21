using System;
using System.Collections.Generic;

namespace PluginSdk.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class PluginAttribute : Attribute
    {
        public Guid Guid { get; }
        public IReadOnlyList<Type> Dependencies { get; }

        public PluginAttribute(string guid, params Type[] dependencies) =>
            (Guid, Dependencies) = (new Guid(guid), dependencies ?? Array.Empty<Type>());
    }
}