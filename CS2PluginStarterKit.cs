using CounterStrikeSharp.API.Core;

namespace CS2PluginStarterKit;

public class CS2PluginStarterKit : BasePlugin
{
    public override string ModuleName => "CS2PluginStarterKit";

    public override string ModuleVersion => "0.0.1";
    
    public override void Load(bool hotReload)
    {
        base.Load(hotReload);
        Console.WriteLine($"{ModuleName} loaded!");
    }
    
    public override void Unload(bool hotReload)
    {
        base.Unload(hotReload);
        Console.WriteLine($"{ModuleName} unloaded!");
    }
    
}

