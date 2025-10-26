using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BIMOpsToolkit.Tools.Versioning.Views
{
    /// <summary>
    /// Interaction logic for SaveVersionView.xaml
    /// </summary>
    public partial class SaveVersionView : Window
    {
        public SaveVersionView()
        {
            InitializeComponent();
        }

        private void CloseOnCancelClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
