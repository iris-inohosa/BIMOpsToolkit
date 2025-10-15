using Autodesk.Revit.UI;
using BIMOpsToolkit.Utils;
using JetBrains.Annotations;
using Nice3point.Revit.Extensions;
using Nice3point.Revit.Toolkit.External;
using System.IO;
using System.Windows.Input;

namespace BIMOpsToolkit
{
    [UsedImplicitly]
    public class App : ExternalApplication
    {
        public override void OnStartup()
        {
            // create new tab and panel
            string tabName = "BIMOps Toolkit";
            Application.CreateRibbonTab(tabName);
            RibbonPanel panel = Application.CreateRibbonPanel(tabName, "Versioning Tools");
            string assemblyPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)!;

            // Create new button and add to ribbon
            panel.AddPushButton<src.RevitVersionManager.Commands.DummyTest>("Open Version Manager")
                .SetLargeImage(ResourcesUtils.GetRibbonIconPath(assemblyPath, Resources.RibbonIcon_RevitVersionManager))
                .SetToolTip("The tool allow to store Revit Model data in Database and compare mulitple versions.");
        }

        public override void OnShutdown() { }
    }
}
