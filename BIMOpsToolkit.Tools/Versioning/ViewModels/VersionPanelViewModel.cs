using Autodesk.Revit.UI;
using BIMOpsToolkit.Tools.Versioning.Models;
using BIMOpsToolkit.Tools.Versioning.Services;
using BIMOpsToolkit.Tools.Versioning.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;


namespace BIMOpsToolkit.Tools.Versioning.ViewModels
{
    public partial class VersionPanelViewModel : ObservableObject
    {
        private readonly DialogService _dialogService = Ioc.Default.GetService<DialogService>()!;

        [ObservableProperty]
        private string mainPanelTitle = ToolsMetadata.ModelVersionInfo.Name;
        [ObservableProperty]
        private string compareWindowTitle = ToolsMetadata.ModelVersionInfo.CompareWindowTitle;
        [ObservableProperty]
        private string settingsWindowTitle = ToolsMetadata.ModelVersionInfo.SettingsWindowTitle;

        [ObservableProperty]
        private string modelVersion = "0";

        [RelayCommand]
        private void OpenSaveVersionWindow()
        {
            _dialogService.ShowDialog<SaveVersionView, SaveVersionViewModel>();
        }

        [RelayCommand]
        private void OpenCompareVersionsWindow()
        {
            TaskDialog.Show("Compare Versions", "Placeholder");
        }

        [RelayCommand]
        private void OpenSettingsWindow()
        {
            TaskDialog.Show("Compare Versions", "Placeholder");
        }

        public ObservableCollection<VersionItem> Versions { get; set; } =
        [
            new() { Name="V1.0", CreatedAt="25-03-10", Author="Iris", Comment="Initial Scan" },
            new() { Name="V1.1", CreatedAt="25-03-12", Author="Max", Comment="Ceiling update" },
            new() { Name="V2.0", CreatedAt="25-03-15", Author="Sara", Comment="New MEP data" }
        ];

    }
}
