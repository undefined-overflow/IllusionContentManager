using System;

namespace GameSdk.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class GameAttribute : Attribute
    {
        public Guid Guid { get; }

        public GameAttribute(string guid) => Guid = new Guid(guid);
    }
}