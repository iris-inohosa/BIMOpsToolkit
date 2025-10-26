using Autodesk.Revit.UI;
using BIMOpsToolkit.Core.Utils;
using System.Windows;

namespace BIMOpsToolkit.Tools.Versioning.Services
{
    public class DialogService(UIApplication uiApp)
    {
        private readonly UIApplication _uiApp = uiApp;

        public bool ShowDialog<TView, TViewModel>()
            where TView : Window, new()
            where TViewModel : new()
        {
            var viewModel = new TViewModel();
            var window = new TView
            {
                DataContext = viewModel
            };

            RevitWindowHelper.SetRevitAsOwner(window, _uiApp);

            bool? result = window.ShowDialog();
            return result == true;
        }

        public void Show<TView, TViewModel>()
            where TView : Window, new()
            where TViewModel : new()
        {
            var viewModel = new TViewModel();
            var window = new TView
            {
                DataContext = viewModel
            };

            RevitWindowHelper.SetRevitAsOwner(window, _uiApp);
            window.Show();
        }
    }
}
