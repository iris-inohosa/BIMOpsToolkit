using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIMOpsToolkit.Tools.Versioning.Models
{
    public class VersionItem
    {
        public string Name { get; set; } = "";
        public string CreatedAt { get; set; } = "";
        public string Author { get; set; } = "";
        public string Comment { get; set; } = "";
    }
}
