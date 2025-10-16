using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Nice3point.Revit.Toolkit.External;

namespace BIMOpsToolkit.Addin.Commands.Versioning
{
    [Transaction(TransactionMode.Manual)]
    [Regeneration(RegenerationOption.Manual)]
    internal class DummyTest : ExternalCommand
    {
        public override void Execute()
        {
            TaskDialog.Show("Revit 2025 – Revit Versioning Manager", "Command is called");
        }
    }
}
