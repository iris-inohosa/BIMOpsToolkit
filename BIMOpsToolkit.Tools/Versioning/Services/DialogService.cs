using Autodesk.Revit.UI;
using BIMOpsToolkit.Core.Utils;
using BIMOpsToolkit.Tools.Versioning.Views;
using System.Windows.Interop;

namespace BIMOpsToolkit.Tools.Versioning.Services
{
    internal class DialogService
    {
        private readonly SaveVersionView _saveVersionView;
        private readonly UIApplication _uiApp;
        DialogService(SaveVersionView saveVersionView, UIApplication uiApp)
        {

            _saveVersionView = saveVersionView;
            _uiApp = uiApp;
        }
        public bool ShowSaveVersionDialog()
        {
            WindowInteropHelper helper = new(_saveVersionView);
            RevitWindowHelper.SetRevitAsOwner(_saveVersionView, _uiApp);
            return _saveVersionView.ShowDialog() ?? false;
        }
    }
}
