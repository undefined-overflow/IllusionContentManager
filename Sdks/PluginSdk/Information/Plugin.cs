namespace PluginSdk.Information
{
    public abstract class Plugin
    {
        public Author Author { get; init; }
        public bool Obsolete { get; init; }
    }
}