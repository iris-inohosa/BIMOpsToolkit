using BIMOpsToolkit.Tools.Versioning;
using JetBrains.Annotations;
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

            //register dockable panels
            VersionPanelSetup.RegisterPanel(Application);
        }

        public override void OnShutdown() { }

    }
}
