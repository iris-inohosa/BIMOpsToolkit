using Autodesk.Revit.UI;
using BIMOpsToolkit.Addin.Commands.Versioning;
using JetBrains.Annotations;
using Nice3point.Revit.Extensions;
using Nice3point.Revit.Toolkit.External;
using System.IO;
using BIMOpsToolkit.Core.Utils;

namespace BIMOpsToolkit.Addin
{
    [UsedImplicitly]
    public class App : ExternalApplication
    {
        public override void OnStartup()
        {
            // create new tab and panel
            Application.CreateRibbonTab(Resources.Tab_ToolkitName);
            RibbonPanel panel = Application.CreateRibbonPanel(Resources.Tab_ToolkitName, Resources.RibbonPanel_VersioningTools);

            // Create new button and add to ribbon
            string assemblyPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)!;
            panel.AddPushButton<DummyTest>(Resources.ButtonName_OpenVersionManager)
                .SetLargeImage(ResourcesUtils.GetRibbonIconPath(assemblyPath, Resources.RibbonIcon_RevitVersionManager))
                .SetToolTip(Resources.RibbonTooltip_RevitVersionManager);
        }

        public override void OnShutdown() { }
    }
}
