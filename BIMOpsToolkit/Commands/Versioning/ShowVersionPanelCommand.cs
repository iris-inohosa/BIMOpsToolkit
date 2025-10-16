using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Nice3point.Revit.Toolkit.External;
using BIMOpsToolkit.Tools.Versioning.Views;
using BIMOpsToolkit.Tools.Versioning.ViewModels;

namespace BIMOpsToolkit.Addin.Commands.Versioning
{
    [Transaction(TransactionMode.Manual)]
    [Regeneration(RegenerationOption.Manual)]
    internal class ShowVersionPanelCommand : ExternalCommand
    {
        public override void Execute()
        {
            var id = new DockablePaneId(new Guid("D8A7B22C-3C8A-4C83-9F6E-2B8F4E8E7A77"));

            // Beispiel: Übergib einen Service oder Context ins ViewModel
            var viewModel = new VersionPanelViewModel();
            var view = new VersionPanel { DataContext = viewModel };

            UiApplication.RegisterDockablePane(id, "BIMOpsToolkit Panel", view);
            UiApplication.GetDockablePane(id).Show();
        }
    }
}
