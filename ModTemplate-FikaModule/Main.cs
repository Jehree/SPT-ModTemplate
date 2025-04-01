using ModTemplate.Fika;
using ModTemplate.FikaModule.Common;

namespace ModTemplate.FikaModule;

internal class Main
{
    // called by the core dll via reflection
    public static void Init()
    {
        PluginAwake();
        FikaBridge.PluginEnableEmitted += PluginEnable;
        FikaBridge.IAmHostEmitted += FikaMethods.IAmHost;
        FikaBridge.GetRaidIdEmitted += FikaMethods.GetRaidId;
    }

    public static void PluginAwake()
    {

    }

    public static void PluginEnable()
    {
        FikaMethods.InitOnPluginEnabled();
    }
}
