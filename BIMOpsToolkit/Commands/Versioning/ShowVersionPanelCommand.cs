using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using BIMOpsToolkit.Tools.Versioning;
using BIMOpsToolkit.Tools.Versioning.Services;
using Nice3point.Revit.Toolkit.External;

namespace BIMOpsToolkit.Addin.Commands.Versioning
{
    [Transaction(TransactionMode.Manual)]
    [Regeneration(RegenerationOption.Manual)]
    internal class ShowVersionPanelCommand : ExternalCommand
    {
        public override void Execute()
        {
            // init Dialog Service, that manages all sub-views
            DialogService dialogService = new(UiApplication);

            // setup main viewModel
            VersionPanelSetup.VersionPanelViewModel.DialogService = dialogService;

            var panelId = new DockablePaneId(GuidRegistry.ModelVersionPanelId);
            UiApplication.GetDockablePane(panelId).Show();
        }
    }
}
