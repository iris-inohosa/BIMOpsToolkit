using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Nice3point.Revit.Toolkit.External;

namespace BIMOpsToolkit.Addin.Commands.Versioning
{
    [Transaction(TransactionMode.Manual)]
    [Regeneration(RegenerationOption.Manual)]
    internal class ShowVersionPanelCommand : ExternalCommand
    {
        public override void Execute()
        {
            var panelId = new DockablePaneId(GuidRegistry.ModelVersionPanelId);
            UiApplication.GetDockablePane(panelId).Show();
        }
    }
}
