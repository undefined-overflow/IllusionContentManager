using Core;
using System;

namespace GameSdk.Attributes
{
  [AttributeUsage(AttributeTargets.Class)]
  public class LanguageAttribute : Attribute
  {
    public LanguageType Type { get; set; }

    public string Name { get; set; }

    public LanguageAttribute(LanguageType type, string name) =>
        (Type, Name) = (type, name);
  }
}
