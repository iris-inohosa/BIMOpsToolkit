using Autodesk.Revit.UI;
using BIMOpsToolkit.Tools.Versioning.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIMOpsToolkit.Tools.Versioning.ViewModels
{
    public partial class VersionPanelViewModel : ObservableObject
    {
        [ObservableProperty]
        private string panelTitle = ToolsMetadata.ModelVersionInfo.Name;

        [ObservableProperty]
        private string modelVersion = "0";

        [RelayCommand]
        private void OpenSaveVersion()
        {
            modelVersion = "Updated at " + DateTime.Now.ToLongTimeString();
        }

        [RelayCommand]
        private void OpenCompareVersion()
        {
            TaskDialog.Show("Compare Versions", "Placeholder");
        }

        [RelayCommand]
        private void OpenSettings()
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
