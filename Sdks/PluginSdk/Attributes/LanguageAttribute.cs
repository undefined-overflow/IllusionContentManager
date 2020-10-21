using Core;
using System;

namespace PluginSdk.Attributes
{
  [AttributeUsage(AttributeTargets.Class)]
  public class LanguageAttribute : Attribute
  {
    public LanguageType Type { get; set; }

    public string Name { get; set; }
    public string Description { get; set; }

    public LanguageAttribute(LanguageType type, string name, string description) =>
        (Type, Name, Description) = (type, name, description);
  }
}
