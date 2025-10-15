using System.IO;

namespace BIMOpsToolkit.Utils
{
    public static class ResourcesUtils
    {
        public static string GetRibbonIconPath(string exePath, string imageName)
        {
            return Path.Combine(exePath, "Resources", "RibbonIcons", imageName);
        }
    }
}
