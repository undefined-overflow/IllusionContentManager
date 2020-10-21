using System;
using System.Collections.Generic;

namespace PluginSdk.Information
{
    public sealed class GitEntityPlugin
    {
        public IEnumerable<Type> Games { get; set; }
        public string FileMask { get; set; }
    }

    public abstract class GitPlugin : Plugin
    {
        public string GitUser { get; set; }
        public string GitRepository { get; set; }
        public IEnumerable<GitEntityPlugin> Entities { get; set; }
    }

    public abstract class GitSharedPlugin : Plugin
    {
        public string GitUser { get; set; }
        public string GitRepository { get; set; }
        public string FileMask { get; set; }
        public IEnumerable<Type> Games { get; set; }
    }
}