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
            _app.CreateRibbonTab(RibbonResources.Tab_ToolkitName);

            // versioning tools panel
            RibbonPanel versioningPanel = CreatePanel(RibbonResources.RibbonPanel_VersioningTools);
            versioningPanel.AddPushButton<ShowVersionPanelCommand>(RibbonResources.ButtonName_OpenVersionManager)
                .SetLargeImage(RibbonResourcesUtils.GetRibbonIconPath(assemblyPath, RibbonResources.RibbonIcon_RevitVersionManager))
                .SetToolTip(RibbonResources.RibbonTooltip_RevitVersionManager);
        }


        private RibbonPanel CreatePanel(string panelName)
        {
            return _app.CreateRibbonPanel(RibbonResources.Tab_ToolkitName, panelName);
        }

    }
}
