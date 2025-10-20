using Autodesk.Revit.UI;
using BIMOpsToolkit.Addin;
using BIMOpsToolkit.Tools.Versioning.ViewModels;
using BIMOpsToolkit.Tools.Versioning.Views;
using Nice3point.Revit.Toolkit.Decorators;
using System.Runtime.Versioning;

namespace BIMOpsToolkit.Tools.Versioning
{
    public static class VersionPanelSetup
    {
        private static Guid Guid => GuidRegistry.ModelVersionPanelId;
        private static readonly string panelTitle = ToolsMetadata.ModelVersionInfo.Name;

        private static VersionPanelViewModel viewModel;

        public static void RegisterPanel(UIControlledApplication uIControlledApp)
        {
            viewModel = new();
            VersionPanel view = new() { DataContext = viewModel };

            // Dockable Panel registrieren
            DockablePaneProvider
                .Register(uIControlledApp, Guid, panelTitle)
                .SetConfiguration(data =>
                {
                    data.InitialState = new DockablePaneState
                    {
                        DockPosition = DockPosition.Right,
                    };
                    data.VisibleByDefault = false;
                    data.FrameworkElement = view;
                });
        }
    }
}
