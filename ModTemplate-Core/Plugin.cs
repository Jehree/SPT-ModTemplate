using BepInEx;
using BepInEx.Bootstrap;
using BepInEx.Logging;
using EFT.UI;
using ModTemplate.Common;
using ModTemplate.Fika;
using ModTemplate.Helpers;
using ModTemplate.Patches;
using System;
using System.Reflection;

namespace ModTemplate
{
    [BepInDependency("com.fika.core", BepInDependency.DependencyFlags.SoftDependency)]
    public class Plugin : BaseUnityPlugin
    {
        public static bool FikaInstalled { get; private set; }
        public static ManualLogSource LogSource;


        private void Awake()
        {
            FikaInstalled = Chainloader.PluginInfos.ContainsKey("com.fika.core");

            LogSource = Logger;
            Settings.Init(Config);

            new GetAvailableActionsPatch().Enable();
            new GameStartedPatch().Enable();
            new GameEndedPatch().Enable();

            ConsoleScreen.Processor.RegisterCommandGroup<ConsoleCommands>();

            TryInitFikaModuleAssembly();
        }

        private void OnEnable()
        {
            FikaBridge.PluginEnable();
        }

        private void TryInitFikaModuleAssembly()
        {
            if (!FikaInstalled) return;

            Assembly fikaModuleAssembly = Assembly.Load("ModTemplate-FikaModule");
            Type main = fikaModuleAssembly.GetType("ModTemplate.FikaModule.Main");
            MethodInfo init = main.GetMethod("Init");

            init.Invoke(main, null);
        }
    }
}