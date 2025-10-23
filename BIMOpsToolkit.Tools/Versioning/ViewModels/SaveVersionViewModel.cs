using Autodesk.Revit.UI;
using BIMOpsToolkit.Tools.Versioning.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows;

namespace BIMOpsToolkit.Tools.Versioning.ViewModels
{
    public partial class SaveVersionViewModel : ObservableObject
    {
        [ObservableProperty]
        string versionName = string.Empty;

        [RelayCommand]
        private void Save()
        {
            // Logic to Save new Version
            MessageBox.Show($"Version '{VersionName}' saved successfully!");
        }
    }
}
