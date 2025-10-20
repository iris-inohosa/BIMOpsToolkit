using System.IO;

namespace BIMOpsToolkit.Core.Utils
{
    public static class RibbonResourcesUtils
    {
        public static string GetRibbonIconPath(string exePath, string imageName)
        {
            return Path.Combine(exePath, "Resources", "RibbonIcons", imageName);
        }
    }
}
