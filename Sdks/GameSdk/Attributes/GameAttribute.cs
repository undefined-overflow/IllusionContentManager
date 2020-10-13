using System;

namespace GameSdk.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class GameAttribute : Attribute
    {
        public Guid Guid { get; init; }

        public GameAttribute(string guid) => Guid = new(guid);
    }
}