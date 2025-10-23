using Autodesk.Revit.UI;
using BIMOpsToolkit.Addin;
using BIMOpsToolkit.Tools.Versioning.Services;
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

        private static VersionPanelViewModel versionPanelViewModel;
        private static SaveVersionViewModel saveVersionViewModel;
        private static readonly DialogService dialogService;

        public static void RegisterPanel(UIControlledApplication uIControlledApp)
        {
            saveVersionViewModel = new();
            SaveVersionView saveVersionView = new() { DataContext = saveVersionViewModel };

            versionPanelViewModel = new(dialogService);
            VersionPanel mainView = new() { DataContext = versionPanelViewModel };

            // register Dockable Panel
            DockablePaneProvider
                .Register(uIControlledApp, Guid, panelTitle)
                .SetConfiguration(data =>
                {
                    data.InitialState = new DockablePaneState
                    {
                        DockPosition = DockPosition.Right,
                    };
                    data.VisibleByDefault = false;
                    data.FrameworkElement = mainView;
                });
        }
    }
}
