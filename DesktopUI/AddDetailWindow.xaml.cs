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

namespace DesktopUI
{
    /// <summary>
    /// Interaction logic for AddDetailWindow.xaml
    /// </summary>
    public partial class AddDetailWindow : Window
    {
        public AddDetailWindow(AddUserVM vm)
        {
            InitializeComponent();
            DataContext = vm;
            vm.CloseAction = () => Close();
        }

        private void Button_Click()
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //MainWindow secondWindow = new MainWindow();
            //secondWindow.Show();
            //this.Close();
        }
    }
}
