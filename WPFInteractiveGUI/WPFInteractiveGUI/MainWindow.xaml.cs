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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFInteractiveGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Controller controller;
        public MainWindow()
        {
            InitializeComponent();

            controller = new Controller();
            if (controller.PersonCount <= 0  && controller.PersonIndex == -1)
            {
                tbLine1.Text = string.Empty;
                tbLine2.Text = string.Empty;
                tbLine3.Text = string.Empty;
                tbLine4.Text = string.Empty;
            }
        }

        private void Button_NewP(object sender, RoutedEventArgs e)
        {

        }

        private void Button_DelP(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Up(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Down(object sender, RoutedEventArgs e)
        {

        }
    }
}
