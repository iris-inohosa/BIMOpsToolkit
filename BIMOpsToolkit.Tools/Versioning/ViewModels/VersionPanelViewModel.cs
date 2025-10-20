using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
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
        private void SaveVersion()
        {
            modelVersion = "Updated at " + DateTime.Now.ToLongTimeString();
        }
    }
}
