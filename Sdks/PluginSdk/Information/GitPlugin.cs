using System;
using System.Collections.Generic;

namespace PluginSdk.Information
{
    public sealed class GitEntityPlugin
    {
        public IEnumerable<Type> Games { get; init; }
        public string FileMask { get; init; }
    }

    public abstract class GitPlugin : Plugin
    {
        public string GitUser { get; init; }
        public string GitRepository { get; init; }
        public IEnumerable<GitEntityPlugin> Entities { get; init; }
    }

    public abstract class GitSharedPlugin : Plugin
    {
        public string GitUser { get; init; }
        public string GitRepository { get; init; }
        public string FileMask { get; init; }
        public IEnumerable<Type> Games { get; init; }
    }
}