using BIMOpsToolkit.Tools.Versioning;
using BIMOpsToolkit.Tools.Versioning.Services;
using CommunityToolkit.Mvvm.DependencyInjection;
using JetBrains.Annotations;
using Microsoft.Extensions.DependencyInjection;
using Nice3point.Revit.Toolkit.External;

namespace BIMOpsToolkit.Addin
{
    [UsedImplicitly]
    public class App : ExternalApplication
    {
        public override void OnStartup()
        {
            // create custom  tab and panel
            RibbonBuilder ribbonBuilder = new(Application);
            ribbonBuilder.Create();

            // register required services
            Ioc.Default.ConfigureServices(
            new ServiceCollection()
                .AddSingleton(UiApplication)
                .AddSingleton<DialogService>() // registrier DialogService
                .BuildServiceProvider()
                );

            //register dockable panels
            VersionPanelSetup.RegisterPanel(Application);
        }

        public override void OnShutdown() { }

    }
}
