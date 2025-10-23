using Autodesk.Revit.UI;
using System.Windows;
using System.Windows.Interop;

namespace BIMOpsToolkit.Core.Utils
{
    public static class RevitWindowHelper
    {
        public static void SetRevitAsOwner(Window window, UIApplication uiApp)
        {
            IntPtr handle = uiApp.MainWindowHandle;
            WindowInteropHelper helper = new(window);
            helper.Owner = handle;
        }
    }
}
