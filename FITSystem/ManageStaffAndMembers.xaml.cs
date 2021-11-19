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

namespace FITSystem
{
    /// <summary>
    /// Interaction logic for ManageStaffAndMembers.xaml
    /// </summary>
    public partial class ManageStaffAndMembers : Window
    {
        public ManageStaffAndMembers()
        {
            InitializeComponent();
        }

        private void FitTitleBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
