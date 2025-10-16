using Autodesk.Revit.UI;
using BIMOpsToolkit.Addin.Commands.Versioning;
using BIMOpsToolkit.Core.Utils;
using Nice3point.Revit.Extensions;
using System.IO;

namespace BIMOpsToolkit.Addin
{
    public class RibbonBuilder(UIControlledApplication app)
    {
        private readonly UIControlledApplication _app = app;
        readonly string assemblyPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)!;

        public void Create()
        {
            _app.CreateRibbonTab(Resources.Tab_ToolkitName);

            // versioning tools panel
            RibbonPanel versioningPanel = CreatePanel(Resources.RibbonPanel_VersioningTools);
            versioningPanel.AddPushButton<DummyTest>(Resources.ButtonName_OpenVersionManager)
                .SetLargeImage(ResourcesUtils.GetRibbonIconPath(assemblyPath, Resources.RibbonIcon_RevitVersionManager))
                .SetToolTip(Resources.RibbonTooltip_RevitVersionManager);
        }


        private RibbonPanel CreatePanel(string panelName)
        {
            return _app.CreateRibbonPanel(Resources.Tab_ToolkitName, panelName);
        }

    }
}
